using System;
using System.Linq;

namespace Grid_game
{
    class Grid_game
    {
        static void Main()
        {
            int i, j;
            int flag = 0;
            int r = 0;
            int n;
            int m;
            int[] num = new int[9] { 1, 2, 3, 4, 5, 6, 7, 0, 8 };
            int[] ans = new int[9] { 1, 2, 3, 4, 5, 6, 7, 8, 0 };
            Console.WriteLine("Welcome to the game!");
            do
            {
                flag = 0;
                r = 0;
                for (i = 0; i <= 10; i++)
                {
                    if (i == 3 || i == 7)
                    {
                        for (j = 1; j <= 16; j++)
                        {
                            Console.Write("* ");
                        }
                    }
                    else
                    {
                        if (i == 1 || i == 5 || i == 9)
                        {
                            Console.Write("   " + num[r++] + "    " + "*" + "      " + num[r++] + "      " + "*" + "  " + num[r++]);
                        }
                        else
                        {
                            Console.Write("        " + "*" + "             *");
                        }
                    }
                    Console.WriteLine("");
                }
                m = Array.IndexOf(num, 0);
                //Console.WriteLine(m);
                m = m + 1;
                Console.WriteLine("Enter the grid you want to move (1 ~ 9):");
                n = Int32.Parse(Console.ReadLine());
                switch (m)
                {
                    case 1:
                        if (n == 2 || n == 4)
                        {
                            num[0] = num[n-1];
                            num[n-1] = 0;
                        }
                        else
                        {
                            Console.WriteLine("Sorry cannot move the grid");
                            flag = -1;
                        }
                        break;
                    case 2:
                        if (n == 1 || n == 3 || n == 5)
                        {
                            num[1] = num[n-1];
                            num[n-1] = 0;
                        }
                        else
                        {
                            Console.WriteLine("Sorry cannot move the grid");
                            flag = -1;
                        }
                        break;
                    case 3:
                        if (n == 2 || n == 6)
                        {
                            num[2] = num[n-1];
                            num[n-1] = 0;
                        }
                        else
                        {
                            Console.WriteLine("Sorry cannot move the grid");
                            flag = -1;
                        }
                        break;
                    case 4:
                        if (n == 1 || n == 5 || n == 7)
                        {
                            num[3] = num[n-1];
                            num[n-1] = 0;
                        }
                        else
                        {
                            Console.WriteLine("Sorry cannot move the grid");
                            flag = -1;
                        }
                        break;
                    case 5:
                        if (n == 2 || n == 4 || n == 6 || n == 8)
                        {
                            num[4] = num[n-1];
                            num[n-1] = 0;
                        }
                        else
                        {
                            Console.WriteLine("Sorry cannot move the grid");
                            flag = -1;
                        }
                        break;
                    case 6:
                        if (n == 3 || n == 5 || n == 9)
                        {
                            num[5] = num[n-1];
                            num[n-1] = 0;
                        }
                        else
                        {
                            Console.WriteLine("Sorry cannot move the grid");
                            flag = -1;
                        }
                        break;
                    case 7:
                        if (n == 4 || n == 8)
                        {
                            num[6] = num[n-1];
                            num[n-1] = 0;
                        }
                        else
                        {
                            Console.WriteLine("Sorry cannot move the grid");
                            flag = -1;
                        }
                        break;
                    case 8:
                        if (n == 5 || n == 7 || n == 9)
                        {
                            num[7] = num[n-1];
                            num[n-1] = 0;
                        }
                        else
                        {
                            Console.WriteLine("Sorry cannot move the grid");
                            flag = -1;
                        }
                        break;
                    case 9:
                        if (n == 8 || n == 6)
                        {
                            num[8] = num[n-1];
                            num[n-1] = 0;
                        }
                        else
                        {
                            Console.WriteLine("Sorry cannot move the grid");
                            flag = -1;
                        }
                        break;
                }
                if(flag != -1)
                {
                    for (i = 0; i < 9; i++)
                    {
                        if (num[i] == ans[i])
                        {
                            flag = flag + 1;
                        }
                    }
                }
                if(flag == 9)
                {
                    break;
                }
            } while (flag != -1);
            if (flag == 9)
            {
                Console.WriteLine("Congratulations!");
            }
            else
            {
                Console.WriteLine("Game Over");
            }
        }
    }
}
