class Empleado : Persona
{
    public string Puesto { get; set; }

    public Empleado(int id, string nombre, string puesto)
        : base(id, nombre)
    {
        Puesto = puesto;
    }

    public override string ToString()
    {
        return base.ToString() + $", Puesto: {Puesto}";
    }
}