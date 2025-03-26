namespace filmekGUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txKereses = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbNemzet = new System.Windows.Forms.ComboBox();
            this.dgAdatok = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbSzinesz = new System.Windows.Forms.Label();
            this.rtxFilmek = new System.Windows.Forms.RichTextBox();
            this.nev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szuldatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nemzet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgAdatok)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Keresés";
            // 
            // txKereses
            // 
            this.txKereses.Location = new System.Drawing.Point(88, 49);
            this.txKereses.Name = "txKereses";
            this.txKereses.Size = new System.Drawing.Size(392, 21);
            this.txKereses.TabIndex = 1;
            this.txKereses.TextChanged += new System.EventHandler(this.txKereses_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(523, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nemzetiség";
            // 
            // cbNemzet
            // 
            this.cbNemzet.FormattingEnabled = true;
            this.cbNemzet.Location = new System.Drawing.Point(613, 47);
            this.cbNemzet.Name = "cbNemzet";
            this.cbNemzet.Size = new System.Drawing.Size(121, 23);
            this.cbNemzet.TabIndex = 3;
            this.cbNemzet.SelectedIndexChanged += new System.EventHandler(this.cbNemzet_SelectedIndexChanged);
            // 
            // dgAdatok
            // 
            this.dgAdatok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAdatok.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nev,
            this.szuldatum,
            this.nemzet});
            this.dgAdatok.Location = new System.Drawing.Point(27, 85);
            this.dgAdatok.Name = "dgAdatok";
            this.dgAdatok.Size = new System.Drawing.Size(707, 262);
            this.dgAdatok.TabIndex = 4;
            this.dgAdatok.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAdatok_CellClick);
            this.dgAdatok.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAdatok_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Violet;
            this.panel1.Controls.Add(this.rtxFilmek);
            this.panel1.Controls.Add(this.lbSzinesz);
            this.panel1.Location = new System.Drawing.Point(33, 376);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(701, 196);
            this.panel1.TabIndex = 5;
            // 
            // lbSzinesz
            // 
            this.lbSzinesz.AutoSize = true;
            this.lbSzinesz.Location = new System.Drawing.Point(15, 14);
            this.lbSzinesz.Name = "lbSzinesz";
            this.lbSzinesz.Size = new System.Drawing.Size(69, 15);
            this.lbSzinesz.TabIndex = 0;
            this.lbSzinesz.Text = "lbSzinesz";
            // 
            // rtxFilmek
            // 
            this.rtxFilmek.BackColor = System.Drawing.Color.Cyan;
            this.rtxFilmek.Location = new System.Drawing.Point(55, 32);
            this.rtxFilmek.Name = "rtxFilmek";
            this.rtxFilmek.Size = new System.Drawing.Size(555, 151);
            this.rtxFilmek.TabIndex = 1;
            this.rtxFilmek.Text = "";
            // 
            // nev
            // 
            this.nev.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nev.HeaderText = "Színész";
            this.nev.Name = "nev";
            this.nev.ReadOnly = true;
            // 
            // szuldatum
            // 
            this.szuldatum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.szuldatum.HeaderText = "Született";
            this.szuldatum.Name = "szuldatum";
            this.szuldatum.ReadOnly = true;
            // 
            // nemzet
            // 
            this.nemzet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nemzet.HeaderText = "Nemzetiség";
            this.nemzet.Name = "nemzet";
            this.nemzet.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(780, 597);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgAdatok);
            this.Controls.Add(this.cbNemzet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txKereses);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Színészek";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAdatok)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txKereses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbNemzet;
        private System.Windows.Forms.DataGridView dgAdatok;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox rtxFilmek;
        private System.Windows.Forms.Label lbSzinesz;
        private System.Windows.Forms.DataGridViewTextBoxColumn nev;
        private System.Windows.Forms.DataGridViewTextBoxColumn szuldatum;
        private System.Windows.Forms.DataGridViewTextBoxColumn nemzet;
    }
}

