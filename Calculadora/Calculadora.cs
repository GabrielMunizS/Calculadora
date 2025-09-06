using System;
using System.Collections.Generic;
using System.Linq;
namespace Calculadora
{
    public class Calculadora
    {
        
        private Stack<Operacoes> historicoContas = new Stack<Operacoes>(); // Stack para armazenar histórico das operações realizadas

        public Stack<Operacoes> GetHistoricoContas
        {
            get {return historicoContas;}
        }

        public void SetHistoricoContas(Operacoes operacao)
        {
            historicoContas.Push(operacao);
        }

        public void PrintHistoricoConta(Queue<Operacoes> operacoes) // Exibe todas as operações já concluídas (em ordem cronológica)
        {
            int i = 1;
            Console.WriteLine("Histórico de Operações:\n");
            foreach (Operacoes op in GetHistoricoContas.Reverse())
            {
                Console.WriteLine("{0}° Operação: {1} {2} {3} = {4}", i, op.valorA, op.operador, op.valorB, op.resultado);
                i++;
            }
        }
        public void PrintContaPendente(Queue<Operacoes> operacoes) // Exibe operações ainda na fila
        {
            int j = 1;
            Console.WriteLine("\nOperações ainda na fila:");
            foreach (Operacoes op in operacoes)
            {
                Console.WriteLine($"{j}° Operação: {op.valorA} {op.operador} {op.valorB}");
                j++;
            }

            if (operacoes.Count == 0)
                Console.WriteLine("Nenhuma operação pendente.\n");
        }

        public Operacoes calcular(Operacoes operacao) // Calcula o resultado de uma operação e adiciona ao histórico
        {
            switch (operacao.operador)
            {
                case '+': operacao.resultado = soma(operacao); break;
                case '-': operacao.resultado = subtracao(operacao); break;
                case '*': operacao.resultado = multiplicacao(operacao); break;
                case '/': operacao.resultado = divisao(operacao); break;
                default: operacao.resultado = 0; break;
            }
            SetHistoricoContas(operacao);
            return operacao;
        }

        // -------------------------------
        // Métodos Matemáticos
        // -------------------------------

        public long soma(Operacoes operacao)
        {
            return operacao.valorA + operacao.valorB;
        }
        public long subtracao(Operacoes operacao)
        {
            return operacao.valorA - operacao.valorB;
        }
        public long multiplicacao(Operacoes operacao)
        {
            return operacao.valorA * operacao.valorB;
        }
        public long divisao(Operacoes operacao)
        {
            if (operacao.valorB == 0)
            {
                throw new DivideByZeroException("Divisão por zero não é permitida.");
            }
            return operacao.valorA / operacao.valorB;
        }


    }
}