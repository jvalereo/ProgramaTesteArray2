namespace AulaArray2
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.BtnVetor = new System.Windows.Forms.Button();
            this.BtnTexto = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(80, 39);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(152, 22);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Testando Array";
            this.lblTitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // BtnVetor
            // 
            this.BtnVetor.Location = new System.Drawing.Point(100, 124);
            this.BtnVetor.Name = "BtnVetor";
            this.BtnVetor.Size = new System.Drawing.Size(114, 40);
            this.BtnVetor.TabIndex = 1;
            this.BtnVetor.Text = "Teste Vetor";
            this.BtnVetor.UseVisualStyleBackColor = true;
            this.BtnVetor.Click += new System.EventHandler(this.BtnVetor_Click);
            // 
            // BtnTexto
            // 
            this.BtnTexto.Location = new System.Drawing.Point(100, 200);
            this.BtnTexto.Name = "BtnTexto";
            this.BtnTexto.Size = new System.Drawing.Size(114, 41);
            this.BtnTexto.TabIndex = 2;
            this.BtnTexto.Text = "Vetor Texto";
            this.BtnTexto.UseVisualStyleBackColor = true;
            this.BtnTexto.Click += new System.EventHandler(this.BtnTexto_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.Location = new System.Drawing.Point(120, 275);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(70, 33);
            this.BtnSair.TabIndex = 3;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(301, 336);
            this.ControlBox = false;
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnTexto);
            this.Controls.Add(this.BtnVetor);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teste Array";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button BtnVetor;
        private System.Windows.Forms.Button BtnTexto;
        private System.Windows.Forms.Button BtnSair;
    }
}

