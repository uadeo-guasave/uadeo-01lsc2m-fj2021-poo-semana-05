/**
 * Procesador
 * RAM
 * Monitor
 * Teclado
 * Mouse
 * Disco
 **/

class ComponenteDeComputadora
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
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
    public string Tipo { get; set; }
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
    public string Tipo { get; set; }

    public string ImprimirMonitor()
    {
        return $"Monitor {Marca} Modelo {Modelo} Dimensión {Dimensión} Tipo {Tipo}";
    }
}

class Disco
{
    public string Tipo { get; set; }
    public float FactorForma { get; set; }
    public int Capacidad { get; set; }
    public int Velocidad { get; set; }
    public string Interfaz { get; set; }
    public float MemoriaCache { get; set; }

    public string ImprimirDisco()
    {
        return $"Disco {Marca} Modelo {Modelo} Tipo {Tipo} Capacidad {Capacidad}";
    }
}

// TODO: Si todo es un objeto en C# ¿Cuál es el objeto Padre de todos?