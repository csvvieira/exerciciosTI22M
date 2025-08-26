using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class ExerciciosModel
    {
        //Área de variáveis
        private double area;
        private double IMC;
        //Método Construtor 
        public ExerciciosModel()
        {
            this.area = 0;
            this.IMC = 0;
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
    }//Fim da Classe
}//Fim do Projeto
