// See https://aka.ms/new-console-template for more information

using System.ComponentModel.Design;

Random random = new Random();
int randomNumber = random.Next(1, 10);
int userGuess = 0;
Console.WriteLine("Welcome to the guessing Game!");
Console.WriteLine("userGuess the number between 1 and 10.You have 3 attempts.");


userGuess = int.Parse(Console.ReadLine());
if (userGuess == randomNumber)
{ 
Console.WriteLine("Congratulations! You guessed the number!");


} else  { Console.WriteLine("Wrong guess. Try again!");


userGuess = int.Parse(Console.ReadLine());
if (userGuess == randomNumber) 
   

    { Console.WriteLine("Congratulations! You guessed the number!");


} else { 
    Console.WriteLine("Wrong guess. Try again!");

userGuess = int.Parse(Console.ReadLine());
if (userGuess == randomNumber)

        { Console.WriteLine("Congratulations! You guessed the number!");


  } else {
            Console.WriteLine("Sorry! You've used all your attempts. The number was" + randomNumber);
        }
    }
}




