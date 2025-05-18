public class Api<T>
{
    private List<T> elementos;

    public Api()
    {
        elementos = new List<T>();
    }

    public void AgregarElemento(T elemento)
    {
        elementos.Add(elemento);
    }

    public void EliminarElemento(int indice)
    {
        if (indice >= 0 && indice < elementos.Count)
        {
            elementos.RemoveAt(indice);
        }
        else
        {
            Console.WriteLine("Índice fuera de rango");
        }
    }

    public T ObtenerElemento(int indice)
    {
        if (indice >= 0 && indice < elementos.Count)
        {
            return elementos[indice];
        }
        else
        {
            Console.WriteLine("índice fuera de rango");
            return elementos[0];
        }
    }

    public void MostrarElementos()
    {
        foreach (var elemento in elementos)
        {
            Console.WriteLine(elemento.ToString());
        }
    }

    public void ActualizarElemento(int indice, T nuevoElemento)
    {
        if (indice >= 0 && indice < elementos.Count)
        {
            elementos[indice] = nuevoElemento;
        }
        else
        {
            Console.WriteLine("Índice fuera de rango");
        }
    }
}
