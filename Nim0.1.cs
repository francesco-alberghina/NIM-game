using System;
namespace Gioco_Del_NIM
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
        int n,ultimaScelta,ultimoCaso,numeroBicchieri;
        public int[,] tab;

        public Nim(int n)
        {
            numeroBicchieri = this.n = n;
            tab = new int[4,n];

            for (int i = 0; i < 4; i++)
            {
                /*
                COMPILAZIONE DELLA TABELLA:
                {1,2,3,3,3,3,3,3,3,3} riga che contiene il numero di mosse possibili per ogni bicchiere
                {1,1,1,1,1,1,1,1,1,1} bigliettino 1
                {0,2,2,2,2,2,2,2,2,2} bigliettino 2               
                {0,0,3,3,3,3,3,3,3,3} bigliettino 3
                */
                for (int j = 0; j < n; j++)
                {
                    if (i == 0 && j == 0)
                        tab[i,j] = 1;
                    if (i == 0 && j == 1)
                        tab[i, j] = 2;
                    if (i == 0 && j > 1)
                        tab[i, j] = 3;
                    if (i == 1)
                        tab[i, j] = 1;
                    if (i == 2 && j > 0)
                        tab[i, j] = 2;
                    if (i == 3 && j > 1)
                        tab[i, j] = 3;
                }
            }
        }
        /// <summary>
        /// Metodo che fa la mossa da parte dell'utente
        /// </summary>
        /// <returns><c>true</c>, se l'utente perde, <c>false</c> se l'utente non perde.</returns>
        /// <param name="mossa">numero di bicchieri da togliere (da 1 a 3).</param>
        public bool MossaUtente(int mossa)
        {
            if (mossa <= 3 && mossa > 0)
            {
                bool perso = false;
                n -= mossa;
                if (n <= 0)
                    perso = true;
                return perso;
            }
            else throw new Exception("Mossa non valida");
        }
        /// <summary>
        /// Metodo che fa la mossa della macchina
        /// </summary>
        /// <returns><c>true</c>, se la macchina perde, <c>false</c> se la macchina non perde</returns>
        public bool MossaMacchina()
        {
            bool perso = false;
            int mossa;
            Random rnd = new Random();
            do
            {
                mossa = rnd.Next(1,4);
            } while (tab[mossa,n-1] == 0);

            if (tab[0, n - 1] != 1)
            {
                ultimaScelta = mossa;
                ultimoCaso = n;
            }
            n -= mossa;
            if (n == 0)
                perso = true;
            return perso;
        }
        /// <summary>
        /// Metodo per rimuovere la mossa che ha fatto perdere la macchina
        /// </summary>
        public void RimuoviMossaSbagliata()
        {
            if (ultimaScelta != 0)
            {
                //metto a 0 la mossa che ha fatto perdere la macchina e decremento il numero di mosse disponibili per quel caso
                tab[ultimaScelta, ultimoCaso - 1] = 0;
                tab[0, ultimoCaso-1] -= 1;
            }
        }
        /// <summary>
        /// Metodo che riporta il gioco alla situazione iniziale, preservando però la matrice con le mosse
        /// </summary>
        public void Restart()
        {
            n = numeroBicchieri;
            ultimaScelta = 0;
        }

        /// <summary>
        /// Proprietà che restituisce il numero di bicchieri presenti
        /// </summary>
        /// <value>Numero di bicchieri</value>
        public int NumeroBicchieri
        {
            get => n;
        }

    }
}
