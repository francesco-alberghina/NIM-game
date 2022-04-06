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
    public class Nim
    {
        /*
        ____________________________________________________________________________________       
           _____ _____ ____   _____ ____       _____  ______ _           _   _ _____ __  __ 
          / ____|_   _/ __ \ / ____/ __ \     |  __ \|  ____| |         | \ | |_   _|  \/  |
         | |  __  | || |  | | |   | |  | |    | |  | | |__  | |         |  \| | | | | \  / |
         | | |_ | | || |  | | |   | |  | |    | |  | |  __| | |         | . ` | | | | |\/| |
         | |__| |_| || |__| | |___| |__| |    | |__| | |____| |____     | |\  |_| |_| |  | |
          \_____|_____\____/ \_____\____/     |_____/|______|______|    |_| \_|_____|_|  |_|
        ------------------------------------------------------------------------------------                                                                            
        */
        //BiglieIniziali=numero di biglie all'inizio della partita
        //BiglieAttuali=numero di biglie che variano man a mano
        int biglieIniziali, biglieAttuali, maxMossa, ultimaScelta, ultimoCaso; 
        public int[,] tab;

        public Nim(int n, int max)
        {
            this.biglieIniziali = this.biglieAttuali = n;
            this.maxMossa = max;
            tab = new int[max + 1, n];
            /*
            COMPILAZIONE DELLA TABELLA:
            {1,2,3,3,3,3,3,3,3,3} riga che contiene il numero di mosse possibili per ogni bicchiere
            {1,1,1,1,1,1,1,1,1,1} bigliettino 1
            {0,2,2,2,2,2,2,2,2,2} bigliettino 2               
            {0,0,3,3,3,3,3,3,3,3} bigliettino 3
            */
            int k = 1;
            for (int c = 0; c < n; c++)
            {
                tab[0, c] = k;
                for (int i = 1; i <= k; i++)
                    tab[i, c] = i;

                if (k < max)
                    k++;
            }
        }
        /// <summary>
        /// Metodo che fa la mossa da parte dell'utente
        /// </summary>
        /// <returns><c>true</c>, se l'utente perde, <c>false</c> se l'utente non perde.</returns>
        /// <param name="mossa">numero di bicchieri da togliere (da 1 a maxMossa).</param>
        public bool MossaUtente(int mossa)
        {
            if (mossa <= maxMossa && mossa > 0)
            {
                bool perso = false;
                biglieAttuali -= mossa;
                if (biglieAttuali <= 0)
                    perso = true;
                return perso; //perde l'utente
            }
            else throw new Exception("Mossa non valida");
        }
        /// <summary>
        /// Metodo che fa la mossa della macchina
        /// </summary>
        /// <returns><c>true</c>, se la macchina perde, <c>false</c> se la macchina non perde</returns>
        public int MossaMacchina()
        {
            int perso;
            int mossa;
            Random rnd = new Random();
            mossa = tab[rnd.Next(1, tab[0, biglieAttuali - 1]), biglieAttuali - 1];
            if (tab[0, biglieAttuali - 1] != 1)
            {
                ultimaScelta = mossa;
                ultimoCaso = biglieAttuali;
            }
            biglieAttuali -= mossa;
            if (biglieAttuali == 0)
                perso = -1; //perde la macchina
            else
                perso = mossa;
            return perso;
        }
        /// <summary>
        /// Metodo per rimuovere la mossa che ha fatto perdere la macchina
        /// </summary>
        public void RimuoviMossaSbagliata()
        {
            if (ultimaScelta != 0)
            {
                //shifto le mosse in su di 1
                tab[ultimaScelta, ultimoCaso - 1] = 0;
                for (int i = 1; i < maxMossa + 1; i++)
                {
                    if (tab[i - 1, ultimoCaso - 1] == 0)
                    {
                        tab[i - 1, ultimoCaso - 1] = tab[i, ultimoCaso - 1];
                        tab[i, ultimoCaso - 1] = 0;
                    }
                }
                tab[0, ultimoCaso - 1] -= 1;
            }
        }
        /// <summary>
        /// Metodo che riporta il gioco alla situazione iniziale, preservando però la matrice con le mosse
        /// </summary>
        public void Restart()
        {
            biglieAttuali = biglieIniziali;
            ultimaScelta = 0;
        }

        /// <summary>
        /// Proprietà che restituisce il numero di bicchieri presenti
        /// </summary>
        /// <value>Numero di bicchieri</value>
        public int NumeroBiglie
        {
            get => biglieAttuali;
        }

        public int MaxMosse => maxMossa;

    }
}
