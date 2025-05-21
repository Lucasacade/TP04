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
    "BOTELLA", "VASO", "CUCHILLO", "TENEDOR", "CUCHARA", "PLATO", "SARTEN", "OLLA", "HORNO", "MICROONDAS",
    "REFRIGERADOR", "CONGELADOR", "ESCALERA", "TECHO", "PARED", "PISO", "ALFOMBRA", "CORTINA", "CUADRO", "LAMPARA",
    "BOMBILLA", "ENCHUFE", "CABLEADO", "INTERRUPTOR", "BALCON", "JARDIN", "CERCA", "PORTON", "GARAJE", "SOTANO",
    "DESVAN", "ASCENSOR", "PASILLO", "HABITACION", "DORMITORIO", "SALA", "COMEDOR", "OFICINA", "ESCRITORIO", "ARCHIVADOR",
    "SILLA", "BANCO", "TABURETE", "COLCHON", "ALMOHADA", "SABANA", "MANTA", "TOALLA", "DUCHA", "GRIFO",
    "ESPEJO", "PEINE", "CEPILLO", "PASTA", "JABON", "CHAMPU", "CREMA", "PERFUME", "MAQUILLAJE", "ESMALTE",
    "TIJERA", "PINZA", "AGUJA", "HILO", "BOTON", "CIERRE", "TELA", "ROPA", "ZAPATILLA", "SANDALIA",
    "BOTIN", "SOMBRERO", "GORRA", "BUFANDA", "GUANTE", "CINTURON", "RELOJ", "COLLAR", "ANILLO", "PULSERA",
    "BILLETERA", "BOLSO", "CARTERA", "MALETA", "CAMARA", "TRIPODE", "LENTE", "MEMORIA", "CARGADOR", "BATERIA",
    "RADIO", "TELEVISOR", "ANTENA", "CONTROL", "BOTON", "SEÑAL", "CABLE", "RED", "INTERNET", "SENAL"
}
;
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