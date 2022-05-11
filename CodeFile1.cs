namespace MyApp
{
    internal class Operations
    {
        public static int Somma(int num1, int num2)
        {
            int iSomma = num1 + num2;
            return iSomma;
        }

        public static int Sottrazione(int num1, int num2)
        {
            int iSottrazione = num1 - num2;
            return iSottrazione;
        }

        public static int Prodotto(int num1, int num2)
        {
            int iProdotto = num1 * num2;
            return iProdotto;
        }

        public static decimal Divisione(int num1, int num2)
        {
            decimal iDivisione = (decimal)num1 / (decimal)num2;
            return (decimal)iDivisione;
        }

        public static int Quadrato(int num1)
        {
            int iQuadrato = num1 * num1;
            return iQuadrato;
        }

        public static decimal Media(int[] vect)
        {
            decimal iSomma = 0;
            for (int i = 0; i < vect.Length; i++)
            {
                iSomma += vect[i];
            }

            decimal fMedia = iSomma / (decimal)vect.Length;
            return fMedia;
        }

    }
}