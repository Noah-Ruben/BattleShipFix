using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Noah_Ruben
{
    class ToyaBones
    {
        Label[][] board = Form1.Form1.Board[][];
        public static void Attacking()
        {
            
            int[,] SpacesShot = new int[20,20];
            int ShotsFired = 0;
            Random random = new Random();
            while (ShotsFired <21)
            {
                int column = random.Next(0 , 9);
                int row = random.Next(0 , 9);

                if (Board[row][column] )
            }

        }
    }
}
