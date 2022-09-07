namespace login_sin_basedatos
{
    partial class FrmLogin
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
            this.SalirBtn = new System.Windows.Forms.Button();
            this.Ingresarbtn = new System.Windows.Forms.Button();
            this.lblnusuario = new System.Windows.Forms.Label();
            this.lblncontraseña = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SalirBtn
            // 
            this.SalirBtn.Location = new System.Drawing.Point(338, 184);
            this.SalirBtn.Name = "SalirBtn";
            this.SalirBtn.Size = new System.Drawing.Size(112, 34);
            this.SalirBtn.TabIndex = 0;
            this.SalirBtn.Text = "salir";
            this.SalirBtn.UseVisualStyleBackColor = true;
            // 
            // Ingresarbtn
            // 
            this.Ingresarbtn.Location = new System.Drawing.Point(206, 184);
            this.Ingresarbtn.Name = "Ingresarbtn";
            this.Ingresarbtn.Size = new System.Drawing.Size(112, 34);
            this.Ingresarbtn.TabIndex = 1;
            this.Ingresarbtn.Text = "ingresar";
            this.Ingresarbtn.UseVisualStyleBackColor = true;
            this.Ingresarbtn.Click += new System.EventHandler(this.Ingresarbtn_Click);
            // 
            // lblnusuario
            // 
            this.lblnusuario.AutoSize = true;
            this.lblnusuario.Location = new System.Drawing.Point(30, 59);
            this.lblnusuario.Name = "lblnusuario";
            this.lblnusuario.Size = new System.Drawing.Size(74, 25);
            this.lblnusuario.TabIndex = 2;
            this.lblnusuario.Text = "usuario:";
            // 
            // lblncontraseña
            // 
            this.lblncontraseña.AutoSize = true;
            this.lblncontraseña.Location = new System.Drawing.Point(30, 107);
            this.lblncontraseña.Name = "lblncontraseña";
            this.lblncontraseña.Size = new System.Drawing.Size(102, 25);
            this.lblncontraseña.TabIndex = 3;
            this.lblncontraseña.Text = "contraseña:";
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(135, 56);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(300, 31);
            this.txtusuario.TabIndex = 4;
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.Location = new System.Drawing.Point(138, 107);
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.Size = new System.Drawing.Size(297, 31);
            this.txtcontraseña.TabIndex = 5;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 242);
            this.Controls.Add(this.txtcontraseña);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.lblncontraseña);
            this.Controls.Add(this.lblnusuario);
            this.Controls.Add(this.Ingresarbtn);
            this.Controls.Add(this.SalirBtn);
            this.Name = "FrmLogin";
            this.Text = "FrmLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button SalirBtn;
        private Button Ingresarbtn;
        private Label lblnusuario;
        private Label lblncontraseña;
        private TextBox txtusuario;
        private TextBox txtcontraseña;
    }
}