using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Projeto_Smart_Auto
{
    public partial class Form2 : Form
    {
        //Variaveis para manipular o estado dos Usuários e seus dashboards
        private User usuarioActual;
        private List<User> listaUsuario = new List<User>();

        //variaveis do type of classes
        Carro c1;
        Mota m1;
        Camioneta cam1;

        // Variável para armazenar o veículo ativo e sua velocidade (ou estado)
        private Veiculo1 veiculoAtual;
        private double velocidadeAnimacao = 5.0; // Velocidade em pixels por tick

        //construtor do formulários
        public Form2(User usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;

            //inicializa o list com o primeiro usuario
            listaUsuario.Add(usuario);
            //timer1.Start();
            
            // Atualizar o Dashboard para mostrar os dados do usuário atual
            lblBemVindo.Text = $"Bem-vindo(a), {usuarioActual.nome}!";
        }


        //para o valor do combustivel
        private void timerMovimento_Tick(object sender, EventArgs e)
        {
            PictureBox pbVeiculo = null;

            /*varifica se a variavel pbVeciulo é type de uma das classes derivadas
            e faz com que o pbVeciulo fique com o valor da pictureBox, se for carro
            mota ou camioneta*/
            if (veiculoAtual is Carro) { pbVeiculo = pbCarro; }
            else if (veiculoAtual is Mota) { pbVeiculo = pbMota; }
            else if (veiculoAtual is Camioneta) { pbVeiculo = pbCamioneta; }

            if (pbVeiculo != null && pbVeiculo.Visible == true)
            {
                int novaPosicaoX = pbVeiculo.Location.X + (int)velocidadeAnimacao;
                pbVeiculo.Location = new Point(novaPosicaoX, pbVeiculo.Location.Y);

                // Loop Infinito
                if (pbVeiculo.Location.X > painelSimulacao.Width)
                {
                    pbVeiculo.Location = new Point(-pbVeiculo.Width, pbVeiculo.Location.Y);
                }
            }
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdicionarNovoUser_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Em processo de criação");
           /* using (var addForm = new Form1())
            {
                // ShowDialog() bloqueia o formulário Dashboard até que o FormAdicionarUsuario seja fechado.
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    // Se o usuário foi adicionado (DialogResult.OK), obtenha o objeto.
                    User novo = addForm.NovoUsuario;
                    listaUsuario.Add(novo);
                    MessageBox.Show($"Novo usuário {novo.nome} adicionado!");


                    // O dashboard permanece aberto e atualizado.
                }
            }*/
        }

        private void btnVerOutroUser_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Em processo de criação");
        }

        private PictureBox GetPbMota()
        {
            return pbMota;
        }

        private PictureBox GetPbCarro()
        {
            return pbCarro;
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            pbCarro.Visible = false;
            pbMota.Visible = false;
            pbCamioneta.Visible = false;

            if (string.IsNullOrWhiteSpace(txtPotencia.Text) || string.IsNullOrWhiteSpace(txtPlaca.Text) ||
        string.IsNullOrWhiteSpace(txtMarca.Text) || string.IsNullOrWhiteSpace(txtCor.Text) ||
        string.IsNullOrWhiteSpace(txtModelo.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos para criar o veículo.", "Erro de Entrada");
                return;
            }

            if (rdCarro.Checked == true)
            {
                c1 = new Carro(
                    double.Parse(txtPotencia.Text),
                    txtPlaca.Text,
                    txtMarca.Text,
                    txtCor.Text,
                    txtModelo.Text);
                
                veiculoAtual = c1;

                pbCarro.Image = Properties.Resources.CarroIcone;
                pbCarro.Visible = true;

                // Posicionamento inicial
                pbCarro.Location = new Point(0, pbCarro.Location.Y);

                MessageBox.Show($"O Carro da cor {txtCor.Text}, {txtMarca.Text} Modelo {txtModelo.Text} com a Placa: {txtPlaca.Text} foi criado");
                //mostrar a imagem do carro no espaço
                progressBar1.Value = 80;

                //Para Deixar as caixas de textos Limpas
                txtPotencia.Text = "";
                txtPlaca.Text = "";
                txtMarca.Text = "";
                txtCor.Text = "";
                txtModelo.Text = "";
            }
            else if(rdMota.Checked == true)
            {
                m1 = new Mota(
                    double.Parse(txtPotencia.Text),
                    txtPlaca.Text,
                    txtMarca.Text,
                    txtCor.Text,
                    txtModelo.Text);

                veiculoAtual = m1;

                pbMota.Image = Properties.Resources.MotaIcone;
                pbMota.Visible = true;

                // Posicionamento inicial
                pbMota.Location = new Point(0, pbMota.Location.Y);

                MessageBox.Show($"A Mota da cor {txtCor.Text}, {txtMarca.Text} Modelo {txtModelo.Text} com a Placa: {txtPlaca.Text} foi criado");
                //mostrar a imagem do carro no espaço
                progressBar1.Value = 80;

                //Para Deixar as caixas de textos Limpas
                txtPotencia.Text = "";
                txtPlaca.Text = "";
                txtMarca.Text = "";
                txtCor.Text = "";
                txtModelo.Text = "";
            }
            else if (rdCamioneta.Checked == true)
            {
                cam1 = new Camioneta(
                    double.Parse(txtPotencia.Text),
                    txtPlaca.Text,
                    txtMarca.Text,
                    txtCor.Text,
                    txtModelo.Text);

                veiculoAtual = cam1;

                pbCamioneta.Image = Properties.Resources.CamionetaIcone;
                pbCamioneta.Visible = true;

                // Posicionamento inicial
                pbCamioneta.Location = new Point(0, pbCamioneta.Location.Y);

                MessageBox.Show($"A Camioneta da cor {txtCor.Text}, {txtMarca.Text} Modelo {txtModelo.Text} com a Placa: {txtPlaca.Text} foi criado");
                //mostrar a imagem do carro no espaço
                progressBar1.Value = 80;

                //Para Deixar as caixas de textos Limpas
                txtPotencia.Text = "";
                txtPlaca.Text = "";
                txtMarca.Text = "";
                txtCor.Text = "";
                txtModelo.Text = "";
            }
            else
            {
                MessageBox.Show("Selecione o tipo de Veiculo que deseja criar");
            }
        }
        //metodo EncherTanque
        private void btnEncherTanque_Click(object sender, EventArgs e)
        {
            CultureInfo ptCulture = new CultureInfo("pt-PT");
            double quantidadeOuPreco;
            // 1. Normaliza: Substitui vírgula por ponto
            string normalizedText = txtQtd.Text.Replace(',', '.');

            // Tentar converter o texto da quantidade/preço
            if (!double.TryParse(normalizedText, NumberStyles.Any, CultureInfo.InvariantCulture, out quantidadeOuPreco))
            {
                MessageBox.Show("Por favor, introduza uma quantidade/preço válida (use vírgula para decimal).", "Erro de Formato");
                return;
            }

            try
            {
                if (rdCarro.Checked == true)
                {
                    // Certifique-se de que c1 foi inicializado em btnCriar_Click
                    if (c1 == null)
                    {
                        MessageBox.Show("Primeiro crie um Carro.");
                        return;
                    }

                    lblTanque.Text = $"Quantos Litros Vais Encher?";

                    //Variavel que recebe o metodo encher tanque e o executa
                    var valor = c1.EncherTanque(txtTipoCombustivel.Text, quantidadeOuPreco);
                    if (quantidadeOuPreco < 0.5) { progressBar1.Value += 50; }
                    else { progressBar1.Value += 20; }
                    MessageBox.Show(valor);
                }
                else if (rdMota.Checked == true)
                {
                    // Certifique-se de que c1 foi inicializado em btnCriar_Click
                    if (m1 == null)
                    {
                        MessageBox.Show("Primeiro crie uma Mota.");
                        return;
                    }

                    lblTanque.Text = $"Quantos Litros Vais Encher?";

                    //Variavel que recebe o metodo encher tanque e o executa
                    var valor = m1.EncherTanque(txtTipoCombustivel.Text, quantidadeOuPreco);

                    if (quantidadeOuPreco < 0.5) { progressBar1.Value += 50; }
                    else { progressBar1.Value += 20; }
                    MessageBox.Show(valor);
                }

                else if (rdCamioneta.Checked == true)
                {
                    // Certifique-se de que c1 foi inicializado em btnCriar_Click
                    if (cam1 == null)
                    {
                        MessageBox.Show("Primeiro crie uma Cmaioneta.");
                        return;
                    }

                    lblTanque.Text = $"Quantos Litros Vais Encher?";

                    //Variavel que recebe o metodo encher tanque e o executa
                    var valor = cam1.EncherTanque(txtTipoCombustivel.Text, quantidadeOuPreco);

                    if (quantidadeOuPreco < 2.5) { progressBar1.Value += 50; }
                    else { progressBar1.Value += 20; }
                    MessageBox.Show(valor);
                }
            }
            catch(FormatException ex)
            {
                // Captura se o double.TryParse falhou, embora o 'if' deva apanhar isto primeiro.
                MessageBox.Show("Ocorreu um erro de formato de dados. Por favor, verifique os campos.", $"Erro {ex}");
            }
            catch (NullReferenceException ex)
            {
                // Captura se, por algum motivo, um objeto c1/m1/cam1 não foi criado (apesar do 'if' acima).
                MessageBox.Show("O veículo não foi criado ou referenciado corretamente. Tente criar o veículo primeiro.", $"Erro de Objeto {ex}");
            }
            catch (Exception ex)
            {
                // Captura qualquer outro erro inesperado (ex: dentro do EncherTanque)
                MessageBox.Show($"Ocorreu um erro inesperado: {ex.Message}", "Erro Crítico");
            }
        }
    }
}
