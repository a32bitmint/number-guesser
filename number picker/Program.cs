//Simple number guesser written in C#
/*This program was written by a32bitmint on GitHub; you're free to use
 * the program as you'd like in your projects but please credit me!
 * Version 1.0 */
Begin: //this shows when the program boots
int easy = 1;
int hard = 2;
Console.WriteLine("Which mode would you like to play, easy (1) or hard (2)?");
var mode = int.Parse(Console.ReadLine());
if (mode == easy)
{
    goto EasyMode;
}
if (mode == hard)
{
    goto HardMode;
}
//
//   EASY MODE
//
EasyMode:
//Generate the number
Random rnd = new Random();
int rand = rnd.Next(1, 100);
//Generate a new counter to track the amount of times the user gets the wrong answer
int counter = 0;
//DEBUG: prints the random number into the console
//Console.WriteLine(rand);
//Throw the prompt into console; also contains the main loop
MainLoop:
Console.WriteLine("Guess a number from 1 to 100.");
int number = int.Parse(Console.ReadLine());
if (number == rand) //does the number equal the one that was generated? if so, this runs
{
    Console.WriteLine($"You guessed {number}... and won! Congrats!");
    if (counter > 0) //if the user got the number wrong at any point, print this
    {
        Console.WriteLine($"You got the answer wrong {counter} times. Try to go for a better score next time!");
    }
    goto Begin;
}
else //if it doesn't this set of code runs instead
{
    if (number > rand) //determine if number is too high
    {
        Console.WriteLine("Your guess was too high!");
        counter = counter + 1; goto MainLoop;
    }
    if (number < rand) //determine if number is too low
    {
        Console.WriteLine("Your guess was too low!");
        counter = counter + 1; goto MainLoop;
    }
    goto Begin;
} //the program will keep running until the correct answer is input.
//
//   HARD MODE
//
HardMode:
//Generate the number
Random rndX = new Random();
int randX = rndX.Next(1, 1000);
//Generate a new counter to track the amount of times the user gets the wrong answer
int counter2 = 0;
//DEBUG: prints the random number into the console
//Console.WriteLine(randX);
//Throw the prompt into console; also contains the main loop
MainLoop2:
Console.WriteLine("Guess a number from 1 to 1000.");
int numberX = int.Parse(Console.ReadLine());
if (numberX == randX) //does the number equal the one that was generated? if so, this runs
{
    Console.WriteLine($"You guessed {numberX}... and won! Congrats!");
    if (counter2 > 0) //if the user got the number wrong at any point, print this
    {
        Console.WriteLine($"You got the answer wrong {counter2} times. Try to go for a better score next time!");
    } goto Begin;
}

else //if it doesn't this set of code runs instead
{
    if (numberX > randX) //determine if number is too high
    {
        Console.WriteLine("Your guess was too high!");
        counter2 = counter2 + 1; goto MainLoop2;
    }
    if (numberX < randX) //determine if number is too low
    {
        Console.WriteLine("Your guess was too low!");
        counter2 = counter2 + 1; goto MainLoop2;
    }
    goto Begin;
} //the program will keep running until the correct answer is input.