﻿using System;

namespace QuatroOperacoes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração das variáveis
            /*
            Vamos declarar 7 variáveis, sendo 2
            para o usuário inserir dados e as outras
            serão para guardar os resultados
            */
            int numero1, numero2;
            int soma, subtrair, multiplicar, dividir, resto;

            // Pedir ao usuário que entre com o primeiro número
            Console.WriteLine("Digite um número");

            // Vamos pegar o valor que o usuário digitou e colocar na variável número1
            // Utilizamos o comando int.Parse(...) para passar a captura de texto Console.Readline em número. Mesmo sabendo que o usuário
            // irá digitar um número, infelizmente o Readline sempre lê como texto
                numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro número:");
            numero2 = int.Parse(Console.ReadLine());
            
            // Abaixo realizaremos as cincos operações aritméticas
            soma = numero1 + numero2;
            subtrair = numero1 - numero2;
            multiplicar = numero1 * numero2;
            dividir = numero1 / numero2;
            resto = numero1 % numero2;

    }
}
