using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafiosCSharp
    {
        internal class Program
        {
            static void Main(string[] args)
            {
            //---------------------- 1001 - Extremamente Básico -----------------------

            //int A = Int32.Parse(System.Console.ReadLine().Trim());
            //int B = Int32.Parse(System.Console.ReadLine().Trim());
            //
            //int X = A + B;
            //
            //Console.Write("X = {0}\n", X);
            //
            //Console.ReadLine();

            //-------------------- 1002 - Área do Círculo -----------------------------

            //double R = double.Parse(System.Console.ReadLine());
            //double pi = 3.14159;
            //double A = Math.Pow(R, 2) * pi;

            //Console.WriteLine("A="+A.ToString("F4"));

            //-------------------- 1003 - Soma Simples -----------------------------

            //int A = Convert.ToInt32(Console.ReadLine());
            //int B = Convert.ToInt32(Console.ReadLine());

            //int soma = A + B;
            //Console.WriteLine("SOMA = " + soma);
            //Console.ReadKey();

            //-------------------- 1004 - Produto Simples -----------------------------

            //int A = Convert.ToInt32(Console.ReadLine());
            //int B = Convert.ToInt32(Console.ReadLine());

            //int soma = A * B;
            //Console.WriteLine("PROD = " + soma);


            //-------------------- 1005 - Média1 --------------------------------------

            //double a, b, media;

            //a = Convert.ToDouble(Console.ReadLine());
            //b = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("MEDIA = " + ((a * 3.5 + b * 7.5) / (3.5 + 7.5)).ToString("0.00000"));

            //-------------------- 1006 - Média2 --------------------------------------

            //double a, b, c;

            //a = Convert.ToDouble(Console.ReadLine());
            //b = Convert.ToDouble(Console.ReadLine());
            //c = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("MEDIA = " + (((a * 2 + b * 3 + c * 5) / (2 + 3 + 5))/ 10).ToString("0.0"));

            //-------------------- 1007 - Diferença --------------------------------------

            //int A = Convert.ToInt32(Console.ReadLine());
            //int B = Convert.ToInt32(Console.ReadLine());
            //int C = Convert.ToInt32(Console.ReadLine());
            //int D = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("DIFERENCA = " + (A * B - C * D));

            //-------------------- 1008 - Salário --------------------------------------

            //double numFun = Convert.ToDouble(Console.ReadLine());
            //double numHorasTrab = Convert.ToDouble(Console.ReadLine());
            //double valorPorHoras = Convert.ToDouble(Console.ReadLine());

            //double salary = numHorasTrab * valorPorHoras; 

            //Console.WriteLine("NUMBER = " + numFun);
            //Console.WriteLine("SALARY = U$ " + salary.ToString("0.00"));

            //-------------------- 1009 - Salário com Bônus --------------------------------------

            //string nomeVendedor = Console.ReadLine();
            //double salarioFixo = Convert.ToDouble(Console.ReadLine());
            //double totalVendasMes = Convert.ToDouble(Console.ReadLine());
            //double total = salarioFixo + (totalVendasMes * 0.15);



            //Console.WriteLine($"TOTAL = R$ {total.ToString("0.00")}");

            //-------------------- 1010 - Cálculo Simples --------------------------------------

            //var item1 = Console.ReadLine().Split(' ');
            //var item2 = Console.ReadLine().Split(' ');

            //var itemPreço = (int.Parse(item1[1]) * double.Parse(item1[2])) + (int.Parse(item2[1]) * double.Parse(item2[2]));

            //Console.WriteLine("VALOR A PAGAR: R$ " +itemPreço.ToString("F2"));

            //-------------------- 1011 - Esfera --------------------------------------

            //double R = Convert.ToDouble(Console.ReadLine());
            //var pi = 3.14159;

            //var calculoVolume = (4.0 / 3) * pi * Math.Pow( R, 3);

            //Console.WriteLine($"VOLUME = {calculoVolume.ToString("0.000")}");


            //-------------------- 1012 - Área --------------------------------------

            //var item = Console.ReadLine().Split(' ');
            //Console.WriteLine($"TRIANGULO: {(double.Parse(item[0]) * double.Parse(item[2]) / 2).ToString("F3")}");
            //Console.WriteLine($"CIRCULO: {(Math.Pow(double.Parse(item[2]), 2) * 3.14159).ToString("F3")}");
            //Console.WriteLine($"TRAPEZIO: {((((double.Parse(item[0]) + double.Parse(item[1])) * double.Parse(item[2])) / 2)).ToString("F3")}");
            //Console.WriteLine($"QUADRADO: {( Math.Pow(double.Parse(item[1]), 2)).ToString("F3")}");
            //Console.WriteLine($"RETANGULO: {( double.Parse(item[0]) * double.Parse(item[1])).ToString("F3")}");

            //-------------------- 1013 - O Maior --------------------------------------

            //var item = Console.ReadLine().Split(' ');
            //int A = int.Parse(item[0]);
            //int B = int.Parse(item[1]);
            //int C = int.Parse(item[2]);
            //int maior = ((A + B + Math.Abs(A - B)) / 2);
            //int resultado = ((maior + C + Math.Abs(maior - C)) / 2);

            //Console.WriteLine($"{resultado} eh o maior");

            //-------------------- 1014 - Consumo --------------------------------------

            //var km = Convert.ToInt32(Console.ReadLine());
            //float l = float.Parse(Console.ReadLine());

            //var consumo = km / l;  

            //Console.WriteLine($"{consumo.ToString("F3")} km/l");

            //-------------------- 1015 - Distância Entre Dois Pontos --------------------------------------

            //var p1 = Console.ReadLine().Split(' ');
            //var p2 = Console.ReadLine().Split(' ');
            //var A = float.Parse(p1[0]);
            //var B = float.Parse(p1[1]);
            //var C = float.Parse(p2[0]);
            //var D = float.Parse(p2[1]);
            //var resultado = Math.Sqrt((C - A)*(C - A) + (D - B)* (D - B));
            //Console.WriteLine($"{resultado.ToString("F4")}");

            //-------------------- 1016 - Distância --------------------------------------

            //var Y = Convert.ToInt32(Console.ReadLine());

            //var distancia = Y * 2;

            //Console.WriteLine($"{distancia} minutos");

            //-------------------- 1017 - Gasto de Combustível --------------------------------------

            //var tempoViagem = double.Parse(Console.ReadLine());
            //var velocidadeMedia = double.Parse(Console.ReadLine());

            //double quatidadeLitros = tempoViagem * velocidadeMedia / 12;

            //Console.WriteLine($"{quatidadeLitros.ToString("0.000")}");

            //-------------------- 1018 - Cédulas --------------------------------------

            //int valor = int.Parse(Console.ReadLine());
            //Console.WriteLine(valor);

            //var valor100 = valor / 100;
            //valor = valor % 100;

            //var valor50 = valor / 50;
            //valor = valor % 50;

            //var valor20 = valor / 20;
            //valor = valor % 20;

            //var valor10 = valor / 10;
            //valor = valor % 50;

            //var valor5 = valor / 5;
            //valor = valor % 5;

            //var valor2 = valor / 2;
            //valor = valor % 2;

            //var valor1 = valor / 1;
            //valor = valor % 1;

            //Console.WriteLine("{0} nota(s) de R$ 100,00", valor100);
            //Console.WriteLine("{0} nota(s) de R$ 50,00", valor50);
            //Console.WriteLine("{0} nota(s) de R$ 20,00", valor20);
            //Console.WriteLine("{0} nota(s) de R$ 10,00", valor10);
            //Console.WriteLine("{0} nota(s) de R$ 5,00", valor5);
            //Console.WriteLine("{0} nota(s) de R$ 2,00", valor2);
            //Console.WriteLine("{0} nota(s) de R$ 1,00", valor1);

            //-------------------- 1019 - Conversão de tempo --------------------------------------

            //var segundos = int.Parse(Console.ReadLine());
            //var hora = (segundos / (60 * 60));
            //var minuto = ((segundos - (hora * 60 * 60)) / 60);
            //var segundo = (segundos - (hora * 60 * 60) - (minuto * 60));
            //Console.WriteLine($"{hora}:{minuto}:{segundo}");

            //-------------------- 1020 - Idade em Dias --------------------------------------

            //var dias = int.Parse(Console.ReadLine());
            //int ano = dias / 365;
            //int mes = (dias % 365) / 30;
            //int dia = (dias % 365) % 30;
            //Console.WriteLine($"{ano} ano(s)");
            //Console.WriteLine($"{mes} mes(es)");
            //Console.WriteLine($"{dia} dia(s)");

            //-------------------- 1021 - Notas e moedas --------------------------------------

            //float valor = float.Parse(Console.ReadLine());

            //var valor100 = valor / 100;
            //valor = valor % 100;

            //var valor50 = valor / 50;
            //valor = valor % 50;

            //var valor20 = valor / 20;
            //valor = valor % 20;

            //var valor10 = valor / 10;
            //valor = valor % 50;

            //var valor5 = valor / 5;
            //valor = valor % 5;

            //var valor2 = valor / 2;
            //valor = valor % 2;

            //var valor1 = valor / 1;
            //valor = valor % 1;

            //var valor050 = valor / 0.50;
            //valor = valor % 1;

            //var valor025 = valor / 0.25;
            //valor = valor % 1;

            //var valor010 = valor / 0.10;
            //valor = valor % 1;

            //var valor005 = valor / 0.05;
            //valor = valor % 1;

            //var valor001 = valor / 0.01;
            //Convert.ToInt16(valor = valor % 1);

            //Console.WriteLine("{0} nota(s) de R$ 100,00", valor100);
            //Console.WriteLine("{0} nota(s) de R$ 50,00", valor50);
            //Console.WriteLine("{0} nota(s) de R$ 20,00", valor20);
            //Console.WriteLine("{0} nota(s) de R$ 10,00", valor10);
            //Console.WriteLine("{0} nota(s) de R$ 5,00", valor5);
            //Console.WriteLine("{0} nota(s) de R$ 2,00", valor2);
            //Console.WriteLine("{0} moeda(s) de R$ 1,00", valor1);
            //Console.WriteLine("{0} moeda(s) de R$ 0,50", valor050);
            //Console.WriteLine("{0} moeda(s) de R$ 0,25", valor025);
            //Console.WriteLine("{0} moeda(s) de R$ 0,10", valor010);
            //Console.WriteLine("{0} moeda(s) de R$ 0,05", valor005);
            //Console.WriteLine("{0} moeda(s) de R$ 0,01", valor001);

            //-------------------- 1035 - Seleção 1 --------------------------------------
            //string[] texto = Console.ReadLine().Split(' ');
            //int A = int.Parse(texto[0]),
            //    B = int.Parse(texto[1]),
            //    C = int.Parse(texto[2]),
            //    D = int.Parse(texto[3]);

            //if ((B > C) 
            //    && (D > A) 
            //    && (C + D) > (A + B )
            //    && (A > 0 && B > 0 && C > 0 && D > 0 )
            //    && (A % 2 == 0)) 
            //{ 
            //    Console.WriteLine("Valores aceitos"); 
            //}
            //else
            //{
            //    Console.WriteLine("Valores nao aceitos");
            //}

            //-------------------- 1035 - Seleção 1 --------------------------------------

            //string[] texto = Console.ReadLine().Split(' ');
            //double A = double.Parse(texto[0]),
            //      B = double.Parse(texto[1]),
            //      C = double.Parse(texto[2]);

            //double delta = Math.Pow(B, 2) - (4 * A * C);

            //if(delta >= 0 && A != 0 )
            //{
            //    double R1 = (-B + Math.Sqrt(delta)) / (2 * A);
            //    double R2 = (-B - Math.Sqrt(delta)) / (2 * A);
            //    Console.WriteLine($"R1 = {R1.ToString("N5")}\nR2 = {R2.ToString("N5")}");
            //}
            //else 
            //{
            //    Console.WriteLine("Impossivel calcular");
            //}

            //-------------------- 1037 - Intervalo --------------------------------------

            //var valor = float.Parse(Console.ReadLine());


            //if(valor >= 0.00 && valor <= 25.00)
            //{
            //    Console.WriteLine("Intervalo [0,25]");
            //}
            //else if (valor > 25.00 && valor <= 50.00)
            //{ 
            //    Console.WriteLine("Intervalo (25,50]"); 
            //}
            //else if  (valor > 50.00 && valor <= 75.00)
            //{
            //    Console.WriteLine("Intervalo (50,75]");
            //}           
            //else if  (valor > 75.00 && valor <= 100.00)
            //{
            //    Console.WriteLine("Intervalo (75,100]");
            //}
            //else
            //{
            //    Console.WriteLine("Fora de intervalo");
            //}

            //-------------------- 1038 - Lanche --------------------------------------


            //string[] num = Console.ReadLine().Split(' ');
            //int codigo = int.Parse(num[0]),
            //    qntItem = int.Parse(num[1]);
            //double preco = 0 ;
            //if (codigo == 1)
            //    preco = 4;
            //else if (codigo == 2)
            //    preco = 4.5;
            //else if (codigo == 3)
            //    preco = 5;
            //else if (codigo == 4)
            //    preco = 2;
            //else if (codigo == 5)
            //    preco = 1.5;


            //double total = preco * qntItem;

            //Console.WriteLine($"Total: R$ {total.ToString("N2")}");

            //-------------------- 1040 - Média 3 --------------------------------------

            //string[] nota = Console.ReadLine().Split(' ');
            //double N1 = double.Parse(nota[0]),
            //       N2 = double.Parse(nota[1]),
            //       N3 = double.Parse(nota[2]),
            //       N4 = double.Parse(nota[3]);


            //double media = (((N1 * 2) + (N2 * 3) + (N3 * 4) + N4) / 10);
            //media = Math.Truncate(10 * media) / 10;
            //Console.WriteLine($"Media: {media.ToString("N1")}");

            //if (media >= 7.0)
            //{
            //    Console.WriteLine("Aluno aprovado.");
            //}
            //else if (media >= 5.0 && media <= 6.9)
            //{
            //    Console.WriteLine("Aluno em exame.");
            //    var notaExame = float.Parse(Console.ReadLine());
            //    Console.WriteLine($"Nota do exame: {notaExame.ToString("N1")}");
            //    double mediaFinal = (notaExame + media) / 2;
            //    if (mediaFinal >= 5.0)
            //    {
            //        Console.WriteLine("Aluno aprovado.");
            //        Console.WriteLine($"Media final: {mediaFinal.ToString("N1")}");
            //    }
            //    else 
            //    {
            //        Console.WriteLine("Aluno reprovado.");
            //        Console.WriteLine($"Media final: {mediaFinal.ToString("N1")}");
            //    }
            //}
            //else if (media < 5.0)
            //{
            //    Console.WriteLine("Aluno reprovado.");
            //}

            //-------------------- 1041 - Coordenadas de um ponto --------------------------------------

            //string[] input = Console.ReadLine().Split(' ');
            //float X = float.Parse(input[0]),
            //      Y = float.Parse(input[1]);
            //if (X > 0 && Y > 0) { Console.WriteLine("Q1"); }
            //if (X < 0 && Y > 0) { Console.WriteLine("Q2"); }
            //if (X < 0 && Y < 0) { Console.WriteLine("Q3"); }
            //if (X > 0 && Y < 0) { Console.WriteLine("Q4"); }
            //if (X == 0 && Y == 0) { Console.WriteLine("Origem"); }
            //if (X == 0 && Y != 0) { Console.WriteLine("Eixo Y"); }
            //if (X != 0 && Y == 0) { Console.WriteLine("Eixo X"); }

            //-------------------- 1042 - Cort Simples --------------------------------------


            //string[] input = Console.ReadLine().Split(' ');
            //int num1 = int.Parse(input[0]), num2 = int.Parse(input[1]), num3 = int.Parse(input[2]);

            //if (num1 < num2 && num1 < num3 && num2 < num3)
            //{
            //    Console.WriteLine(num1); Console.WriteLine(num2); Console.WriteLine(num3);
            //}
            //else if (num1 < num2 && num1 < num3 && num2 > num3)
            //{
            //    Console.WriteLine(num1); Console.WriteLine(num3); Console.WriteLine(num2);
            //}
            //else if (num1 > num2 && num2 < num3 && num1 < num3)
            //{   
            //    Console.WriteLine(num2); Console.WriteLine(num1); Console.WriteLine(num3);
            //}
            //else if (num1 > num2 && num2 < num3 && num1 > num3)
            //{
            //    Console.WriteLine(num2); Console.WriteLine(num3); Console.WriteLine(num1);
            //}
            //else if (num1 < num2 && num2 > num3 && num1 > num3)
            //{
            //    Console.WriteLine(num3); Console.WriteLine(num1); Console.WriteLine(num2);
            //}
            //else if (num1 > num2 && num2 > num3 && num1 > num3)
            //{
            //    Console.WriteLine(num3); Console.WriteLine(num2); Console.WriteLine(num1);
            //}  

            //Console.WriteLine("");Console.WriteLine(num1); Console.WriteLine(num2); Console.WriteLine(num3);

            //-------------------- 1042 - Sort Simples --------------------------------------


            //string[] input = Console.ReadLine().Split(' ');
            //float num1 = float.Parse(input[0]),
            //      num2 = float.Parse(input[1]),
            //      num3 = float.Parse(input[2]);

            //if (num1 + num2 > num3 && num3 + num2 > num1 && num1 + num3 > num2)
            //{
            //    float perimetro = num1 + num2 + num3;
            //    Console.WriteLine($"Perimetro = {perimetro.ToString("N1")}");
            //}
            //else
            //{
            //    float area = ((num1 + num2) * num3) / 2;
            //    Console.WriteLine($"Area = {area.ToString("N1")}");
            //}

            //-------------------- 1044 - Múltiplos --------------------------------------

            string[] input = Console.ReadLine().Split(' ');
            int num1 = int.Parse(input[0]),
                  num2 = int.Parse(input[1]);
            
            
            if (num2 % num1 == 0 || num1 % num2 == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }



            Console.ReadLine();
            }
        }
    }



