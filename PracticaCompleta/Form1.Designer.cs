namespace PracticaCompleta
{
    partial class Formulario
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnControlButton = new System.Windows.Forms.Button();
            this.lblAviso = new System.Windows.Forms.Label();
            this.txtEscritura = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnControlButton
            // 
            this.btnControlButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnControlButton.Enabled = false;
            this.btnControlButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnControlButton.Image = global::PracticaCompleta.Properties.Resources._3706872_control_music_play_play_music_play_sound_start_108717;
            this.btnControlButton.Location = new System.Drawing.Point(342, 187);
            this.btnControlButton.Name = "btnControlButton";
            this.btnControlButton.Size = new System.Drawing.Size(133, 71);
            this.btnControlButton.TabIndex = 0;
            this.btnControlButton.UseVisualStyleBackColor = false;
            this.btnControlButton.Click += new System.EventHandler(this.btnControlButton_Click);
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAviso.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAviso.Location = new System.Drawing.Point(305, 145);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(226, 25);
            this.lblAviso.TabIndex = 1;
            this.lblAviso.Text = "¡No presione el boton!";
            this.lblAviso.Click += new System.EventHandler(this.lblAviso_Click);
            this.lblAviso.MouseLeave += new System.EventHandler(this.lblAviso_MouseLeave);
            this.lblAviso.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblAviso_MouseMove);
            // 
            // txtEscritura
            // 
            this.txtEscritura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEscritura.Location = new System.Drawing.Point(342, 76);
            this.txtEscritura.MaxLength = 400;
            this.txtEscritura.Name = "txtEscritura";
            this.txtEscritura.Size = new System.Drawing.Size(133, 20);
            this.txtEscritura.TabIndex = 2;
            this.txtEscritura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEscritura_KeyPress);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(342, 103);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtName.Size = new System.Drawing.Size(133, 20);
            this.txtName.TabIndex = 3;
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtEscritura);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.btnControlButton);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Formulario";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Formulario_FormClosed);
            this.Load += new System.EventHandler(this.Formulario_Load);
            this.Click += new System.EventHandler(this.Formulario_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnControlButton;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.TextBox txtEscritura;
        private System.Windows.Forms.TextBox txtName;
    }
}

