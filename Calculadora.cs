using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora_TDD
{
    public class Calculadora
    {
        private List<string> historicoCalculadora;
        private string data;

        public Calculadora(string data)
        {
            historicoCalculadora = new List<string>();
            this.data = data;
        }

        public int Somar(int valor1,int valor2)
        {
            var resultado = valor1 + valor2;
            InserirHistorico(valor1, valor2, resultado, "+");
            return resultado;
        }

        public int Subtrair(int valor1, int valor2)
        {
            var resultado = valor1 - valor2;
            InserirHistorico(valor1, valor2, resultado, "-");
            return resultado;
        }

        public int Dividir(int valor1, int valor2)
        {
            var resultado = valor1 / valor2;
            InserirHistorico(valor1, valor2, resultado, "/");
            return resultado;
        }

        public int Multiplicar(int valor1, int valor2)
        {
            var resultado = valor1 * valor2;
            InserirHistorico(valor1,valor2,resultado,"*");
            return resultado;
        }

        public List<string> TrazerHistoricos()
        {
            historicoCalculadora.RemoveRange(3, historicoCalculadora.Count - 3);
            return historicoCalculadora;
        }

        public void InserirHistorico(int valor1,int valor2,int resultado,string operador)
        {
            var textoHistorico = $"Resultado da operação {valor1} {operador} {valor2} = {resultado} - data {this.data}";
            historicoCalculadora.Add(textoHistorico);
        }
    }
}
