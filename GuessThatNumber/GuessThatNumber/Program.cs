using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessThatNumber
{
    class Program
    {
    
        static void Main(string[] args)
        {    
            DisplayHighScores();

            GuessThatNumber();





            Console.ReadKey();  
        }
        static void GuessThatNumber()
        
        {



            Random rng = new Random();
        
        
        int userNum;
            Console.WriteLine("Enter a number.");
                userNum = Convert.ToInt32(Console.ReadLine());



            int randomNum = rng.Next(1, 101);
            Console.WriteLine(randomNum);
            while (userNum != randomNum)
            {


                if (userNum == randomNum)
                {
                    Console.WriteLine("Your number " + userNum + " matches");
                }
                else if (userNum > randomNum)
                {
                    Console.WriteLine("Your number " + userNum + " is to great");
                }
                else if (userNum < randomNum)
                {
                    Console.WriteLine("Your number " + userNum + "is lower than " + randomNum);
                }


            }


        
        }


        static void AddHighScore(int playerScore)
        {
            Console.WriteLine("Your name:");
            string playerName = Console.ReadLine();
            //create a gateway to the database
            OwenEntities db = new OwenEntities();
            
            //create a new high score object
            HighScore newHighScore = new HighScore();
            newHighScore.DateCreated = DateTime.Now;
            newHighScore.Game = "Guess that number";
            newHighScore.Name = playerName;
            newHighScore.Score = playerScore;

            //add it to the database
            db.HighScores.Add(newHighScore);
            
            //save our changes
            db.SaveChanges();

            

        }
        static void DisplayHighScores()
        {
            //clear the console
            Console.Clear();
            //write the High score text
            Console.WriteLine("Guess that number High Scores");
            Console.WriteLine("--------------------------------");
            //create a new connection to the database
            OwenEntities db = new OwenEntities();
            //get the highscore list
            List<HighScore>highScoreList = db.HighScores.Where(x => x.Game == "GuessThatNumber" ).OrderByDescending(x => x.Score).Take(10).ToList();

            foreach (HighScore highScore in highScoreList)
            {
                Console.WriteLine("{0}, {1} - {2} on {3}", highScoreList.IndexOf(highScore) + 1, highScore.Name, highScore.Score);
            }


        }
    }

}
