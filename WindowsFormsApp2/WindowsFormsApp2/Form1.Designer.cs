namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Utworzenie formularza
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metody utworzone do Windows form
        /// </summary>
        private void InitializeComponent()
        {            this.barcodeControl1 = new Limilabs.Windows.BarcodeControl();
            this.button1 = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barcodeControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // barcodeControl1
            // 
            this.barcodeControl1.BackColor = System.Drawing.Color.White;
            this.barcodeControl1.BarColor = System.Drawing.Color.Black;
            this.barcodeControl1.FontName = "Orator Std";
            this.barcodeControl1.ForeColor = System.Drawing.Color.Black;
            this.barcodeControl1.Location = new System.Drawing.Point(2, 1);
            this.barcodeControl1.MaximumSize = new System.Drawing.Size(800, 200);
            this.barcodeControl1.MinimumSize = new System.Drawing.Size(800, 200);
            this.barcodeControl1.Name = "barcodeControl1";
            this.barcodeControl1.NarrowBarWidth = 2;
            this.barcodeControl1.Number = "Gotowy do pracy";
            this.barcodeControl1.Ratio = 1;
            this.barcodeControl1.Size = new System.Drawing.Size(800, 200);
            this.barcodeControl1.TabIndex = 0;
            this.barcodeControl1.Text = "barcodeControl1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(314, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Drukuj etykietę";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(2, 241);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(805, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tutaj wpisz tekst etykiety";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 446);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.barcodeControl1);
            this.Name = "Form1";
            this.Text = "Barcode generator";
            ((System.ComponentModel.ISupportInitialize)(this.barcodeControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private Limilabs.Windows.BarcodeControl barcodeControl1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}

