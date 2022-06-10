using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace letscode_Aula05
{
        public class Caixa
        {
            public DateTime DataCaixa { get; private set; }
            public decimal Saldo { get; private set; }
            public void AbrirCaixa(decimal saldoInicial = 0) //o decimal valor indica o caixa inicial
            {
                DataCaixa = DateTime.Now;
                Saldo = saldoInicial;
            }
            public void Deposita(decimal valor)
            {
                Saldo += valor; //soma com o valor já existente
            }

            public void Saque(decimal valor)
            {
                if (Saldo >= valor)
                    Saldo -= valor;
                else
                {
                    Console.WriteLine("Saldo insuficiente");
                    Console.WriteLine($"O saldo atual é R${Saldo}");
                }
                //CalcularTroco - passando o valor da venda e o valor dado pelo cliente
            }
            public decimal CalcularTroco()
            {
                decimal troco = 0M;
                Console.WriteLine("Valor do produto: ");
                decimal valorProduto = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Dinheiro na carteira: ");
                decimal dinheiroCliente = decimal.Parse(Console.ReadLine());

                if (valorProduto <= dinheiroCliente)
                {
                    troco = dinheiroCliente - valorProduto;
                    Console.WriteLine($"Troco da compra: R${troco}");
                    return troco;
                }
                else
                {
                    Console.WriteLine("Dinheiro insuficiente, não foi possível realizar a compra.");
                    return 0;
                }
            }

            //DevolverTroco - passando o valor da venda e o valor dado pelo cliente,
            //mas que o método ja deposito o valor e saque o troco
            public decimal DevolverTroco()
            {
                decimal troco = 0M;
                Console.WriteLine($"Saldo do caixa: R$ {Saldo}");
                Console.WriteLine("Próximo cliente.");
                Console.WriteLine("Valor do produto: ");
                decimal valorProduto = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Valor recebido do cliente: ");
                decimal pagamentoCliente = decimal.Parse(Console.ReadLine());

                if (valorProduto <= pagamentoCliente)
                {
                    troco = pagamentoCliente - valorProduto;
                    Console.WriteLine($"Troco da compra: R${troco}");
                    decimal depositoCaixa = Saldo + valorProduto;
                    decimal saldoAtual = Saldo - troco;
                    Console.WriteLine($"Saldo do caixa: R${saldoAtual}");
                    return saldoAtual;
                }
                else
                {
                    Console.WriteLine("Pagamento insuficiente, não foi possível realizar a compra.");
                    return 0;
                }
            }
        }
}
