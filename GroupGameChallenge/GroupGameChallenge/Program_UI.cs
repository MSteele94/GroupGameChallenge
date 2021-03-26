using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupGameChallenge
{
    public class Program_UI
    {
        //int player score
        //player scoretwo
        //playerscorethree
        //protected readonly PlayerPoints _playerPoints = new PlayerPoints();
        PlayerPoints _playerScore = new PlayerPoints();
        PlayerPoints _playerScoreCinema = new PlayerPoints();
        PlayerPoints _playerScoreNineties = new PlayerPoints();

        string userGuessOneNineties = "";
        string userGuessTwoNineties = "";
        string userGuessThreeNineties = "";
        string userGuessFourNineties = "";
        string userGuessFiveNineties = "";
        string userGuessSixNineties = "";



        int guessCount = 0;
        public void Run()
        {

            //pressing any key thats not 1,2,or 3 will just repeat the Run() menu. 
            //Adding players, and centering questions and text
            //Add secret levels




            Console.WriteLine("\t\t\t\t\t\tWELCOME TO OUR TRIVIA GAME " +
                               "\n\t\t\t\t\t\tThere are multiple options\n" +
                               "\t\t\tplease press (1) for history, (2) for cinema, and (3) for 90's trivia questions");
            string userPickGameInput = Console.ReadLine();
            if (userPickGameInput == "1")
            {
                RunHistory(_playerScore);
            }
            if (userPickGameInput == "2")
            {
                RunCinema(_playerScoreCinema);
            }
            if (userPickGameInput == "3")
            {
                RunNinetiesPopCulture(_playerScoreNineties);
            }
            else
            {
                Run();
            }


        }
        public void RunHistory(PlayerPoints playerScore)
        {
            Console.WriteLine("Welcome to the Histroy Game");
            Console.Clear();

            int guessCount = 0;
            int guessLimit = 1;
            string userGuessOne = "";
            string userGuessTwo = "";
            string userGuessThree = "";
            string userGuessFour = "";
            string userGuessFive = "";



            Console.WriteLine("\t\t\tYou are now playing the History Trivia Game!! Goodluck!\n" +
                                "\t\t\tPlease carefully select your answers. An invalid character\n" +
                                "\t\t\twill result in an extra deduction of points!!\n" +
                                "\t\t\t\tpress any key to start!");
            Console.ReadKey();
            bool isRunningHistory = true;
            while (isRunningHistory)
            {

                //Question One
                if (guessCount < guessLimit)
                {
                    Console.WriteLine("Question 1:\n" +
                                        "\tWhat President was responsible for Watergate\n" +
                                        "\ta. Ronald Reagan\n" +
                                        "\tb. Richard Nixon\n" +
                                        "\tc. Bill Clinton\n" +
                                        "\td. George Washington");
                    userGuessOne = Console.ReadLine();

                    switch (userGuessOne.ToUpper())
                    {
                        case "A":
                            if (userGuessOne != "B")
                            {
                                Console.WriteLine("Wrong Answer, you lose 100 points!");
                                Console.Beep();
                                Console.Beep();
                                Console.Beep();
                                Console.Beep();
                                playerScore.PlayerScore -= 100;

                            }
                            break;
                        case "B":
                            if (userGuessOne.ToUpper() == "B")
                            {
                                Console.WriteLine("That was correct!! You earn 200 points!");
                                Console.Beep();

                                playerScore.PlayerScore += 200;
                            }
                            break;

                        case "C":
                            if (userGuessOne != "B")
                            {
                                Console.WriteLine("Wrong Answer, you lose 100 points");
                                Console.Beep();
                                Console.Beep();
                                Console.Beep();
                                Console.Beep();

                                playerScore.PlayerScore -= 100;
                            }
                            break;
                        case "D":
                            if (userGuessOne != "B")
                            {
                                Console.WriteLine("Wrong Answer, you lose 100 points");
                                Console.Beep();
                                Console.Beep();
                                Console.Beep();
                                Console.Beep();

                                playerScore.PlayerScore -= 100;
                            }
                            break;
                        default:
                            Console.WriteLine("C'MON! Pay attention and pick a,b,c, or d!! For ignorance you lose 150 points");
                            playerScore.PlayerScore -= 150;
                            break;
                    }
                }
                Console.WriteLine($" You cuurent score is {playerScore.PlayerScore}");
                Console.WriteLine("Press any key to continue....");
                Console.ReadKey();
                Console.Clear();
                if (guessCount < guessLimit)
                {
                    Console.WriteLine("Question 2:\n" +
                                        "\tWhat country helped during the revolutionary war?\n" +
                                        "\ta. Great Britain\n" +
                                        "\tb. Spain\n" +
                                        "\tc. France\n" +
                                        "\td. All of the above");
                    userGuessTwo = Console.ReadLine();
                    switch (userGuessTwo.ToUpper())
                    {
                        case "A":
                            if (userGuessTwo != "C")
                            {
                                Console.WriteLine("Incorrect Answer, You lose 100 points!");
                                Console.Beep();
                                Console.Beep();
                                Console.Beep();
                                Console.Beep();
                                playerScore.PlayerScore -= 100;
                            }
                            break;
                        case "B":
                            if (userGuessTwo != "C")
                            {
                                Console.WriteLine("Incorrect Answer, You lose 100 points!");
                                Console.Beep();
                                Console.Beep();
                                Console.Beep();
                                Console.Beep();
                                playerScore.PlayerScore -= 100;
                            }
                            break;
                        case "C":
                            if (userGuessTwo.ToUpper() == "C")
                            {
                                Console.WriteLine("Your answer was correct!! You earned 200 points");
                                Console.Beep();

                                playerScore.PlayerScore += 200;
                            }
                            break;
                        case "D":
                            if (userGuessTwo != "C")
                            {
                                Console.WriteLine("Incorrect Answer,  You lose 100 points!");
                                Console.Beep();
                                Console.Beep();
                                Console.Beep();
                                Console.Beep();
                                playerScore.PlayerScore -= 100;
                            }
                            break;
                        default:
                            Console.WriteLine("C'MON! Pay attention and pick a,b,c, or d!! For ignorance you lose 150 points");
                            playerScore.PlayerScore -= 150;
                            break;

                    }
                }
                Console.ReadKey();
                Console.WriteLine($"You current score is {playerScore.PlayerScore} points!");
                Console.WriteLine("Press any key to continue....");
                Console.ReadKey();
                Console.Clear();
                if (guessCount < guessLimit)
                {
                    Console.WriteLine("Question 3:\n" +
                                        "\tWhen was the declaration of independence signed?\n" +
                                        "\ta. 1783\n" +
                                        "\tb. 1776\n" +
                                        "\tc. 1801\n" +
                                        "\td. 1925");
                    userGuessThree = Console.ReadLine();
                    switch (userGuessThree.ToUpper())
                    {
                        case "A":
                            if (userGuessThree != "B")
                            {
                                Console.WriteLine("Incorrect Answer!  You lost 100 points!");
                                Console.Beep();
                                Console.Beep();
                                Console.Beep();
                                Console.Beep();
                                playerScore.PlayerScore -= 100;
                            }
                            break;
                        case "B":
                            if (userGuessThree.ToUpper() == "B")
                            {
                                Console.WriteLine("Correct Answer, You earned 200 points!");
                                Console.Beep();

                                playerScore.PlayerScore += 200;
                            }
                            break;
                        case "C":
                            if (userGuessThree != "B")
                            {
                                Console.WriteLine("Incorrect Answer!  You lost 100 points!");
                                Console.Beep();
                                Console.Beep();
                                Console.Beep();
                                Console.Beep();
                                playerScore.PlayerScore -= 100;
                            }
                            break;
                        case "D":
                            if (userGuessThree != "B")
                            {
                                Console.WriteLine("Did you even READ the question?????? You lost 100 points!");
                                Console.Beep();
                                Console.Beep();
                                Console.Beep();
                                Console.Beep();
                                playerScore.PlayerScore -= 100;
                            }
                            break;
                        default:
                            Console.WriteLine("C'MON! Pay attention and pick a,b,c, or d!! For ignorance you lose 150 points");
                            playerScore.PlayerScore -= 150;
                            break;
                    }
                }
                Console.ReadKey();
                Console.WriteLine($"You current score is {playerScore.PlayerScore} points!");
                Console.WriteLine("Press any key to continue....");
                Console.ReadKey();
                Console.Clear();
                if (guessCount < guessLimit)
                {
                    Console.WriteLine("Question 4:\n" +
                                       "\tWho was the 2nd President of the United States?\n" +
                                       "\ta. Thomas Jefferson\n" +
                                       "\tb. Teddy Rosevelt\n" +
                                       "\tc. Thomas Edison\n" +
                                       "\td. John Adams");
                    userGuessFour = Console.ReadLine();
                    switch (userGuessFour.ToUpper())
                    {
                        case "A":
                            if (userGuessFour != "D")
                            {
                                Console.WriteLine("Incorrect Answer! You lost 100 points!");
                                Console.Beep();
                                Console.Beep();
                                Console.Beep();
                                Console.Beep();
                                playerScore.PlayerScore -= 100;
                            }
                            break;
                        case "B":
                            if (userGuessFour != "D")
                            {
                                Console.WriteLine("Incorrect Answer! You lost 100 points!");
                                Console.Beep();
                                Console.Beep();
                                Console.Beep();
                                Console.Beep();
                                playerScore.PlayerScore -= 100;
                            }
                            break;
                        case "C":
                            if (userGuessFour != "D")
                            {
                                Console.WriteLine("Incorrect Answer! You lost 100 points!");
                                Console.Beep();
                                Console.Beep();
                                Console.Beep();
                                Console.Beep();
                                playerScore.PlayerScore -= 100;
                            }
                            break;
                        case "D":
                            if (userGuessFour.ToUpper() == "D")
                            {
                                Console.WriteLine("Correct Answer! You earned 200 points!");
                                Console.Beep();

                                playerScore.PlayerScore += 200;
                            }
                            break;
                        default:
                            Console.WriteLine("C'MON! Pay attention and pick a,b,c, or d!! For ignorance you lose 150 points");
                            playerScore.PlayerScore -= 150;
                            break;
                    }
                }
                Console.ReadKey();
                Console.WriteLine($"You current score is {playerScore.PlayerScore} points!");
                Console.WriteLine("Press any key to continue....");
                Console.ReadKey();
                Console.Clear();
                if (guessCount < guessLimit)
                {
                    Console.WriteLine("Question 5:\n" +
                                       "\tWho did we overthrow in order to win to the Revolutionary War?\n" +
                                       "\ta. Marie Antoineete\n" +
                                       "\tb. King George III\n" +
                                       "\tc. Queen Elizabeth\n" +
                                       "\td. Alexander The Great");
                    userGuessFive = Console.ReadLine();
                    switch (userGuessFive.ToUpper())
                    {
                        case "A":
                            if (userGuessFive != "B")
                            {
                                Console.WriteLine("Incorrect Answer! You lost 100 points!");
                                Console.Beep();
                                Console.Beep();
                                Console.Beep();
                                Console.Beep();

                                playerScore.PlayerScore -= 100;
                            }
                            break;
                        case "B":
                            if (userGuessFive.ToUpper() == "B")
                            {
                                Console.WriteLine("Correct Answer!!!! You Earned 200 points!!");
                                Console.Beep();
                                Console.Beep();
                                Console.Beep();
                                Console.Beep();

                                playerScore.PlayerScore += 200;
                            }
                            break;
                        case "C":
                            if (userGuessFive != "B")
                            {
                                Console.WriteLine("Incorrect Answer! You lost 100 points!");
                                Console.Beep();
                                Console.Beep();
                                Console.Beep();
                                Console.Beep();
                                playerScore.PlayerScore -= 100;
                            }
                            break;
                        case "D":
                            if (userGuessFive != "B")
                            {
                                Console.WriteLine("Incorrect Answer! You lost 100 points!");
                                Console.Beep();
                                playerScore.PlayerScore -= 100;
                            }
                            break;
                        default:
                            Console.WriteLine("C'MON! Pay attention and pick a,b,c, or d!! For ignorance you lose 150 points");
                            playerScore.PlayerScore -= 150;
                            break;
                    }
                }
                Console.ReadKey();
                Console.WriteLine($"Your final score was {playerScore.PlayerScore}!!! ");
                //if (playerScore == 100)
                //{
                //    RunSecretHistoryTrivia()
                //}
                Console.WriteLine("That was the end of the History Trivia, Press any key to try again!");
                Console.ReadKey();
                Console.Clear();

                //recursion
                Run();
            }
        }
        public void RunCinema(PlayerPoints playerScore)
        {
            Console.Clear();
            Console.WriteLine("\t\t\t\t\t\tWelcome to the Cinema Game!\n" +
                                "\t\t\t\tPlease carefully select your answers. An invalid character\n" +
                                "\t\t\t\t\twill result in an extra deduction of points!!\n" +
                                "Press any key to start the game!");
            Console.ReadKey();
            Console.Clear();

            int guessCountCinema = 0;
            int guessLimitCinema = 1;

            string userGuessOneCinema = "";
            string userGuessTwoCinema = "";
            string userGuessThreeCinema = "";
            string userGuessFourCinema = "";
            string userGuessFiveCinema = "";



            bool isRunningCinema = true;
            while (isRunningCinema)
            {


                GiveMeAQuestionForAnswerC("Question 1:\n" +
                                        "\tWho was the Main Character of The NoteBook?\n" +
                                        "\ta. Leonardo DiCaprio\n" +
                                        "\tb. Jake Gyllenhaal\n" +
                                        "\tc. Ryan Gosling\n" +
                                        "\td. Brad Pitt\n", 1, playerScore, new List<string> { "Wrong Answer, you lost 100 points!", "Wrong Answer, you lost 100 points!\n"
                                        , "That was correct!! You earn 200 points!", "Wrong Answer, you lost 100 points!" }, "C");
                if (guessCountCinema < guessLimitCinema)
                {
                    Console.WriteLine("Question 2:\n" +
                                      "\tWho was the director of Pulp Fiction?\n" +
                                      "\ta. James Cameron\n" +
                                      "\tb. Quentin Tarantino\n" +
                                      "\tc. Aaron Sorkin\n" +
                                      "\td. M.Night Shyamalan");
                    userGuessTwoCinema = Console.ReadLine();
                    switch (userGuessTwoCinema.ToUpper())
                    {
                        case "A":
                            if (userGuessTwoCinema != "B")
                            {
                                Console.WriteLine("Wrong Answer, you lose 100 points!");
                                playerScore.PlayerScore -= 100;
                                Console.Beep();
                                Console.Beep();
                                Console.Beep();
                                Console.Beep();

                            }
                            break;
                        case "B":
                            if (userGuessTwoCinema.ToUpper() == "B")
                            {
                                Console.WriteLine("That was correct!! You earn 200 points!");
                                playerScore.PlayerScore += 200;
                                Console.Beep();

                            }
                            break;
                        case "C":
                            if (userGuessTwoCinema != "B")
                            {
                                Console.WriteLine("Wrong Answer, you lost 100 points!");
                                playerScore.PlayerScore -= 100;
                                Console.Beep();
                                Console.Beep();
                                Console.Beep();
                                Console.Beep();
                            }
                            break;
                        case "D":
                            if (userGuessTwoCinema != "B")
                            {
                                Console.WriteLine("Wrong Answer, you lost 100 points!");
                                playerScore.PlayerScore -= 100;
                                Console.Beep();
                                Console.Beep();
                                Console.Beep();
                                Console.Beep();
                            }
                            break;

                        default:
                            Console.WriteLine("C'MON! Pay attention and pick a,b,c, or d!! For ignorance you lose 150 points");
                            playerScore.PlayerScore -= 150;
                            break;
                    }
                    Console.ReadKey();
                    Console.WriteLine($"You current score is {playerScore.PlayerScore} points!");
                    Console.WriteLine("Press any key to continue....");
                    Console.ReadKey();
                    Console.Clear();
                }

                if (guessCountCinema < guessLimitCinema)
                {
                    Console.WriteLine("Question 3:\n" +
                                      "\tWhich of the following movies is based on a true story?\n" +
                                      "\ta. The curious case of Benjamin Button\n" +
                                      "\tb. Shawshank Redemption\n" +
                                      "\tc.Star Wars\n" +
                                      "\td. One Night in Miami");
                    userGuessThreeCinema = Console.ReadLine();
                    switch (userGuessThreeCinema.ToUpper())
                    {
                        case "A":
                            if (userGuessThreeCinema != "D")
                            {
                                Console.WriteLine("Wrong Answer, you lost 100 points!");
                                playerScore.PlayerScore -= 100;
                                Console.Beep();
                                Console.Beep();
                                Console.Beep();
                                Console.Beep();
                            }
                            break;
                        case "B":
                            if (userGuessThreeCinema != "D")
                            {
                                Console.WriteLine("Wrong Answer, you lost 100 points!");
                                playerScore.PlayerScore -= 100;
                                Console.Beep();
                                Console.Beep();
                                Console.Beep();
                                Console.Beep();
                            }
                            break;
                        case "C":
                            if (userGuessThreeCinema != "D")
                            {
                                Console.WriteLine("Wrong Answer, you lost 100 points!");
                                playerScore.PlayerScore -= 100;
                                Console.Beep();
                                Console.Beep();
                                Console.Beep();
                                Console.Beep();
                            }
                            break;
                        case "D":
                            if (userGuessThreeCinema == "D")
                            {
                                Console.WriteLine("That was correct!! You earn 200 points!");
                                playerScore.PlayerScore += 200;
                                Console.Beep();
                            }
                            break;
                        default:
                            Console.WriteLine("C'MON! Pay attention and pick a,b,c, or d!! For ignorance you lose 150 points");
                            playerScore.PlayerScore -= 150;
                            break;
                    }
                    Console.ReadKey();
                    Console.WriteLine($"You current score is {playerScore.PlayerScore} points!");
                    Console.WriteLine("Press any key to continue....");
                    Console.ReadKey();
                    Console.Clear();
                }

                if (guessCountCinema < guessLimitCinema)
                {
                    Console.WriteLine("Question 4:\n" +
                                      "\tIn 2017, who won the Oscar for Best Female Lead?\n" +
                                      "\ta. Meryl Streep\n" +
                                      "\tb. Sandra Bullock\n" +
                                      "\tc. Anna Faris\n" +
                                      "\td. Emma Stone");
                    userGuessFourCinema = Console.ReadLine();
                    switch (userGuessFourCinema.ToUpper())
                    {
                        case "A":
                            if (userGuessFourCinema != "D")
                            {
                                Console.WriteLine("Wrong Answer, you lose 100 points!");
                                playerScore.PlayerScore -= 100;
                                Console.Beep();
                                Console.Beep();
                                Console.Beep();
                                Console.Beep();
                            }
                            break;
                        case "B":
                            if (userGuessFourCinema != "D")
                            {
                                Console.WriteLine("Wrong Answer, you lose 100 points!");
                                playerScore.PlayerScore -= 100;
                                Console.Beep();
                                Console.Beep();
                                Console.Beep();
                                Console.Beep();
                            }
                            break;
                        case "C":
                            if (userGuessFourCinema != "D")
                            {
                                Console.WriteLine("Wrong Answer, you lose 100 points!");
                                playerScore.PlayerScore -= 100;
                                Console.Beep();
                                Console.Beep();
                                Console.Beep();
                                Console.Beep();
                            }
                            break;
                        case "D":
                            if (userGuessFourCinema.ToUpper() == "D")
                            {
                                Console.WriteLine("That was correct!! You earn 200 points!");
                                playerScore.PlayerScore += 200;
                                Console.Beep();
                            }
                            break;
                        default:
                            Console.WriteLine("C'MON! Pay attention and pick a,b,c, or d!! For ignorance you lose 150 points");
                            playerScore.PlayerScore -= 150;
                            break;
                    }
                    Console.ReadKey();
                    Console.WriteLine($"You current score is {playerScore.PlayerScore} points!");
                    Console.WriteLine("Press any key to continue....");
                    Console.ReadKey();
                    Console.Clear();

                }
                if (guessCountCinema < guessLimitCinema)
                {
                    Console.WriteLine("Question 5:\n" +
                                      "\tWhich of these peope hold an EGOT(Emmy, Grammy, Oscar, and Tony\n" +
                                      "\ta. John Legend\n" +
                                      "\tb. Clint Eastwood\n" +
                                      "\tc. Matt Damon\n" +
                                      "\td. Beyonce");
                    userGuessFiveCinema = Console.ReadLine();
                    switch (userGuessFiveCinema.ToUpper())
                    {
                        case "A":
                            if (userGuessFiveCinema.ToUpper() == "A")
                            {
                                Console.WriteLine("That was correct!! You earn 200 points!");
                                playerScore.PlayerScore += 200;
                                Console.Beep();
                            }
                            break;
                        case "B":
                            if (userGuessFiveCinema != "A")
                            {
                                Console.WriteLine("Wrong Answer, you lost 100 points!");
                                playerScore.PlayerScore -= 100;
                                Console.Beep();
                                Console.Beep();
                                Console.Beep();
                                Console.Beep();
                            }
                            break;
                        case "C":
                            if (userGuessFiveCinema != "A")
                            {
                                Console.WriteLine("Wrong Answer, you lost 100 points!");
                                playerScore.PlayerScore -= 100;
                                Console.Beep();
                                Console.Beep();
                                Console.Beep();
                                Console.Beep();
                            }
                            break;
                        case "D":
                            if (userGuessFiveCinema != "A")
                            {
                                Console.WriteLine("Wrong Answer, you lost 100 points!");
                                playerScore.PlayerScore -= 100;
                                Console.Beep();
                                Console.Beep();
                                Console.Beep();
                                Console.Beep();
                            }
                            break;
                        default:
                            Console.WriteLine("C'MON! Pay attention and pick a,b,c, or d!! For ignorance you lost 150 points");
                            playerScore.PlayerScore -= 150;
                            break;
                    }
                }
                Console.ReadKey();
                Console.WriteLine($"Your final score was {playerScore}. Good Job!!");
                //if (playerScore == 100)
                //{
                //    RunSecretCinemaTrivia();
                //}
                Console.WriteLine("That was the end of the History Trivia, Press any key to try again!");
                Console.ReadKey();
                Console.Clear();
                Run();
            }
        }
        public void RunNinetiesPopCulture(PlayerPoints pScore90s)
        {

            // Plan to add a secret trivia section where if playerScore equals a certain score it will activate another round of tougher questions
            //
            //
            //
            //
            //
            //
            Console.Clear();
            Console.WriteLine("\t\t\t\t\tWelcome to the 90's Pop Culture Game!\n" +
                                "\t\t\t\tPlease carefully select your answers.An invalid character\n" +
                                "\t\t\t\twill result in an extra deduction of points!!");
            Console.ReadKey();
            Console.Clear();





            bool isRunning = true;
            while (isRunning)
            {


                //Use the give me a question helper method, in the paramaters the synatax is "Our Question, the number of guesses allowed "1",

                //the playerScore, a new List<string> { "The responses to the users input" } , and finally the correct answer to the Question. Each response needs a comma

                // the correct answer at the end of our syntax is typed out as " A " or whatever the correct letter is. pulls from the switch cases we typed
                GiveMeAQuestionForAnswerB("Question 1:\n" +
                                    "How did Jennifer Lopez make her acting debut into the pop culture scene?\n" +
                                    "\ta. The George Lopez Show\n" +
                                    "\tb. Selena\n" +
                                    "\tc. Orange is the New Black\n" +
                                    "\td. Sister Sister", 1, pScore90s, new List<string> {
                                    "Sorry, That was incorrect! You lose 100 points! :( \n" +
                                    "Press any key to see your points total and to continue",
                                    "Nice!! You just earned 200 points!! :)\n" +
                                    "Press any key to see your points total and to continue ",
                                    "Sorry, That was incorrect! You lose 100 points! :( \n" +
                                    "Press any key to see your points total and to continue",
                                    "Sorry, That was incorrect! You lose 100 points! :( \n" +
                                    "Press any key to see your points total and to continue"
                                    }, "B");
                // Console.ReadKey();

                //
                GiveMeAQuestionForAnswerB("Question 2:\n" +
                                                "Complete the line.. \"Saved by the ____ \"\n" +
                                                "a. Alarm\n" +
                                                "b. Bell\n" +
                                                "c. Book\n" +
                                                "d. Club", 1, pScore90s, new List<string> {
                                                "Sorry, That was incorrect! You lose 100 points! :( \n" +
                                                "Press any key to see your points total and to continue","Nice!! You just earned 200 points!! :)\n" +
                                   "Press any key to see your points total and to continue", "Sorry, That was incorrect! You lose 100 points! :( \n" +
                                        "Press any key to see your points total and to continue\n",
                                        "Sorry, That was incorrect! You lose 100 points! :( \n" +
                                       "Press any key to see your points total and to continue"}, "B");
                //
                //
                GiveMeAQuestionForAnswerC("Question 3:\n" +
                                                "In what city did Kevin McCallister get lost?\n" +
                                                "a. Chicago\n" +
                                                "b. Los Angeles\n" +
                                                "c. New York\n" +
                                                "d. Omaha", 1, pScore90s, new List<string> {
                                                "Sorry, That was incorrect! You lose 100 points! :( \n" +
                                               "Press any key to see your points total and to continue",
                                               "Sorry, That was incorrect! You lose 100 points! :( \n" +
                                               "Press any key to see your points total and to continue\n",
                                               "Nice!! You just earned 200 points!! :)\n" +
                                               "Press any key to see your points total and to continue \n",
                                               "Sorry, That was incorrect! You lose 100 points! :( \n" +
                                               "Press any key to see your points total and to continue\n" }, "C");
                //Console.ReadKey();
                GiveMeAQuestionForAnswerA("Question 4:\n" +
                                            "Which one of these people played in both The Titanic AND Misery?\n" +
                                            "a. Kathy Bates\n" +
                                            "b. Halle Berry\n" +
                                            "c. Kate Winslet\n" +
                                            "d. Stephen King", 1, pScore90s, new List<string> {
                                            "Nice!! You just earned 200 points!! :)\n" +
                                        "Press any key to see your points total and to continue ", "Sorry, That was incorrect! You lose 100 points! :( \n" +
                                        "Press any key to see your points total and to continue" , "Sorry, That was incorrect! You lose 100 points! :( \n" +
                                        "Press any key to see your points total and to continue" , "Sorry, That was incorrect! You lose 100 points! :( \n" +
                                        "Press any key to see your points total and to continue"}, "A");

                GiveMeAQuestionForAnswerB("Question 5:\n" +
                                              "Who was the lead singer for N'Sync?\n" +
                                             "a. Nick Carter\n" +
                                             "b. Justin Timberlake\n" +
                                             "c. Lance bass\n" +
                                             "d. Stephen King", 1, pScore90s, new List<string>{
                                             "Sorry, That was incorrect! You lose 100 points! :( \n" +
                                            "Press any key to see your points total and to continue" , "Nice!! You just earned 200 points!! :)\n" +
                                            "Press any key to see your points total and to continue" , "Sorry, That was incorrect! You lose 100 points! :( \n" +
                                            "Press any key to see your points total and to continue" , "Sorry, That was incorrect! You lose 100 points! :( \n" +
                                            "Press any key to see your points total and to continue" }, "B");

                GiveMeAQuestionForAnswerA("Question 6: \n" +
                                                "Which Late Night Show host has the biggest car collection?\n" +
                                                "a. Jay Leno\n" +
                                                "b. David Letterman\n" +
                                                "c. Arseniol Hall\n" +
                                            "d. Conan O'Brien", 1, pScore90s, new List<string> {
                                      "Nice!! You just earned 200 points!! :)\n" +
                                     "Press any key to see your points total and to continue ", "Sorry, That was incorrect! You lose 100 points! :( \n" +
                                     "Press any key to see your points total and to continue" , "Sorry, That was incorrect! You lose 100 points! :( \n" +
                                    "Press any key to see your points total and to continue" , "Sorry, That was incorrect! You lose 100 points! :( \n" +
                                     "Press any key to see your points total and to continue"}, "A");
            }
        }
        private void GiveMeAQuestionForAnswerA(string MainQuestion, int guessLimit, PlayerPoints pScore90s, List<string> questions, string correctLetter)
        {


            Console.Clear();
            if (guessCount < guessLimit)
            {
                Console.WriteLine(MainQuestion);
                userGuessOneNineties = Console.ReadLine();
                CorrectForAnswerA(userGuessOneNineties, pScore90s, questions, correctLetter);
            }
            Console.ReadKey();
            Console.WriteLine($"You current score is {pScore90s.PlayerScore} points!");
            Console.WriteLine("Press any key to advance to the next question.");
            Console.ReadKey();
            Console.Clear();
        }
        private void GiveMeAQuestionForAnswerB(string MainQuestion, int guessLimit, PlayerPoints pScore90s, List<string> questions, string correctLetter)
        {
            
            
            Console.Clear();
            if (guessCount < guessLimit)
            {
                Console.WriteLine(MainQuestion);
                userGuessOneNineties = Console.ReadLine();
                CorrectForAnswerB(userGuessOneNineties, pScore90s, questions, correctLetter);
            }
            Console.ReadKey();
            Console.WriteLine($"You current score is {pScore90s.PlayerScore} points!");
            Console.WriteLine("Press any key to advance to the next question.");
            Console.ReadKey();
            Console.Clear();
        }
        private void GiveMeAQuestionForAnswerC(string MainQuestion, int guessLimit, PlayerPoints pScore90s, List<string> questions, string correctLetter)
        {


            Console.Clear();
            if (guessCount < guessLimit)
            {
                Console.WriteLine(MainQuestion);
                userGuessOneNineties = Console.ReadLine();
                CorrectForAnswerC(userGuessOneNineties, pScore90s, questions, correctLetter);
            }
            Console.ReadKey();
            Console.WriteLine($"You current score is {pScore90s.PlayerScore} points!");
            Console.WriteLine("Press any key to advance to the next question.");
            Console.ReadKey();
            Console.Clear();
        }
        //helper method

        private void CorrectForAnswerA(string userGuessOneNineties, PlayerPoints pScore90s, List<string> questions, string correctLetter)
        {
            switch (userGuessOneNineties.ToUpper())
            {
                case "A":
                    if (userGuessOneNineties.ToUpper() == correctLetter)
                    {
                        Console.WriteLine(questions[0]);
                        pScore90s.PlayerScore += 200;
                        Console.Beep();
                       
                    }
                    break;
                case "B":
                    if (userGuessOneNineties != correctLetter)
                    {
                        Console.WriteLine(questions[1]);
                        pScore90s.PlayerScore -= 100;
                        Console.Beep();
                        Console.Beep();
                        Console.Beep();
                        Console.Beep();
                    }
                    break;
                case "C":
                    if (userGuessOneNineties != correctLetter)
                    {

                        Console.WriteLine(questions[2]);
                        pScore90s.PlayerScore -= 100;
                        Console.Beep();
                        Console.Beep();
                        Console.Beep();
                        Console.Beep();
                    }
                    break;
                case "D":
                    if (userGuessOneNineties != correctLetter)
                    {

                        Console.WriteLine(questions[3]);
                        pScore90s.PlayerScore -= 100;
                        Console.Beep();
                        Console.Beep();
                        Console.Beep();
                        Console.Beep();
                    }
                    break;
                default:
                    Console.WriteLine("You lose 150 points for not paying attention to what buttons you are pressing!!!\n" +
                                        "Press any key to see your points total and to continue");
                    pScore90s.PlayerScore -= 150;
                    break;
            }
        }
        private void CorrectForAnswerB(string userGuessOneNineties, PlayerPoints pScore90s, List<string> questions, string correctLetter)
        {
            switch (userGuessOneNineties.ToUpper())
            {
                case "A":
                    if (userGuessOneNineties != correctLetter)
                    {
                        Console.WriteLine(questions[0]);
                        pScore90s.PlayerScore -= 100;
                        Console.Beep();
                        Console.Beep();
                        Console.Beep();
                        Console.Beep();
                    }
                    break;
                case "B":
                    if (userGuessOneNineties.ToUpper() == correctLetter)
                    {
                        Console.WriteLine(questions[1]);
                        pScore90s.PlayerScore += 200;
                        Console.Beep();
                    }
                    break;
                case "C":
                    if (userGuessOneNineties != correctLetter)
                    {

                        Console.WriteLine(questions[2]);
                        pScore90s.PlayerScore -= 100;
                        Console.Beep();
                        Console.Beep();
                        Console.Beep();
                        Console.Beep();
                    }
                    break;
                case "D":
                    if (userGuessOneNineties != correctLetter)
                    {

                        Console.WriteLine(questions[3]);
                        pScore90s.PlayerScore -= 100;
                        Console.Beep();
                        Console.Beep();
                        Console.Beep();
                        Console.Beep();
                    }
                    break;
                default:
                    Console.WriteLine("You lose 150 points for not paying attention to what buttons you are pressing!!!\n" +
                                        "Press any key to see your points total and to continue");
                    pScore90s.PlayerScore -= 150;
                    break;
            }
        }
        private void CorrectForAnswerC(string userGuessOneNineties, PlayerPoints pScore90s, List<string> questions, string correctLetter)
        {
            switch (userGuessOneNineties.ToUpper())
            {
                case "A":
                    if (userGuessOneNineties != correctLetter)
                    {
                        Console.WriteLine(questions[0]);
                        pScore90s.PlayerScore -= 100;
                        Console.Beep();
                        Console.Beep();
                        Console.Beep();
                        Console.Beep();
                    }
                    break;
                case "B":
                    if (userGuessOneNineties != correctLetter)
                    {
                        Console.WriteLine(questions[1]);
                        pScore90s.PlayerScore -= 100;
                        Console.Beep();
                        Console.Beep();
                        Console.Beep();
                        Console.Beep();
                    }
                    break;
                case "C":
                    if (userGuessOneNineties.ToUpper() == correctLetter)
                    {

                        Console.WriteLine(questions[2]);
                        pScore90s.PlayerScore += 200;
                        Console.Beep();
                        
                    }
                    break;
                case "D":
                    if (userGuessOneNineties != correctLetter)
                    {

                        Console.WriteLine(questions[3]);
                        pScore90s.PlayerScore -= 100;
                        Console.Beep();
                        Console.Beep();
                        Console.Beep();
                        Console.Beep();
                    }
                    break;
                default:
                    Console.WriteLine("You lose 150 points for not paying attention to what buttons you are pressing!!!\n" +
                                        "Press any key to see your points total and to continue");
                    pScore90s.PlayerScore -= 150;
                    break;
            }
        }
    }
}

