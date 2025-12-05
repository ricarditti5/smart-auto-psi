using System.Windows.Forms;
/*
# Documentação passo-a-passo do Projeto Smart-Auto
- deve ter 1 classe base;
- 2-3 classes derivadas(devem herdar da classe base, sobre-escrever um dos metodos, ter diferentes comportamentos);
- uma das classes ser abstrata
- implementar na iterface uma das classe
- ter metodos comuns e usáveis
- usar keyword base
- usar polimorfismo
 Classe base Veiculo
 Classes derivadas: Carro, Mota, Camioneta
 Polimorfismo: Acelerar(), Travão()
 Interface: ISensor (ex.: detetar obstáculos)
 Classe abstrata: VeiculoMotorizado
 Uso do base nos construtores
se possível: criar carro autónomo com comportamento especial.

Utilizar o metodo Lista para cadastrar usuários(´Primeira pagina meio que o login, dps
o dasboard principal e o simulador de veiculos em movimento
 */

//ESTE FORM1 SERÁ APENAS PARA MOSTRAR USUÁRIOS
namespace Projeto_Smart_Auto
{
    public partial class Form1 : Form
    {
        User user1;
        public Form1()
        {
            InitializeComponent();
        }

        public User NovoUsuario { get; internal set; }

        private void btnSair_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void btnUser_Click(object sender, System.EventArgs e)
        {
            user1 = new User(txtNome.Text, int.Parse(txtTlm.Text));

            // 2. Definir o resultado da caixa de diálogo como OK--gemini
            // Isso permite que o Form Principal (Dashboard) saiba que o usuário foi adicionado.--gemini
            this.DialogResult = DialogResult.OK;

            Form2 novoForm = new Form2(user1);
            this.Hide();
            novoForm.Show();
            
            //fecha o formulario do User
        }
    }
}
