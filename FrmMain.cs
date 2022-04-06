using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NIM
{
    /**INTERAZIONE TRA INTERFACCIA GRAFICA E CLASSE**/
    public partial class FrmMain : Form
    {
        Nim gioco;
        int biglie, max_mosse;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnGenera_Click(object sender, EventArgs e)
        {
            //codice per generare i bottoni
            if (nudNumeroBiglie.Value > 0 && nudMax.Value > 0)
            {
                nudMax.Enabled = false;
                nudNumeroBiglie.Enabled = false;
                biglie = (int)nudNumeroBiglie.Value;
                max_mosse = (int)nudMax.Value;
                GeneraBottoni(biglie);

                //creo l'oggetto per la gestione del gioco
                gioco = new Nim(biglie, max_mosse);

              
            }
            else
                MessageBox.Show("Assicurarsi che entrambi valori siano superiori a zero!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void GeneraBottoni(int bicchieri)
        {
            //genera i bottoni nell'interfaccia grafica

            /**SPAWN BOTTONI**/
            for (int i = 0; i < bicchieri; i++)
            {
                Button btn = new Button();
               
                // diamo uno stile "flat" al pulsante
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 5;
                btn.Margin = new Padding(2);

                btn.BackColor = Color.Red;
                btn.ForeColor = Color.White;

                btn.Height = 80;
                btn.Width = flpNim.Width/(bicchieri+2);

                //aggancio l'evento click al bottone. 
                //ad ogni bottono creato è collegato lo stesso metodo di risposta al click, e il mouse che entra e esce dal controllo
                btn.Click += Btn_Click;
                btn.MouseEnter += MouseEntra;
                btn.MouseLeave += MouseEsce;

                btn.TabIndex = i+1;
                
                flpNim.Controls.Add(btn); //inserisco il bottone nel flowlayoutpanel
               
            }
        }

        /// <summary>
        /// Quando il mouse esce da un bottone cioè bicchiere
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MouseEsce(object sender, EventArgs e)
        {
            foreach(Button b in flpNim.Controls)
            {
                b.BackColor = Color.Red;
            }
            
        }

        /// <summary>
        /// Quando il mouse entra in un bottone cioè bicchiere
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MouseEntra(object sender, EventArgs e)
        {
            Button b = (Button)sender;  //il sender è il bottone "mandante", quello su cui sono
            int bottone = b.TabIndex;

            if (bottone > (biglie - max_mosse)) //se è tra quelli possibili 
            {
                bool trovato = false;
                foreach (Button btn in flpNim.Controls)
                {
                    if(btn.TabIndex == bottone || trovato)
                    {
                        btn.BackColor = Color.Gray;
                        trovato = true;
                    }
                    
                }
            }
            
        }

        /// <summary>
        /// Quando si clicca per ELIMINARE
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor == Color.Gray)
            {
                int i = 0;
                foreach (Button b in flpNim.Controls)
                {
                    if (b.BackColor == Color.Gray && b.Visible!=false)
                    {
                        b.Visible = false;
                        i++;
                    }
                }

                if (gioco.MossaUtente(i))
                {              
                    MessageBox.Show("Hai perso");
                    btnRestart.Enabled = true;
                    flpNim.Enabled = false;
                }
                else
                {
                    biglie = gioco.NumeroBiglie; //decrementa il numero di biglie nell'oggetto
                    int risultato= gioco.MossaMacchina();
                    MessageBox.Show($"{risultato}, {biglie}");

                    if(risultato==-1)//la macchina ha perso
                    {
                        MessageBox.Show("Hai VINTO");
                        btnRestart.Enabled = true;
                        flpNim.Enabled = false;
                        gioco.RimuoviMossaSbagliata(); //elimina la mossa sbagliata
                    }
                    else
                    {
                        foreach (Button b in flpNim.Controls)
                        {
                            if (b.TabIndex > biglie-risultato)
                            {
                                b.Visible = false;
                            }
                        }
                        biglie = gioco.NumeroBiglie; //decrementa il numero di biglie nell'oggetto

                    }
                }
            }
                
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            /**valori azzerati e far scomparire i bottoni**/

            gioco.Restart();
            biglie = gioco.NumeroBiglie;
            flpNim.Enabled = true;

            foreach (Button b in flpNim.Controls)
            {
                b.Visible= true;
            }
            
            nudMax.Value = gioco.MaxMosse;
            nudNumeroBiglie.Value = gioco.NumeroBiglie;

        }
    }
}
