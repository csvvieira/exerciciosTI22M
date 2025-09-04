using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class Control
    {
        private int opcao;
        public ExerciciosModel modelo;//Criando a conexão com a classe modelo
        public Control()
        {
            this.opcao = 0; 
            this.modelo= new ExerciciosModel();//Instanciando para usar os métodos
        }//Fim do Método

        public int ModificarOpcao
        {
            get { return this.opcao; }
            set { this.opcao = value; } 
        }//Fim do ModificarOpcao

        public void MostrarMenu()
        {
            Console.WriteLine("\nMenu" + "\n0. Sair" + "\n1. Exercício 1" + "\n2. Exercício 2" + "\n3. Exercício 3" + "\n4. Exercício 4" + "\n5. Exercício 5" + "\n6. Exercício 6" + "\n8. Exercício 8" + 
                              "\n9. Exercício 9" + "\n10. Exercício 10" + "\n11. Exercício 11" + "\n12. Exercício 12" + "\n13. Exercício 13" + "\n16. Exercício 16");
            Console.WriteLine("\nQual exercício deseja realizar?");
            ModificarOpcao = Convert.ToInt32(Console.ReadLine());
        }//Fim do MostrarMenu

        public void ExecutarMenu()
        {
            do
            {
                //Chamar o menu
                MostrarMenu();
                switch (ModificarOpcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado!!!");
                        break;
                    case 1:
                        Console.WriteLine("\nExercício 01");
                        Console.WriteLine("Informe um número: ");
                        int num = Convert.ToInt32(Console.ReadLine());
                        //Chamar a ExercicioModel
                        Console.WriteLine(modelo.Triplo(num));
                        break;
                    case 2:
                        Console.WriteLine("\nExercício 02");
                        Console.WriteLine("Informe um número: ");
                        num = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(modelo.Metade(num));
                        break;
                    case 3:
                        Console.WriteLine("\nExercício 03");
                        Console.WriteLine("Informe quantos dólares você quer converter: ");
                        double dolares = Convert.ToDouble(Console.ReadLine());
                        
                        //Mostrar resultado
                        Console.WriteLine(modelo.ConverterReais(dolares));
                        break;  
                    case 4:
                        Console.WriteLine("\nExercício 04");
                        Console.WriteLine("Informe o valor de um lado do quadrado");
                        double lado = Convert.ToDouble(Console.ReadLine());

                        //Mostrar o resultado
                        if (modelo.PerimetroQuadrado(lado) == -1)
                        {
                            Console.WriteLine("O número digitado não é válido");
                        }
                        else
                        {
                            Console.WriteLine($"O perímetro do quadrado é: {modelo.PerimetroQuadrado(lado)}");
                        }
                        break;
                    case 5:
                        Console.WriteLine("\nExercício 05");
                        Console.WriteLine("Informe o valor das horas que deseja transformar em minutos: ");
                        int hora = Convert.ToInt32(Console.ReadLine());

                        //Mostrar o resultado
                        if (modelo.HoraMinuto(hora) == -1)
                        {
                            Console.WriteLine("O número digitado não é válido!");
                        }
                        else
                        {
                            Console.WriteLine($"O valor em minutos é: {modelo.HoraMinuto(hora)}");
                        }   
                        break;
                    case 6:
                        Console.WriteLine("\nExercício 06");
                        Console.WriteLine("Informe um número para saber os seus 10%: ");
                        double porcentagem = Convert.ToDouble(Console.ReadLine());

                        //Mostrar o resultado
                        if(modelo.PorcentagemDez(porcentagem) == -1)
                        {
                            Console.WriteLine("O número digitado não é válido!");
                        }
                        else
                        {
                            Console.WriteLine("10% de " + (porcentagem) + $" é: {modelo.PorcentagemDez(porcentagem)}");
                        }
                        break;
                    case 7:
                        Console.WriteLine("\nExercício 07");
                        Console.WriteLine("Informe um número para saber os seus 25%: ");
                        porcentagem = Convert.ToDouble(Console.ReadLine());

                        //Mostrar o resultado
                        if (modelo.PorcentagemVinteCinco(porcentagem) == -1)
                        {
                            Console.WriteLine("O número digitado não é válido!");
                        }
                        else
                        {
                            Console.WriteLine("25% de " + (porcentagem) + $" é: {modelo.PorcentagemVinteCinco(porcentagem)}" );
                        }
                        break;
                    case 8:
                        Console.WriteLine("\nExercício 08");
                        Console.WriteLine("Informe a diagonal maior: ");
                        double diagonalMaior = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Informe a diagonal menor: ");
                        double diagonalMenor = Convert.ToDouble(Console.ReadLine());

                        //Mostrar o resultado
                        if (modelo.AreaLosango(diagonalMaior, diagonalMenor) == -1)
                        {
                            Console.WriteLine("O número digitado não é válido!");
                        }
                        else
                        {
                            Console.WriteLine($"A área do losango é: {modelo.AreaLosango(diagonalMaior, diagonalMenor)}");
                        }//Fim do if/else
                        break;
                    case 9:
                        Console.WriteLine("\nExercício 09");
                        Console.WriteLine("Informe o raio: ");
                        double raio = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Informe a altura: ");
                        double altura = Convert.ToDouble(Console.ReadLine());

                        //Mostrar o resultado
                        if (modelo.VolumeCilindro(raio, altura) == -1)
                        {
                            Console.WriteLine("O número digitado não é válido!");
                        }
                        else
                        {
                            Console.WriteLine($"O volume do cilindro é: {modelo.VolumeCilindro(raio, altura)}");
                        }//Fim do if/else
                        break;
                    case 10:
                        Console.WriteLine("\nExercício 10");
                        Console.WriteLine("Informe um número: ");
                        num = Convert.ToInt32(Console.ReadLine());

                        //Mostrar o resultado
                        Console.WriteLine("O valor absoluto de " + (num) + $" é: {modelo.ValorAbsoluto(num)}");
                        break;
                    case 11:
                        Console.WriteLine("\nExercício 11");
                        Console.WriteLine("Informe o valor em km: ");
                        int km = Convert.ToInt32(Console.ReadLine());
                        
                        //Mostrar o resultado
                        if (modelo.QuilometrosMetros(km) == -1)
                        {
                            Console.WriteLine("O número digitado não é válido!");
                        }
                        else
                        {
                            Console.WriteLine("O valor em metros de " + (km) + $" quilômetro(s) é : {modelo.QuilometrosMetros(km)} metros");   
                        }
                        break;
                    case 12:
                        Console.WriteLine("\nExercício 12");
                        Console.WriteLine("Informe um número: ");
                        num = Convert.ToInt32(Console.ReadLine());

                        //Mostrar o resultado
                        if (modelo.QuintaPotencia(num) == -1)
                        {
                            Console.WriteLine("O número digitado não é válido");
                        }
                        else
                        {
                            Console.WriteLine((num) + $" elevado a quinta potência é: {modelo.QuintaPotencia(num)}");
                        }
                        break;
                    case 13:
                        Console.WriteLine("\nExercício 13");
                        Console.WriteLine("Informe a distância: ");
                        int distancia = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe a velocidade: ");
                        int velocidade = Convert.ToInt32(Console.ReadLine());

                        //Mostrar resultado
                        if (modelo.TempoViagem(distancia, velocidade) == -1)
                        {
                            Console.WriteLine("O número digitado não é válido!");
                        }
                        else
                        {
                            Console.WriteLine($"O tempo da viagem será de: {modelo.TempoViagem(distancia, velocidade)} minutos");
                        }
                        break;
                    case 16:
                        Console.WriteLine("\nExercício 16");
                        Console.WriteLine("Informe o seu peso: ");
                        double peso = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Informe sua altura: ");
                        altura = Convert.ToDouble(Console.ReadLine());

                        //Mostrar o resultado
                        Console.WriteLine(modelo.CalcularIMC(peso, altura));
                        break;
                    default:
                        Console.WriteLine("Opção escolhida não é válida!!!");
                        break;
                }//Fim do switch
            } while (ModificarOpcao != 0);
        }//Fim do ExecutarMenu
    }//Fim da Classe
}//Fim do Projeto
