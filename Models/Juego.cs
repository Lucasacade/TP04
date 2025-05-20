class Juego
{
    public static string palabraMostrar{get; set;}
    public static string palabraAdivinar{get; set;}
    public static List<char> letrasUsadas{get; set;}
    public static int cantLetras{get; set;}
    public static int intentos{get; set;}
    public static bool adivino{get; set;}

    public static string CargarPalabra()
    {
        string[] palabras = new string[]
{
    "GATO", "PERRO", "CASA", "ARBOL", "LIBRO", "ESCUELA", "SILLA", "MESA", "VENTANA", "PUERTA",
    "ZAPATO", "LAPIZ", "RELOJ", "CAMISA", "PANTALON", "CHAQUETA", "COCINA", "BAÑO", "TELEFONO", "COMPUTADORA",
    "TECLADO", "RATON", "PANTALLA", "CABLE", "AURICULAR", "CIUDAD", "PAIS", "MAPA", "PLANETA", "LUNA",
    "SOL", "ESTRELLA", "CIELO", "NUBE", "LLUVIA", "VIENTO", "FUEGO", "TIERRA", "ARENA", "MONTANA",
    "RIO", "MAR", "LAGO", "ISLA", "BOSQUE", "SELVA", "FLOR", "ARROZ", "CARNE", "PESCADO",
    "PAN", "LECHE", "HUEVO", "FRUTA", "MANZANA", "PERA", "BANANA", "NARANJA", "UVA", "ZANAHORIA",
    "LECHUGA", "PAPA", "CEBOLLA", "AJI", "AZUCAR", "SAL", "ACEITE", "VINAGRE", "COCHE", "BICICLETA",
    "AVION", "BARCO", "TREN", "CAMION", "MOTO", "TRAFICO", "CALLE", "CARRETERA", "SEMAFORO", "PUENTE",
    "TUNEL", "ESPEJO", "CRISTAL", "BOTE", "VELA", "MOTOR", "RUEDA", "BOLIGRAFO", "CUADERNO", "MOCHILA",
    "JUGUETE", "PELOTA", "MUÑECA", "ROMPECABEZAS", "PINTURA", "INSTRUMENTO", "RECREO", "PROFESOR", "ALUMNO", "TAREA"};
      Random num = new Random();
        string palabra = palabras[num.Next(palabras.Count())];
        return palabra;
    }
     public static void IniciarJuego()
    {
        letrasUsadas =new List<char>();
        intentos = 0;
        palabraAdivinar = CargarPalabra();
        cantLetras = palabraAdivinar.Length;
        palabraMostrar = new string('_', cantLetras);
}
        
    
    public static string ArriesgarLetra(char letraArriesgada)
    {
        adivino = false;
        
        for (int i = 0; i < cantLetras; i++)
        {
            if (palabraAdivinar[i].ToString().ToLower() == letraArriesgada.ToString().ToLower())
            {
                palabraMostrar = palabraMostrar.Remove(i, 1).Insert(i, letraArriesgada.ToString().ToUpper());
                adivino = true;
            }
        }

        if (adivino == false)
        {
            if (letrasUsadas.Contains(char.ToLower(letraArriesgada))==false && letrasUsadas.Contains(char.ToUpper(letraArriesgada))==false)
            {
                  letrasUsadas.Add(letraArriesgada);
                  intentos++;
            }
        }
        return palabraMostrar;

    }
    public static bool ArriesgarPalabra(string palabra)
    {
        bool adivino = false;
        if (palabra == palabraAdivinar)
        {
            adivino = true;
        }
        return adivino;
    }
}