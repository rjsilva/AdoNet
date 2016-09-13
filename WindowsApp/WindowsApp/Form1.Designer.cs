namespace WindowsApp
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
            this.btnTabela = new System.Windows.Forms.Button();
            this.lblcoluna = new System.Windows.Forms.Label();
            this.lblkey = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // btnTabela
            // 
            this.btnTabela.Location = new System.Drawing.Point(82, 36);
            this.btnTabela.Name = "btnTabela";
            this.btnTabela.Size = new System.Drawing.Size(75, 23);
            this.btnTabela.TabIndex = 2;
            this.btnTabela.Text = "Tabela";
            this.btnTabela.UseVisualStyleBackColor = true;
            this.btnTabela.Click += new System.EventHandler(this.btnTabela_Click);
            // 
            // lblcoluna
            // 
            this.lblcoluna.AutoSize = true;
            this.lblcoluna.Location = new System.Drawing.Point(15, 100);
            this.lblcoluna.Name = "lblcoluna";
            this.lblcoluna.Size = new System.Drawing.Size(39, 13);
            this.lblcoluna.TabIndex = 3;
            this.lblcoluna.Text = "coluna";
            // 
            // lblkey
            // 
            this.lblkey.AutoSize = true;
            this.lblkey.Location = new System.Drawing.Point(18, 137);
            this.lblkey.Name = "lblkey";
            this.lblkey.Size = new System.Drawing.Size(40, 13);
            this.lblkey.TabIndex = 4;
            this.lblkey.Text = "primary";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblkey);
            this.Controls.Add(this.lblcoluna);
            this.Controls.Add(this.btnTabela);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTabela;
        private System.Windows.Forms.Label lblcoluna;
        private System.Windows.Forms.Label lblkey;
    }
}

