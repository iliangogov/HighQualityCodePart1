namespace Kitty
{
    using System;

    internal class Solution
    {
        public static void Main()
        {
            string playingMapInput = Console.ReadLine();
            char[] playingMap = new char[playingMapInput.Length];
            for (var i = 0; i < playingMap.Length; i++)
            {
                playingMap[i] = playingMap[i];
            }

            string[] moves = Console.ReadLine().Trim().Split(' ');

            long nextPosition = 0;
            long souls = 0;
            long food = 0;
            long deadlocks = 0;
            bool locked = false;
            long jumpsCounter = 0;

            char currCell = playingMap[nextPosition];
            if (currCell == '@')
            {
                souls++;
                playingMap[nextPosition] = 'O';
            }

            if (currCell == '*')
            {
                food++;
                playingMap[nextPosition] = 'O';
            }

            if (currCell == 'x')
            {
                deadlocks++;
                if (nextPosition % 2 == 0)
                {
                    souls--;
                    playingMap[nextPosition] = '@';
                    if (souls < 0)
                    {
                        locked = true;
                    }
                }
                else
                {
                    food--;
                    playingMap[nextPosition] = '*';
                    if (food < 0)
                    {
                        locked = true;
                    }
                }
            }

            if (!locked)
            {
                for (long i = 0; i < moves.Length; i++)
                {
                    jumpsCounter++;
                    long move = long.Parse(moves[i]);
                    if (move == 0)
                    {
                        jumpsCounter--;
                        continue;
                    }

                    if (move > 0)
                    {
                        nextPosition = (nextPosition + move) % (long)playingMapInput.Length;
                    }

                    if (move < 0)
                    {
                        nextPosition = (nextPosition + move) % (long)playingMapInput.Length;
                        if (nextPosition < 0)
                        {
                            nextPosition += playingMapInput.Length;
                        }
                    }

                    currCell = playingMap[nextPosition];
                    if (currCell == '@')
                    {
                        souls++;
                        playingMap[nextPosition] = 'O';
                    }

                    if (currCell == '*')
                    {
                        food++;
                        playingMap[nextPosition] = 'O';
                    }

                    if (currCell == 'x')
                    {
                        deadlocks++;
                        if (nextPosition % 2 == 0)
                        {
                            souls--;
                            playingMap[nextPosition] = '@';
                            if (souls < 0)
                            {
                                locked = true;
                                break;
                            }
                        }
                        else
                        {
                            food--;
                            playingMap[nextPosition] = '*';
                            if (food < 0)
                            {
                                locked = true;
                                break;
                            }
                        }
                    }
                }
            }

            if (!locked)
            {
                Console.WriteLine("Coder souls collected: {0}", souls);
                Console.WriteLine("Food collected: {0}", food);
                Console.WriteLine("Deadlocks: {0}", deadlocks);
            }
            else
            {
                Console.WriteLine("You are deadlocked, you greedy kitty!");
                Console.WriteLine("Jumps before deadlock: {0}", jumpsCounter);
            }
        }
    }
}
