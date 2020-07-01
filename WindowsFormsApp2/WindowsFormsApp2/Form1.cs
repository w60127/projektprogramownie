using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{

    public partial class Form1 : Form
    {   
        
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// inicjalizacja zmiennej do programu
        /// </summary>
        int licznik;

        /// <summary>
        /// Kliknięcie przycisku powoduje wydruk
        /// </summary>
        /// <param name="sender">Odniesienie sie do obiektu który wykonuje akcje (przycisku)</param>
        /// <param name="e">kliknięcie jest prawdą</param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.printDialog1.ShowDialog() == DialogResult.OK)
            {
                this.printDocument1.Print();
            }
        }
        /// <summary>
        /// Wysyłanie zapytania do drukowania dokumentu
        /// </summary>
        /// <param name="sender">Odniesienie sie do obiektu który wykonuje akcje (przycisku)</param>
        /// <param name="barcodeContolRender">Barcode.dll generuje obraz do wydruku</param>
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            this.barcodeControl1.Render(e.Graphics, 100, 100);
            e.HasMorePages = false;
        }
        /// <summary>
        /// Zmiana wartości generowanego obrazu przez barcode.dll, po zmianie wartości wysyła nową wartość do barcodeControl1, jeżeli wartość wprowadzana długość jest równa 0 lub 32 (maksymalna długość) wyrzuca okienko z komunikatem
        /// </summary>
        /// <param name="sender">Odniesienie sie do obiektu który wykonuje akcje (pole tekstowe)</param>
        /// <param name="e">e=zmiana wartości w polu</param>
        /// <param name="tekst">Zapisuje wartość textBox1 do stringa w celu przesłania do funkcji</param>

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.barcodeControl1.Number = textBox1.Text;
            string tekst = textBox1.Text;
            licznik = this.barcodeControl1.Number.Length;
            czyZawieraPolskieZnaki(tekst);
            testDlugosci(licznik);

        }
        /// <summary>
        /// Testowanie czy nie przekacza maksymalnego obszaru wydruku
        /// </summary>
        /// <param name="licznik">Jest to długość wprowadzonego kodu</param>
        
        public bool testDlugosci(int licznik)
        {
            bool wynikTestu = true;
            if (licznik == 0)
            {
                MessageBox.Show("Masz putą etykietę");
                wynikTestu = false;
                return wynikTestu;

            };
            if (licznik > 32)
            {
                MessageBox.Show("Doszedłeś do maksymalnej długości");
                wynikTestu = false;
                return wynikTestu;
            };
            return true;
        }
        /// <summary>
        /// Sprawdza czy ciąg zawiera polskie znaki
        /// </summary>
        /// <param name="box">Tekst wprowadzony do pola tekstowego zapisany jako strong</param>
      
        public bool czyZawieraPolskieZnaki(string box)
        {
            
            string polskieZnaki1 = "ą";
            string polskieZnaki2 = "ć";
            string polskieZnaki3 = "ę";
            string polskieZnaki4 = "ó";
            string polskieZnaki5 = "ń";
            string polskieZnaki6 = "ł";
            string polskieZnaki7 = "ż";
            string polskieZnaki8 = "ź";
            if (box.Contains(polskieZnaki1))
            {
                MessageBox.Show("Nie używaj polskich znaków w kodzie kreskowym");
                return true;
            }
            if (box.Contains(polskieZnaki2))
            {
                MessageBox.Show("Nie używaj polskich znaków w kodzie kreskowym");
                return true;
            }
            if (box.Contains(polskieZnaki3))
            {
                MessageBox.Show("Nie używaj polskich znaków w kodzie kreskowym");
                return true;
            }
            if (box.Contains(polskieZnaki4))
            {
                MessageBox.Show("Nie używaj polskich znaków w kodzie kreskowym");
                return true;
            }
            if (box.Contains(polskieZnaki5))
            {
                MessageBox.Show("Nie używaj polskich znaków w kodzie kreskowym");
                return true;
            }
            if (box.Contains(polskieZnaki6))
            {
                MessageBox.Show("Nie używaj polskich znaków w kodzie kreskowym");
                return true;
            }
            if (box.Contains(polskieZnaki7))
            {
                MessageBox.Show("Nie używaj polskich znaków w kodzie kreskowym");
                return true;
            }
            if (box.Contains(polskieZnaki8))
            {
                MessageBox.Show("Nie używaj polskich znaków w kodzie kreskowym");
                return true;
            }
            

            return false;
        }
    }
   
}
