
namespace HelloWorld
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.soma = new System.Windows.Forms.Button();
            this.number1 = new System.Windows.Forms.TextBox();
            this.number2 = new System.Windows.Forms.TextBox();
            this.limpar = new System.Windows.Forms.Button();
            this.resultcampo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // soma
            // 
            this.soma.Location = new System.Drawing.Point(12, 40);
            this.soma.Name = "soma";
            this.soma.Size = new System.Drawing.Size(93, 23);
            this.soma.TabIndex = 0;
            this.soma.Text = "Calculator";
            this.soma.UseVisualStyleBackColor = true;
            this.soma.Click += new System.EventHandler(this.soma_Click);
            // 
            // number1
            // 
            this.number1.Location = new System.Drawing.Point(12, 12);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(44, 22);
            this.number1.TabIndex = 1;
            // 
            // number2
            // 
            this.number2.Location = new System.Drawing.Point(62, 12);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(43, 22);
            this.number2.TabIndex = 2;
            // 
            // limpar
            // 
            this.limpar.Location = new System.Drawing.Point(111, 70);
            this.limpar.Name = "limpar";
            this.limpar.Size = new System.Drawing.Size(63, 23);
            this.limpar.TabIndex = 4;
            this.limpar.Text = "Clear";
            this.limpar.UseVisualStyleBackColor = true;
            this.limpar.Click += new System.EventHandler(this.limpar_Click);
            // 
            // resultcampo
            // 
            this.resultcampo.Location = new System.Drawing.Point(13, 70);
            this.resultcampo.Name = "resultcampo";
            this.resultcampo.Size = new System.Drawing.Size(92, 22);
            this.resultcampo.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImage = global::HelloWorld.Properties.Resources.noite_estrelada;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultcampo);
            this.Controls.Add(this.limpar);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.number1);
            this.Controls.Add(this.soma);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculadora Topster";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button soma;
        private System.Windows.Forms.TextBox number1;
        private System.Windows.Forms.TextBox number2;
        private System.Windows.Forms.Button limpar;
        private System.Windows.Forms.TextBox resultcampo;
    }
}

