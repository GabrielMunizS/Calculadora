# Calculadora

## Resumo das mudanças

- **Fila (`Queue`)** para controlar operações pendentes (processamento natural em ordem FIFO).  
- **Pilha (`Stack`)** para guardar o histórico (mais prático, e dá pra inverter quando quiser ver em ordem).  
- **Tipo `long`** pra evitar problemas de overflow.  
- **Tratamento de erros**, evitando resultados incorretos passando despercebidos.  
- **Impressão separada** do que falta e do que já foi feito, deixando o fluxo mais transparente.  

## Comentários

1. **Histórico das operações**  
   Usei uma `Stack<Operacoes>` para guardar tudo que já foi calculado. Na hora de imprimir faço um `Reverse()` pra exibir em ordem cronológica, agindo mais como um histórico.
   
2. **Divisão implementada**  
   Adicionei o operador `/` e criei a rotina de divisão com tratamento de `DivideByZeroException`. Assim esclarecendo o motivo do erro pro usuário ao invés de finalizar o código direto.

3. **Overflow na penúltima operação**  
   Troquei o tipo dos valores para `long`. Dessa forma a conta `2147483647 + 2` funciona corretamente sem estourar o limite de `int`.

4. **Impressão da fila pendente**  
   Depois de cada cálculo chamo `PrintContaPendente(filaOperacoes)`, mostrando exatamente o que ainda falta ser processado.

5. **Processamento da fila corrigido**  
   Passei a usar `Dequeue()` dentro do `while (filaOperacoes.Count > 0)`, assim cada item é adicionado no stack e logo após removido da fila depois de processado.

# Calculadora

Case para Engenharia de Software JR

Você precisa corrigir os seguintes problemas no codigo:
  1. Aplicação só está processando o primeiro item da fila infinitamente.
  2. Implemente a funcionalidade de divisão.
  3. Aplicação não está calculando a penultima operação corretamente.
     
     	Saída esperada no console:
     
     		14 - 8 = 6
     
     		5 * 6 = 30
     
     		2147483647 + 2 = 2147483649
     
     		18 / 3 = 6

  5. Implemente uma funcionalidade para imprimir toda a lista de operaçõoes a ser processada após cada calculo realizado.
  6. Crie uma nova pilha (Stack) para guardar o resultado de cada calculo efetuado e imprima a pilha ao final


Não existe resposta certa ou errada, o objetivo do case é avaliar a linha de raciocínio de cada candidato.
Você é livre para fazer na linguagem de sua preferência, desde que aplique as mesmas funcionalidades e tarefas deste case.
Dica: Utilize Visual Code ou Visual Studio Community para realizar as tarefas.
