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
        Carro c1;
        Mota m1;
        Camioneta cam1;
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
        private void timer1_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("Em processo de criação");
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void btnCriar_Click(object sender, EventArgs e)
        {
            if(rdCarro.Checked == true)
            {
                c1 = new Carro(
                    double.Parse(txtPotencia.Text),
                    txtPlaca.Text,
                    txtMarca.Text,
                    txtCor.Text,
                    txtModelo.Text);
                MessageBox.Show($"O Carro da cor {txtCor} Modelo {txtModelo} com a Placa: {txtPlaca} foi criado");
            }
            else if(rdMota.Checked == true)
            {
                    m1 = new Mota(
                        double.Parse(txtPotencia.Text),
                        txtPlaca.Text,
                        txtMarca.Text,
                        txtCor.Text,
                        txtModelo.Text);
                    MessageBox.Show($"A Mota da cor {txtCor} Modelo {txtModelo} com a Placa: {txtPlaca} foi criado");
            }
            else if (rdCamioneta.Checked == true)
            {

                cam1 = new Camioneta(
                    double.Parse(txtPotencia.Text),
                    txtPlaca.Text,
                    txtMarca.Text,
                    txtCor.Text,
                    txtModelo.Text);
                MessageBox.Show($"A Camioneta da cor {txtCor} Modelo {txtModelo} com a Placa: {txtPlaca} foi criado");
                //mostrar a imagem da camioneta no espaço
            }
        }
    }
}
