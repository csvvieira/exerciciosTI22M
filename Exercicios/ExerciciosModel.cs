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
        private double lado;
        private int hora;
        private double porcentagem;
        private double km;
        private int potencia;
        private double tempo;
        private double tempi;
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
            this.tempi = 0;
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

        public double ModificarTempi
        {
            get { return this.tempi; }
            set { this.tempi = value; }
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
        public double TempoViagem(int distancia, int velocidade)
        {
            if (ModificarTempi > 1)
            {
                ModificarTempi = 1;
            }
            else
            {
                ModificarTempi = -1;
            }
            return ModificarTempi;
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
