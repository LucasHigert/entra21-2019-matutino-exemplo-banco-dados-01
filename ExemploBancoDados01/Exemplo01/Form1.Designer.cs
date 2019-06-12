namespace Exemplo01
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
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lblCor = new System.Windows.Forms.Label();
            this.cbCor = new System.Windows.Forms.ComboBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.nudAno = new System.Windows.Forms.NumericUpDown();
            this.mtbPreco = new System.Windows.Forms.MaskedTextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dgvCarros = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnApagar = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudAno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarros)).BeginInit();
            this.SuspendLayout();
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(16, 98);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(42, 13);
            this.lblModelo.TabIndex = 0;
            this.lblModelo.Text = "Modelo";
            this.lblModelo.Click += new System.EventHandler(this.lblModelo_Click);
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(16, 124);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(140, 20);
            this.txtModelo.TabIndex = 1;
            this.txtModelo.TextChanged += new System.EventHandler(this.txtModelo_TextChanged);
            // 
            // lblCor
            // 
            this.lblCor.AutoSize = true;
            this.lblCor.Location = new System.Drawing.Point(16, 168);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(23, 13);
            this.lblCor.TabIndex = 2;
            this.lblCor.Text = "Cor";
            this.lblCor.Click += new System.EventHandler(this.lblCor_Click);
            // 
            // cbCor
            // 
            this.cbCor.FormattingEnabled = true;
            this.cbCor.Items.AddRange(new object[] {
            "Preto",
            "Branco",
            "Prata",
            "Amarelo",
            "Azul"});
            this.cbCor.Location = new System.Drawing.Point(16, 197);
            this.cbCor.Name = "cbCor";
            this.cbCor.Size = new System.Drawing.Size(140, 21);
            this.cbCor.TabIndex = 4;
            this.cbCor.SelectedIndexChanged += new System.EventHandler(this.cbCor_SelectedIndexChanged);
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(13, 235);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(35, 13);
            this.lblPreco.TabIndex = 5;
            this.lblPreco.Text = "Preço";
            this.lblPreco.Click += new System.EventHandler(this.lblPreco_Click);
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Location = new System.Drawing.Point(13, 302);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(26, 13);
            this.lblAno.TabIndex = 6;
            this.lblAno.Text = "Ano";
            this.lblAno.Click += new System.EventHandler(this.lblAno_Click);
            // 
            // nudAno
            // 
            this.nudAno.Location = new System.Drawing.Point(16, 340);
            this.nudAno.Maximum = new decimal(new int[] {
            2019,
            0,
            0,
            0});
            this.nudAno.Minimum = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            this.nudAno.Name = "nudAno";
            this.nudAno.Size = new System.Drawing.Size(140, 20);
            this.nudAno.TabIndex = 7;
            this.nudAno.Value = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            this.nudAno.ValueChanged += new System.EventHandler(this.nudAno_ValueChanged);
            // 
            // mtbPreco
            // 
            this.mtbPreco.Location = new System.Drawing.Point(16, 261);
            this.mtbPreco.Name = "mtbPreco";
            this.mtbPreco.Size = new System.Drawing.Size(140, 20);
            this.mtbPreco.TabIndex = 8;
            this.mtbPreco.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbPreco_MaskInputRejected);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(19, 380);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(65, 56);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // dgvCarros
            // 
            this.dgvCarros.AllowUserToAddRows = false;
            this.dgvCarros.AllowUserToDeleteRows = false;
            this.dgvCarros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnModelo});
            this.dgvCarros.Location = new System.Drawing.Point(297, 43);
            this.dgvCarros.Name = "dgvCarros";
            this.dgvCarros.ReadOnly = true;
            this.dgvCarros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCarros.Size = new System.Drawing.Size(347, 243);
            this.dgvCarros.TabIndex = 10;
            this.dgvCarros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCarros_CellContentClick);
            this.dgvCarros.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCarros_CellDoubleClick);
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "Código";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            // 
            // ColumnModelo
            // 
            this.ColumnModelo.HeaderText = "Modelo";
            this.ColumnModelo.Name = "ColumnModelo";
            this.ColumnModelo.ReadOnly = true;
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(212, 382);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(65, 56);
            this.btnApagar.TabIndex = 11;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(16, 42);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 12;
            this.lblCodigo.Text = "Código";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(107, 42);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(13, 13);
            this.lblId.TabIndex = 13;
            this.lblId.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 450);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.dgvCarros);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.mtbPreco);
            this.Controls.Add(this.nudAno);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.cbCor);
            this.Controls.Add(this.lblCor);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.lblModelo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.nudAno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lblCor;
        private System.Windows.Forms.ComboBox cbCor;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.NumericUpDown nudAno;
        private System.Windows.Forms.MaskedTextBox mtbPreco;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView dgvCarros;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnModelo;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblId;
    }
}

