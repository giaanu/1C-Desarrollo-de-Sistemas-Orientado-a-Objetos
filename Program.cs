namespace EjerciciosEncapsulamiento;

// Ejercicio 1 
class CuentaBancaria
{
    private decimal saldo;

    public void Depositar(decimal monto)
    {
        saldo += monto;
    }

    public void Retirar(decimal monto)
    {
        if (monto < 0 || monto > saldo)
        {
            Console.WriteLine("Error: monto inválido o saldo insuficiente.");
            return;
        }
        saldo -= monto;
    }

    public decimal Saldo => saldo;
}

// Ejercicio 2 
class Personaje
{
    private int vida;
    private string nombre;

    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public int Vida
    {
        get { return vida; }
        set
        {
            if (value < 0)
                vida = 0;
            else if (value > 100)
                vida = 100;
            else
                vida = value;
        }
    }
}

// Ejercicio 3 
class Producto
{
    protected float costoFabricacion;
    private float precioVenta;

    public float PrecioVenta
    {
        get { return precioVenta; }
        set { precioVenta = value; }
    }

    public Producto(float costoFabricacion, float precioVenta)
    {
        this.costoFabricacion = costoFabricacion;
        this.precioVenta = precioVenta;
    }
}

class ProductoImportado : Producto
{
    public ProductoImportado(float costoFabricacion, float precioVenta)
        : base(costoFabricacion, precioVenta) { }

    public float CalcularImpuestos()
    {
        return costoFabricacion * 0.21f;
    }
}

// Ejercicio 4 
class Usuario
{
    private string password;

    public string Password
    {
        get { return password; }
        set
        {
            if (value.Length < 8)
            {
                Console.WriteLine("Error: la contraseña debe tener al menos 8 caracteres.");
                return;
            }
            password = value;
        }
    }
}

// Ejercicio 5 
class Servidor
{
    protected string direccionIP;
    private bool estaConectado;

    public bool EstaConectado => estaConectado;

    public Servidor(string direccionIP)
    {
        this.direccionIP = direccionIP;
        estaConectado = false;
    }

    public void HacerPing()
    {
        estaConectado = true;
        Console.WriteLine($"Ping exitoso. Servidor {direccionIP} conectado.");
    }
}

// Ejercicio 6 
abstract class Animal
{
    public string Nombre { get; set; }
    public abstract void HacerRuido();
}

class Perro : Animal
{
    public Perro(string nombre) { Nombre = nombre; }
    public override void HacerRuido() => Console.WriteLine($"{Nombre}: ¡Guau!");
}

class Gato : Animal
{
    public Gato(string nombre) { Nombre = nombre; }
    public override void HacerRuido() => Console.WriteLine($"{Nombre}: ¡Miau!");
}

class Vaca : Animal
{
    public Vaca(string nombre) { Nombre = nombre; }
    public override void HacerRuido() => Console.WriteLine($"{Nombre}: ¡Muuu!");
}

// Ejercicio 7 
abstract class DispositivoRed
{
    public string DireccionIP { get; set; }
    public abstract void EjecutarDiagnostico();
}

class Router : DispositivoRed
{
    public Router(string ip) { DireccionIP = ip; }
    public override void EjecutarDiagnostico() => Console.WriteLine($"Revisando tablas de ruteo en {DireccionIP}");
}

class Switch : DispositivoRed
{
    public Switch(string ip) { DireccionIP = ip; }
    public override void EjecutarDiagnostico() => Console.WriteLine($"Revisando puertos VLAN en {DireccionIP}");
}

class Program
{
    static void Main(string[] args)
    {
        // Ejercicio 1
        Console.WriteLine("=== Ejercicio 1 - Cajero Automático ===");
        CuentaBancaria cuenta = new CuentaBancaria();
        cuenta.Depositar(1000);
        cuenta.Retirar(400);
        cuenta.Retirar(800);
        cuenta.Retirar(-50);
        Console.WriteLine($"Saldo actual: ${cuenta.Saldo}");

        // Ejercicio 2
        Console.WriteLine("\n=== Ejercicio 2 - Videojuego ===");
        Personaje personaje = new Personaje();
        personaje.Nombre = "Guerrero";
        personaje.Vida = 100;
        personaje.Vida -= 60;
        personaje.Vida -= 80;
        Console.WriteLine($"{personaje.Nombre} - Vida: {personaje.Vida}");
        personaje.Vida += 200;
        Console.WriteLine($"{personaje.Nombre} - Vida tras poción: {personaje.Vida}");

        // Ejercicio 3
        Console.WriteLine("\n=== Ejercicio 3 - E-Commerce ===");
        ProductoImportado producto = new ProductoImportado(500, 900);
        Console.WriteLine($"Impuestos de importación: ${producto.CalcularImpuestos()}");
        producto.PrecioVenta = 950;
        Console.WriteLine($"Precio de venta actualizado: ${producto.PrecioVenta}");

        // Ejercicio 4
        Console.WriteLine("\n=== Ejercicio 4 - Sistema de Usuarios ===");
        Usuario usuario = new Usuario();
        usuario.Password = "123";
        usuario.Password = "contraSegura123";
        Console.WriteLine("Contraseña asignada correctamente.");

        // Ejercicio 5
        Console.WriteLine("\n=== Ejercicio 5 - Red Corporativa ===");
        Servidor servidor = new Servidor("192.168.1.1");
        Console.WriteLine($"¿Conectado antes del ping? {servidor.EstaConectado}");
        servidor.HacerPing();
        Console.WriteLine($"¿Conectado después del ping? {servidor.EstaConectado}");

        // Ejercicio 6
        Console.WriteLine("\n=== Ejercicio 6 - Zoológico Virtual ===");
        Animal[] zoologico = new Animal[3];
        zoologico[0] = new Perro("Rex");
        zoologico[1] = new Gato("Michi");
        zoologico[2] = new Vaca("Lola");

        foreach (Animal animal in zoologico)
        {
            animal.HacerRuido();
        }

        // Ejercicio 7
        Console.WriteLine("\n=== Ejercicio 7 - Monitoreo de Infraestructura IT ===");
        DispositivoRed[] datacenter = new DispositivoRed[4];
        datacenter[0] = new Router("10.0.0.1");
        datacenter[1] = new Switch("10.0.0.2");
        datacenter[2] = new Router("10.0.0.3");
        datacenter[3] = new Switch("10.0.0.4");

        foreach (DispositivoRed dispositivo in datacenter)
        {
            dispositivo.EjecutarDiagnostico();
        }
    }
}