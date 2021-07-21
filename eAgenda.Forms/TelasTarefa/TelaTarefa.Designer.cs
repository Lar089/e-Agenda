
namespace eAgenda.Forms.TelasTarefa
{
    partial class TelaTarefa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaTarefa));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Adicionar = new System.Windows.Forms.Button();
            this.Editar = new System.Windows.Forms.Button();
            this.Excluir = new System.Windows.Forms.Button();
            this.Voltar = new System.Windows.Forms.Button();
            this.tabsVisualizar = new System.Windows.Forms.TabControl();
            this.Pendentes = new System.Windows.Forms.TabPage();
            this.TabelaPendente = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prioridade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataCriacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Percentual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataConclusao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Concluidas = new System.Windows.Forms.TabPage();
            this.TabelaConcluida = new System.Windows.Forms.DataGridView();
            this.Id2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prioridade2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataCriacao2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Percentual2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataConclusao2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.todasTarefas = new System.Windows.Forms.TabPage();
            this.TabelaTodas = new System.Windows.Forms.DataGridView();
            this.Id3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prioridade3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataCriacao3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Percentual3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataConclusao3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabsVisualizar.SuspendLayout();
            this.Pendentes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaPendente)).BeginInit();
            this.Concluidas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaConcluida)).BeginInit();
            this.todasTarefas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaTodas)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(279, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 50);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Century", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label3.Location = new System.Drawing.Point(327, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 44);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tarefa";
            // 
            // Adicionar
            // 
            this.Adicionar.BackColor = System.Drawing.SystemColors.Highlight;
            this.Adicionar.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adicionar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Adicionar.Location = new System.Drawing.Point(673, 76);
            this.Adicionar.Name = "Adicionar";
            this.Adicionar.Size = new System.Drawing.Size(101, 31);
            this.Adicionar.TabIndex = 12;
            this.Adicionar.Text = "Adicionar";
            this.Adicionar.UseVisualStyleBackColor = false;
            this.Adicionar.Click += new System.EventHandler(this.Adicionar_Click);
            // 
            // Editar
            // 
            this.Editar.BackColor = System.Drawing.SystemColors.Highlight;
            this.Editar.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Editar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Editar.Location = new System.Drawing.Point(673, 127);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(101, 31);
            this.Editar.TabIndex = 13;
            this.Editar.Text = "Editar";
            this.Editar.UseVisualStyleBackColor = false;
            this.Editar.Click += new System.EventHandler(this.Editar_Click);
            // 
            // Excluir
            // 
            this.Excluir.BackColor = System.Drawing.SystemColors.Highlight;
            this.Excluir.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Excluir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Excluir.Location = new System.Drawing.Point(673, 176);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(101, 31);
            this.Excluir.TabIndex = 14;
            this.Excluir.Text = "Excluir";
            this.Excluir.UseVisualStyleBackColor = false;
            this.Excluir.Click += new System.EventHandler(this.Excluir_Click);
            // 
            // Voltar
            // 
            this.Voltar.BackColor = System.Drawing.SystemColors.Highlight;
            this.Voltar.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Voltar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Voltar.Location = new System.Drawing.Point(673, 428);
            this.Voltar.Name = "Voltar";
            this.Voltar.Size = new System.Drawing.Size(101, 31);
            this.Voltar.TabIndex = 18;
            this.Voltar.Text = "Voltar";
            this.Voltar.UseVisualStyleBackColor = false;
            this.Voltar.Click += new System.EventHandler(this.Voltar_Click);
            // 
            // tabsVisualizar
            // 
            this.tabsVisualizar.Controls.Add(this.Pendentes);
            this.tabsVisualizar.Controls.Add(this.Concluidas);
            this.tabsVisualizar.Controls.Add(this.todasTarefas);
            this.tabsVisualizar.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabsVisualizar.Location = new System.Drawing.Point(12, 59);
            this.tabsVisualizar.Name = "tabsVisualizar";
            this.tabsVisualizar.SelectedIndex = 0;
            this.tabsVisualizar.Size = new System.Drawing.Size(655, 406);
            this.tabsVisualizar.TabIndex = 19;
            this.tabsVisualizar.SelectedIndexChanged += new System.EventHandler(this.tabsVisualizar_SelectedIndexChanged);
            // 
            // Pendentes
            // 
            this.Pendentes.Controls.Add(this.TabelaPendente);
            this.Pendentes.Location = new System.Drawing.Point(4, 25);
            this.Pendentes.Name = "Pendentes";
            this.Pendentes.Padding = new System.Windows.Forms.Padding(3);
            this.Pendentes.Size = new System.Drawing.Size(647, 377);
            this.Pendentes.TabIndex = 0;
            this.Pendentes.Text = "Pendentes";
            this.Pendentes.UseVisualStyleBackColor = true;
            // 
            // TabelaPendente
            // 
            this.TabelaPendente.AllowUserToAddRows = false;
            this.TabelaPendente.AllowUserToDeleteRows = false;
            this.TabelaPendente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TabelaPendente.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TabelaPendente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabelaPendente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Titulo,
            this.Prioridade,
            this.DataCriacao,
            this.Percentual,
            this.DataConclusao});
            this.TabelaPendente.GridColor = System.Drawing.Color.Black;
            this.TabelaPendente.Location = new System.Drawing.Point(3, 0);
            this.TabelaPendente.Name = "TabelaPendente";
            this.TabelaPendente.ReadOnly = true;
            this.TabelaPendente.Size = new System.Drawing.Size(641, 371);
            this.TabelaPendente.TabIndex = 12;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Titulo
            // 
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            // 
            // Prioridade
            // 
            this.Prioridade.HeaderText = "Prioridade";
            this.Prioridade.Name = "Prioridade";
            this.Prioridade.ReadOnly = true;
            // 
            // DataCriacao
            // 
            this.DataCriacao.HeaderText = "Data de Criação";
            this.DataCriacao.Name = "DataCriacao";
            this.DataCriacao.ReadOnly = true;
            // 
            // Percentual
            // 
            this.Percentual.HeaderText = "Percentual";
            this.Percentual.Name = "Percentual";
            this.Percentual.ReadOnly = true;
            // 
            // DataConclusao
            // 
            this.DataConclusao.HeaderText = "Data de Conclusão";
            this.DataConclusao.Name = "DataConclusao";
            this.DataConclusao.ReadOnly = true;
            // 
            // Concluidas
            // 
            this.Concluidas.Controls.Add(this.TabelaConcluida);
            this.Concluidas.Location = new System.Drawing.Point(4, 25);
            this.Concluidas.Name = "Concluidas";
            this.Concluidas.Padding = new System.Windows.Forms.Padding(3);
            this.Concluidas.Size = new System.Drawing.Size(647, 377);
            this.Concluidas.TabIndex = 1;
            this.Concluidas.Text = "Concluídas";
            this.Concluidas.UseVisualStyleBackColor = true;
            // 
            // TabelaConcluida
            // 
            this.TabelaConcluida.AllowUserToAddRows = false;
            this.TabelaConcluida.AllowUserToDeleteRows = false;
            this.TabelaConcluida.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TabelaConcluida.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TabelaConcluida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabelaConcluida.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id2,
            this.Titulo2,
            this.Prioridade2,
            this.DataCriacao2,
            this.Percentual2,
            this.DataConclusao2});
            this.TabelaConcluida.Location = new System.Drawing.Point(3, 0);
            this.TabelaConcluida.Name = "TabelaConcluida";
            this.TabelaConcluida.ReadOnly = true;
            this.TabelaConcluida.Size = new System.Drawing.Size(641, 371);
            this.TabelaConcluida.TabIndex = 13;
            // 
            // Id2
            // 
            this.Id2.HeaderText = "Id";
            this.Id2.Name = "Id2";
            this.Id2.ReadOnly = true;
            // 
            // Titulo2
            // 
            this.Titulo2.HeaderText = "Titulo";
            this.Titulo2.Name = "Titulo2";
            this.Titulo2.ReadOnly = true;
            // 
            // Prioridade2
            // 
            this.Prioridade2.HeaderText = "Prioridade";
            this.Prioridade2.Name = "Prioridade2";
            this.Prioridade2.ReadOnly = true;
            // 
            // DataCriacao2
            // 
            this.DataCriacao2.HeaderText = "Data de Criação";
            this.DataCriacao2.Name = "DataCriacao2";
            this.DataCriacao2.ReadOnly = true;
            // 
            // Percentual2
            // 
            this.Percentual2.HeaderText = "Percentual";
            this.Percentual2.Name = "Percentual2";
            this.Percentual2.ReadOnly = true;
            // 
            // DataConclusao2
            // 
            this.DataConclusao2.HeaderText = "Data de Conclusão";
            this.DataConclusao2.Name = "DataConclusao2";
            this.DataConclusao2.ReadOnly = true;
            // 
            // todasTarefas
            // 
            this.todasTarefas.Controls.Add(this.TabelaTodas);
            this.todasTarefas.Location = new System.Drawing.Point(4, 25);
            this.todasTarefas.Name = "todasTarefas";
            this.todasTarefas.Padding = new System.Windows.Forms.Padding(3);
            this.todasTarefas.Size = new System.Drawing.Size(647, 377);
            this.todasTarefas.TabIndex = 2;
            this.todasTarefas.Text = "Todas as Tarefas";
            this.todasTarefas.UseVisualStyleBackColor = true;
            // 
            // TabelaTodas
            // 
            this.TabelaTodas.AllowUserToAddRows = false;
            this.TabelaTodas.AllowUserToDeleteRows = false;
            this.TabelaTodas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TabelaTodas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TabelaTodas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabelaTodas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id3,
            this.Titulo3,
            this.Prioridade3,
            this.DataCriacao3,
            this.Percentual3,
            this.DataConclusao3});
            this.TabelaTodas.Location = new System.Drawing.Point(3, 0);
            this.TabelaTodas.Name = "TabelaTodas";
            this.TabelaTodas.ReadOnly = true;
            this.TabelaTodas.Size = new System.Drawing.Size(641, 371);
            this.TabelaTodas.TabIndex = 14;
            // 
            // Id3
            // 
            this.Id3.HeaderText = "Id";
            this.Id3.Name = "Id3";
            this.Id3.ReadOnly = true;
            // 
            // Titulo3
            // 
            this.Titulo3.HeaderText = "Titulo";
            this.Titulo3.Name = "Titulo3";
            this.Titulo3.ReadOnly = true;
            // 
            // Prioridade3
            // 
            this.Prioridade3.HeaderText = "Prioridade";
            this.Prioridade3.Name = "Prioridade3";
            this.Prioridade3.ReadOnly = true;
            // 
            // DataCriacao3
            // 
            this.DataCriacao3.HeaderText = "Data de Criação";
            this.DataCriacao3.Name = "DataCriacao3";
            this.DataCriacao3.ReadOnly = true;
            // 
            // Percentual3
            // 
            this.Percentual3.HeaderText = "Percentual";
            this.Percentual3.Name = "Percentual3";
            this.Percentual3.ReadOnly = true;
            // 
            // DataConclusao3
            // 
            this.DataConclusao3.HeaderText = "Data de Conclusão";
            this.DataConclusao3.Name = "DataConclusao3";
            this.DataConclusao3.ReadOnly = true;
            // 
            // TelaTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(784, 471);
            this.Controls.Add(this.tabsVisualizar);
            this.Controls.Add(this.Voltar);
            this.Controls.Add(this.Excluir);
            this.Controls.Add(this.Editar);
            this.Controls.Add(this.Adicionar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.ForeColor = System.Drawing.Color.DarkMagenta;
            this.Name = "TelaTarefa";
            this.Text = "TelaTarefa";
            this.Load += new System.EventHandler(this.TelaTarefa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabsVisualizar.ResumeLayout(false);
            this.Pendentes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TabelaPendente)).EndInit();
            this.Concluidas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TabelaConcluida)).EndInit();
            this.todasTarefas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TabelaTodas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Adicionar;
        private System.Windows.Forms.Button Editar;
        private System.Windows.Forms.Button Excluir;
        private System.Windows.Forms.Button Voltar;
        private System.Windows.Forms.TabControl tabsVisualizar;
        private System.Windows.Forms.TabPage Pendentes;
        private System.Windows.Forms.DataGridView TabelaPendente;
        private System.Windows.Forms.TabPage Concluidas;
        private System.Windows.Forms.DataGridView TabelaConcluida;
        private System.Windows.Forms.TabPage todasTarefas;
        private System.Windows.Forms.DataGridView TabelaTodas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prioridade;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataCriacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Percentual;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataConclusao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prioridade2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataCriacao2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Percentual2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataConclusao2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prioridade3;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataCriacao3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Percentual3;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataConclusao3;
    }
}