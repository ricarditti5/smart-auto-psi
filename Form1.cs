using System.Linq;
using System.Windows.Forms;

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

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtTlm_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
