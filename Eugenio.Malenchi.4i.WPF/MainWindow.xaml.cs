using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows;

namespace Eugenio.Malenchi._4i.WPF
{ 
    public partial class MainWindow : Window
    {
        public MainWindow()
        {   
            InitializeComponent();
            List<Contatto> listContatti = new List<Contatto>();
            Contatto[] Contatti = new Contatto[100];
            

            try
            {
                for (int i = 0;i<Contatti.Length;i++)
                {
                    Contatti[i] = new Contatto();
                }
                StreamReader fin = new StreamReader("dati.csv");
                while (!fin.EndOfStream)
                {
                     string? riga = fin.ReadLine();
                    Contatto c = new Contatto(riga);
                    listContatti.Add(c);

                }
            }
            catch (Exception ex) {
                MessageBox.Show("Errore: " + ex.Message); 
            }
            
            try
            {
                Contatto c = new Contatto
                {
                    Numero = 1,
                    Nome = "Maurizio",
                    Cognome = "Conti",
                    EMail = "maurizio.conti@ittsrimini.edu.it",
                    Telefono = "3337722",
                    CAP = "47923"
                };
                listContatti.Add(c);

                Contatto c1 = new Contatto(2, "Riccardo", "Bianchi");
                listContatti.Add(c1);

                Contatto c2 = new Contatto(3, "Antonio", "Vallone");
                listContatti.Add(c2);
            }
            catch (Exception err)
            {
                MessageBox.Show("Errore: " + err.Message);
            }


            private void dgDati_LoadignRow(object sender, EventArgs e) {  }

            
        }
    }
}
