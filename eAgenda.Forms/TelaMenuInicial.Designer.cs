
namespace eAgenda.Forms
{
    partial class TelaMenuInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaMenuInicial));
            this.Tarefa = new System.Windows.Forms.Button();
            this.Contato = new System.Windows.Forms.Button();
            this.Compromisso = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Tarefa
            // 
            this.Tarefa.BackColor = System.Drawing.SystemColors.Highlight;
            this.Tarefa.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tarefa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Tarefa.Location = new System.Drawing.Point(89, 112);
            this.Tarefa.Name = "Tarefa";
            this.Tarefa.Size = new System.Drawing.Size(236, 69);
            this.Tarefa.TabIndex = 0;
            this.Tarefa.Text = "Tarefa";
            this.Tarefa.UseVisualStyleBackColor = false;
            this.Tarefa.Click += new System.EventHandler(this.Tarefa_Click);
            // 
            // Contato
            // 
            this.Contato.BackColor = System.Drawing.SystemColors.Highlight;
            this.Contato.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contato.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Contato.Location = new System.Drawing.Point(89, 234);
            this.Contato.Name = "Contato";
            this.Contato.Size = new System.Drawing.Size(236, 69);
            this.Contato.TabIndex = 1;
            this.Contato.Text = "Contato";
            this.Contato.UseVisualStyleBackColor = false;
            this.Contato.Click += new System.EventHandler(this.Contato_Click);
            // 
            // Compromisso
            // 
            this.Compromisso.BackColor = System.Drawing.SystemColors.Highlight;
            this.Compromisso.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Compromisso.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Compromisso.Location = new System.Drawing.Point(89, 352);
            this.Compromisso.Name = "Compromisso";
            this.Compromisso.Size = new System.Drawing.Size(236, 69);
            this.Compromisso.TabIndex = 2;
            this.Compromisso.Text = "Compromisso";
            this.Compromisso.UseVisualStyleBackColor = false;
            this.Compromisso.Click += new System.EventHandler(this.Compromisso_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(79, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 50);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Century", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label1.Location = new System.Drawing.Point(127, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 44);
            this.label1.TabIndex = 4;
            this.label1.Text = "E-Agenda";
            // 
            // TelaMenuInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(404, 461);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Compromisso);
            this.Controls.Add(this.Contato);
            this.Controls.Add(this.Tarefa);
            this.Name = "TelaMenuInicial";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Tarefa;
        private System.Windows.Forms.Button Contato;
        private System.Windows.Forms.Button Compromisso;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

