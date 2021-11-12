
namespace CoGamers
{
    partial class Busca
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbEmailPessoaBusca = new System.Windows.Forms.Label();
            this.lbNomePessoaBusca = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rTBBemVindo = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dGVJogosUsuario = new System.Windows.Forms.DataGridView();
            this.IDJogo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeJogo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.cBFiltroJogos = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dGVPessoasPorJogo = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVJogosUsuario)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVPessoasPorJogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel1.Controls.Add(this.lbEmailPessoaBusca);
            this.panel1.Controls.Add(this.lbNomePessoaBusca);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(4, 424);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 133);
            this.panel1.TabIndex = 0;
            // 
            // lbEmailPessoaBusca
            // 
            this.lbEmailPessoaBusca.AutoSize = true;
            this.lbEmailPessoaBusca.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbEmailPessoaBusca.Location = new System.Drawing.Point(164, 66);
            this.lbEmailPessoaBusca.Name = "lbEmailPessoaBusca";
            this.lbEmailPessoaBusca.Size = new System.Drawing.Size(0, 30);
            this.lbEmailPessoaBusca.TabIndex = 2;
            // 
            // lbNomePessoaBusca
            // 
            this.lbNomePessoaBusca.AutoSize = true;
            this.lbNomePessoaBusca.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNomePessoaBusca.Location = new System.Drawing.Point(164, 9);
            this.lbNomePessoaBusca.Name = "lbNomePessoaBusca";
            this.lbNomePessoaBusca.Size = new System.Drawing.Size(0, 32);
            this.lbNomePessoaBusca.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CoGamers.Properties.Resources.iconeUsuario;
            this.pictureBox1.Location = new System.Drawing.Point(14, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // rTBBemVindo
            // 
            this.rTBBemVindo.BackColor = System.Drawing.SystemColors.Desktop;
            this.rTBBemVindo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rTBBemVindo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rTBBemVindo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.rTBBemVindo.Location = new System.Drawing.Point(18, 7);
            this.rTBBemVindo.Name = "rTBBemVindo";
            this.rTBBemVindo.Size = new System.Drawing.Size(321, 38);
            this.rTBBemVindo.TabIndex = 1;
            this.rTBBemVindo.Text = "Bem vindo!";
            this.rTBBemVindo.TextChanged += new System.EventHandler(this.rTBBemVindo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(18, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seus jogos:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dGVJogosUsuario);
            this.panel2.Location = new System.Drawing.Point(18, 95);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(235, 254);
            this.panel2.TabIndex = 3;
            // 
            // dGVJogosUsuario
            // 
            this.dGVJogosUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVJogosUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDJogo,
            this.NomeJogo});
            this.dGVJogosUsuario.Location = new System.Drawing.Point(0, 0);
            this.dGVJogosUsuario.Name = "dGVJogosUsuario";
            this.dGVJogosUsuario.RowTemplate.Height = 25;
            this.dGVJogosUsuario.Size = new System.Drawing.Size(235, 254);
            this.dGVJogosUsuario.TabIndex = 0;
            // 
            // IDJogo
            // 
            this.IDJogo.HeaderText = "IDJogo";
            this.IDJogo.Name = "IDJogo";
            // 
            // NomeJogo
            // 
            this.NomeJogo.HeaderText = "Nome Jogo";
            this.NomeJogo.Name = "NomeJogo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(322, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Buscar amigo por jogo:";
            // 
            // cBFiltroJogos
            // 
            this.cBFiltroJogos.FormattingEnabled = true;
            this.cBFiltroJogos.Location = new System.Drawing.Point(535, 62);
            this.cBFiltroJogos.Name = "cBFiltroJogos";
            this.cBFiltroJogos.Size = new System.Drawing.Size(211, 23);
            this.cBFiltroJogos.TabIndex = 5;
            this.cBFiltroJogos.Text = "Selecione um jogo:";
            this.cBFiltroJogos.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dGVPessoasPorJogo);
            this.panel3.Location = new System.Drawing.Point(322, 133);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(424, 216);
            this.panel3.TabIndex = 4;
            // 
            // dGVPessoasPorJogo
            // 
            this.dGVPessoasPorJogo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVPessoasPorJogo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Email});
            this.dGVPessoasPorJogo.Location = new System.Drawing.Point(0, 0);
            this.dGVPessoasPorJogo.MultiSelect = false;
            this.dGVPessoasPorJogo.Name = "dGVPessoasPorJogo";
            this.dGVPessoasPorJogo.ReadOnly = true;
            this.dGVPessoasPorJogo.RowTemplate.Height = 25;
            this.dGVPessoasPorJogo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVPessoasPorJogo.Size = new System.Drawing.Size(424, 216);
            this.dGVPessoasPorJogo.TabIndex = 0;
            this.dGVPessoasPorJogo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVPessoasPorJogo_CellClick);
            this.dGVPessoasPorJogo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVPessoasPorJogo_CellContentClick);
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.MinimumWidth = 10;
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 150;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 230;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(322, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pessoas que jogam";
            // 
            // Busca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.cBFiltroJogos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rTBBemVindo);
            this.Controls.Add(this.panel1);
            this.Name = "Busca";
            this.Text = "Busca";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVJogosUsuario)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVPessoasPorJogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox rTBBemVindo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cBFiltroJogos;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dGVPessoasPorJogo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridView dGVJogosUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDJogo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeJogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbEmailPessoaBusca;
        private System.Windows.Forms.Label lbNomePessoaBusca;
    }
}