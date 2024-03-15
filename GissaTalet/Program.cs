namespace GissaTalet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // objekt som används till slumpgenerering
            Random rand = new Random();

            // variabel för max antal gissningar
            int maxNumberOfGuesses;

            // variabel som innehåller den senaste gissningen. måste ha ett startvärde.
            int guess = 0;

            // variabel för det högsta talet man kan gissa
            int highestGuess;

            // variabel för talet som man ska gissa
            int randNumber;

            // variabel för antalet gånger man får gissa
            int numberOfGuesses;

            Console.WriteLine("Detta är ett spel där du ska gissa ett tal.");

            // evighetsloop där spelet startar om för alltid
            while (true) {
                // nollställ antal gissningar
                numberOfGuesses = 0;

                // fråga och läs in antal gissningar man får
                Console.Write("Hur många gissningar får man? ");
                maxNumberOfGuesses = int.Parse(Console.ReadLine());

                // fråga och läs in högsta talet
                Console.Write("Hur många tal ska man gissa på? ");
                highestGuess = int.Parse(Console.ReadLine());

                // slumpa fram talet man ska gissa på
                randNumber = rand.Next(1, highestGuess + 1);

                // starta spelet och loopa tills man gissar rätt eller har slut på gissningar
                while (guess != randNumber && numberOfGuesses < maxNumberOfGuesses) {
                    
                    // fråga och läs in en gissning
                    Console.WriteLine("Gissa ett tal mellan 1-" + highestGuess);
                    guess = int.Parse(Console.ReadLine());

                    // öka antalet gissningar
                    numberOfGuesses++;

                    // svara på gissningen
                    if (guess == randNumber)
                    {
                        Console.Write("Du gissade rätt! Bra jobbat! ");
                    }
                    else if (guess < randNumber) {
                        Console.Write("Du gissade för lågt! ");
                    }
                    else if (guess > randNumber)
                    {
                        Console.Write("Du gissade för högt! ");
                    }

                    // skriv även ut hur många gissningar det är kvar
                    Console.WriteLine((maxNumberOfGuesses - numberOfGuesses) + " gissning(ar) kvar!");
                }

                // spelet slut om slut på gissningar
                if (guess != randNumber && numberOfGuesses == maxNumberOfGuesses)
                {
                    Console.WriteLine("Slut på gissningar! Du är dålig!");
                }

                // skriv att ett nytt spel startar och lägg till en tom rad
                Console.WriteLine("Vi spelar en gång till!");
                Console.WriteLine();
            }
        }
    }
}