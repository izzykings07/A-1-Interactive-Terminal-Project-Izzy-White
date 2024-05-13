namespace Interactive_Terminal_Project_Izzy_White
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //assistant setup 
            //Name setup 
            Console.WriteLine(" Hi, I am your assistant. \n Before I can help you, you'll need answer some question. \n Dont worry it shouldn't take long.");
            Console.ReadLine();

            //naming Assistant and getting player name 
            Console.WriteLine(" First you'll have to give me a name for you to call me.");
            string assistantname = Console.ReadLine();
            Console.WriteLine($" Hi my name is {assistantname}. \n My name has been save.");
            Console.ReadLine();
            Console.WriteLine(" Second I'll have to know your name. This will also be the name I'll be calling you");
            string playername = Console.ReadLine();
            Console.WriteLine($" Nice to meet you {playername}. \n Your name is save. \n Pressed Enter to continued");
            Console.ReadLine();

            //Asking question to get familer with player and assistant
            Console.WriteLine(" Now that we know each other name we will be doing the setup for us to get familer with each other. \n Pressed Enter to continued");
            Console.ReadLine();
            Console.WriteLine(" What is your favorite colour?");
            string favoritecolour = Console.ReadLine();
            Console.WriteLine($" {favoritecolour} is my favorite colour as well. \n Pressed Enter to continued");
            Console.ReadLine();

            Console.WriteLine(" what type of music do you list to?");
            string genremusic = Console.ReadLine();
            Console.WriteLine($" I have save {genremusic} as your favorite type of music. Gradully as we listen to music I'll be able to recommanded songs.\n Pressed Enter to continued");
            Console.ReadLine();

            Console.WriteLine(" What city do you live?");
            string City = Console.ReadLine();
            Console.WriteLine($" {City} has been save as your home city. \n Pressed Enter to continued");
            Console.ReadLine();

            // setting up jokes for assistant.
            Console.WriteLine(" We are half way through the setup process. \n Don't give up yet, LOL.");
            Console.ReadLine();

            Console.WriteLine(" Now we are going to setup jokes preference. cause who doesn't love to laugh. \n Pressed Enter to continued");
            Console.ReadLine();
            Console.WriteLine(" To make the setup simple you get to choose from 3 genre.");
            Console.WriteLine(" 1. Dad Joke \n 2. Dark Humor \n 3. Knock Knock Joke");
            Console.WriteLine("Choose the corresponding number.");
            string jokes = Console.ReadLine();

            // Condition statment for jokes selection 
            // THE DARK JOKES ARE JUST FOR LAUGHS AND I DO NOT MEAN ANY OF THEM !!!

            if (jokes == "1")
            {

                Console.WriteLine(" Why did the physicist and the biologist break up? Because they had no chemistry.");

            }
            else if (jokes == "2")
            { 
            
                Console.WriteLine(" You know you’re not liked when you get handed the camera every time they take a group photo.");
            
            }
            else if (jokes == "3") 
            { 
            
                Console.WriteLine(" Knock, knock.\r\n Who’s there?\r\n Anita.\r\n Anita who?\r\n Let me in! Anita borrow something.");
            
            }
            else 
            {

                Console.WriteLine(" Invalid Entry");
                    
            }
            
            Console.ReadLine();

            //Rock, Paper, Scissors Games
            
            Console.WriteLine(" For our Final set up we will play a game \n  Rock, Paper, Scissor.");
            Console.WriteLine(" Rules: \n Rock wins against scissor; paper wins against rock; and scissor wins against paper.");
            Console.WriteLine(" 1. Rock \n 2. Scissor \n 3. paper \n Choose the corresponding number.");
            
            string choice = Console.ReadLine();

            if (choice == "1") 
            { 
            
                Console.WriteLine(" I choose paper \n YOU LOSE");
            
            }
            else if (choice == "3") 
            {

                Console.WriteLine(" I choose scissor's \n YOU LOSE");
            
            }
            else if (choice == "2") 
            {

                Console.WriteLine(" I choose Paper \n YOU WIN ");    
            
            }
            else 
            { 
            
                Console.WriteLine("Invalid Entry");
            
            }
            Console.WriteLine("Pressed Enter to continued");
            Console.ReadLine();

            //Final statment
            Console.WriteLine($" YAY {playername}, you've completed the setup for your assistant");
            



            





           

                
        }
    }
}
