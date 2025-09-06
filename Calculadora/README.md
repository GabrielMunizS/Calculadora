# Calculadora

## Resumo das mudan�as

- **Fila (`Queue`)** para controlar opera��es pendentes (processamento natural em ordem FIFO).  
- **Pilha (`Stack`)** para guardar o hist�rico (mais pr�tico, e d� pra inverter quando quiser ver em ordem).  
- **Tipo `long`** pra evitar problemas de overflow.  
- **Tratamento de erros**, evitando resultados incorretos passando despercebidos.  
- **Impress�o separada** do que falta e do que j� foi feito, deixando o fluxo mais transparente.  

## Coment�rios

1. **Hist�rico das opera��es**  
   Usei uma `Stack<Operacoes>` para guardar tudo que j� foi calculado. Na hora de imprimir fa�o um `Reverse()` pra exibir em ordem cronol�gica, agindo mais como um hist�rico.
   
2. **Divis�o implementada**  
   Adicionei o operador `/` e criei a rotina de divis�o com tratamento de `DivideByZeroException`. Assim esclarecendo o motivo do erro pro usu�rio ao inv�s de finalizar o c�digo direto.

3. **Overflow na pen�ltima opera��o**  
   Troquei o tipo dos valores para `long`. Dessa forma a conta `2147483647 + 2` funciona corretamente sem estourar o limite de `int`.

4. **Impress�o da fila pendente**  
   Depois de cada c�lculo chamo `PrintContaPendente(filaOperacoes)`, mostrando exatamente o que ainda falta ser processado.

5. **Processamento da fila corrigido**  
   Passei a usar `Dequeue()` dentro do `while (filaOperacoes.Count > 0)`, assim cada item � adicionado no stack e logo ap�s removido da fila depois de processado.


