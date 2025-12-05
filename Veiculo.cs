using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Smart_Auto
{
        interface ISensor
        {
            string DetectarObstaculos();
        }

        abstract class VeiculoMotorizado
        {
            public abstract string EncherTanque(string tipoCombustivel, double qtdCombustivel);
        }

        //classe base veiculo
        class Veiculo1 : VeiculoMotorizado
        {
            //para validar o valor da placa
            private string placa;
            public string Placa
            {
                get { return placa; }
                set
                {
                    if (this.placa == " ")
                    {
                        placa = $"Introduza Os Dados da Placa";
                    }
                    else
                    {
                        placa = value;
                    }
                }
            }
            public string typeVeiculo { get; set; }
            public string marca { get; set; }
            public string cor { get; set; }
            public string modelo { get; set; }

            public Veiculo1(string placa, string marca, string cor, string modelo)
            {
                this.placa = placa;
                this.marca = marca;
                this.cor = cor;
                this.modelo = modelo;

            }

            public string Acelerar()
            {
                return $"O {typeVeiculo}  da Marca {marca} está a Acelerar";
                //caso for fazer a simulação do carro usar:
                //....
                // posicaoCarro++; fazer com a diferença dos kilometros totais com o tempo
            }
            public string Travar(string typeVeiculo, string marca)
            {
                //.....
                //posicaoCarro = 0; pra fazer ele parar ou posicaoCarro --; por x tempo determindado
                return $"O {typeVeiculo}  da Marca {marca} está a Travar";
            }

            //metodo que herda do abstract EncherTanque()
            //RadioButtom pra ver o tipo   TxtBox pra quantidade
            public override string EncherTanque(string tipoCombustivel, double precoTotal)
            {
                //gasolina = 1.75€
                //gasoleo = 1.65€
                //precoTotal = precoUnitario * quantidade;
                double qtdCombustivel;
                double precoCombustivel;

                if (tipoCombustivel == "Gasolina" || tipoCombustivel == "gasolina")
                {
                    tipoCombustivel = "Gasolina";
                    precoCombustivel = 1.75;
                }
                else if (tipoCombustivel == "Gasóleo" || tipoCombustivel == "gasóleo" || tipoCombustivel == "Gasoleo" || tipoCombustivel == "gasoleo")
                {
                    precoCombustivel = 1.65;
                    tipoCombustivel = "Gasoleo";
                }
                else
                {
                    return "Diga um tipo de Combustível Válido";
                }

            qtdCombustivel = precoTotal / precoCombustivel;

                return $"Colocaste {precoTotal} €({qtdCombustivel} litros) de {tipoCombustivel} no teu Veiculo ";
            }
        }
        //
        //
        //classes derivadas
       class Carro : Veiculo1, ISensor
        {
            //declaração de variáveis
            private double potenciaCV;

        public double PotenciaCV
            {
                get { return potenciaCV; }
                set { potenciaCV = value; }
            }

        //apenas pra evitar bugs com os valores(vou fazer tds as classes derivadas)

        public Carro(double potenciaCV, string placa, string marca, string cor, string modelo) : base(placa, marca, cor, modelo)
        {
            this.potenciaCV = potenciaCV;
        }


        //possivel chamar metodos Acelerar() e Travar()
        public string DetectarObstaculos()
            {
                return $"Cuidado com o obstaculo";
            }
        }

        class Mota : Veiculo1
        {
            //posivel chamar o encherTanque e usar a variavel placa

            //declaração de variáveis
            private double potenciaCV;
            public double PotenciaCV
            {
                get { return potenciaCV; }
                set { potenciaCV = value; }
            }

            //apenas pra evitar bugs com os valores(vou fazer tds as classes derivadas)
            public Mota(double potenciaCV, string placa, string marca, string cor, string modelo) : base(placa, marca, cor, modelo)
            {
                this.potenciaCV = potenciaCV;
            }

            //possivel chamar metodos Acelerar() e Travar()
        }

        class Camioneta : Veiculo1, ISensor
        {
            //posivel chamar o encherTanque e usar a variavel placa

            //declaração de variáveis
            private double potenciaCV;
            public double PotenciaCV
            {
                get { return potenciaCV; }
                set { potenciaCV = value; }
            }

            //apenas pra evitar bugs com os valores(vou fazer tds as classes derivadas)
            public Camioneta(double potenciaCV, string placa, string marca, string cor, string modelo) : base(placa, marca, cor, modelo)
            {
                this.potenciaCV = potenciaCV;
            }
            public string DetectarObstaculos()
            {
                return $"Cuidado com o obstaculo";
            }
            //possivel chamar metodos Acelerar() e Travar()
        }
}