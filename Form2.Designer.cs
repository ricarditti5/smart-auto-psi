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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
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
            this.btnVerDadosUser = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnAcelerar = new System.Windows.Forms.Button();
            this.btnTravar = new System.Windows.Forms.Button();
            this.timerMovimento = new System.Windows.Forms.Timer(this.components);
            this.lblBemVindo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPotencia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTanque = new System.Windows.Forms.Label();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.pbCamioneta = new System.Windows.Forms.PictureBox();
            this.pbMota = new System.Windows.Forms.PictureBox();
            this.pbCarro = new System.Windows.Forms.PictureBox();
            this.painelSimulacao = new System.Windows.Forms.Panel();
            this.cbTipoCombustivel = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCamioneta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCarro)).BeginInit();
            this.painelSimulacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(21, 114);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 20);
            this.txtMarca.TabIndex = 0;
            this.txtMarca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMarca_KeyPress);
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
            this.txtPlaca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlaca_KeyPress);
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
            this.txtModelo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtModelo_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdCamioneta);
            this.groupBox1.Controls.Add(this.rdMota);
            this.groupBox1.Controls.Add(this.rdCarro);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(24, 271);
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
            this.btnCriar.Location = new System.Drawing.Point(66, 391);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(137, 79);
            this.btnCriar.TabIndex = 7;
            this.btnCriar.Text = "Criar Veiculo";
            this.btnCriar.UseVisualStyleBackColor = true;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(686, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Sair do Aplicativo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Sair_Click);
            // 
            // btnEncherTanque
            // 
            this.btnEncherTanque.Location = new System.Drawing.Point(531, 145);
            this.btnEncherTanque.Name = "btnEncherTanque";
            this.btnEncherTanque.Size = new System.Drawing.Size(119, 23);
            this.btnEncherTanque.TabIndex = 9;
            this.btnEncherTanque.Text = "Encher o Tanque";
            this.btnEncherTanque.UseVisualStyleBackColor = true;
            this.btnEncherTanque.Click += new System.EventHandler(this.btnEncherTanque_Click);
            // 
            // btnVerDadosUser
            // 
            this.btnVerDadosUser.Location = new System.Drawing.Point(686, 12);
            this.btnVerDadosUser.Name = "btnVerDadosUser";
            this.btnVerDadosUser.Size = new System.Drawing.Size(120, 23);
            this.btnVerDadosUser.TabIndex = 10;
            this.btnVerDadosUser.Text = "Ver meus Dados";
            this.btnVerDadosUser.UseVisualStyleBackColor = true;
            this.btnVerDadosUser.Click += new System.EventHandler(this.btnVerOutroUser_Click);
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
            this.txtCor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCor_KeyPress);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(416, 145);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 13;
            this.progressBar1.Value = 100;
            // 
            // btnAcelerar
            // 
            this.btnAcelerar.Location = new System.Drawing.Point(479, 457);
            this.btnAcelerar.Name = "btnAcelerar";
            this.btnAcelerar.Size = new System.Drawing.Size(75, 23);
            this.btnAcelerar.TabIndex = 15;
            this.btnAcelerar.Text = "Acelerar";
            this.btnAcelerar.UseVisualStyleBackColor = true;
            this.btnAcelerar.Click += new System.EventHandler(this.btnAcelerar_Click);
            // 
            // btnTravar
            // 
            this.btnTravar.Location = new System.Drawing.Point(632, 457);
            this.btnTravar.Name = "btnTravar";
            this.btnTravar.Size = new System.Drawing.Size(75, 23);
            this.btnTravar.TabIndex = 16;
            this.btnTravar.Text = "Travar";
            this.btnTravar.UseVisualStyleBackColor = true;
            this.btnTravar.Click += new System.EventHandler(this.btnTravar_Click);
            // 
            // timerMovimento
            // 
            this.timerMovimento.Interval = 1500;
            this.timerMovimento.Tick += new System.EventHandler(this.timerMovimento_Tick);
            // 
            // lblBemVindo
            // 
            this.lblBemVindo.AutoSize = true;
            this.lblBemVindo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblBemVindo.Location = new System.Drawing.Point(18, 43);
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
            this.txtPotencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPotencia_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(163, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(223, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Diz o Tipo de Combustível: Gasolina/Gasoleo";
            // 
            // lblTanque
            // 
            this.lblTanque.AutoSize = true;
            this.lblTanque.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTanque.Location = new System.Drawing.Point(528, 120);
            this.lblTanque.Name = "lblTanque";
            this.lblTanque.Size = new System.Drawing.Size(182, 13);
            this.lblTanque.TabIndex = 24;
            this.lblTanque.Text = "Quanto de Combustivel vais Encher?";
            // 
            // txtQtd
            // 
            this.txtQtd.Location = new System.Drawing.Point(657, 148);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(100, 20);
            this.txtQtd.TabIndex = 23;
            this.txtQtd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtd_KeyPress);
            // 
            // pbCamioneta
            // 
            this.pbCamioneta.Image = ((System.Drawing.Image)(resources.GetObject("pbCamioneta.Image")));
            this.pbCamioneta.Location = new System.Drawing.Point(3, 128);
            this.pbCamioneta.Name = "pbCamioneta";
            this.pbCamioneta.Size = new System.Drawing.Size(100, 50);
            this.pbCamioneta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbCamioneta.TabIndex = 2;
            this.pbCamioneta.TabStop = false;
            // 
            // pbMota
            // 
            this.pbMota.Image = ((System.Drawing.Image)(resources.GetObject("pbMota.Image")));
            this.pbMota.Location = new System.Drawing.Point(3, 62);
            this.pbMota.Name = "pbMota";
            this.pbMota.Size = new System.Drawing.Size(81, 60);
            this.pbMota.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMota.TabIndex = 1;
            this.pbMota.TabStop = false;
            // 
            // pbCarro
            // 
            this.pbCarro.Image = ((System.Drawing.Image)(resources.GetObject("pbCarro.Image")));
            this.pbCarro.Location = new System.Drawing.Point(3, 11);
            this.pbCarro.Name = "pbCarro";
            this.pbCarro.Size = new System.Drawing.Size(100, 50);
            this.pbCarro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCarro.TabIndex = 0;
            this.pbCarro.TabStop = false;
            // 
            // painelSimulacao
            // 
            this.painelSimulacao.Controls.Add(this.pbCarro);
            this.painelSimulacao.Controls.Add(this.pbCamioneta);
            this.painelSimulacao.Controls.Add(this.pbMota);
            this.painelSimulacao.Location = new System.Drawing.Point(419, 196);
            this.painelSimulacao.Name = "painelSimulacao";
            this.painelSimulacao.Size = new System.Drawing.Size(387, 224);
            this.painelSimulacao.TabIndex = 26;
            // 
            // cbTipoCombustivel
            // 
            this.cbTipoCombustivel.FormattingEnabled = true;
            this.cbTipoCombustivel.Items.AddRange(new object[] {
            "Gasolina",
            "Gasoleo"});
            this.cbTipoCombustivel.Location = new System.Drawing.Point(166, 222);
            this.cbTipoCombustivel.Name = "cbTipoCombustivel";
            this.cbTipoCombustivel.Size = new System.Drawing.Size(121, 21);
            this.cbTipoCombustivel.TabIndex = 27;
            this.cbTipoCombustivel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbTipoCombustivel_KeyPress);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(827, 487);
            this.Controls.Add(this.cbTipoCombustivel);
            this.Controls.Add(this.painelSimulacao);
            this.Controls.Add(this.lblTanque);
            this.Controls.Add(this.txtQtd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPotencia);
            this.Controls.Add(this.lblBemVindo);
            this.Controls.Add(this.btnTravar);
            this.Controls.Add(this.btnAcelerar);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCor);
            this.Controls.Add(this.btnVerDadosUser);
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
            ((System.ComponentModel.ISupportInitialize)(this.pbCamioneta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCarro)).EndInit();
            this.painelSimulacao.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnAdicionarNovoUser;
        private System.Windows.Forms.Timer timerMovimento;
        private System.Windows.Forms.Label lblBemVindo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPotencia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTanque;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.PictureBox pbCamioneta;
        private System.Windows.Forms.PictureBox pbMota;
        private System.Windows.Forms.PictureBox pbCarro;
        private System.Windows.Forms.Panel painelSimulacao;
        private System.Windows.Forms.ComboBox cbTipoCombustivel;
        private System.Windows.Forms.Button btnVerDadosUser;
    }
}