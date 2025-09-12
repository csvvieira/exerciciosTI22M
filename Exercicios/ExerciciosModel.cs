using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class ExerciciosModel
    {
        //Área de variáveis
        private double area;
        private double IMC;
        private double lado;
        private int hora;
        private double porcentagem;
        private double km;
        private int potencia;
        private double tempo;
        private double consumo;
        public int fatorial;
        public int segundo;
        public int[] num;//Estrutura de dados finita
        public string[] nome;
        public double []vet;
        public int[] pares;
        public int[] impares;

        //Método Construtor 
        public ExerciciosModel()
        {
            this.area = 0;
            this.IMC = 0;
            this.lado = 0;
            this.hora = 0;
            this.porcentagem = 0;
            this.km = 0;
            this.potencia = 0;
            this.tempo = 0;
            this.consumo = 0;
            this.segundo = 0;
            this.num = new int[10];//De 0 até 9
            this.nome = new string[10];
            this.vet = new double[10];
            this.pares = new int[10];
            this.impares = new int[10];
        }//Fim do Construtor

        //Método GET e SET
        public double ModificarArea
        {
            get { return this.area; }
            set { this.area = value; }
        }//Fim do GET e SET

        public double ModificarIMC
        {
            get { return this.IMC; }
            set { this.IMC = value; }
        }//Fim do GET e SET

        public double ModificarLado
        {
            get { return this.lado; }
            set { this.lado = value; }
        }//Fim do GET e SET
        
        public int ModificarHora
        {
            get { return this.hora; }
            set { this.hora = value; }
        }//Fim do GET e SET

        public double ModificarPorcentagem
        {
            get { return this.porcentagem; }
            set { this.porcentagem = value; }
        }//Fim do GET e SET

        public double ModificarKm
        {
            get { return this.km; }
            set { this.km = value; }
        }//Fim do GET e SET

        public int ModificarPotencia
        {
            get { return this.potencia;}
            set { this.potencia = value;}
        }//Fim do GET e SET

        public double ModificarTempo
        {
            get { return this.tempo; }
            set { this.tempo = value; }
        }//Fim do GET e SET

        public double ModificarConsumo
        {
            get { return this.consumo; }
            set { this.consumo = value; }
        }//Fim do GET e SET

        public int ModificarFatorial
        {
            get { return this.fatorial; }
            set { this.fatorial = value;}
        }//Fim do GET e SET

        public int ModificarSegundo
        {
            get { return this.segundo; }
            set { this.segundo = value; }
        }//Fim do GET e SET

        //1. Leia um número e exiba o seu triplo
        public int Triplo(int num)
        {
            return num * 3;
        }//Fim do Método

        //2. Leia um número e exiba sua metade
        public int Metade(int num)
        {
            return num / 2;
        }//Fim do Método

        //3. Converta um valor de dólares para reais com uma taxa fixa
        public double ConverterReais(double dolares)
        {
            return dolares * 5.40;
        }//Fim do Método

        //4. Calcule o perímetro de um quadrado com base no lado
        public double PerimetroQuadrado(double lado)
        {
            if (lado > 0)
            {
                ModificarLado = lado * 4;
            }
            else
            {
                ModificarLado = -1;
            }
            return ModificarLado;
        }//Fim do Método

        //5.Converta o valor em horas para minutos
        public int HoraMinuto(int hora)
        {
            if (hora > 0)
            {
                ModificarHora = hora * 60;
            }
            else
            {
                ModificarHora = -1;
            }
            return ModificarHora;
        }//Fim do método

        //6.Leia um valor e exiba 10% dele
        public double PorcentagemDez(double porcentagem)
        {
            if(porcentagem > 0)
            {
                ModificarPorcentagem = porcentagem * 0.1;
            }
            else
            {
                ModificarPorcentagem = -1;
            }
            return ModificarPorcentagem;
        }//Fim do método

        //7.Leia um valor e exiba 25% dele
        public double PorcentagemVinteCinco(double porcentagem)
        {
            if(porcentagem > 0)
            {
                ModificarPorcentagem = porcentagem * 0.25;
            }
            else
            {
                ModificarPorcentagem= -1;
            }
            return ModificarPorcentagem;
        }//Fim do método

        //8.Calcule a área de um losango com base nas diagonais
        //Área = (diagonalMaior * diagonalMenor) / 2
        public double AreaLosango(double diagonalMaior, double diagonalMenor)
        {
            //Validação
            if(diagonalMaior > 0 && diagonalMenor > 0)
            {
                ModificarArea = (diagonalMaior * diagonalMenor) / 2;
            }
            else
            {
                ModificarArea = -1;//Criando um alerta com um símbolo
            }//Fim do if/else
            return ModificarArea;
        }//Fim do Método

        //9. Calcule o volume de um cilindro com base no raio e na altura
        //Volume = pi * raio² * altura
        public double VolumeCilindro(double raio, double altura)
        { 
            if(raio > 0 && altura > 0)
            {
                return Math.PI * Math.Pow(raio, 2) * altura;
            }
            else
            {
                return -1;
            }//Fim do if/else
        }//Fim do Método

        //10.Leia um número e exiba seu valor absoluto
        public int ValorAbsoluto(int num)
        {
            if (num < 0)
            {
                return num * -1;
            }
            else
            {
                return num;
            }
        }//Fim do método

        //11.Converta um valor de quilômetros para metros
        public double QuilometrosMetros(double km)
        {
            if(km > 0)
            {
                ModificarKm = km * 1000;
            }
            else
            {
                ModificarKm = -1;
            }
            return ModificarKm;
        }//Fim do método

        //12.Leia um número e exiba a sua quinta potência
        public int QuintaPotencia(int num)
        {
            if (num > 0)
            {
                ModificarPotencia = (int)Math.Pow(num, 5);
            }
            else
            {
                ModificarPotencia = -1;
            }
            return ModificarPotencia;
        }//Fim do método

        //13.Calcule o tempo de uma viagem com base na distância e velocidade
        public double TempoViagem(double distancia, double velocidade)
        {
            if (distancia > 0 && velocidade > 0)
            {
                ModificarTempo = distancia / velocidade * 60;
            }
            else
            {
                ModificarTempo = -1;
            }
            return ModificarTempo;
        }//Fim do método

        //14. Calcule o consumo médio de combustível com base em km e litros
        public double ConsumoMedio(double km, double litros)
        {
            if(km > 0 && litros > 0)
            {
                ModificarConsumo = km / litros;
            }
            else
            {
                ModificarConsumo = -1;
            }
            return ModificarConsumo;
        }//Fim do método

        //15. Leia o número 5 e calcule seu fatorial
        public double FatorialCinco(int num)
        {
            if (num == 5)
            {
                num *= (5 - 1);
                num *= 3;
                num *= (3 - 1);
                num *= 1;
                ModificarFatorial = num;
            }
            else
            {
                ModificarFatorial = -1;
            }
            return ModificarFatorial;
        }//Fim do método

        //16. Leia a altura e o pseo de uma pessoa e calcule o IMC
        //Se IMC < 18.5 - Abaixo do Peso
        //Se IMC >= 18.5 e IMC < 24.9 - Peso Normal
        //Se IMC >= 24.9 e IMC < 29.9 - Sobrepeso
        //Se IMC >= 29.9 e IMC < 34.4 - Obesidade Grau I
        //Se IMC >= 34.4 e IMC < 39.9 - Obesidade Grau II
        //Se IMC >= 39.9 - Obesidade Grau III
        //Devolva o grau
        public string CalcularIMC(double peso, double altura)
        {
            string resultado = "";//Declaração local
            if (peso > 0 && altura > 0)
            {
                ModificarIMC = peso / Math.Pow(altura, 2);
                resultado = "\nSeu IMC é: " + ModificarIMC;
                if (ModificarIMC < 18.5) 
                {
                    resultado += " - Abaixo do Peso";
                }
                else if(ModificarIMC < 24.9)
                {
                    resultado += " - Peso Normal";
                }
                else if(ModificarIMC < 29.9)
                {
                    resultado += " - Sobrepeso";
                }
                else if(ModificarIMC < 34.9)
                {
                    resultado += " - Obesidade Grau I";
                }
                else if(ModificarIMC < 39.9)
                {
                    resultado += " - Obesidade Grau II";
                }
                else
                {
                    resultado += " - Obesidade Grau III";
                }//Fim do if/else resultado
            }
            else
            {
                resultado = "Impossível calcular IMC com peso e/ou altura negativos!";
            }//Fim do if/else validação
            return resultado;
        }//Fim do Método

        //17.Calcule o salário anual com base no salário mensal
        public double SalarioAnual(double salario)
        {
            if (salario > 0)
            {
                return salario * 12;
            }
            else
            {
                return -1;
            }
        }//Fim do método

        //18.Leia um número e exiba seu logaritmo natural
        public double LogaritmoNatural(double num1)
        {
            if (num1 > 0)
            {
                return Math.Log(num1);
            }
            else
            {
                return -1;
            }
        }//Fim do método

        //19.Leia um número e exiba seu seno
        public double Seno(double catetoOposto, double hipotenusa)
        {
            if (catetoOposto > 0 && hipotenusa > 0 && catetoOposto < hipotenusa)
            {
                return catetoOposto / hipotenusa;
            }
            else
            {
                return -1;
            }
        }//Fim do método

        //20.Leia um número e exiba seu cosseno
        public double Cosseno(double catetoAdjacente, double hipotenusa)
        {
            if (catetoAdjacente > 0 && hipotenusa > 0 && catetoAdjacente < hipotenusa)
            {
                return catetoAdjacente / hipotenusa;
            }
            else
            {
                return -1;
            }
        }//Fim do método
        
        //21.Calcule a área de um trapézio com base na base maior, base menor e altura
        public double AreaTrapezio(double baseMaior, double baseMenor, double altura)
        {
            if (baseMaior > 0 && baseMenor > 0 && altura > 0 && baseMenor < baseMaior)
            {
                return (baseMaior + baseMenor) * altura / 2;
            }
            else
            {
                return -1;
            }
        }//Fim do método

        //22.Converta um valor de dias para segundos
        public int DiasSegundos(int dias)
        {
            if (dias > 0)
            {
                dias *= 24;
                dias *= 60;
                dias *= 60;
                ModificarSegundo = dias;
            }
            else
            {
                ModificarSegundo = -1;
            }
            return ModificarSegundo;
        }//Fim do método

        //23.Leia um número e exiba a soma dos seus dígitos
        public int ContarLetras(int num)
        {
            int somar = 0;
            //Validação
            if (num < 0)
            {
                num = num * -1;
            }
            string numero = "" + num;
            for (int i = 0; i < numero.Length; i++)
            {
                somar += Convert.ToInt32(numero.Substring(i, 1));
            }
            return somar;
        }//Fim do método

        //##### VETORES #####
        //Preenchendo o vetor
        public void PreencherVetor()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.Write(i + 1 + "º Número: ");
                num[i] = Convert.ToInt32(Console.ReadLine());
            }//Fim do for
        }//Fim do método

        //Método consultar
        public void ConsultarVetor()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i + 1} º Número: {num[i]}");
            }
        }//Fim do método

        public void BuscarNumero(int num)
        {
            Boolean flag = false;
            for(int i = 0; i < 10; i++)
            {
                if (this.num[i] == num)
                {
                    flag = true;
                    Console.WriteLine($"O número {num} está na posição: {i + 1}");
                }
            }
            if (flag == false)
            {
                Console.WriteLine($"O número {num} não está no vetor!");
            }//Fim da validação booleana
        }//Fim do método

        public void OrdemInversa()
        {
            for(int i = 9; i >= 0; i--)
            {
                Console.WriteLine($"{i + 1} º Número: {num[i]}");
            }//Fim do for
        }//Fim do método

        public void VetorPares()
        {
            for(int i = 0; i < 10; i++) 
            {
                if (num[i] % 2 == 0)
                {
                    Console.WriteLine($"{num[i]} é par!");
                }//Fim do if
            }//Fim do for
        }//Fim do método

        public void VetorMedia()
        {
            double soma = 0;
            double media = 0;
            for(int i = 0; i < 10; i++)
            {
                soma += num[i];
            }//Fim do for
            media = soma / 10;
            Console.WriteLine($"A média dos números é: {media}");
        }//Fim do método

        public void VetorString()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write(i + 1 + "º Nome: ");
                nome[i] = Convert.ToString(Console.ReadLine());
            }//Fim do for
        }//Fim do método

        public void VetorA()
        {
            for(int i = 0; i < 10; i++)
            {
                if (nome[i].Substring(0,1) == "a" || nome[i].Substring(0,1) == "A")
                {
                    Console.WriteLine(nome[i]);
                }//Fim da validação
            }//Fim do for
        }//Fim do método

        public void MaiorMedia()
        {
            double soma = 0;
            double media = 0;
            double acimaMedia = 0;
            for (int i = 0; i < 10; i++)
            {
                soma += num[i];   
            }//Fim do for
            media = soma / 10;
            for (int i = 0; i < 10; i++)
            {
                if (num[i] > media)
                {
                    acimaMedia += 1;
                }//fim do if
            }//Fim do for
            Console.WriteLine($"Existem {acimaMedia} números acima da média");
        }//Fim do método

        public void PreencherIdade()
        {
            for (int i = 0; i < 10; i++)
            {
                do
                {
                    Console.Write(i+1 + "ª Idade: ");
                    num[i] = Convert.ToInt32(Console.ReadLine());
                    if (num[i] <= 0)
                    {
                        Console.WriteLine("Valor necessita ser maior do que zero!");
                    }//Fim do if
                } while (num[i] < 0); //Fim do do-while
            }//Fim do for
        }//Fim do método

        public void MaiorIdade()
        {
            int idadeMaior = 0;
            for(int i = 0; i < 10; i++)
            {
                if (i == 0)
                {
                    idadeMaior = num[i];
                } //Fim do if
                if (num[i] > idadeMaior)
                {
                    idadeMaior = num[i];
                }//Fim do if
            }//Fim do for
            Console.WriteLine($"A maior idade presente é: {idadeMaior} anos");
        }//Fim do método

        public void PreencherAltura()
        {
            for(int i = 0; i < 10; i++)
            {
                do
                {
                    Console.Write(i + 1 + "ª Altura: ");
                    vet[i] = Convert.ToDouble(Console.ReadLine());
                    if(vet[i] <= 0)
                    {
                        Console.WriteLine("Valor necessita ser maior do que zero!");
                    }//Fim do if
                } while (vet[i] < 0); //Fim do do-while
            }//Fim do for
        }//Fim do método

        public void MediaAltura()
        {
            double soma = 0;
            double media = 0;
            for(int i = 0; i < 10; i++)
            {
                soma += vet[i];
            }//Fim do método
            media = soma / 10;
            Console.WriteLine($"A média das alturas é {media}");
        }//Fim do método

        public void PreencherSalario()
        {
            for(int i = 0; i < 10; i++)
            {
                do
                {
                    Console.Write(i + 1 + "º Salário: ");
                    vet[i] = Convert.ToDouble(Console.ReadLine());
                    if( vet[i] <= 0)
                    {
                        Console.WriteLine("Valor necessita ser maior que zero!");
                    }//Fim do if
                } while (vet[i] < 0);//Fim do do-while
            }//Fim do for
        }//Fim do método

        public void ExibaSalarios()
        {
            for (int i = 0; i < 10; i++)
            {
                if( vet[i] > 1200)
                {
                    Console.WriteLine($"R${vet[i]}");
                }//Fim do if
            }//Fim do for
        }//fim do método

        public void MultiploCinco()
        {
            for(int i = 0; i < 10; i++) 
            {
                if (num[i] % 5 == 0)
                {
                    Console.WriteLine(num[i]);
                }//Fim do if
            }//Fim do for
        }//Fim do método

        public void ImparPar()
        {
            int impar = 0;
            int par = 0;
            for(int i = 0; i < 10; i++)
            {
                if (num[i] % 2 != 0)
                {
                    impares[impar] = num[i];
                    impar++;
                }//Fim do if
                else
                {
                    pares[par] = num[i];
                    par++;
                }//Fim do if
            }//Fim do for
            Console.WriteLine("\nOs números ímpares são: ");
            for (int i = 0; i < impar; i++)
            {   
                Console.WriteLine($"{impares[i]} é ímpar");
            }
            Console.WriteLine("\nOs números pares são: ");
            for (int i = 0; i < par; i++)
            {   
                Console.WriteLine($"{pares[i]} é par");
            }
        }//Fim do método

        public void MaiorMenor()
        {
            int aux = 0;
            for(int i = 1; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (num[i] > num[j])
                    {
                        aux = num[i];
                        num[i] = num[j];
                        num[j] = aux;
                    }//Fim do if
                }//Fim do for J
            }//Fim do for I
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i + 1}º: {num[i]}");
            }//Fim do for
        }//Fim do método
    }//Fim da Classe
}//Fim do Projeto
