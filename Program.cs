class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Empleados:");
        Api<Empleado> apiEmpleados = new Api<Empleado>();
        apiEmpleados.AgregarElemento(new Empleado(10, "Sofía", "Recepcionista"));
        apiEmpleados.AgregarElemento(new Empleado(11, "Diego", "Programador"));
        apiEmpleados.AgregarElemento(new Empleado(12, "Elena", "Diseñadora"));
        apiEmpleados.MostrarElementos();

        apiEmpleados.ActualizarElemento(1, new Empleado(11, "Diego López", "Jefe"));
        Console.WriteLine(apiEmpleados.ObtenerElemento(2));
        apiEmpleados.EliminarElemento(0);
        apiEmpleados.MostrarElementos();

        Console.WriteLine("Personas:");
        Api<Persona> apiPersonas = new Api<Persona>();
        apiPersonas.AgregarElemento(new Persona(20, "Nuria"));
        apiPersonas.AgregarElemento(new Persona(21, "Toni"));
        apiPersonas.AgregarElemento(new Persona(22, "Laura"));
        apiPersonas.MostrarElementos();
        apiPersonas.ActualizarElemento(0, new Persona(20, "Nuria Gómez"));
        Console.WriteLine(apiPersonas.ObtenerElemento(1));
        apiPersonas.EliminarElemento(2);
        apiPersonas.MostrarElementos();

        Console.WriteLine("Productos:");
        Api<Producto> apiProductos = new Api<Producto>();
        apiProductos.AgregarElemento(new Producto(201, "Auriculares", 29.95));
        apiProductos.AgregarElemento(new Producto(202, "Altavoz", 45.00));
        apiProductos.AgregarElemento(new Producto(203, "Webcam HD", 65.50));
        apiProductos.MostrarElementos();
        apiProductos.ActualizarElemento(2, new Producto(203, "Webcam Full HD", 79.99));
        Console.WriteLine(apiProductos.ObtenerElemento(0));
        apiProductos.EliminarElemento(1);
        apiProductos.MostrarElementos();
    }
}