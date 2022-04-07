//Simple number guesser written in C#
/*This program was written by a32bitmint on GitHub; you're free to use
 * the program as you'd like in your projects but please credit me!
 * Version 1.0 */
//this shows when the program boots
Main();
void Main()
{
    while (true)
    {
        int easy = 100;
        int hard = 1000;
        Console.WriteLine("Which mode would you like to play, easy or hard? (or exit to exit)");
        var mode = Console.ReadLine().ToLower();
        if (mode == "easy")
        {
            Play(easy);
        }
        else if (mode == "hard")
        {
            Play(hard);
        }
        else if (mode == "exit")
	{
		return;
	}
        else
        {
            Console.WriteLine("Whoops! That's not an option!");
        }
    }
    
}
void Play(int guessRange)
{ 
    //Generate the number
    Random rnd = new Random();
    int rand = rnd.Next(1, guessRange);
    //Generate a new counter to track the amount of times the user gets the wrong answer
    int counter = 0;
    while (true)
    {
        //DEBUG: prints the random number into the console
        //Console.WriteLine(rand);
        //Throw the prompt into console; also contains the main loop
        Console.WriteLine($"Guess a number from 1 to {guessRange}.");
        int number;
        try
        {
            number = int.Parse(Console.ReadLine());
        }
        catch(Exception e)
        {
            Console.WriteLine("You dummy, that's not a number!");
            continue;
        }
        if (number == rand) //does the number equal the one that was generated? if so, this runs
        {
            Console.WriteLine($"You guessed {number}... and won! Congrats!");
            if (counter > 0) //if the user got the number wrong at any point, print this
            {
                Console.WriteLine($"You got the answer wrong {counter} times. Try to go for a better score next time!");
            }
            return;
        }
        else //if it doesn't this set of code runs instead
        {
            if (number > rand) //determine if number is too high
            {
                Console.WriteLine("Your guess was too high!");
            }
            else if (number < rand) //determine if number is too low
            {
                Console.WriteLine("Your guess was too low!");   
            }
            counter++;
        } //the program will keep running until the correct answer is input.
    }

}

