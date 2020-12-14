namespace Projeto_POO_Static
{
    public static class Conversor
    {
        private static float cotacaoDolar = 5.10f;

        private static float cotacaoEuro = 6.20f;

        public static float valorUsuario;


        //Conversor de Dolar para Real/Real para Dolar
        public static float ConverterDolarParaReal(){
            return valorUsuario * cotacaoDolar;
        }
        public static float ConverterRealParaDolar(){
            return valorUsuario / cotacaoDolar;
        }

        //Conversor de Euro para Real/Real para Euro
        public static float ConverterEuroParaReal(){
            return valorUsuario * cotacaoEuro;
        }
        public static float ConverterRealParaEuro(){
            return valorUsuario / cotacaoEuro;
        }
        

    }
}