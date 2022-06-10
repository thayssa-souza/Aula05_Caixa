using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace letscode_Aula05
{
    class caixaDoPetshop
    {
        public static void Main(string[] args)
        {
        Caixa caixaDoDia = new Caixa();
        caixaDoDia.AbrirCaixa(); //entao primeiro abrimos o caixa no mercado

        Console.WriteLine($"Caixa aberto em: {caixaDoDia.DataCaixa} ");
        Console.WriteLine($"Saldo do caixa: R${caixaDoDia.Saldo}");

        caixaDoDia.Deposita(10M);
        Console.WriteLine($"Saldo do caixa: R${caixaDoDia.Saldo}");

        caixaDoDia.Deposita(50M);
        Console.WriteLine($"Saldo do caixa: R${caixaDoDia.Saldo}");

        caixaDoDia.Saque(20);
        Console.WriteLine($"Saldo do caixa: R${caixaDoDia.Saldo}");

        caixaDoDia.Saque(70M);
        Console.WriteLine($"Saldo do caixa: R${caixaDoDia.Saldo}");

        caixaDoDia.CalcularTroco();
        Console.WriteLine(caixaDoDia.CalcularTroco);
        Console.WriteLine("-----------------------------");
        caixaDoDia.DevolverTroco();
        Console.WriteLine($"Saldo do caixa: R${caixaDoDia.DevolverTroco}");
    }
}
}
