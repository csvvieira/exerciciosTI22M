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
                              "\n19. Exercício 19" + "\n20. Exercício 20" + "\n21. Exercício 21" + "\n22. Exercício 22" + "\n23. Exercício 23" + "\n24. Exercício 24 - Vetor" +
                              "\n25. Exercício 25 - Vetor" + "\n26. Exercício 26 - Vetor" + "\n27. Exercício 27 - Vetor" + "\n28. Exercício 28 - Vetor" + "\n29. Exercício 29 - Vetor" +
                              "\n30 .Exercício 30 - Vetor" + "\n31. Exercício 31 - Vetor" + "\n32. Exercício 32 - Vetor" + "\n33. Exercício 33 - Vetor" + "\n34. Exercício 34 - Vetor" + 
                              "\n35. Exercício 35 - Vetor" + "\n36. Exercício 36 - Vetor" + "\n37. Exercício 37 - Vetor" + "\n38. Exercício 38 - Vetor" + "\n39. Exercício 39 - Vetor" +
                              "\n40. Exercício 40 - Vetor" + "\n41. Exercício 41 - Vetor" + "\n42. Exercício 42 - Vetor" + "\n43. Exercício 43 - Vetor" + "\n44. Exercício 44 - Vetor" +
                              "\n45. Exercício 45 - Vetor" + "\n46. Exercício 46 - Vetor");
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

                    //##### Vetores #####
                    case 24:
                        Console.WriteLine("\nExercício 24");
                        //Mostrar
                        modelo.PreencherVetor();
                        break;
                    case 25:
                        Console.WriteLine("\nExercício 25");
                        //Mostrar
                        modelo.ConsultarVetor();
                        break;
                    case 26:
                        Console.WriteLine("\nExercício 26");
                        //mostrar
                        Console.WriteLine("Informe o número que deseja procurar: ");
                        num = Convert.ToInt32(Console.ReadLine());
                        //Buscar no método
                        modelo.BuscarNumero(num);
                        break;
                    case 27:
                        Console.WriteLine("\nExercício 27");
                        //Mostrar
                        modelo.PreencherVetor();
                        break;
                    case 28:
                        Console.WriteLine("\nExercício 28");
                        modelo.PreencherVetor();
                        Console.WriteLine("\nVetor na ordem inversa: ");
                        modelo.OrdemInversa();
                        break;
                    case 29:
                        Console.WriteLine("\nExercício 29");
                        modelo.PreencherVetor();
                        Console.WriteLine("\nOs números pares são: ");
                        modelo.VetorPares();
                        break;
                    case 30:
                        Console.WriteLine("\nExercício 30");
                        modelo.PreencherVetor();
                        modelo.VetorMedia();
                        break;
                    case 31:
                        Console.WriteLine("\nExercício 31");
                        modelo.VetorString();
                        Console.WriteLine("\nOs nomes que começam com A são: ");
                        modelo.VetorA();
                        break;
                    case 32:
                        Console.WriteLine("\nExercício 32");
                        modelo.PreencherVetor();
                        Console.WriteLine("\nNúmeros acima da média:");
                        modelo.MaiorMedia();
                        break;
                    case 33:
                        Console.WriteLine("\nExercício 33");
                        modelo.PreencherIdade();
                        modelo.MaiorIdade();
                        break;
                    case 34:
                        Console.WriteLine("\nExercício 34");
                        modelo.PreencherAltura();
                        modelo.MediaAltura();
                        break;
                    case 35:
                        Console.WriteLine("\nExercício 35");
                        modelo.PreencherSalario();
                        Console.WriteLine("\nOs salários acima de R$1200,00 são: ");
                        modelo.ExibaSalarios();
                        break;
                    case 36:
                        Console.WriteLine("\nExercício 36");
                        modelo.PreencherVetor();
                        Console.WriteLine("\nOs múltiplos de 5 são: ");
                        modelo.MultiploCinco();
                        break;
                    case 37:
                        Console.WriteLine("\nExercício 37");
                        modelo.PreencherVetor();
                        modelo.ImparPar();
                        break;
                    case 38:
                        Console.WriteLine("\nExercício 38");
                        modelo.PreencherVetor();
                        Console.WriteLine("\nNúmeros ordenados do maior para o menor: ");
                        modelo.MaiorMenor();
                        break;
                    case 39:
                        Console.WriteLine("\nExercício 39");
                        modelo.PreencherVetor();
                        Console.WriteLine("\nNúmeros repetidos: ");
                        modelo.NumeroRepetido();
                        break;
                    case 40:
                        Console.WriteLine("\nExercício 40");
                        Console.WriteLine("Preencha o Primeiro Vetor:");
                        modelo.PreencherVetor();
                        Console.WriteLine("\nPreencha o Segundo Vetor: ");
                        modelo.PreencherDois();
                        Console.WriteLine("\nSoma dos dois vetores: ");
                        modelo.SomaVetores();
                        break;
                    case 41:
                        Console.WriteLine("\nExercício 41");
                        Console.WriteLine("Preencha o Primeiro Vetor:");
                        modelo.PreencherVetor();
                        Console.WriteLine("\nPreencha o Segundo Vetor: ");
                        modelo.PreencherDois();
                        Console.WriteLine("\nMultiplicação dos dois vetores: ");
                        modelo.MultiplicacaoVetores();
                        break;
                    case 42:
                        Console.WriteLine("\nExercício 42");
                        modelo.PreencherVetor();
                        Console.WriteLine("\nSoma dos elementos do vetor: ");
                        modelo.SomaVetor();
                        break;
                    case 43:
                        Console.WriteLine("\nExercício 43");
                        modelo.PreencherVetor();
                        Console.WriteLine("\nMaior número e sua posição: ");
                        modelo.MaiorPosicao();
                        break;
                    case 44:
                        Console.WriteLine("\nExercício 44");
                        Console.WriteLine("\nPreencha o vetor com o nome dos alunos: ");
                        modelo.VetorString();
                        Console.WriteLine("\nPreencha o vetor com a nota dos alunos: ");
                        modelo.PreencherNota();
                        Console.WriteLine("\nAlunos com nota acima de 7: ");
                        modelo.AcimaSete();
                        break;

                    



                    default:
                        Console.WriteLine("Opção escolhida não é válida!");
                        break;
                }//Fim do switch
            } while (ModificarOpcao != 0);
        }//Fim do ExecutarMenu
    }//Fim da Classe
}//Fim do Projeto
