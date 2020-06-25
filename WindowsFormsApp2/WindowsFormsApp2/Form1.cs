using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {/// <summary>
    /// inicjalizacja programu
    /// </summary>
        public Form1()
        {
            InitializeComponent();
        }
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
        /// Zmiana wartości generowanego obrazu przez barcode.dll, po zmianie wartości wysyła nową wartość do barcodeControl1
        /// </summary>
        /// <param name="sender">Odniesienie sie do obiektu który wykonuje akcje (pole tekstowe)</param>
        /// <param name="e">e=zmiana wartości w polu</param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.barcodeControl1.Number = textBox1.Text;
        }

      
    }
}
