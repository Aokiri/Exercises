// This is just a explanation in Spanish for myself about the Event concept in C#

public class Vehiculo
{
    // Declaración de un evento llamado IntentoDeRobo
    // (Se está tratando de robar un vehículo...)
    public event EventHandler IntentoDeRobo;

    // Método que acciona el evento
    // (Cuando se intenta robar un vehículo, se acciona la Alarma Antirrobos).
    public void AlarmaAntirrobos()
    {
        Console.WriteLine("La Alarma Antirrobos ha sido activada, tomando acciones...");

        // Antes de accionar el evento, se verifica si hay suscriptores (o listeners)
        // Los suscriptores (o listeners) serán la o las acciones a tomar cuando se dispare la Alarma Antirrobos
        IntentoDeRobo.Invoke(this, EventArgs.Empty);
    }
}

public class Program
{
    public static void Main()
    {
        Vehiculo carroModerno = new();

        // Suscribirse al evento, utilizando un manejador de eventos (Event Handler)
        // (Como este es un Carro Moderno, hagamos que llame a la policía cuando haya un intento de robo).
        carroModerno.IntentoDeRobo += LlamadaPolicial;

        // Accionemos el evento... (Llamemos a la policía)
        carroModerno.AlarmaAntirrobos();
    }

    // Manejador de eventos (Event Handler)
    // Definamos el método que se ejecutará cuando el accionador lo active (en este caso, la Llamada Policial).
    /* 
       NOTA: El Event Handler puede ser un delegado (suele serlo) para ejecutar más de un solo método a la vez.
       El delegado debe ser del mismo tipo y con los mismos argumentos que el método accionador.
       En este caso, nuestro Event Handler (delegado de eventos) es LlamadaPolicial.
    */
    public static void LlamadaPolicial(object sender, EventArgs e)
    {
        Console.WriteLine("Se ha detectado un intento de robo; llamando a la policía.");
    }
}