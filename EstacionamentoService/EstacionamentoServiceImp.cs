using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Estacionamento.Negocio;

namespace EstacionamentoService
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da classe "Service1" no arquivo de código e configuração ao mesmo tempo.
    public class EstacionamentoServiceImp : IEstacionamentoService
    {

        public void Checkin(string placa)
        {
            Operacoes.Checkin(placa);
        }

        public double Checkout(string placa)
        {
            return Operacoes.Checkout(placa);
        }

        public int VagasRestantes()
        {
            return Operacoes.VagasRestantes();
        }
    }
}
