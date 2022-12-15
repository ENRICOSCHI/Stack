namespace Verifica22._12._13
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTitolo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btAggiungi = new System.Windows.Forms.Button();
            this.btRimuovi = new System.Windows.Forms.Button();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.lbStampa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTitolo
            // 
            this.txtTitolo.Location = new System.Drawing.Point(154, 46);
            this.txtTitolo.Name = "txtTitolo";
            this.txtTitolo.Size = new System.Drawing.Size(476, 27);
            this.txtTitolo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Titolo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo";
            // 
            // btAggiungi
            // 
            this.btAggiungi.Location = new System.Drawing.Point(51, 259);
            this.btAggiungi.Name = "btAggiungi";
            this.btAggiungi.Size = new System.Drawing.Size(111, 66);
            this.btAggiungi.TabIndex = 4;
            this.btAggiungi.Text = "Aggiungi";
            this.btAggiungi.UseVisualStyleBackColor = true;
            this.btAggiungi.Click += new System.EventHandler(this.btAggiungi_Click);
            // 
            // btRimuovi
            // 
            this.btRimuovi.Location = new System.Drawing.Point(562, 259);
            this.btRimuovi.Name = "btRimuovi";
            this.btRimuovi.Size = new System.Drawing.Size(111, 66);
            this.btRimuovi.TabIndex = 6;
            this.btRimuovi.Text = "Rimuovi";
            this.btRimuovi.UseVisualStyleBackColor = true;
            this.btRimuovi.Click += new System.EventHandler(this.btRimuovi_Click);
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(154, 117);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(147, 28);
            this.comboBox.TabIndex = 7;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // lbStampa
            // 
            this.lbStampa.AutoSize = true;
            this.lbStampa.Location = new System.Drawing.Point(249, 207);
            this.lbStampa.Name = "lbStampa";
            this.lbStampa.Size = new System.Drawing.Size(0, 20);
            this.lbStampa.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbStampa);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.btRimuovi);
            this.Controls.Add(this.btAggiungi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTitolo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtTitolo;
        private Label label1;
        private Label label2;
        private Button btAggiungi;
        private Button btRimuovi;
        private ComboBox comboBox;
        private Label lbStampa;
    }
}