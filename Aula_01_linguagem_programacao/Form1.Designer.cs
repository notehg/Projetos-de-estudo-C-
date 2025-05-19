namespace Aula_01
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.enviar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enviar
            // 
            this.enviar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.enviar.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.enviar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.enviar.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enviar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.enviar.Location = new System.Drawing.Point(404, 105);
            this.enviar.Margin = new System.Windows.Forms.Padding(1);
            this.enviar.Name = "enviar";
            this.enviar.Size = new System.Drawing.Size(105, 42);
            this.enviar.TabIndex = 0;
            this.enviar.Text = "enviar";
            this.enviar.UseVisualStyleBackColor = false;
            this.enviar.Click += new System.EventHandler(this.Enviar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(413, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ao infinito e alem";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 377);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enviar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enviar;
        private System.Windows.Forms.Label label1;
    }
}

