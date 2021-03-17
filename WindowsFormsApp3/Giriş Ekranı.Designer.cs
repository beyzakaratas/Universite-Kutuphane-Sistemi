namespace WindowsFormsApp3
{
    partial class FormGiriş
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
            this.comboBoxTablo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGöster = new System.Windows.Forms.Button();
            this.radioButtonSekmeli = new System.Windows.Forms.RadioButton();
            this.radioButtonGrid = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // comboBoxTablo
            // 
            this.comboBoxTablo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.comboBoxTablo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTablo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.comboBoxTablo.FormattingEnabled = true;
            this.comboBoxTablo.Items.AddRange(new object[] {
            "Öğrenci",
            "Ödünç Kayıt",
            "Kitap"});
            this.comboBoxTablo.Location = new System.Drawing.Point(146, 24);
            this.comboBoxTablo.Name = "comboBoxTablo";
            this.comboBoxTablo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTablo.TabIndex = 0;
            this.comboBoxTablo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tablo Seçiniz:";
            // 
            // btnGöster
            // 
            this.btnGöster.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGöster.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnGöster.Location = new System.Drawing.Point(28, 134);
            this.btnGöster.Name = "btnGöster";
            this.btnGöster.Size = new System.Drawing.Size(88, 28);
            this.btnGöster.TabIndex = 2;
            this.btnGöster.Text = "GÖSTER";
            this.btnGöster.UseVisualStyleBackColor = true;
            this.btnGöster.Click += new System.EventHandler(this.btnGöster_Click);
            // 
            // radioButtonSekmeli
            // 
            this.radioButtonSekmeli.AutoSize = true;
            this.radioButtonSekmeli.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonSekmeli.ForeColor = System.Drawing.Color.Indigo;
            this.radioButtonSekmeli.Location = new System.Drawing.Point(32, 62);
            this.radioButtonSekmeli.Name = "radioButtonSekmeli";
            this.radioButtonSekmeli.Size = new System.Drawing.Size(140, 23);
            this.radioButtonSekmeli.TabIndex = 3;
            this.radioButtonSekmeli.TabStop = true;
            this.radioButtonSekmeli.Text = "Sekmeli Görünüm";
            this.radioButtonSekmeli.UseVisualStyleBackColor = true;
            // 
            // radioButtonGrid
            // 
            this.radioButtonGrid.AutoSize = true;
            this.radioButtonGrid.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonGrid.ForeColor = System.Drawing.Color.Indigo;
            this.radioButtonGrid.Location = new System.Drawing.Point(32, 91);
            this.radioButtonGrid.Name = "radioButtonGrid";
            this.radioButtonGrid.Size = new System.Drawing.Size(117, 23);
            this.radioButtonGrid.TabIndex = 4;
            this.radioButtonGrid.TabStop = true;
            this.radioButtonGrid.Text = "Grid Görünüm";
            this.radioButtonGrid.UseVisualStyleBackColor = true;
            // 
            // FormGiriş
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(295, 192);
            this.Controls.Add(this.radioButtonGrid);
            this.Controls.Add(this.radioButtonSekmeli);
            this.Controls.Add(this.btnGöster);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxTablo);
            this.Name = "FormGiriş";
            this.Text = "Giriş Ekranı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTablo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGöster;
        private System.Windows.Forms.RadioButton radioButtonSekmeli;
        private System.Windows.Forms.RadioButton radioButtonGrid;
    }
}