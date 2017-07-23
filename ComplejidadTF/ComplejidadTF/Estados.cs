namespace ComplejidadTF
{
    public static class Estados
    {
        //Nodos
        public static int NO_SELECCIONADO = 0;
        public static int SELECCIONADO = 1;
        public static int DESTINO = 2;

        //Aristas
        public static int NORMAL = 0;
        public static int OPTIMO = 1;

        //Grafo
        public static int NO_COMPLETADO = 0;
        public static int COMPLETADO = 1;

        //Algoritmo
        public static int BELLMAN_FORD = 0;
        public static int KRUSKAL = 1;

        //Juego
        public static int FINALIZADO = 2;
    }
}
