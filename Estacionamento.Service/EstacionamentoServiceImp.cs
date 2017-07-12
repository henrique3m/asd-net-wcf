using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Estacionamento.Negocio;

namespace Estacionamento.Service
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da classe "Service1" no arquivo de código e configuração ao mesmo tempo.
    public class EstacionamentoServiceImp : IEstacionamentoService
    {

        public void Checkin(string placa)
        {
            try
            {
                Operacoes.Checkin(placa);
            }catch (Exception ex)
            {
                throw new FaultException(ex.Message);   
                
            }
        }

        public double Checkout(string placa)
        {
            var resultado = 0.0;
            try
            {
               resultado = Operacoes.Checkout(placa);
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);

            }
            return resultado;
        }

        public int VagasRestantes()
        {
            var resultado = 0;
            try
            {
                resultado = Operacoes.VagasRestantes();
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);

            }
            return resultado;
        }
    }
}
