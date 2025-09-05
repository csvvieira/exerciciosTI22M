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
            Console.WriteLine("\nMenu\n" + "\n0. Sair" + "\n1. Exercício 1" + "\n2. Exercício 2" + "\n3. Exercício 3" + "\n4. Exercício 4" + "\n5. Exercício 5" + 
                              "\n6. Exercício 6" + "\n8. Exercício 8" + "\n9. Exercício 9" + "\n10. Exercício 10" + "\n11. Exercício 11" + "\n12. Exercício 12" + 
                              "\n13. Exercício 13" + "\n14. Exercício 14" + "\n15. Exercício 15" + "\n16. Exercício 16" + "\n17. Exercício 17" + "\n18. Exercício 18" +
                              "\n19. Exercício 19" + "\n20. Exercício 20" + "\n21. Exercício 21" + "\n22. Exercício 22" + "\n23. Exercício 23");
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
                        double km = Convert.ToDouble(Console.ReadLine());
                        
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
                        double distancia = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Informe a velocidade: ");
                        double velocidade = Convert.ToDouble(Console.ReadLine());

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
                    case 14:
                        Console.WriteLine("\nExercício 14");
                        Console.WriteLine("Informe o km percorrido: ");
                        km = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Informe o combustível consumido: ");
                        double litros = Convert.ToDouble(Console.ReadLine());

                        //Mostrar o resultado
                        if (modelo.ConsumoMedio(km, litros) == -1)
                        {
                            Console.WriteLine("O número digitado não é válido!");
                        }
                        else
                        {
                            Console.WriteLine($"O consumo médio de combustível é: {modelo.ConsumoMedio(km, litros)} km/l");
                        }
                        break;
                    case 15:
                        Console.WriteLine("\nExercício 15");
                        Console.WriteLine("Informe o número 5 para descobrir seu fatorial: ");
                        num = Convert.ToInt32(Console.ReadLine());

                        //Mostrar o resultado
                        if (modelo.FatorialCinco(num) == -1)
                        {
                            Console.WriteLine("O número digitado não é válido!");
                        }
                        else
                        {
                            Console.WriteLine($"O fatorial de 5 é: {modelo.FatorialCinco(num)}");
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
                    case 17:
                        Console.WriteLine("\nExercício 17");
                        Console.WriteLine("Informe seu salário mensal: ");
                        double salario = Convert.ToDouble(Console.ReadLine());

                        //Mostrar o resultado
                        if (modelo.SalarioAnual(salario) == -1)
                        {
                            Console.WriteLine("O número digitado não é válido!");
                        }
                        else
                        {
                            Console.WriteLine($"O seu salário anual é de: {modelo.SalarioAnual(salario)}R$");
                        }
                        break;
                    case 18:
                        Console.WriteLine("\nExercício 18");
                        Console.WriteLine("Informe um número para descobirir o seu logaritmo natural: ");
                        double num1 = Convert.ToDouble(Console.ReadLine());

                        //Mostrar o resultado
                        if (modelo.LogaritmoNatural(num1) == -1)
                        {
                            Console.WriteLine("O número digitado não é valido");
                        }
                        else
                        {
                            Console.WriteLine("O logaritmo natural de " + (num1) + $" é: {modelo.LogaritmoNatural(num1)}");
                        }
                        break;
                    case 19:
                        Console.WriteLine("\nExercício 19");
                        Console.WriteLine("Informe o cateto oposto: ");
                        double catetoOposto = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Informe a hipotenusa: ");
                        double hipotenusa = Convert.ToDouble(Console.ReadLine());

                        //Mostrar o resultado
                        if (modelo.Seno(catetoOposto, hipotenusa) == -1)
                        {
                            Console.WriteLine("O número digitado não é válido!");
                        }
                        else
                        {
                            Console.WriteLine($"O valor de seno é: {modelo.Seno(catetoOposto, hipotenusa)}");
                        }
                        break;
                    case 20:
                        Console.WriteLine("\nExercício 20");
                        Console.WriteLine("Informe o valor do cateto adjacente: ");
                        double catetoAdjacente = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Informe o valor da hipotenusa: ");
                        hipotenusa = Convert.ToDouble(Console.ReadLine());

                        //Mostrar o resultado
                        if (modelo.Cosseno(catetoAdjacente, hipotenusa) == -1)
                        {
                            Console.WriteLine("O número digitado não é válido!");
                        }
                        else
                        {
                            Console.WriteLine($"O valor de cosseno é:  {modelo.Cosseno(catetoAdjacente, hipotenusa)}");
                        }
                        break;
                    case 21:
                        Console.WriteLine("\nExercício 21");
                        Console.WriteLine("Informe o valor da base maior: ");
                        double baseMaior = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Informe o valor da base menor: ");
                        double baseMenor = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Informe o valor da altura: ");
                        altura = Convert.ToDouble(Console.ReadLine());

                        //Mostrar o resultado
                        if (modelo.AreaTrapezio(baseMaior, baseMenor, altura) == -1)
                        {
                            Console.WriteLine("O número digitado não é válido!");
                        }
                        else
                        {
                            Console.WriteLine($"A área do trapézio é: {modelo.AreaTrapezio(baseMaior, baseMenor, altura)}");
                        }
                        break;
                    case 22:
                        Console.WriteLine("\nExercício 22");
                        Console.WriteLine("Informe a quantidade de dias: ");
                        int dias = Convert.ToInt32(Console.ReadLine());

                        //Mostrar o resultado
                        if (modelo.DiasSegundos(dias) == -1)
                        {
                            Console.WriteLine("O número digitado não é válido!");
                        }
                        else
                        {
                            Console.WriteLine("O valor em segundos para " + (dias) + $" dias é: {modelo.DiasSegundos(dias)} segundos");
                        }
                        break;
                    case 23:
                        Console.WriteLine("\nExercício 23");
                        Console.WriteLine("Informe o número para descobir a soma dos seus dígitos: ");
                        num = Convert.ToInt32(Console.ReadLine());

                        //Mostrar o resultado
                        Console.WriteLine($"A soma dos dígitos é: {modelo.ContarLetras(num)}");
                        break;
                    case 24:

                }//Fim do switch
            } while (ModificarOpcao != 0);
        }//Fim do ExecutarMenu
    }//Fim da Classe
}//Fim do Projeto
