using System;

namespace MakeAnAdventure
{
    class Program
    {
        static Random randomObject = new Random();
        static void Main(string[] args)
        {
            Console.Write("What is your name?: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}! Welcome to our story.");
            Console.WriteLine("After a long journey you finally made it to GRAND door that holds countless treasure's known to man. Do you approach it?");
            Console.Write("Type YES or NO: ");
            Console.ForegroundColor = (ConsoleColor)randomObject.Next(5);
            string noiseChoice = Console.ReadLine();
            Console.WriteLine(noiseChoice);
            if (noiseChoice == "NO")
            {
                Console.WriteLine("Really, after that long journey your just going to go back, guess you just wanted to see if it was real or not I guess...");
                Console.WriteLine("THE END.");
            }
            else if (noiseChoice == "YES")
            {
                Console.WriteLine("You walk up to the door feeling a bit nervous but, pulled through to get close to it.");
                Console.WriteLine("Do you open it or knock?");
            }
            Console.Write("Type OPEN or KNOCK: ");
            string doorChoice = Console.ReadLine();
            doorChoice = doorChoice.ToUpper();
            if (doorChoice == "KNOCK")
            {
                Console.WriteLine("A voice behind the door speaks. It says, \"Answer this riddle: \"");
                Console.WriteLine("Poor people have it. Rich people need it. If you eat it you die. What is it?");
                Console.WriteLine("Type your answer: ");
                string riddleAnswer = Console.ReadLine();
                riddleAnswer = riddleAnswer.ToUpper();
                if (riddleAnswer == "NOTHING")
                {
                    Console.WriteLine("The door opens and NOTHING is there.");
                    Console.WriteLine("All of a sudden the ground shakes and it turned out to be a trap and you were being ambushed by goblins.");
                    Console.WriteLine("Do you try to fight or run?");
                    string actionChoice = Console.ReadLine();
                    if (actionChoice == "Run")
                    {
                        Console.WriteLine("You manage to run away from the goblins, and promised yourself to never go there again.");
                        Console.WriteLine("THE END!");
                    }
                    else if (actionChoice == "Fight")
                    {
                        int randomAttack = randomObject.Next(20);
                        switch (randomAttack)
                        {
                            case 0:
                                Console.WriteLine("You rolled a 1.");
                                Console.WriteLine("As soon as the fight started, you immediately got killed.");
                                Console.WriteLine("THE END");
                                break;
                            case 1:
                                Console.WriteLine("You rolled a 2.");
                                Console.WriteLine("As soon as the fight started, you immediately got killed.");
                                Console.WriteLine("THE END");
                                break;
                            case 2:
                                Console.WriteLine("You rolled a 3.");
                                Console.WriteLine("As soon as the fight started, you immediately got killed.");
                                Console.WriteLine("THE END");
                                break;
                            case 3:
                                Console.WriteLine("You rolled a 4.");
                                Console.WriteLine("As soon as the fight started, you immediately got killed.");
                                Console.WriteLine("THE END");
                                break;
                            case 4:
                                Console.WriteLine("You rolled a 5.");
                                Console.WriteLine("As soon as the fight started, you immediately got killed.");
                                Console.WriteLine("THE END");
                                break;
                            case 5:
                                Console.WriteLine("You rolled a 6.");
                                Console.WriteLine("You managed to survive for only a little while before one killed you from behind.");
                                Console.WriteLine("THE END");
                                break;
                            case 6:
                                Console.WriteLine("You rolled a 7.");
                                Console.WriteLine("You managed to survive for only a little while before one killed you from behind.");
                                Console.WriteLine("THE END");
                                break;
                            case 7:
                                Console.WriteLine("You rolled a 8.");
                                Console.WriteLine("You managed to survive for only a little while before one killed you from behind.");
                                Console.WriteLine("THE END");
                                break;
                            case 8:
                                Console.WriteLine("You rolled a 9.");
                                Console.WriteLine("You managed to survive for only a little while before one killed you from behind.");
                                Console.WriteLine("THE END");
                                break;
                            case 9:
                                Console.WriteLine("You rolled a 10.");
                                Console.WriteLine("You successfully dealt with the goblins with a lot of injuries.");
                                Console.WriteLine("With that you head on home with adventure marked as never going there again.");
                                Console.WriteLine("THE END");
                                break;
                            case 10:
                                Console.WriteLine("You rolled a 11.");
                                Console.WriteLine("You successfully dealt with the goblins with a lot of injuries.");
                                Console.WriteLine("With that you head on home with adventure marked as never going there again.");
                                Console.WriteLine("THE END");
                                break;
                            case 11:
                                Console.WriteLine("You rolled a 12.");
                                Console.WriteLine("You successfully dealt with the goblins with a lot of injuries.");
                                Console.WriteLine("With that you head on home with adventure marked as never going there again.");
                                Console.WriteLine("THE END");
                                break;
                            case 12:
                                Console.WriteLine("You rolled a 13.");
                                Console.WriteLine("You successfully dealt with the goblins with a lot of injuries.");
                                Console.WriteLine("With that you head on home with adventure marked as never going there again.");
                                Console.WriteLine("THE END");
                                break;
                            case 13:
                                Console.WriteLine("You rolled a 14.");
                                Console.WriteLine("You successfully dealt with the goblins with a lot of injuries.");
                                Console.WriteLine("With that you head on home with adventure marked as never going there again.");
                                Console.WriteLine("THE END");
                                break;
                            case 14:
                                Console.WriteLine("You rolled a 15.");
                                Console.WriteLine("You successfully dealt with the goblins with little injuries.");
                                Console.WriteLine("With that you head on home with adventure marked as never going there again.");
                                Console.WriteLine("THE END");
                                break;
                            case 15:
                                Console.WriteLine("You rolled a 16.");
                                Console.WriteLine("You successfully dealt with the goblins with little injuries.");
                                Console.WriteLine("With that you head on home with adventure marked as never going there again.");
                                Console.WriteLine("THE END");
                                break;
                            case 16:
                                Console.WriteLine("You rolled a 17.");
                                Console.WriteLine("You successfully dealt with the goblins with little injuries.");
                                Console.WriteLine("With that you head on home with adventure marked as never going there again.");
                                Console.WriteLine("THE END");
                                break;
                            case 17:
                                Console.WriteLine("You rolled a 18.");
                                Console.WriteLine("You successfully dealt with the goblins with no injuries.");
                                Console.WriteLine("With that you head on home with adventure marked as never going there again.");
                                Console.WriteLine("THE END");
                                break;
                            case 18:
                                Console.WriteLine("You rolled a 19.");
                                Console.WriteLine("You successfully dealt with the goblins with no injuries.");
                                Console.WriteLine("With that you head on home with adventure marked as never going there again.");
                                Console.WriteLine("THE END");
                                break;
                            case 19:
                                Console.WriteLine("You rolled a 20.");
                                Console.WriteLine("You successfully dealt with the goblins with no injuries and mananged to get some loot from them as well.");
                                Console.WriteLine("With that you head on home with adventure marked as never going there again.");
                                Console.WriteLine("THE END");
                                break;
                        }
                    }
                    else if (riddleAnswer == "")
                    {
                        Console.WriteLine("You answered incorrectly. The door doesn't open.");
                        Console.WriteLine("THE END.");
                    }

                }
            }
            if (doorChoice == "OPEN")
            {
            Console.WriteLine("The door is locked! See if one of your three keys will open it.");
            Console.WriteLine("Enter a number (1-3): ");
            string keyChoice = Console.ReadLine();
            switch (keyChoice)
                {
                    case "1":
                        Console.WriteLine("You choose the first key. Lucky choice!");
                        Console.WriteLine("The door opens and NOTHING is there. Strange...");
                        Console.WriteLine("THE END.");
                        break;
                    case "2":
                        Console.WriteLine("You choose the second key. The door doesn't open.");
                        Console.WriteLine("THE END.");
                        break;
                    case "3":
                        Console.WriteLine("You choose the third key. The door doesn't open.");
                        Console.WriteLine("THE END.");
                        break;
                }
            }  
        }   
    }    
}