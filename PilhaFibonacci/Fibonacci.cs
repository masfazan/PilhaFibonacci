
namespace PilhaFibonacci
{
    internal class Fibonacci
    {
        int numero;
        Fibonacci anterior; 

        public Fibonacci(int numero)
        {
            this.numero = numero;
            this.anterior = null;
        }

        public int getNumero()
        {
            return numero;
        }

        public void setAnterior(Fibonacci ant)//inserir
        {
            this.anterior = ant;
        }

        public Fibonacci getAnterior()//guardar valor
        {
            return this.anterior;
        }
        public override string? ToString()
        {
            return numero.ToString();
        }
    }

}
