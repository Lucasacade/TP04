class Juego
{
    public static List<string> palabras {get; set;}
    public static List<char> palabraMostrar{get; set;}
    public static string palabraAdivinar{get; set;}
    public static List<char> letrasUsadas{get; set;}
    public static int intentos{get; set;}
    public static bool finalizado{get; set;}
    public static bool ganaste{get; set;}
    public static bool perdiste{get; set;}
    public static bool adivino{get; set;}

    public static void CargarPalabras()
    {
        
        string[] palabras = new string[100];

palabras[0] = "GATO";
palabras[1] = "PERRO";
palabras[2] = "ELEFANTE";
palabras[3] = "JIRAFA";
palabras[4] = "MARIPOSA";
palabras[5] = "TIGRE";
palabras[6] = "LEON";
palabras[7] = "BALLENA";
palabras[8] = "PINGUINO";
palabras[9] = "OSO";
palabras[10] = "RATON";
palabras[11] = "CABALLO";
palabras[12] = "AGUILA";
palabras[13] = "SERPIENTE";
palabras[14] = "CANGREJO";
palabras[15] = "ZORRO";
palabras[16] = "ARDILLA";
palabras[17] = "CABRA";
palabras[18] = "BURRO";
palabras[19] = "CAMELLO";
palabras[20] = "NUBE";
palabras[21] = "SOL";
palabras[22] = "LUNA";
palabras[23] = "ESTRELLA";
palabras[24] = "RIO";
palabras[25] = "MONTANA";
palabras[26] = "ARBOL";
palabras[27] = "FLOR";
palabras[28] = "HOJA";
palabras[29] = "PIEDRA";
palabras[30] = "MANZANA";
palabras[31] = "BANANA";
palabras[32] = "PERA";
palabras[33] = "UVA";
palabras[34] = "MELON";
palabras[35] = "FRESA";
palabras[36] = "KIWI";
palabras[37] = "PINA";
palabras[38] = "SANDIA";
palabras[39] = "NARANJA";
palabras[40] = "COCHE";
palabras[41] = "BICICLETA";
palabras[42] = "AVION";
palabras[43] = "TREN";
palabras[44] = "BARCO";
palabras[45] = "MOTO";
palabras[46] = "CAMION";
palabras[47] = "HELICOPTERO";
palabras[48] = "SUBMARINO";
palabras[49] = "TRACTOR";
palabras[50] = "MESA";
palabras[51] = "SILLA";
palabras[52] = "PUERTA";
palabras[53] = "VENTANA";
palabras[54] = "LAMPARA";
palabras[55] = "RELOJ";
palabras[56] = "CAMA";
palabras[57] = "ESPEJO";
palabras[58] = "ALFOMBRA";
palabras[59] = "CORTINA";
palabras[60] = "LIBRO";
palabras[61] = "CUADERNO";
palabras[62] = "LAPIZ";
palabras[63] = "BOLIGRAFO";
palabras[64] = "GOMA";
palabras[65] = "REGLA";
palabras[66] = "MOCHILA";
palabras[67] = "PAPEL";
palabras[68] = "TIJERAS";
palabras[69] = "PIZARRA";
palabras[70] = "PAN";
palabras[71] = "QUESO";
palabras[72] = "LECHE";
palabras[73] = "HUEVO";
palabras[74] = "POLLO";
palabras[75] = "PESCADO";
palabras[76] = "CARNE";
palabras[77] = "ARROZ";
palabras[78] = "PASTA";
palabras[79] = "SOPA";
palabras[80] = "ZAPATO";
palabras[81] = "CAMISA";
palabras[82] = "PANTALON";
palabras[83] = "CHAQUETA";
palabras[84] = "SOMBRERO";
palabras[85] = "CALCETIN";
palabras[86] = "FALDA";
palabras[87] = "GUANTE";
palabras[88] = "BUFANDA";
palabras[89] = "ABRIGO";
palabras[90] = "DOCTOR";
palabras[91] = "MAESTRO";
palabras[92] = "BOMBERO";
palabras[93] = "POLICIA";
palabras[94] = "PANADERO";
palabras[95] = "PINTOR";
palabras[96] = "JARDINERO";
palabras[97] = "PILOTO";
palabras[98] = "MECANICO";
palabras[99] = "FUTBOL";

        int num;
        Random r = new Random();
        num = r.Next(0, 99);
        palabraMostrar = new List<char>();
        palabraAdivinar = palabras[num];
        for(int i = 0; i < 100; i++)
        {
           palabraMostrar.Add('_');
        }
        letrasUsadas =new List<char>();
        intentos = 0;
        finalizado = false;
        ganaste = false;
        perdiste = false;
    }
    public static void ArriesgarLetra(char letraArriesgada, bool palabra)
    {
        if (letrasUsadas.Contains(letraArriesgada)) return;
        letrasUsadas.Add(letraArriesgada);
        intentos++;
        adivino = false;
        for (int i = 0; i < palabraAdivinar.Length; i++)
        {
            if (palabraAdivinar[i] == letraArriesgada)
            {
               palabraMostrar[i] = letraArriesgada;
               adivino = true;
            }
        }
        if(!adivino && !palabra)
        {
            intentos++;
        }
        if(!palabraMostrar.Contains('_'))
        {
            finalizado = true;
            ganaste = true;
        }
        if(intentos > 6)
        {
            perdiste = true; 
        }
    }
}