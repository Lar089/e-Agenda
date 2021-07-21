
namespace eAgenda.Forms.TelasCompromisso
{
    partial class TelaCompromisso
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCompromisso));
            this.tabsVisualizar = new System.Windows.Forms.TabControl();
            this.Pendentes = new System.Windows.Forms.TabPage();
            this.TabelaPendente = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Assunto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Local = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Link = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraTermino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Concluidos = new System.Windows.Forms.TabPage();
            this.TabelaConcluidos = new System.Windows.Forms.DataGridView();
            this.Id2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Assunto2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Local2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Link2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraInicio2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraTermino2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contato2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.todosCompromissos = new System.Windows.Forms.TabPage();
            this.TabelaTodos = new System.Windows.Forms.DataGridView();
            this.Id3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Assunto3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Local3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Link3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraInicio3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraTermino3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contato3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Voltar = new System.Windows.Forms.Button();
            this.Excluir = new System.Windows.Forms.Button();
            this.Editar = new System.Windows.Forms.Button();
            this.Adicionar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.InicioData = new System.Windows.Forms.DateTimePicker();
            this.FinalData = new System.Windows.Forms.DateTimePicker();
            this.DataInicial = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabsVisualizar.SuspendLayout();
            this.Pendentes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaPendente)).BeginInit();
            this.Concluidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaConcluidos)).BeginInit();
            this.todosCompromissos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaTodos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabsVisualizar
            // 
            this.tabsVisualizar.Controls.Add(this.Pendentes);
            this.tabsVisualizar.Controls.Add(this.Concluidos);
            this.tabsVisualizar.Controls.Add(this.todosCompromissos);
            this.tabsVisualizar.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabsVisualizar.Location = new System.Drawing.Point(11, 60);
            this.tabsVisualizar.Name = "tabsVisualizar";
            this.tabsVisualizar.SelectedIndex = 0;
            this.tabsVisualizar.Size = new System.Drawing.Size(655, 334);
            this.tabsVisualizar.TabIndex = 26;
            this.tabsVisualizar.SelectedIndexChanged += new System.EventHandler(this.tabsVisualizar_SelectedIndexChanged);
            // 
            // Pendentes
            // 
            this.Pendentes.Controls.Add(this.TabelaPendente);
            this.Pendentes.Location = new System.Drawing.Point(4, 25);
            this.Pendentes.Name = "Pendentes";
            this.Pendentes.Padding = new System.Windows.Forms.Padding(3);
            this.Pendentes.Size = new System.Drawing.Size(647, 305);
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
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.DarkMagenta;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TabelaPendente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.TabelaPendente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabelaPendente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Assunto,
            this.Local,
            this.Link,
            this.Data,
            this.HoraInicio,
            this.HoraTermino,
            this.Contato});
            this.TabelaPendente.Location = new System.Drawing.Point(3, 0);
            this.TabelaPendente.Name = "TabelaPendente";
            this.TabelaPendente.ReadOnly = true;
            this.TabelaPendente.Size = new System.Drawing.Size(641, 302);
            this.TabelaPendente.TabIndex = 12;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Assunto
            // 
            this.Assunto.HeaderText = "Assunto";
            this.Assunto.Name = "Assunto";
            this.Assunto.ReadOnly = true;
            // 
            // Local
            // 
            this.Local.HeaderText = "Local";
            this.Local.Name = "Local";
            this.Local.ReadOnly = true;
            // 
            // Link
            // 
            this.Link.HeaderText = "Link";
            this.Link.Name = "Link";
            this.Link.ReadOnly = true;
            // 
            // Data
            // 
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // HoraInicio
            // 
            this.HoraInicio.HeaderText = "Hora de Inicio";
            this.HoraInicio.Name = "HoraInicio";
            this.HoraInicio.ReadOnly = true;
            // 
            // HoraTermino
            // 
            this.HoraTermino.HeaderText = "Hora de Termino ";
            this.HoraTermino.Name = "HoraTermino";
            this.HoraTermino.ReadOnly = true;
            // 
            // Contato
            // 
            this.Contato.HeaderText = "Contato";
            this.Contato.Name = "Contato";
            this.Contato.ReadOnly = true;
            // 
            // Concluidos
            // 
            this.Concluidos.Controls.Add(this.TabelaConcluidos);
            this.Concluidos.Location = new System.Drawing.Point(4, 25);
            this.Concluidos.Name = "Concluidos";
            this.Concluidos.Padding = new System.Windows.Forms.Padding(3);
            this.Concluidos.Size = new System.Drawing.Size(647, 305);
            this.Concluidos.TabIndex = 1;
            this.Concluidos.Text = "Concluídos";
            this.Concluidos.UseVisualStyleBackColor = true;
            // 
            // TabelaConcluidos
            // 
            this.TabelaConcluidos.AllowUserToAddRows = false;
            this.TabelaConcluidos.AllowUserToDeleteRows = false;
            this.TabelaConcluidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TabelaConcluidos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.DarkMagenta;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TabelaConcluidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.TabelaConcluidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabelaConcluidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id2,
            this.Assunto2,
            this.Local2,
            this.Link2,
            this.Data2,
            this.HoraInicio2,
            this.HoraTermino2,
            this.Contato2});
            this.TabelaConcluidos.Location = new System.Drawing.Point(3, 0);
            this.TabelaConcluidos.Name = "TabelaConcluidos";
            this.TabelaConcluidos.ReadOnly = true;
            this.TabelaConcluidos.Size = new System.Drawing.Size(641, 302);
            this.TabelaConcluidos.TabIndex = 13;
            // 
            // Id2
            // 
            this.Id2.HeaderText = "Id";
            this.Id2.Name = "Id2";
            this.Id2.ReadOnly = true;
            // 
            // Assunto2
            // 
            this.Assunto2.HeaderText = "Assunto";
            this.Assunto2.Name = "Assunto2";
            this.Assunto2.ReadOnly = true;
            // 
            // Local2
            // 
            this.Local2.HeaderText = "Local";
            this.Local2.Name = "Local2";
            this.Local2.ReadOnly = true;
            // 
            // Link2
            // 
            this.Link2.HeaderText = "Link";
            this.Link2.Name = "Link2";
            this.Link2.ReadOnly = true;
            // 
            // Data2
            // 
            this.Data2.HeaderText = "Data";
            this.Data2.Name = "Data2";
            this.Data2.ReadOnly = true;
            // 
            // HoraInicio2
            // 
            this.HoraInicio2.HeaderText = "Hora de Inicio";
            this.HoraInicio2.Name = "HoraInicio2";
            this.HoraInicio2.ReadOnly = true;
            // 
            // HoraTermino2
            // 
            this.HoraTermino2.HeaderText = "Hora de Termino ";
            this.HoraTermino2.Name = "HoraTermino2";
            this.HoraTermino2.ReadOnly = true;
            // 
            // Contato2
            // 
            this.Contato2.HeaderText = "Contato";
            this.Contato2.Name = "Contato2";
            this.Contato2.ReadOnly = true;
            // 
            // todosCompromissos
            // 
            this.todosCompromissos.Controls.Add(this.TabelaTodos);
            this.todosCompromissos.Location = new System.Drawing.Point(4, 25);
            this.todosCompromissos.Name = "todosCompromissos";
            this.todosCompromissos.Padding = new System.Windows.Forms.Padding(3);
            this.todosCompromissos.Size = new System.Drawing.Size(647, 305);
            this.todosCompromissos.TabIndex = 2;
            this.todosCompromissos.Text = "Todos os Compromissos";
            this.todosCompromissos.UseVisualStyleBackColor = true;
            // 
            // TabelaTodos
            // 
            this.TabelaTodos.AllowUserToAddRows = false;
            this.TabelaTodos.AllowUserToDeleteRows = false;
            this.TabelaTodos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TabelaTodos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.DarkMagenta;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TabelaTodos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.TabelaTodos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabelaTodos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id3,
            this.Assunto3,
            this.Local3,
            this.Link3,
            this.Data3,
            this.HoraInicio3,
            this.HoraTermino3,
            this.Contato3});
            this.TabelaTodos.Location = new System.Drawing.Point(3, 0);
            this.TabelaTodos.Name = "TabelaTodos";
            this.TabelaTodos.ReadOnly = true;
            this.TabelaTodos.Size = new System.Drawing.Size(641, 302);
            this.TabelaTodos.TabIndex = 13;
            // 
            // Id3
            // 
            this.Id3.HeaderText = "Id";
            this.Id3.Name = "Id3";
            this.Id3.ReadOnly = true;
            // 
            // Assunto3
            // 
            this.Assunto3.HeaderText = "Assunto";
            this.Assunto3.Name = "Assunto3";
            this.Assunto3.ReadOnly = true;
            // 
            // Local3
            // 
            this.Local3.HeaderText = "Local";
            this.Local3.Name = "Local3";
            this.Local3.ReadOnly = true;
            // 
            // Link3
            // 
            this.Link3.HeaderText = "Link";
            this.Link3.Name = "Link3";
            this.Link3.ReadOnly = true;
            // 
            // Data3
            // 
            this.Data3.HeaderText = "Data";
            this.Data3.Name = "Data3";
            this.Data3.ReadOnly = true;
            // 
            // HoraInicio3
            // 
            this.HoraInicio3.HeaderText = "Hora de Inicio";
            this.HoraInicio3.Name = "HoraInicio3";
            this.HoraInicio3.ReadOnly = true;
            // 
            // HoraTermino3
            // 
            this.HoraTermino3.HeaderText = "Hora de Termino ";
            this.HoraTermino3.Name = "HoraTermino3";
            this.HoraTermino3.ReadOnly = true;
            // 
            // Contato3
            // 
            this.Contato3.HeaderText = "Contato";
            this.Contato3.Name = "Contato3";
            this.Contato3.ReadOnly = true;
            // 
            // Voltar
            // 
            this.Voltar.BackColor = System.Drawing.SystemColors.Highlight;
            this.Voltar.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Voltar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Voltar.Location = new System.Drawing.Point(672, 435);
            this.Voltar.Name = "Voltar";
            this.Voltar.Size = new System.Drawing.Size(101, 31);
            this.Voltar.TabIndex = 25;
            this.Voltar.Text = "Voltar";
            this.Voltar.UseVisualStyleBackColor = false;
            this.Voltar.Click += new System.EventHandler(this.Voltar_Click);
            // 
            // Excluir
            // 
            this.Excluir.BackColor = System.Drawing.SystemColors.Highlight;
            this.Excluir.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Excluir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Excluir.Location = new System.Drawing.Point(672, 177);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(101, 31);
            this.Excluir.TabIndex = 24;
            this.Excluir.Text = "Excluir";
            this.Excluir.UseVisualStyleBackColor = false;
            this.Excluir.Click += new System.EventHandler(this.Excluir_Click);
            // 
            // Editar
            // 
            this.Editar.BackColor = System.Drawing.SystemColors.Highlight;
            this.Editar.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Editar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Editar.Location = new System.Drawing.Point(672, 128);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(101, 31);
            this.Editar.TabIndex = 23;
            this.Editar.Text = "Editar";
            this.Editar.UseVisualStyleBackColor = false;
            this.Editar.Click += new System.EventHandler(this.Editar_Click);
            // 
            // Adicionar
            // 
            this.Adicionar.BackColor = System.Drawing.SystemColors.Highlight;
            this.Adicionar.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adicionar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Adicionar.Location = new System.Drawing.Point(672, 77);
            this.Adicionar.Name = "Adicionar";
            this.Adicionar.Size = new System.Drawing.Size(101, 31);
            this.Adicionar.TabIndex = 22;
            this.Adicionar.Text = "Adicionar";
            this.Adicionar.UseVisualStyleBackColor = false;
            this.Adicionar.Click += new System.EventHandler(this.Adicionar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(218, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 50);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Century", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label3.Location = new System.Drawing.Point(266, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 44);
            this.label3.TabIndex = 20;
            this.label3.Text = "Compromisso";
            // 
            // InicioData
            // 
            this.InicioData.CalendarFont = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InicioData.CalendarForeColor = System.Drawing.Color.DarkMagenta;
            this.InicioData.CalendarMonthBackground = System.Drawing.SystemColors.ButtonHighlight;
            this.InicioData.CalendarTitleBackColor = System.Drawing.SystemColors.Highlight;
            this.InicioData.CalendarTitleForeColor = System.Drawing.Color.Plum;
            this.InicioData.CalendarTrailingForeColor = System.Drawing.Color.Black;
            this.InicioData.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InicioData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.InicioData.Location = new System.Drawing.Point(164, 36);
            this.InicioData.Name = "InicioData";
            this.InicioData.Size = new System.Drawing.Size(120, 27);
            this.InicioData.TabIndex = 27;
            this.InicioData.ValueChanged += new System.EventHandler(this.InicioData_ValueChanged);
            // 
            // FinalData
            // 
            this.FinalData.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FinalData.Location = new System.Drawing.Point(476, 38);
            this.FinalData.Name = "FinalData";
            this.FinalData.Size = new System.Drawing.Size(120, 27);
            this.FinalData.TabIndex = 28;
            this.FinalData.ValueChanged += new System.EventHandler(this.FinalData_ValueChanged);
            // 
            // DataInicial
            // 
            this.DataInicial.AutoSize = true;
            this.DataInicial.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataInicial.ForeColor = System.Drawing.Color.DarkMagenta;
            this.DataInicial.Location = new System.Drawing.Point(24, 40);
            this.DataInicial.Name = "DataInicial";
            this.DataInicial.Size = new System.Drawing.Size(134, 23);
            this.DataInicial.TabIndex = 29;
            this.DataInicial.Text = "Data Inicial:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label1.Location = new System.Drawing.Point(347, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 23);
            this.label1.TabIndex = 30;
            this.label1.Text = "Data Final:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label2.Location = new System.Drawing.Point(127, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(402, 23);
            this.label2.TabIndex = 31;
            this.label2.Text = "Selecione o intervalo dos Compromissos";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DataInicial);
            this.groupBox1.Controls.Add(this.FinalData);
            this.groupBox1.Controls.Add(this.InicioData);
            this.groupBox1.Location = new System.Drawing.Point(11, 393);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(655, 76);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            // 
            // TelaCompromisso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(784, 478);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabsVisualizar);
            this.Controls.Add(this.Voltar);
            this.Controls.Add(this.Excluir);
            this.Controls.Add(this.Editar);
            this.Controls.Add(this.Adicionar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Name = "TelaCompromisso";
            this.Text = "TelaCompromisso";
            this.Load += new System.EventHandler(this.TelaCompromisso_Load);
            this.tabsVisualizar.ResumeLayout(false);
            this.Pendentes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TabelaPendente)).EndInit();
            this.Concluidos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TabelaConcluidos)).EndInit();
            this.todosCompromissos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TabelaTodos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabsVisualizar;
        private System.Windows.Forms.TabPage Pendentes;
        private System.Windows.Forms.DataGridView TabelaPendente;
        private System.Windows.Forms.TabPage Concluidos;
        private System.Windows.Forms.TabPage todosCompromissos;
        private System.Windows.Forms.Button Voltar;
        private System.Windows.Forms.Button Excluir;
        private System.Windows.Forms.Button Editar;
        private System.Windows.Forms.Button Adicionar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Assunto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Local;
        private System.Windows.Forms.DataGridViewTextBoxColumn Link;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraTermino;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contato;
        private System.Windows.Forms.DataGridView TabelaConcluidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Assunto2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Local2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Link2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data2;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraInicio2;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraTermino2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contato2;
        private System.Windows.Forms.DataGridView TabelaTodos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Assunto3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Local3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Link3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data3;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraInicio3;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraTermino3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contato3;
        private System.Windows.Forms.DateTimePicker InicioData;
        private System.Windows.Forms.DateTimePicker FinalData;
        private System.Windows.Forms.Label DataInicial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}