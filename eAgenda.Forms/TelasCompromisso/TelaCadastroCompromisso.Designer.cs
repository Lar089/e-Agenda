
namespace eAgenda.Forms.TelasCompromisso
{
    partial class TelaCadastroCompromisso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastroCompromisso));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Cancelar = new System.Windows.Forms.Button();
            this.Salvar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Local = new System.Windows.Forms.ComboBox();
            this.Horatermino = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPrioridade = new System.Windows.Forms.Label();
            this.Assunto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Link = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Data = new System.Windows.Forms.DateTimePicker();
            this.HoraInicio = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TabelaContatos = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeContato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.AdicionarContato = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ContatoSelecionado = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaContatos)).BeginInit();
            this.SuspendLayout();
            // 
            // Cancelar
            // 
            this.Cancelar.BackColor = System.Drawing.SystemColors.Highlight;
            this.Cancelar.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Cancelar.Location = new System.Drawing.Point(675, 421);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(97, 38);
            this.Cancelar.TabIndex = 20;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = false;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Salvar
            // 
            this.Salvar.BackColor = System.Drawing.SystemColors.Highlight;
            this.Salvar.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salvar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Salvar.Location = new System.Drawing.Point(21, 421);
            this.Salvar.Name = "Salvar";
            this.Salvar.Size = new System.Drawing.Size(97, 38);
            this.Salvar.TabIndex = 19;
            this.Salvar.Text = "Salvar";
            this.Salvar.UseVisualStyleBackColor = false;
            this.Salvar.Click += new System.EventHandler(this.Salvar_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.36842F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.63158F));
            this.tableLayoutPanel1.Controls.Add(this.Local, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Horatermino, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelPrioridade, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Assunto, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Link, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.Data, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.HoraInicio, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(21, 101);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(380, 314);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // Local
            // 
            this.Local.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Local.FormattingEnabled = true;
            this.Local.Items.AddRange(new object[] {
            "Presencial",
            "Remoto"});
            this.Local.Location = new System.Drawing.Point(106, 55);
            this.Local.Name = "Local";
            this.Local.Size = new System.Drawing.Size(270, 28);
            this.Local.TabIndex = 29;
            this.Local.SelectedIndexChanged += new System.EventHandler(this.Local_SelectedIndexChanged);
            // 
            // Horatermino
            // 
            this.Horatermino.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Horatermino.Location = new System.Drawing.Point(106, 263);
            this.Horatermino.Mask = "00:00";
            this.Horatermino.Name = "Horatermino";
            this.Horatermino.Size = new System.Drawing.Size(127, 27);
            this.Horatermino.TabIndex = 16;
            this.Horatermino.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label6.Location = new System.Drawing.Point(3, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 36);
            this.label6.TabIndex = 8;
            this.label6.Text = "Hora Termino";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Assunto";
            // 
            // labelPrioridade
            // 
            this.labelPrioridade.AutoSize = true;
            this.labelPrioridade.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrioridade.ForeColor = System.Drawing.Color.DarkMagenta;
            this.labelPrioridade.Location = new System.Drawing.Point(3, 52);
            this.labelPrioridade.Name = "labelPrioridade";
            this.labelPrioridade.Size = new System.Drawing.Size(51, 18);
            this.labelPrioridade.TabIndex = 1;
            this.labelPrioridade.Text = "Local";
            // 
            // Assunto
            // 
            this.Assunto.Location = new System.Drawing.Point(106, 3);
            this.Assunto.Name = "Assunto";
            this.Assunto.Size = new System.Drawing.Size(270, 20);
            this.Assunto.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label2.Location = new System.Drawing.Point(3, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Link";
            // 
            // Link
            // 
            this.Link.Enabled = false;
            this.Link.Location = new System.Drawing.Point(106, 107);
            this.Link.Name = "Link";
            this.Link.Size = new System.Drawing.Size(271, 20);
            this.Link.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label5.Location = new System.Drawing.Point(3, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Data";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label4.Location = new System.Drawing.Point(3, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 36);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hora Inicial";
            // 
            // Data
            // 
            this.Data.CalendarForeColor = System.Drawing.Color.Black;
            this.Data.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Data.Location = new System.Drawing.Point(106, 159);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(127, 27);
            this.Data.TabIndex = 12;
            // 
            // HoraInicio
            // 
            this.HoraInicio.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoraInicio.Location = new System.Drawing.Point(106, 211);
            this.HoraInicio.Mask = "00:00";
            this.HoraInicio.Name = "HoraInicio";
            this.HoraInicio.Size = new System.Drawing.Size(127, 27);
            this.HoraInicio.TabIndex = 15;
            this.HoraInicio.ValidatingType = typeof(System.DateTime);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(224, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 50);
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Century", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label3.Location = new System.Drawing.Point(272, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 44);
            this.label3.TabIndex = 22;
            this.label3.Text = "Compromisso";
            // 
            // TabelaContatos
            // 
            this.TabelaContatos.AllowUserToAddRows = false;
            this.TabelaContatos.AllowUserToDeleteRows = false;
            this.TabelaContatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TabelaContatos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkMagenta;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TabelaContatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TabelaContatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabelaContatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.NomeContato});
            this.TabelaContatos.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.TabelaContatos.Location = new System.Drawing.Point(434, 156);
            this.TabelaContatos.Name = "TabelaContatos";
            this.TabelaContatos.ReadOnly = true;
            this.TabelaContatos.Size = new System.Drawing.Size(338, 183);
            this.TabelaContatos.TabIndex = 24;
            this.TabelaContatos.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.TabelaContatos_RowHeaderMouseClick);
            // 
            // Id
            // 
            this.Id.FillWeight = 50F;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // NomeContato
            // 
            this.NomeContato.FillWeight = 150F;
            this.NomeContato.HeaderText = "Nome do Contato";
            this.NomeContato.Name = "NomeContato";
            this.NomeContato.ReadOnly = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label7.Location = new System.Drawing.Point(442, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 18);
            this.label7.TabIndex = 25;
            this.label7.Text = "Adicionar Contato";
            // 
            // AdicionarContato
            // 
            this.AdicionarContato.AutoSize = true;
            this.AdicionarContato.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdicionarContato.ForeColor = System.Drawing.Color.Black;
            this.AdicionarContato.Location = new System.Drawing.Point(622, 104);
            this.AdicionarContato.Name = "AdicionarContato";
            this.AdicionarContato.Size = new System.Drawing.Size(57, 24);
            this.AdicionarContato.TabIndex = 26;
            this.AdicionarContato.Text = "Sim";
            this.AdicionarContato.UseVisualStyleBackColor = true;
            this.AdicionarContato.CheckedChanged += new System.EventHandler(this.AdicionarContato_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label8.Location = new System.Drawing.Point(431, 356);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 18);
            this.label8.TabIndex = 27;
            this.label8.Text = "Contato Selecionado";
            // 
            // ContatoSelecionado
            // 
            this.ContatoSelecionado.Enabled = false;
            this.ContatoSelecionado.Location = new System.Drawing.Point(434, 377);
            this.ContatoSelecionado.Name = "ContatoSelecionado";
            this.ContatoSelecionado.Size = new System.Drawing.Size(338, 20);
            this.ContatoSelecionado.TabIndex = 28;
            // 
            // TelaCadastroCompromisso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(784, 471);
            this.Controls.Add(this.ContatoSelecionado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.AdicionarContato);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TabelaContatos);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Salvar);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TelaCadastroCompromisso";
            this.Text = "TelaCadastroCompromisso";
            this.Load += new System.EventHandler(this.TelaCadastroCompromisso_Load_1);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaContatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button Salvar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPrioridade;
        private System.Windows.Forms.TextBox Assunto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Link;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker Data;
        private System.Windows.Forms.DataGridView TabelaContatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeContato;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox AdicionarContato;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ContatoSelecionado;
        private System.Windows.Forms.MaskedTextBox HoraInicio;
        private System.Windows.Forms.MaskedTextBox Horatermino;
        private System.Windows.Forms.ComboBox Local;
    }
}