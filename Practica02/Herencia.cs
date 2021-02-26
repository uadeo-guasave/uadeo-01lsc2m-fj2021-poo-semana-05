/**
 * Procesador
 * RAM
 * Monitor
 * Teclado
 * Mouse
 * Disco
 **/
using System;
class Program
{
    public static void Main(string[] args)
    {
        var procIntel = new Procesador()
        {
            Marca = "Intel",
            Modelo = "Core i5 11898",
            TipoDeComponente = "Procesador",
            Generación = "11va",
            Socket = "1200",
            Núcleos = 4,
            Velocidad = 2.4f
        };

        var ramKingston = new Ram()
        {
            Marca = "Kingston",
            Modelo = "DDR4",
            TipoDeComponente = "Memoria RAM",
            TipoDeMemoria = "DIMM",
            Capacidad = 8,
            Velocidad = 1200
        };

        Console.WriteLine("Imprimiendo procIntel");
        Console.WriteLine(procIntel);
        Console.WriteLine("Imprimiendo ramKingston");
        Console.WriteLine(ramKingston);

        Console.WriteLine("Usando método imprimir");
        Console.WriteLine(procIntel.ImprimirProcesador());
        Console.WriteLine(ramKingston.ImprimirRam());
    }
}

class ComponenteDeComputadora
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public string TipoDeComponente { get; set; }

    public override string ToString()
    {
        return $"{TipoDeComponente} {Marca}, Modelo {Modelo}";
    }

    // sobrecarga de métodos (overload)
    // sobreescritura de métodos (override)
}

class Procesador : ComponenteDeComputadora
{
    public string Generación { get; set; }
    public string Socket { get; set; }
    public int Núcleos { get; set; }
    public float Velocidad;

    public string ImprimirProcesador()
    {
        return $"Procesador {Marca} Modelo {Modelo} (hasta {Velocidad} GHz)";
    }
}

class Ram : ComponenteDeComputadora
{
    public string TipoDeMemoria { get; set; }
    public int Capacidad { get; set; }
    public int Velocidad { get; set; }

    public string ImprimirRam()
    {
        return $"Memoria {Marca} Modelo {Modelo} Capacidad {Capacidad} Velocidad {Velocidad}";
    }
}

class Monitor : ComponenteDeComputadora
{
    public int Dimensión { get; set; }
    public string TipoDeMonitor { get; set; }

    public string ImprimirMonitor()
    {
        return $"Monitor {Marca} Modelo {Modelo} Dimensión {Dimensión} Tipo {TipoDeMonitor}";
    }
}

class Disco : ComponenteDeComputadora
{
    public string TipoDeDisco { get; set; }
    public float FactorForma { get; set; }
    public int Capacidad { get; set; }
    public int Velocidad { get; set; }
    public string Interfaz { get; set; }
    public float MemoriaCache { get; set; }

    public string ImprimirDisco()
    {
        return $"Disco {Marca} Modelo {Modelo} Tipo {TipoDeDisco} Capacidad {Capacidad}";
    }
}

// TODO: Si todo es un objeto en C# ¿Cuál es el objeto Padre de todos?
// clase base
// clase Object