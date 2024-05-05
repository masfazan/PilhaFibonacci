
namespace PilhaFibonacci
{
    internal class Pilha
    {
        Fibonacci topo;

        public Pilha() //criando a pilha
        {
            topo = null;
        }

        Boolean PilhaVazia()
        {
            if (topo == null)
                return true;
            else
                return false;
        }

        public void Imprimir()
        {
            Fibonacci aux = this.topo;
            if (PilhaVazia())
            {
                Console.WriteLine("Não há conteúdo para imprimir");
            }
            else
            {
                do
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.getAnterior();
                } while (aux != null);
            }
    
        }

        public void Push(Fibonacci aux)
        {
            if (PilhaVazia()==true)
            {
                topo = aux;
            }
            else
            {
                aux.setAnterior(topo);
                topo= aux;
            }
        }

    }
}
