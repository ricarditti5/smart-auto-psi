using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Smart_Auto
{
    public partial class Form2 : Form
    {
        private User usuarioActual;
        private List<User> listaUsuario = new List<User>();

        public Form2(User usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;

            //inicializa o list com o primeiro usuario
            listaUsuario.Add(usuario);
            //timer1.Start();
            
            // Atualizar o Dashboard para mostrar os dados do usuário atual
            //lblBemVindo.Text = $"Bem-vindo(a), {usuarioAtual.NomeUsuario}!";
        }

        private void lblBemVindo_Click(object sender, EventArgs e)
        {
            lblBemVindo.Text = $"Bem Vindo ao Smart Auto {usuarioActual}";
        }

        //para o valor do combustivel
        private void timer1_Tick(object sender, EventArgs e)
        {
           if(progressBar1.Value > 10)
            {
                progressBar1.Value = progressBar1.Value - 10;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //Codigo do botao de adicionar Novo Usuario
        /*
         using (var addForm = new FormAdicionarUsuario())
        {
            // ShowDialog() bloqueia o formulário Dashboard até que o FormAdicionarUsuario seja fechado.
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                // Se o usuário foi adicionado (DialogResult.OK), obtenha o objeto.
                Usuario novo = addForm.NovoUsuario;
                listaUsuarios.Add(novo);
                MessageBox.Show($"Novo usuário {novo.NomeUsuario} adicionado!");
                
                // O dashboard permanece aberto e atualizado.
            }
        }
        */
    }
}
