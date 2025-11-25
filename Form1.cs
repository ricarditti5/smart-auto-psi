using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
 */
namespace Projeto_Smart_Auto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    }
}
