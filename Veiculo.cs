using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Smart_Auto
{
    //interface para as classes derivadas de veiculo
    interface ISensor
    {
        void DetectarObstaculos();
    }

    abstract class VeiculoMotorizado
    {
        public abstract string EncherTanque(string tipoCombustivel, double qtdCombustivel);
    }

    //classe base veiculo
    class Veiculo : VeiculoMotorizado
    {
        //para validar o valor da placa
        private string placa;
        public string Placa
        {
            get { return placa; }
            set
            {
                if(this.placa == " ") {
                    placa = $"Introduza Os Dados da Placa";
                }
            }
        }
        public string typeVeiculo { get; set; }
        public string marca { get; set; }

        public string Acelerar()
        {
            return $"O {typeVeiculo}  da Marca {marca} está a Acelerar";
            //caso for fazer a simulação do carro usar:
            //....
            // posicaoCarro++; fazer com a diferença dos kilometros totais com o tempo
        }
        public string Travao(string typeVeiculo, string marca)
        {
            //.....
            //posicaoCarro = 0; pra fazer ele parar ou posicaoCarro --; por x tempo determindado
            return $"O {typeVeiculo}  da Marca {marca} está a Travar";
        }

        //metodo que herda do abstract EncherTanque()
                                    //RadioButtom pra ver o tipo   TxtBox pra quantidade
        public override string EncherTanque(string tipoCombustivel,double qtdCombustivel)
        {
            //gasolina = 1.75€
            //gasoleo = 1.65€
            //precoTotal = precoUnitario * quantidade;
            double precoTotal;
            double precoCombustivel;

            if (tipoCombustivel == "Gasolina")
            {
                tipoCombustivel = "Gasolina";
                precoCombustivel = 1.75;
            }else if(tipoCombustivel == "Gasóleo" || tipoCombustivel == "gasóleo" || tipoCombustivel == "Gasoleo" || tipoCombustivel == "gasoleo")
            {
                precoCombustivel = 1.65;
                tipoCombustivel = "Gasoleo";
            }
            else
            {
                return "Diga um tipo de Combustível Válido";
            }

            precoTotal = precoCombustivel * qtdCombustivel;

            return $"Colocaste {precoTotal} €({qtdCombustivel} litros) de {tipoCombustivel} no teu Veiculo ";
        }
    }
    //classes derivadas
    class Carro : Veiculo, ISensor
    {
        //declaração de variáveis
        
        
        //apenas pra evitar bugs com os valores(vou fazer tds as classes derivadas)
        public Carro()
        {

        }
        public void DetectarObstaculos()
        {

        }
    }
}
