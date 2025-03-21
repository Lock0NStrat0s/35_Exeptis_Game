namespace _35_Exeptis_Game;

internal class Program
{
    static void Main(string[] args)
    {
        try
        {
            Random rnd = new();
            int undesirable = rnd.Next(10);
            Console.WriteLine(undesirable);
            List<int> storedNums = new();

            while (true)
            {
                int userInput;
                bool alreadyGuessed;
                do
                {
                    Console.Write("Pick a number between 0 and 9: ");
                    userInput = Convert.ToInt32(Console.ReadLine());

                    alreadyGuessed = storedNums.Contains(userInput);
                    if (alreadyGuessed) Console.WriteLine("This number has already been guessed.");
                } while (alreadyGuessed);

                if (userInput == undesirable) throw new Exception();

                storedNums.Add(userInput);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
