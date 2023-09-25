using System.Text;

namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {

            //Console.WriteLine($"RecursiveOdd(1) {RecursiveOdd(1)}");
            //Console.WriteLine($"RecursiveOdd(3) {RecursiveOdd(3)}");
            //Console.WriteLine($"RecursiveOdd(5) {RecursiveOdd(5)}");

            //Console.WriteLine();

            //Console.WriteLine($"RecursiveEven(5) {RecursiveEven(1)}");
            //Console.WriteLine($"RecursiveEven(5) {RecursiveEven(3)}");
            //Console.WriteLine($"RecursiveEven(5) {RecursiveEven(5)}");

            //Console.WriteLine();

            //Console.WriteLine($"RecursiveFib(0) {RecursiveFib(0)}");
            //Console.WriteLine($"RecursiveFib(1) {RecursiveFib(1)}");
            //Console.WriteLine($"RecursiveFib(2) {RecursiveFib(2)}");
            //Console.WriteLine($"(RecursiveFib(3) {RecursiveFib(3)}");
            //Console.WriteLine($"RecursiveFib(4) {RecursiveFib(4)}");
            //Console.WriteLine($"RecursiveFib(5) {RecursiveFib(5)}");
            //Console.WriteLine($"RecursiveFib(10) {RecursiveFib(10)}");

            //Console.WriteLine();

            //Console.WriteLine($"IterativeOdd(1) {IterativeOdd(1)}");
            //Console.WriteLine($"IterativeOdd(3) {IterativeOdd(3)}");
            //Console.WriteLine($"IterativeOdd(5) {IterativeOdd(5)}");

            //Console.WriteLine();

            //Console.WriteLine($"IterativeEven(1) {IterativeEven(1)}");
            //Console.WriteLine($"IterativeEven(3) {IterativeEven(3)}");
            //Console.WriteLine($"IterativeEven(5) {IterativeEven(5)}");

            //Console.WriteLine();

            //Console.WriteLine($"IterativeFib(0) {IterativeFib(0)}");
            //Console.WriteLine($"IterativeFib(1) {IterativeFib(1)}");
            //Console.WriteLine($"IterativeFib(2) {IterativeFib(2)}");
            //Console.WriteLine($"IterativeFib(3) {IterativeFib(3)}");
            //Console.WriteLine($"IterativeFib(4) {IterativeFib(4)}");
            //Console.WriteLine($"IterativeFib(5) {IterativeFib(5)}");
            //Console.WriteLine($"IterativeFib(10) {IterativeFib(10)}");

            //Console.WriteLine();

            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParanthesis"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */
            
            List<string> list = new List<string>();
            string? input;
            bool keepShowingCommands = true;

            do
            {
                Console.WriteLine("Enter a string to add by putting a '+' infront of it.\nTo remove, do the same but start with a '-' followed by the string.\nEnter command 'q' for exit.\n");
                input = Console.ReadLine();
                char nav = input![0];
                string value = input.Substring(1);

                switch (nav)
                {
                    case '+':
                        list.Add(value);
                        Console.WriteLine($"Capacity after adding {value} to the list: {list.Capacity}\n");
                        Console.WriteLine($"Elements inside: {list.Count}\n");
                        break;
                    case '-':
                        Console.WriteLine($"Elements inside before removing: {list.Count}");
                        if (list.Remove(value))
                        {
                            Console.WriteLine($"Capacity after removing {value} to the list: {list.Capacity}\n");
                            Console.WriteLine($"Elements inside: {list.Count}\n");  
                        } 
                        else
                        {
                            Console.WriteLine($"The string {value} did not exists in list.\n");
                            Console.WriteLine($"Elements inside: {list.Count}\n");
                        }
                        break;
                    case 'q':
                        keepShowingCommands = false;
                        break;
                    default:
                        Console.WriteLine("Use only + or -.");
                        break;

                }
            } while (keepShowingCommands);
        }

        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */

            Queue<string> icaQueue = new Queue<string>();
            string? input;
            bool keepShowingCommands = true;
            do
            {
                Console.WriteLine("Enter 'enqueue' to get in the queue. Or enter 'dequeue' to remove the first person in the queue.\nCommand 'q' for exit.\n");
                input = Console.ReadLine();
                switch (input) 
                {
                    case "enqueue":
                        Console.WriteLine("Enter your name:");
                        string? name = Console.ReadLine();
                        icaQueue.Enqueue(name!);
                        Console.WriteLine($"Queue size after enqueueing {name}: {icaQueue.Count}\n");
                        break;
                    case "dequeue":
                        if (icaQueue.Count > 0)
                        {
                            icaQueue.Dequeue();
                            Console.WriteLine($"Queue size after dequeueing: {icaQueue.Count}\n");
                        }
                        else
                            Console.WriteLine("Queue is empty.\n");
                        break;
                    case "q":
                        keepShowingCommands = false;
                        break;
                    default: 
                        Console.WriteLine("Use only 'enqueue' or 'dequeue'.\n");
                        break;
                }
            } while (keepShowingCommands);
        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */
            bool keepShowingCommands = true;
            string? input;
            do
            {
                Console.WriteLine("Enter a string and get it back reversed! :D\n");
                input = Console.ReadLine(); 
                Console.WriteLine(ReverseText(input!));
            } while (keepShowingCommands);
        }

        static string ReverseText(string text)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char c in text)
            {
                stack.Push(c);
            }
            StringBuilder sb = new StringBuilder();
            while(stack.Count > 0) 
            {
                sb.Append(stack.Pop());
            }
            return sb.ToString();
        }

        /// <summary>
        /// Verifies if a set of parentheses are valid.
        /// </summary>
        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */
            Stack<char> stack = new Stack<char>();

            Console.WriteLine("Enter parentheses");
            string? input = Console.ReadLine();
            bool isValid = true;

            foreach (char c in input!)
            {
                if(c == '(')
                {
                    stack.Push(')');
                }
                else if(c == '[')
                {
                    stack.Push(']');
                }
                else if(c == '{')
                {
                    stack.Push('}');
                }
                else
                {
                    if (stack.Count == 0 || c != stack.Pop())
                    {
                        isValid = false;
                        break;
                    }
                }
            }
            
            if (stack.Count != 0)
            {
                isValid = false;
            }
            Console.WriteLine($"{input} is valid: {isValid}");
        }

        static int RecursiveOdd(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            return (RecursiveOdd(n - 1) + 2);
        }

        /// <summary>
        /// Finds the n:th even number
        /// </summary>
        /// <param name="n">the nth number</param>
        /// <returns></returns>
        static int RecursiveEven(int n)
        {
            if(n == 0) 
            {
                return 0;
            }
            return (RecursiveEven(n - 1) + 2);
        }

        /// <summary>
        /// Finds the n:th number in the fibonacci sequence with recursion
        /// </summary>
        /// <param name="n">the nth number</param>
        /// <returns></returns>
        static int RecursiveFib(int n)
        {
            if( n == 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return 1;
            }
            return (RecursiveFib(n - 1) + RecursiveFib(n - 2));
        }

        static int IterativeOdd(int n)
        {
            int result = 1;

            for(int i = 0; i < n - 1; i++) 
            {
                result += 2;
            }
            return result;
        }

        /// <summary>
        /// Finds the n:th even number
        /// </summary>
        /// <param name="n">the nth even number</param>
        /// <returns></returns>
        static int IterativeEven(int n)
        {
            int result = 0;

            for( int i = 0; i < n -1; i++)
            {
                result += 2;
            }
            return result;
        }

        /// <summary>
        /// Finds the n:th number in the fibonacci sequence with iteration
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static int IterativeFib(int n)
        {
            if(n == 0)
            {
                return 0;
            }
            if(n == 1)
            {
                return 1;
            }

            int num1 = 0;
            int num2 = 1;
            int fib = num1 + num2;
            for(int i = 2; i < n; i++)
            {
                num1 = num2;
                num2 = fib;
                fib = num1 + num2;
            }
            return fib;
        }
    }

    /* Q: Hur fungerar stacken och heapen? Förklara gärna med exempel eller skiss på dess grundläggande funktion
     * A: Stacken lagrar lokala variabler i en LIFO ordning. Så det som sist las till kan man komma åt först. Det som lagras på stacken tas bort när det inte längre används.
     *    Heapen är en dynamisk minnesallokering och där lagras värden på referens variabler, men själva variabeln lagras på stacken. 
     *    Addressen finns sedan i variablen så vi kan komma åt den. För att ta bort oanvända saker från heapen används en Garbage Collector som kollar om objektet har någon referens.
     * 
    * Q: Vad är Value Types respektive Reference Types och vad skiljer dem åt?
    * A: Value Types lagrar deras värden direkt. Reference Types lagrar en referens till dess data vilket gör att flera variabler kan ha en referens till samma data, te.x. ett objekt.
    *    Vilket gör att man kan ändra samma objekt från olika referenser. Detta kan man inte göra i en Value Type eftersom varje variabel sparar värdet direkt i sig. Så även om man
    *    sätter att en Value Type variabel är samma som en annan, och sen sätter den till ett nytt värde, kommer det inte påverka den första Value Types variabeln.
    *    En Value Type kan lagras antingen på stacken eller heapen beroende på om den ligger i en metod eller i en klass. En Reference Type lagras bara på heapen.
    *    
    * Q: Följande metoder (se bild nedan) genererar olika svar. Den första returnerar 3, den andra returnerar 4, varför?
    * A: Eftersom i den första metoden är int en Value Type. Man ändrar aldrig på x. När man säger att x = y, så gör man bara att de får samma värde (kopierar),
    *    men de sparar inte på samma värde i minnet, de har sin egna. Sen när man sätter om y = 4, påverkas fortfarande inte x då, eftersom den aldrig sätts om, och 3 returneras.
    *    I den andra metoden är MyInt x ett objekt. Man sätter då en referens, x.MyValue, till 3 och när man skapar objektet y och referar det till x, pekar de nu på samma objekt.
    *    Detta gör att y kan modifiera objektet och det ändras också på x. Dvs 4 returneras.
    *    
    * Övning 1: ExamineList()
    * Q: När ökar listans kapacitet? (Alltså den underliggande arrayens storlek)
    * A: Efter var fjärde element har lagts in i listan, och sen lägger man en ytterligare.
    * 
    * Q: Med hur mycket ökar kapaciteten?
    * A: Tvåpotens och börjar med 4, så 4, 8, 16, 32, 64...osv.
    * 
    * Q: Varför ökar inte listans kapacitet i samma takt som element läggs till?
    *    Eftersom kapaciteten är den totala antal element listan kan hålla utan att behöva ändra storlek. Kapaciteten är alltid större eller likamed Count.
    * 
    * Q: Minskar kapaciteten när element tas bort ur listan?
    *    Nej. Men man kan kalla på TrimExcess() metoden om man tycker den allokerat upp onödigt mycket kapacitet.
    *    
    * Q: När är det då fördelaktigt att använda en egendefinierad array istället för en lista?
    * A: När man vet exakt hur många element man vill lagra, så man vet exakt vilken storlek datastrukturen ska ha, och slipper resiza ofta.
    * 
    * Övning 3: ExamineStack()
    * Q: Simulera ännu en gång ICA-kön på papper. Denna gång med en stack. Varför är det inte så smart att använda en stack i det här fallet?
    * A: För att det går bara att komma åt det senast tillagda elementet/personen.
    * 
    * Rekursion och Iteration
    * Q: Utgå ifrån era nyvunna kunskaper om iteration, rekursion och minneshantering. Vilken av ovanstående funktioner är mest minnesvänlig och varför?
    * A: IterativeOdd(). Eftersom rekursion använder mer minne, eftersom varje rekursivt anrop läggs på stacken och värdena ligger kvar där tills anropningen är klar.
    *    Rekursion har också overhead, det har inte iteration.
    */
}

