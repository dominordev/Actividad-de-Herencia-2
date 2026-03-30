// Aquí le muestro 5 diferentes ejemplos de herencia

// Ejemplo 1
class Persona
{
    public string Nombre;
    public void Saludar()
    {
        Console.WriteLine("Hola, me llamo " + Nombre);
    }
}

class Estudiante : Persona
{
    public string Carrera;
    public void MostrarCarrera()
    {
        Console.WriteLine("Yo estudio la carrera de " + Carrera);
    }
}

// Ejemplo 2

class Animal
{
    public virtual void Sonido()
    {
        Console.WriteLine("Sonido");
    }
}

class Perro : Animal
{
    public override void Sonido()
    {
        Console.WriteLine("Guau guau");
    }
}

class Gato : Animal
{
    public override void Sonido()
    {
        Console.WriteLine("Miau miau");
    }
}

// Ejemplo 3

class Abuelo
{
    public void Historia()
    {
        Console.WriteLine("Mi hijo cuando yo tenía tu edad...");
    }
}

class Padre : Abuelo
{
    public void Trabajo()
    {
        Console.WriteLine("Yo trabajo en tal cosa");
    }
}

class Hijo : Padre
{
    public void Colegio()
    {
        Console.WriteLine("Yo estoy en el Babeque");
    }
}

// Ejemplo 4

class Vehiculo
{
    public void Prender()
    {
        Console.WriteLine("Brum brum");
    }
}

class Carro : Vehiculo
{
    public void CuatroRuedas()
    {
        Console.WriteLine("Tiene 4 ruedas");
    }
}

class Moto : Vehiculo
{
    public void DosRuedas()
    {
        Console.WriteLine("Tiene 2 ruedas");
    }
}

// Ejemplo 5

class Persona
{
    public string Nombre;
    public Persona(string nombre)
    {
        Nombre = nombre;
    }
}

class Profesor : Persona
{
    public string Materia;
    public Profesor(string nombre, string materia) : base(nombre)
    {
        Materia = materia;
    }
}
