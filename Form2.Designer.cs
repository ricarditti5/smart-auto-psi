namespace Projeto_Smart_Auto
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdCamioneta = new System.Windows.Forms.RadioButton();
            this.rdMota = new System.Windows.Forms.RadioButton();
            this.rdCarro = new System.Windows.Forms.RadioButton();
            this.btnCriar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnEncherTanque = new System.Windows.Forms.Button();
            this.btnVerOutroUser = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnAcelerar = new System.Windows.Forms.Button();
            this.btnTravar = new System.Windows.Forms.Button();
            this.é_para_quando_a_movimentacao_do_veiculo_for_criada = new System.Windows.Forms.ListBox();
            this.btnAdicionarNovoUser = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblBemVindo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPotencia = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(21, 114);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 20);
            this.txtMarca.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(18, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(18, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Placa";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(21, 171);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(100, 20);
            this.txtPlaca.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(163, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Modelo do Veiculo";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(166, 114);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(100, 20);
            this.txtModelo.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdCamioneta);
            this.groupBox1.Controls.Add(this.rdMota);
            this.groupBox1.Controls.Add(this.rdCarro);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(21, 248);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 114);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleciona o Tipo de Veiculo";
            // 
            // rdCamioneta
            // 
            this.rdCamioneta.AutoSize = true;
            this.rdCamioneta.Location = new System.Drawing.Point(7, 67);
            this.rdCamioneta.Name = "rdCamioneta";
            this.rdCamioneta.Size = new System.Drawing.Size(75, 17);
            this.rdCamioneta.TabIndex = 2;
            this.rdCamioneta.TabStop = true;
            this.rdCamioneta.Text = "Camioneta";
            this.rdCamioneta.UseVisualStyleBackColor = true;
            // 
            // rdMota
            // 
            this.rdMota.AutoSize = true;
            this.rdMota.Location = new System.Drawing.Point(7, 44);
            this.rdMota.Name = "rdMota";
            this.rdMota.Size = new System.Drawing.Size(49, 17);
            this.rdMota.TabIndex = 1;
            this.rdMota.TabStop = true;
            this.rdMota.Text = "Mota";
            this.rdMota.UseVisualStyleBackColor = true;
            // 
            // rdCarro
            // 
            this.rdCarro.AutoSize = true;
            this.rdCarro.Location = new System.Drawing.Point(7, 20);
            this.rdCarro.Name = "rdCarro";
            this.rdCarro.Size = new System.Drawing.Size(50, 17);
            this.rdCarro.TabIndex = 0;
            this.rdCarro.TabStop = true;
            this.rdCarro.Text = "Carro";
            this.rdCarro.UseVisualStyleBackColor = true;
            // 
            // btnCriar
            // 
            this.btnCriar.Location = new System.Drawing.Point(28, 384);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(137, 79);
            this.btnCriar.TabIndex = 7;
            this.btnCriar.Text = "Criar Veiculo";
            this.btnCriar.UseVisualStyleBackColor = true;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(28, 485);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Sair";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnEncherTanque
            // 
            this.btnEncherTanque.Location = new System.Drawing.Point(474, 85);
            this.btnEncherTanque.Name = "btnEncherTanque";
            this.btnEncherTanque.Size = new System.Drawing.Size(119, 23);
            this.btnEncherTanque.TabIndex = 9;
            this.btnEncherTanque.Text = "Encher o Tanque";
            this.btnEncherTanque.UseVisualStyleBackColor = true;
            // 
            // btnVerOutroUser
            // 
            this.btnVerOutroUser.Location = new System.Drawing.Point(603, 12);
            this.btnVerOutroUser.Name = "btnVerOutroUser";
            this.btnVerOutroUser.Size = new System.Drawing.Size(124, 23);
            this.btnVerOutroUser.TabIndex = 10;
            this.btnVerOutroUser.Text = "Ver Outro Utilizador";
            this.btnVerOutroUser.UseVisualStyleBackColor = true;
            this.btnVerOutroUser.Click += new System.EventHandler(this.btnVerOutroUser_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(163, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Cor";
            // 
            // txtCor
            // 
            this.txtCor.Location = new System.Drawing.Point(166, 171);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(100, 20);
            this.txtCor.TabIndex = 11;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(359, 85);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 13;
            this.progressBar1.Value = 100;
            // 
            // btnAcelerar
            // 
            this.btnAcelerar.Location = new System.Drawing.Point(422, 397);
            this.btnAcelerar.Name = "btnAcelerar";
            this.btnAcelerar.Size = new System.Drawing.Size(75, 23);
            this.btnAcelerar.TabIndex = 15;
            this.btnAcelerar.Text = "Acelerar";
            this.btnAcelerar.UseVisualStyleBackColor = true;
            // 
            // btnTravar
            // 
            this.btnTravar.Location = new System.Drawing.Point(575, 397);
            this.btnTravar.Name = "btnTravar";
            this.btnTravar.Size = new System.Drawing.Size(75, 23);
            this.btnTravar.TabIndex = 16;
            this.btnTravar.Text = "Travar";
            this.btnTravar.UseVisualStyleBackColor = true;
            // 
            // é_para_quando_a_movimentacao_do_veiculo_for_criada
            // 
            this.é_para_quando_a_movimentacao_do_veiculo_for_criada.FormattingEnabled = true;
            this.é_para_quando_a_movimentacao_do_veiculo_for_criada.Location = new System.Drawing.Point(359, 114);
            this.é_para_quando_a_movimentacao_do_veiculo_for_criada.Name = "é_para_quando_a_movimentacao_do_veiculo_for_criada";
            this.é_para_quando_a_movimentacao_do_veiculo_for_criada.Size = new System.Drawing.Size(341, 277);
            this.é_para_quando_a_movimentacao_do_veiculo_for_criada.TabIndex = 14;
            // 
            // btnAdicionarNovoUser
            // 
            this.btnAdicionarNovoUser.Location = new System.Drawing.Point(422, 12);
            this.btnAdicionarNovoUser.Name = "btnAdicionarNovoUser";
            this.btnAdicionarNovoUser.Size = new System.Drawing.Size(120, 23);
            this.btnAdicionarNovoUser.TabIndex = 17;
            this.btnAdicionarNovoUser.Text = "Adicionar Utilizador";
            this.btnAdicionarNovoUser.UseVisualStyleBackColor = true;
            this.btnAdicionarNovoUser.Click += new System.EventHandler(this.btnAdicionarNovoUser_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblBemVindo
            // 
            this.lblBemVindo.AutoSize = true;
            this.lblBemVindo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblBemVindo.Location = new System.Drawing.Point(37, 38);
            this.lblBemVindo.Name = "lblBemVindo";
            this.lblBemVindo.Size = new System.Drawing.Size(128, 13);
            this.lblBemVindo.TabIndex = 18;
            this.lblBemVindo.Text = "Bem Vindo ao Smart Auto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(21, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Potencia do Veiculo";
            // 
            // txtPotencia
            // 
            this.txtPotencia.Location = new System.Drawing.Point(24, 223);
            this.txtPotencia.Name = "txtPotencia";
            this.txtPotencia.Size = new System.Drawing.Size(100, 20);
            this.txtPotencia.TabIndex = 19;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(739, 520);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPotencia);
            this.Controls.Add(this.lblBemVindo);
            this.Controls.Add(this.btnAdicionarNovoUser);
            this.Controls.Add(this.btnTravar);
            this.Controls.Add(this.btnAcelerar);
            this.Controls.Add(this.é_para_quando_a_movimentacao_do_veiculo_for_criada);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCor);
            this.Controls.Add(this.btnVerOutroUser);
            this.Controls.Add(this.btnEncherTanque);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCriar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMarca);
            this.Name = "Form2";
            this.Text = "Smart Auto";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdCamioneta;
        private System.Windows.Forms.RadioButton rdMota;
        private System.Windows.Forms.RadioButton rdCarro;
        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnEncherTanque;
        private System.Windows.Forms.Button btnVerOutroUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnAcelerar;
        private System.Windows.Forms.Button btnTravar;
        private System.Windows.Forms.ListBox é_para_quando_a_movimentacao_do_veiculo_for_criada;
        private System.Windows.Forms.Button btnAdicionarNovoUser;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblBemVindo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPotencia;
    }
}