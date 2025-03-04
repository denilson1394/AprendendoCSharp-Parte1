﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Execultando projeto 9: Escopo");

            int idadeJoao = 18;
            bool acompanhado = true;
            string mensagemAdicional;

            if (acompanhado == true)
            {
                mensagemAdicional = "João está acompanhado!";
                Console.WriteLine(mensagemAdicional);
            }
            else
            {
                mensagemAdicional = "João não está acompanhado";
            }


            if (idadeJoao >= 18 || acompanhado == true)
            {
                Console.WriteLine("Pode entrar...");
                Console.WriteLine(mensagemAdicional);
            }
            else
            {
                Console.WriteLine("Não pode entrar");
            }

            // De 1900.0 até 2800.0 o IR é de 7.5% e pode deduzir R$ 142
            // De 2800.01 até 3751.0 o IR é de 15% e pode deduzir R$ 350
            // De 3751.01 até 4664.00 o IR é de 22.5% e pode deduzir R$ 636

            double salario = 3800.0;

            if (salario >= 1900.0 && salario <= 2800.0)
            {
                Console.WriteLine("A sua aliquota é de 7%");
                Console.WriteLine("Você pode deduzir até R$ 142");
            }
            else if (salario >= 2800.01 && salario <= 3751.0)
            {
                Console.WriteLine("A sua aliquota é de 15%");
                Console.WriteLine("Você pode deduzir até R$ 350");
            }
            else if (salario >= 3751.01 && salario <= 4664.0)
            {
                Console.WriteLine("A sua aliquota é de 22.5%");
                Console.WriteLine("Você pode deduzir até R$ 636");
            }


            Console.ReadLine();
        }
    }
}
