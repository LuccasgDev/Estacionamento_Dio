using System;
using System.Collections.Generic;

namespace Projeto_Estacionamento.Models
{
    public class Estacionamento
    {
        private List<string> C_Placas = new List<string>();

        public void CadastrarVeiculo(string placa) 
        {
            C_Placas.Add(placa);
            Console.WriteLine($"A placa {placa} foi cadastrada com sucesso!!");
        }

        public void RemoverVeiculo(string placa)
        {
            if (C_Placas.Remove(placa))
            {
                Console.WriteLine($"A placa {placa} foi removida com sucesso!!");
            }
            else
            {
                Console.WriteLine($"A placa {placa} não foi encontrada.");
            }
        }

        public void ListarVeiculos()
        {
            if (C_Placas.Count == 0)
            {
                Console.WriteLine("Nenhum veículo cadastrado.");
            }
            else
            {
                foreach (var placa in C_Placas)
                {
                    Console.WriteLine(placa);
                }
            }
        }
    }
}
