/**
 * La abstracción nos ayuda a identificar las características y comportamientos
 * de los objetos que deseamos mapear al lenguaje de programación
 * Computadora
 * Tipo, marca, modelo, procesador (marca, modelo, velocidad), ram (capacidad, 
 * modelo, velocidad), disco (tipo, marca, modelo, capacidad), monitor (tipo, 
 * tamaño), sistema operativo, precio
 */

class Procesador
{
    // 1
    // private string marca;
    // public string Marca
    // {
    //     get { return marca; }
    //     set { marca = "Marca: " + value; }
    // }
    // 2
    // public string Marca { get; set; }
    // 3
    public string Marca;
    public string Modelo;
    public float Velocidad;

    public string imprimir()
    {
        return $"Procesador {Marca} {Modelo} (hasta {Velocidad} GHz)";
    }
}

// TODO: realizar la propuesta de clases para RAM, DISCO y MONITOR
