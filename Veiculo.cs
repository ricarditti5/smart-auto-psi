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
        public abstract void EncherTanque();
    }

    //classe base veiculo
    class Veiculo
    {
        public string placa { get; set; }
        public string Acelerar(string carName)
        {
            return $"O Carro {carName} está a Acelerar";
            //caso for fazer a simulação do carro usar:
            //....
            // posicaoCarro++; fazer com a diferença dos kilometros totais com o tempo
        }
        public string Travao(string carName)
        {
            //.....
            //posicaoCarro = 0; pra fazer ele parar ou posicaoCarro --; por x tempo determindado
            return $"O Carro {carName} está a Acelerar";
        }
    }
}
