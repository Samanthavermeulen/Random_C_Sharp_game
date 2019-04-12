using System;


namespace Exercise05
{
    public class Exercise04
    {
        public void randonNummer()
        {
            var random = new Random();
            var nexRandom = random.Next(1, 10);
            

            for (int i = 0; i < 4; i++)
            {
                var user = Convert.ToInt32(Console.ReadLine());


                if (i == 0)
                {
                    Console.WriteLine("First Attempt");
                    if (nexRandom == user)
                    {

                        Console.WriteLine("You win");
                        break;
                    }

                    Console.WriteLine("You lose");
                }

                if (i == 1)
                {
                    Console.WriteLine("Second Attempt");
                    if (nexRandom == user)
                    {

                        Console.WriteLine("You win");
                        break;
                    }

                    Console.WriteLine("You lose");
                }

                if (i == 2)
                {
                    Console.WriteLine("Third Attempt");
                    if (nexRandom == user)
                    {

                        Console.WriteLine("You win");
                        break;
                    }

                    Console.WriteLine("You lose");
                }



            }

        }
            
        }
    }

