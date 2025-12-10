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
        private double velocidadeAnimacao = 15.0; // Velocidade em pixels por tick
        private readonly double INCREMENTO_VELOCIDADE = 0.5; // O quanto a velocidade aumenta
        private readonly double VELOCIDADE_MAXIMA = 15.0; // Limite para a velocidade

        // Defina estas variáveis no topo da sua classe Form2 para que sejam acessíveis
        private readonly int POSICAO_INICIAL_X = 5;
        private readonly int LIMITE_MAXIMO_PARAGEM = 600; // Exemplo: A área segura vai até o pixel X=600


        //construtor do formulários
        public Form2(User usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;

            //inicializa o list com o primeiro usuario
            listaUsuario.Add(usuario);

            // Atualizar o Dashboard para mostrar os dados do usuário atual
            lblBemVindo.Text = $"Bem-vindo(a) ao SmartAuto! ,{usuarioActual.nome} ";

            //para esconder as imagens ao inicializar o form2
            pbCarro.Visible = false;
            pbMota.Visible = false;
            pbCamioneta.Visible = false;
        }
        //Timer para o movimento dos veiculos
        private void timerMovimento_Tick(object sender, EventArgs e)
        {
            PictureBox pbVeiculo = null;

            /*verifica se a variavel pbVeciulo é type de uma das classes derivadas
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
                progressBar1.Value -= 9;
            }
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // em processo de criação
        private void btnAdicionarNovoUser_Click(object sender, EventArgs e)
        {
            Form1 addNovoUser = new Form1();
            addNovoUser.Show();

            this.Close();
        }

        private void btnVerOutroUser_Click(object sender, EventArgs e)
        {
            // Verificação de segurança: Deve haver usuários para ver
            if (listaUsuario.Count == 0)
            {
                MessageBox.Show("Não há outros usuários registados para selecionar. Adicione um novo usuário primeiro.", "Aviso");
                return;
            }

            // Cria e mostra o novo formulário de seleção
            // Passamos a lista de todos os usuários
            using (VerDadosUser formSelecao = new VerDadosUser(listaUsuario))
            {
                // Usamos ShowDialog() para bloquear o Form2 até que a seleção seja feita/cancelada
                if (formSelecao.ShowDialog() == DialogResult.OK)
                {
                    User usuarioSelecionado = formSelecao.UsuarioSelecionado;

                    //this.Hide();

                    Form2 novoDashboard = new Form2(usuarioSelecionado);
                    novoDashboard.Show();
                }
                // Se o utilizador cancelar a seleção, o Form2 atual (Dashboard) permanece aberto
            }
        }
        //--------------------------------------------------------------------------
        private void btnCriar_Click(object sender, EventArgs e)
        {
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

                // posição inicial do png do carro
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
                cbTipoCombustivel.Text = "";
            }
            else if (rdMota.Checked == true)
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

                // posição inicial do png da mota
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
                cbTipoCombustivel.Text = "";
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

                // posição inicial do png da camioneta
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
                cbTipoCombustivel.Text = "";
            }
            else
            {
                MessageBox.Show("Selecione o tipo de Veiculo que deseja criar");
            }
        }

        private void btnEncherTanque_Click(object sender, EventArgs e)
        {
            CultureInfo ptCulture = new CultureInfo("pt-PT");
            double quantidadeOuPreco = 0;
            string tipoCombustivel = "";
            

            if(cbTipoCombustivel.SelectedItem == null)
            {
                MessageBox.Show("Selecione um Tipo de Combustivel Válido" , "Caso não Tenhas criado um Veiculo, cria um Veiculo agora");
                return;
            }

            //o tipo combustivel toma o valor do que está na comboBox
            tipoCombustivel = cbTipoCombustivel.SelectedItem.ToString();

            //ve se nos numeros tem pontos ou virgulas
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
                    var valor = c1.EncherTanque(tipoCombustivel, quantidadeOuPreco);

                    if (quantidadeOuPreco < 0.5) { progressBar1.Value += 50; txtQtd.Text = ""; }
                    else { progressBar1.Value += 20; txtQtd.Text = ""; }
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
                    var valor = m1.EncherTanque(tipoCombustivel, quantidadeOuPreco);

                    if (quantidadeOuPreco < 0.5) { progressBar1.Value += 50; txtQtd.Text = ""; }
                    else { progressBar1.Value += 20; txtQtd.Text = ""; }
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
                    var valor = cam1.EncherTanque(tipoCombustivel, quantidadeOuPreco);

                    if (quantidadeOuPreco < 2.5) { progressBar1.Value += 50; txtQtd.Text = ""; }
                    else { progressBar1.Value += 20; txtQtd.Text = ""; }
                    MessageBox.Show(valor);
                }
            }
            catch (FormatException ex)
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

        private void btnAcelerar_Click(object sender, EventArgs e)
        {

            // 1. Verificação de Segurança (o veículo deve existir)
            if (veiculoAtual == null)
            {
                MessageBox.Show("Crie um veículo primeiro antes de acelerar.", "Aviso");
                return;
            }

            // 2. Aumentar a Velocidade e verifica como o veiculo age baseado no tipo de veiculo
            if (veiculoAtual is Carro)
            {
                veiculoAtual = c1;
                if (velocidadeAnimacao < VELOCIDADE_MAXIMA)
                {
                    // Aumenta a velocidade se ainda não atingiu o limite
                    velocidadeAnimacao += INCREMENTO_VELOCIDADE;
                    MessageBox.Show(c1.Acelerar(velocidadeAnimacao), "Acelerar");
                    progressBar1.Value -= 9;
                }
                else
                {
                    MessageBox.Show("Velocidade Máxima Atingida");
                    progressBar1.Value -= 12;
                }
                //coloquei aqui dentro desta verificação para verificar tera bugs e vou fazer nos outros
                // 3. Iniciar/Continuar o Movimento
                // Se o Timer já estiver ativo, ele continua, mas mais rápido. 
                // Se estiver parado (após Travar), ele recomeça.
                if (!timerMovimento.Enabled)
                {
                    timerMovimento.Start();
                }
            } 
            else if(veiculoAtual is Mota)
            {
                veiculoAtual = m1;
                if (velocidadeAnimacao < VELOCIDADE_MAXIMA)
                {
                    // Aumenta a velocidade se ainda não atingiu o limite
                    velocidadeAnimacao += INCREMENTO_VELOCIDADE;
                    MessageBox.Show(m1.Acelerar(velocidadeAnimacao), "Acelerar");
                    progressBar1.Value -= 9;
                }
                else
                {
                    MessageBox.Show("Velocidade Máxima Atingida");
                    progressBar1.Value -= 12;
                }
                // 3. Iniciar/Continuar o Movimento
                // Se o Timer já estiver ativo, ele continua, mas mais rápido. 
                // Se estiver parado (após Travar), ele recomeça.
                if (!timerMovimento.Enabled)
                {
                    timerMovimento.Start();
                }
            }
            else if(veiculoAtual is Camioneta)
            {
                veiculoAtual = cam1;
                if (velocidadeAnimacao < VELOCIDADE_MAXIMA)
                {
                    // Aumenta a velocidade se ainda não atingiu o limite
                    velocidadeAnimacao += INCREMENTO_VELOCIDADE;
                    MessageBox.Show(cam1.Acelerar(velocidadeAnimacao), "Acelerar");
                    progressBar1.Value -= 9;
                }
                else
                {
                    MessageBox.Show("Velocidade Máxima Atingida");
                    progressBar1.Value -= 12;
                }
                // 3. Iniciar/Continuar o Movimento
                // Se o Timer já estiver ativo, ele continua, mas mais rápido. 
                // Se estiver parado (após Travar), ele recomeça.
                if (!timerMovimento.Enabled)
                {
                    timerMovimento.Start();
                }
            }
            else
            {
                MessageBox.Show("Cria um veiculo primeiro antes de Acelerar");
            }
        }

        private void btnTravar_Click(object sender, EventArgs e)
        {
            // 1. PARE O MOVIMENTO IMEDIATAMENTE
            timerMovimento.Stop();

            // 2. Identificar o PictureBox ativo (Lógica espelhada do Timer Tick)
            PictureBox pbVeiculo = null;

            if (veiculoAtual is Carro)
            {
                pbVeiculo = pbCarro;
            }
            else if (veiculoAtual is Mota)
            {
                pbVeiculo = pbMota;
            }
            else if (veiculoAtual is Camioneta)
            {
                pbVeiculo = pbCamioneta;
            }

            // Verificação de segurança
            if (pbVeiculo == null || pbVeiculo.Visible == false)
            {
                MessageBox.Show("Nenhum veículo ativo para parar.", "Aviso");
                return;
            }

            // 3. Obter a Posição Atual
            int posicaoAtualX = pbVeiculo.Location.X;

            // 4. Lógica de Verificação da Posição
            if (posicaoAtualX > LIMITE_MAXIMO_PARAGEM)
            {
                // SE FORA DA ÁREA PERMITIDA: Regressar ao Ponto Inicial

                // Mantemos o Y onde estava, mas o X regressa ao ponto inicial
                pbVeiculo.Location = new Point(POSICAO_INICIAL_X, pbVeiculo.Location.Y);

                MessageBox.Show($"O veículo parou em X={posicaoAtualX} e estava fora da área segura. Regressou ao ponto inicial ({POSICAO_INICIAL_X}).", "Limite Excedido");
            }
            else
            {
                if (veiculoAtual is Carro)
                {
                    c1.Travar();
                }
                else if (veiculoAtual is Mota)
                {
                    m1.Travar();
                }
                else if (veiculoAtual is Camioneta)
                {
                    cam1.Travar();
                }
            }
        }
        //
        //Secção dos KeyPress
        //
        //para quando o user digitar um caracter que não seja number
        private void txtMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite Backspace e letras
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Permite o espaço (para nomes compostos)
                if (e.KeyChar != ' ')
                {
                    // Bloqueia qualquer outra coisa
                    e.Handled = true;
                }
            }
        }

        private void txtModelo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite Backspace e letras
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Permite o espaço (para nomes compostos)
                if (e.KeyChar != ' ')
                {
                    // Bloqueia qualquer outra coisa
                    e.Handled = true;
                }
            }
        }

        private void txtPlaca_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite Backspace e letras
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Permite o espaço (para nomes compostos)
                if (e.KeyChar != ' ')
                {
                    // Bloqueia qualquer outra coisa
                    e.Handled = true;
                }
            }
        }

        private void txtCor_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite Backspace e letras
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Permite o espaço (para nomes compostos)
                if (e.KeyChar != ' ')
                {
                    // Bloqueia qualquer outra coisa
                    e.Handled = true;
                }
            }
        }

        private void txtPotencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite Backspace e dígitos
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Permite o separador decimal (vírgula ou ponto)
                if (e.KeyChar == ',' || e.KeyChar == '.')
                {
                    // Verifica se a caixa de texto já contém um separador
                    if (((TextBox)sender).Text.Contains(',') || ((TextBox)sender).Text.Contains('.'))
                    {
                        // Se já houver um separador, bloqueia a entrada
                        e.Handled = true;
                    }
                }
                else
                {
                    // Bloqueia qualquer outro caractere que não seja dígito, Backspace, vírgula ou ponto
                    e.Handled = true;
                }
            }
        }

        private void txtQtd_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite Backspace e dígitos
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Permite o separador decimal (vírgula ou ponto)
                if (e.KeyChar == ',' || e.KeyChar == '.')
                {
                    // Verifica se a caixa de texto já contém um separador
                    if (((TextBox)sender).Text.Contains(',') || ((TextBox)sender).Text.Contains('.'))
                    {
                        // Se já houver um separador, bloqueia a entrada
                        e.Handled = true;
                    }
                }
                else
                {
                    // Bloqueia qualquer outro caractere que não seja dígito, Backspace, vírgula ou ponto
                    e.Handled = true;
                }
            }
        }

        private void cbTipoCombustivel_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite Backspace e letras
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Permite o espaço (para nomes compostos)
                if (e.KeyChar != ' ')
                {
                    // Bloqueia qualquer outra coisa
                    e.Handled = true;
                }
            }
        }
    }
}