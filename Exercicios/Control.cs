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
            Console.WriteLine("\nMenu" + "\n0. Sair" + "\n1. Exercício 1" + "\n2. Exercício 2" + "\n3. Exercício 3" + "\n8. Exercício 8" + "\n9. Exercício 9" + "\n16. Exercício 16");
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
                        Console.WriteLine("Exercício 01");
                        Console.WriteLine("Informe um número: ");
                        int num = Convert.ToInt32(Console.ReadLine());
                        //Chamar a ExercicioModel
                        Console.WriteLine(modelo.Triplo(num));
                        break;
                    case 2:
                        Console.WriteLine("Exercício 02");
                        Console.WriteLine("Informe um número: ");
                        num = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(modelo.Metade(num));
                        break;
                    case 3:
                        Console.WriteLine("Exercício 03");
                        Console.WriteLine("Informe quantos dólares você quer converter: ");
                        double dolares = Convert.ToDouble(Console.ReadLine());
                        
                        //Mostrar resultado
                        Console.WriteLine(modelo.ConverterReais(dolares));
                        break;                    
                    case 8:
                        Console.WriteLine("Exercício 08");
                        Console.WriteLine("Informe a diagonal maior: ");
                        double diagonalMaior = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Informe a diagonal menor: ");
                        double diagonalMenor = Convert.ToDouble(Console.ReadLine());

                        //Mostrar o resultado
                        if (modelo.AreaLosango(diagonalMaior, diagonalMenor) == -1)
                        {
                            Console.WriteLine("Os números digitados não são válidos!");
                        }
                        else
                        {
                            Console.WriteLine($"A área do losango é: {modelo.AreaLosango(diagonalMaior, diagonalMenor)}");
                        }//Fim do if/else
                        break;
                    case 9:
                        Console.WriteLine("Exercício 09");
                        Console.WriteLine("Informe o raio: ");
                        double raio = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Informe a altura: ");
                        double altura = Convert.ToDouble(Console.ReadLine());

                        //Mostrar o resultado
                        if (modelo.VolumeCilindro(raio, altura) == -1)
                        {
                            Console.WriteLine("Os números digitados não são válidos!");
                        }
                        else
                        {
                            Console.WriteLine($"O volume do cilindro é: {modelo.VolumeCilindro(raio, altura)}");
                        }//Fim do if/else
                        break;
                    case 16:
                        Console.WriteLine("Exercício 16");
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
