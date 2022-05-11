namespace MyApp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            /*for (char tizio = 'a'; tizio < 'z'; tizio++)
                Console.WriteLine(tizio);

            var a = "aaa"; */
            //utilizzo var <nome> per dichiarare una variabile assegnando 
            // il tipo dell'oggetto che gli sto assegnando come valore


            /*int n = 0;
            for (int i = 0; i < 256; i++)
            {
                if (n == 16)
                {
                    Console.WriteLine();
                    n = 0;
                }
                n++;
                Console.Write("{0}", Convert.ToChar(i));

                // Console.Write("{0}", (char)i); ^ uguale, si può usare tra scalari
                // casting 
            */

            "ciao;miao wow".Split(new char[] { ' ', ';' }); //crea un vettore e gli asegno i valori per cui fare lo split


            Console.WriteLine("che operazione vuoi effettuare? 0 - somma,1- prodotto, 2 - divisione, 3 - sottrazione, 4 - quadrato, 5 - media");

            int iUserMethodChoice = int.Parse(Console.ReadLine());

            int iUserNumChoice1 = 0;
            int iUserNumChoice2 = 0;
            int[] iUserNumbers;
            iUserNumbers = new int[10];

            if (iUserMethodChoice == 0 || iUserMethodChoice == 1 || iUserMethodChoice == 2 || iUserMethodChoice == 3)
            {
                Console.WriteLine("scegli due numeri");
                iUserNumChoice1 = int.Parse(Console.ReadLine());
                iUserNumChoice2 = int.Parse(Console.ReadLine());
            }
            else if (iUserMethodChoice == 4)
            {
                Console.WriteLine("scegli un numero");
                iUserNumChoice1 = int.Parse(Console.ReadLine());
            }
            else if (iUserMethodChoice == 5)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("scegli un numero");
                    int iUserChoice = 0;
                    iUserChoice = int.Parse(Console.ReadLine());
                    iUserNumbers[i] = iUserChoice;

                }

            }
            float risultato = 0;
            switch (iUserMethodChoice)
            {
                case 0:
                    risultato = MyApp.Operations.Somma(iUserNumChoice1, iUserNumChoice2);
                    Console.WriteLine("La Somma è {0}", risultato);
                    break;
                case 1:
                    risultato = MyApp.Operations.Prodotto(iUserNumChoice1, iUserNumChoice2);
                    Console.WriteLine("Il Prodotto è {0}", risultato);
                    break;
                case 2:
                    risultato = (float)MyApp.Operations.Divisione(iUserNumChoice1, iUserNumChoice2);
                    Console.WriteLine("La Divisione è {0}", risultato);
                    break;
                case 3:
                    risultato = MyApp.Operations.Sottrazione(iUserNumChoice1, iUserNumChoice2);
                    Console.WriteLine("La Sottrazione è {0}", risultato);
                    break;
                case 4:
                    risultato = MyApp.Operations.Quadrato(iUserNumChoice1);
                    Console.WriteLine("Il Quadrato è {0}", risultato);
                    break;
                case 5:
                    risultato = (float)MyApp.Operations.Media(iUserNumbers);
                    Console.WriteLine("La Media è {0}", risultato);
                    break;
            }

        }
    }

}
