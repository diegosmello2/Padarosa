namespace Padarosa.Formularios
{
    partial class GerenciadorProdutos
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
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.grbCadastro = new System.Windows.Forms.GroupBox();
            this.cmbCategoriaCad = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtPrecoCad = new System.Windows.Forms.TextBox();
            this.txtProdutoCad = new System.Windows.Forms.TextBox();
            this.lblCategoriaCad = new System.Windows.Forms.Label();
            this.lblPrecoCad = new System.Windows.Forms.Label();
            this.lblProdutoCad = new System.Windows.Forms.Label();
            this.grbEditar = new System.Windows.Forms.GroupBox();
            this.cmbCategoriaEdi = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtPrecoEdi = new System.Windows.Forms.TextBox();
            this.txtProdutoEdi = new System.Windows.Forms.TextBox();
            this.lblCategoriaEdi = new System.Windows.Forms.Label();
            this.lblPrecoEdi = new System.Windows.Forms.Label();
            this.lblProdutoEdi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.grbCadastro.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grbEditar.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(15, 12);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(769, 295);
            this.dgvProdutos.TabIndex = 1;
            this.dgvProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellContentClick);
            // 
            // grbCadastro
            // 
            this.grbCadastro.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.grbCadastro.Controls.Add(this.cmbCategoriaCad);
            this.grbCadastro.Controls.Add(this.groupBox1);
            this.grbCadastro.Controls.Add(this.btnCadastrar);
            this.grbCadastro.Controls.Add(this.txtPrecoCad);
            this.grbCadastro.Controls.Add(this.txtProdutoCad);
            this.grbCadastro.Controls.Add(this.lblCategoriaCad);
            this.grbCadastro.Controls.Add(this.lblPrecoCad);
            this.grbCadastro.Controls.Add(this.lblProdutoCad);
            this.grbCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCadastro.Location = new System.Drawing.Point(15, 346);
            this.grbCadastro.Name = "grbCadastro";
            this.grbCadastro.Size = new System.Drawing.Size(271, 219);
            this.grbCadastro.TabIndex = 2;
            this.grbCadastro.TabStop = false;
            this.grbCadastro.Text = "CADASTRO:";
            // 
            // cmbCategoriaCad
            // 
            this.cmbCategoriaCad.FormattingEnabled = true;
            this.cmbCategoriaCad.Location = new System.Drawing.Point(137, 128);
            this.cmbCategoriaCad.Name = "cmbCategoriaCad";
            this.cmbCategoriaCad.Size = new System.Drawing.Size(121, 24);
            this.cmbCategoriaCad.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(269, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 219);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CADASTRO:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "CADASTRAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(137, 128);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 22);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(137, 90);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(126, 22);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(137, 48);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(126, 22);
            this.textBox3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nome Completo:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(41, 179);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(185, 34);
            this.btnCadastrar.TabIndex = 2;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtPrecoCad
            // 
            this.txtPrecoCad.Location = new System.Drawing.Point(137, 90);
            this.txtPrecoCad.Name = "txtPrecoCad";
            this.txtPrecoCad.Size = new System.Drawing.Size(126, 22);
            this.txtPrecoCad.TabIndex = 4;
            // 
            // txtProdutoCad
            // 
            this.txtProdutoCad.Location = new System.Drawing.Point(137, 48);
            this.txtProdutoCad.Name = "txtProdutoCad";
            this.txtProdutoCad.Size = new System.Drawing.Size(126, 22);
            this.txtProdutoCad.TabIndex = 3;
            // 
            // lblCategoriaCad
            // 
            this.lblCategoriaCad.AutoSize = true;
            this.lblCategoriaCad.Location = new System.Drawing.Point(6, 134);
            this.lblCategoriaCad.Name = "lblCategoriaCad";
            this.lblCategoriaCad.Size = new System.Drawing.Size(79, 16);
            this.lblCategoriaCad.TabIndex = 2;
            this.lblCategoriaCad.Text = "Categoria:";
            // 
            // lblPrecoCad
            // 
            this.lblPrecoCad.AutoSize = true;
            this.lblPrecoCad.Location = new System.Drawing.Point(6, 96);
            this.lblPrecoCad.Name = "lblPrecoCad";
            this.lblPrecoCad.Size = new System.Drawing.Size(52, 16);
            this.lblPrecoCad.TabIndex = 1;
            this.lblPrecoCad.Text = "Preço:";
            // 
            // lblProdutoCad
            // 
            this.lblProdutoCad.AutoSize = true;
            this.lblProdutoCad.Location = new System.Drawing.Point(6, 54);
            this.lblProdutoCad.Name = "lblProdutoCad";
            this.lblProdutoCad.Size = new System.Drawing.Size(65, 16);
            this.lblProdutoCad.TabIndex = 0;
            this.lblProdutoCad.Text = "Produto:";
            // 
            // grbEditar
            // 
            this.grbEditar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.grbEditar.Controls.Add(this.cmbCategoriaEdi);
            this.grbEditar.Controls.Add(this.groupBox3);
            this.grbEditar.Controls.Add(this.btnEditar);
            this.grbEditar.Controls.Add(this.txtPrecoEdi);
            this.grbEditar.Controls.Add(this.txtProdutoEdi);
            this.grbEditar.Controls.Add(this.lblCategoriaEdi);
            this.grbEditar.Controls.Add(this.lblPrecoEdi);
            this.grbEditar.Controls.Add(this.lblProdutoEdi);
            this.grbEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEditar.Location = new System.Drawing.Point(513, 346);
            this.grbEditar.Name = "grbEditar";
            this.grbEditar.Size = new System.Drawing.Size(271, 219);
            this.grbEditar.TabIndex = 3;
            this.grbEditar.TabStop = false;
            this.grbEditar.Text = "EDITAR:";
            this.grbEditar.Enter += new System.EventHandler(this.grbEditar_Enter);
            // 
            // cmbCategoriaEdi
            // 
            this.cmbCategoriaEdi.FormattingEnabled = true;
            this.cmbCategoriaEdi.Location = new System.Drawing.Point(137, 128);
            this.cmbCategoriaEdi.Name = "cmbCategoriaEdi";
            this.cmbCategoriaEdi.Size = new System.Drawing.Size(121, 24);
            this.cmbCategoriaEdi.TabIndex = 5;
            this.cmbCategoriaEdi.SelectedIndexChanged += new System.EventHandler(this.cmbCategoriaEdi_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Controls.Add(this.textBox5);
            this.groupBox3.Controls.Add(this.textBox6);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(269, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(269, 219);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CADASTRO:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(41, 179);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(185, 34);
            this.button2.TabIndex = 2;
            this.button2.Text = "CADASTRAR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(137, 128);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(126, 22);
            this.textBox4.TabIndex = 5;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(137, 90);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(126, 22);
            this.textBox5.TabIndex = 4;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(137, 48);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(126, 22);
            this.textBox6.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Senha:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nome Completo:";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(41, 179);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(185, 34);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtPrecoEdi
            // 
            this.txtPrecoEdi.Location = new System.Drawing.Point(137, 90);
            this.txtPrecoEdi.Name = "txtPrecoEdi";
            this.txtPrecoEdi.Size = new System.Drawing.Size(126, 22);
            this.txtPrecoEdi.TabIndex = 4;
            // 
            // txtProdutoEdi
            // 
            this.txtProdutoEdi.Location = new System.Drawing.Point(137, 48);
            this.txtProdutoEdi.Name = "txtProdutoEdi";
            this.txtProdutoEdi.Size = new System.Drawing.Size(126, 22);
            this.txtProdutoEdi.TabIndex = 3;
            // 
            // lblCategoriaEdi
            // 
            this.lblCategoriaEdi.AutoSize = true;
            this.lblCategoriaEdi.Location = new System.Drawing.Point(6, 134);
            this.lblCategoriaEdi.Name = "lblCategoriaEdi";
            this.lblCategoriaEdi.Size = new System.Drawing.Size(79, 16);
            this.lblCategoriaEdi.TabIndex = 2;
            this.lblCategoriaEdi.Text = "Categoria:";
            // 
            // lblPrecoEdi
            // 
            this.lblPrecoEdi.AutoSize = true;
            this.lblPrecoEdi.Location = new System.Drawing.Point(6, 96);
            this.lblPrecoEdi.Name = "lblPrecoEdi";
            this.lblPrecoEdi.Size = new System.Drawing.Size(52, 16);
            this.lblPrecoEdi.TabIndex = 1;
            this.lblPrecoEdi.Text = "Preço:";
            // 
            // lblProdutoEdi
            // 
            this.lblProdutoEdi.AutoSize = true;
            this.lblProdutoEdi.Location = new System.Drawing.Point(6, 54);
            this.lblProdutoEdi.Name = "lblProdutoEdi";
            this.lblProdutoEdi.Size = new System.Drawing.Size(65, 16);
            this.lblProdutoEdi.TabIndex = 0;
            this.lblProdutoEdi.Text = "Produto:";
            // 
            // GerenciadorProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(796, 577);
            this.Controls.Add(this.grbEditar);
            this.Controls.Add(this.grbCadastro);
            this.Controls.Add(this.dgvProdutos);
            this.Name = "GerenciadorProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gerenciador de Produtos";
            this.Load += new System.EventHandler(this.GerenciadorProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.grbCadastro.ResumeLayout(false);
            this.grbCadastro.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbEditar.ResumeLayout(false);
            this.grbEditar.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.GroupBox grbCadastro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtPrecoCad;
        private System.Windows.Forms.TextBox txtProdutoCad;
        private System.Windows.Forms.Label lblCategoriaCad;
        private System.Windows.Forms.Label lblPrecoCad;
        private System.Windows.Forms.Label lblProdutoCad;
        private System.Windows.Forms.GroupBox grbEditar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txtPrecoEdi;
        private System.Windows.Forms.TextBox txtProdutoEdi;
        private System.Windows.Forms.Label lblCategoriaEdi;
        private System.Windows.Forms.Label lblPrecoEdi;
        private System.Windows.Forms.Label lblProdutoEdi;
        private System.Windows.Forms.ComboBox cmbCategoriaCad;
        private System.Windows.Forms.ComboBox cmbCategoriaEdi;
    }
}