namespace olimpiada_jud_2016
{
    partial class Autentificare_client
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
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblParola = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.btnIntra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(28, 33);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(94, 19);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Adresa email";
            // 
            // lblParola
            // 
            this.lblParola.AutoSize = true;
            this.lblParola.Location = new System.Drawing.Point(28, 87);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(50, 19);
            this.lblParola.TabIndex = 1;
            this.lblParola.Text = "Parola";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(189, 30);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(151, 27);
            this.txtEmail.TabIndex = 2;
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(189, 84);
            this.txtParola.Name = "txtParola";
            this.txtParola.PasswordChar = '*';
            this.txtParola.Size = new System.Drawing.Size(151, 27);
            this.txtParola.TabIndex = 3;
            // 
            // btnIntra
            // 
            this.btnIntra.Location = new System.Drawing.Point(251, 177);
            this.btnIntra.Name = "btnIntra";
            this.btnIntra.Size = new System.Drawing.Size(120, 42);
            this.btnIntra.TabIndex = 4;
            this.btnIntra.Text = "Intra";
            this.btnIntra.UseVisualStyleBackColor = true;
            this.btnIntra.Click += new System.EventHandler(this.btnIntra_Click);
            // 
            // Autentificare_client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 231);
            this.Controls.Add(this.btnIntra);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblParola);
            this.Controls.Add(this.lblEmail);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Autentificare_client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autentificare_client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Autentificare_client_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblParola;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.Button btnIntra;
    }
}