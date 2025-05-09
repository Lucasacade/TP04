class Palabras
{
    public static List<string> palabras {get; set;}
    public static string palabraMostrar{get; set;}
    public static string palabraAdivinar{get; set;}



    public static void CargarPalabras()
    {
        
        List<string> palabras = new List<string>();
palabras.Add("abeja");
palabras.Add("abismo");
palabras.Add("acuario");
palabras.Add("almohada");
palabras.Add("anillo");
palabras.Add("araña");
palabras.Add("árbol");
palabras.Add("avión");
palabras.Add("bailar");
palabras.Add("balanza");
palabras.Add("barco");
palabras.Add("barril");
palabras.Add("bebé");
palabras.Add("biblioteca");
palabras.Add("bicicleta");
palabras.Add("bisonte");
palabras.Add("blanco");
palabras.Add("bocina");
palabras.Add("bolsillo");
palabras.Add("botella");
palabras.Add("brújula");
palabras.Add("burbuja");
palabras.Add("caballo");
palabras.Add("cactus");
palabras.Add("cadera");
palabras.Add("café");
palabras.Add("caja");
palabras.Add("calle");
palabras.Add("cámara");
palabras.Add("camión");
palabras.Add("canción");
palabras.Add("caracol");
palabras.Add("caramelo");
palabras.Add("carpeta");
palabras.Add("castillo");
palabras.Add("cazador");
palabras.Add("cebolla");
palabras.Add("cielo");
palabras.Add("ciencia");
palabras.Add("cine");
palabras.Add("clavel");
palabras.Add("clima");
palabras.Add("cocodrilo");
palabras.Add("colina");
palabras.Add("cometa");
palabras.Add("conejo");
palabras.Add("corazón");
palabras.Add("cráter");
palabras.Add("cuchara");
palabras.Add("cuervo");
palabras.Add("dado");
palabras.Add("dedal");
palabras.Add("desierto");
palabras.Add("diamante");
palabras.Add("dibujo");
palabras.Add("dinero");
palabras.Add("dinosaurio");
palabras.Add("dormir");
palabras.Add("dragón");
palabras.Add("eco");
palabras.Add("elefante");
palabras.Add("escalera");
palabras.Add("espejo");
palabras.Add("estrella");
palabras.Add("faro");
palabras.Add("feliz");
palabras.Add("fideo");
palabras.Add("foca");
palabras.Add("fósil");
palabras.Add("fruta");
palabras.Add("fuego");
palabras.Add("futuro");
palabras.Add("gafas");
palabras.Add("gallo");
palabras.Add("gato");
palabras.Add("globo");
palabras.Add("gota");
palabras.Add("granja");
palabras.Add("helado");
palabras.Add("hielo");
palabras.Add("hormiga");
palabras.Add("hoja");
palabras.Add("iglesia");
palabras.Add("iman");
palabras.Add("invierno");
palabras.Add("isla");
palabras.Add("jirafa");
palabras.Add("juego");
palabras.Add("juguete");
palabras.Add("lago");
palabras.Add("laguna");
palabras.Add("lámpara");
palabras.Add("lengua");
palabras.Add("león");
palabras.Add("llama");
palabras.Add("lluvia");
palabras.Add("luna");
palabras.Add("mano");
palabras.Add("mariposa");
palabras.Add("melon");
palabras.Add("montaña");
palabras.Add("muñeca");
palabras.Add("nube");
palabras.Add("nuez");
palabras.Add("numero");
palabras.Add("nunca");

        int num;
        Random r = new Random();
        num = r.Next(0, palabras.Count - 1);
        palabraAdivinar = palabras[num];
    }
    public static void ArriesgarLetra(char letraArriesgada)
    {
        for (int i = 0; i < palabraAdivinar.Length; i++)
        {
            if (palabraAdivinar[i] == letraArriesgada)
            {

            }
        }
    }
}