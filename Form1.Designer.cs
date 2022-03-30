
namespace CuestionarioEntregable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelTitulo = new System.Windows.Forms.Label();
            this.btnJugar = new System.Windows.Forms.Button();
            this.btnPuntaje = new System.Windows.Forms.Button();
            this.txtJugador = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitulo.ForeColor = System.Drawing.Color.GhostWhite;
            this.labelTitulo.Location = new System.Drawing.Point(131, 42);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(383, 46);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Juego Cuestionario";
            this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnJugar
            // 
            this.btnJugar.BackColor = System.Drawing.Color.White;
            this.btnJugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnJugar.Image = ((System.Drawing.Image)(resources.GetObject("btnJugar.Image")));
            this.btnJugar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJugar.Location = new System.Drawing.Point(167, 261);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(310, 105);
            this.btnJugar.TabIndex = 1;
            this.btnJugar.Text = "Iniciar Juego";
            this.btnJugar.UseVisualStyleBackColor = false;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // btnPuntaje
            // 
            this.btnPuntaje.BackColor = System.Drawing.Color.White;
            this.btnPuntaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPuntaje.Image = ((System.Drawing.Image)(resources.GetObject("btnPuntaje.Image")));
            this.btnPuntaje.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPuntaje.Location = new System.Drawing.Point(167, 391);
            this.btnPuntaje.Name = "btnPuntaje";
            this.btnPuntaje.Size = new System.Drawing.Size(310, 105);
            this.btnPuntaje.TabIndex = 2;
            this.btnPuntaje.Text = "Revisar Puntajes";
            this.btnPuntaje.UseVisualStyleBackColor = false;
            this.btnPuntaje.Click += new System.EventHandler(this.btnPuntaje_Click);
            // 
            // txtJugador
            // 
            this.txtJugador.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtJugador.Location = new System.Drawing.Point(199, 197);
            this.txtJugador.Name = "txtJugador";
            this.txtJugador.Size = new System.Drawing.Size(239, 34);
            this.txtJugador.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.GhostWhite;
            this.label1.Location = new System.Drawing.Point(211, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingresa tu apodo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(629, 533);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtJugador);
            this.Controls.Add(this.btnPuntaje);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.labelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(647, 580);
            this.MinimumSize = new System.Drawing.Size(647, 580);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Juego Preguntas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.Button btnPuntaje;
        private System.Windows.Forms.TextBox txtJugador;
        private System.Windows.Forms.Label label1;
    }
}

