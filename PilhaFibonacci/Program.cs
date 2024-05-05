using PilhaFibonacci;
internal class Program
{
    private static void Main(string[] args)
    {
        Pilha pilhaResult = new Pilha();

        int pos, penultimo = -1, atual, ultimo = 1;
          
        Console.WriteLine("Informe a posição: ");
        pos = int.Parse(Console.ReadLine());

        for (int i = 0; i < pos; i++)
        {
            atual = penultimo + ultimo;
            pilhaResult.Push(new Fibonacci(atual));//números são adicionados na pilha
            penultimo = ultimo;
            ultimo = atual;
        }
        Console.WriteLine("Sequência Fibonacci");
        pilhaResult.Imprimir();
    }
}