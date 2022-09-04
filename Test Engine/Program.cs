using System;

namespace Test_Engine
{
    class Program
    {
        static void Main(string[] args)
        {
            string player1 = "player1";
            string player2 = "player2";
            string player3 = "player3";
            string enemy1 = "enemy1";
            string enemy2 = "enemy2";

            Unit A = new Unit(3, player1);
            Unit B = new Unit(7, player2);
            Unit C = new Unit(5, player3);
            Unit D = new Unit(4, enemy1);
            Unit E = new Unit(1, enemy2);
            Unit Nul = new Unit();
            // ใส่ Unit ตามกลุ่ม array ต่างๆ //
            Unit[] Party = { A, B, C };
            Unit[] EnemyGroup = { D, E };

            // ใส่ element จาก Party และ EnemyGroup ใน array ของ speedDecider//
            Unit[] speedDecider = new Unit[Party.Length + EnemyGroup.Length];
            for (int i = 0; i < speedDecider.Length; i++)
            {
                if (i <= Party.Length - 1)
                    speedDecider[i] = Party[i];
                else
                    speedDecider[i] = EnemyGroup[i - Party.Length];
            }
            
            // เรียง element ใน array จากค่า speed มากไปน้อย //
            for (int c = 0; c < (speedDecider.Length - 1); c++)
            {
                for (int d = 0; d < speedDecider.Length - c - 1; d++)
                {
                    if (speedDecider[d].speed < speedDecider[d + 1].speed)
                    {
                        Nul = speedDecider[d];
                        speedDecider[d] = speedDecider[d + 1];
                        speedDecider[d + 1] = Nul;
                    }
                }
            }

            // ให้แสดงค่าจาก array ตามที่กำหนด //
            Console.WriteLine("Speed Test");
            for (int n = 0; n < speedDecider.Length;n++)
            {
                speedDecider[n].showName();
            }
            Console.ReadLine();
        }



        
    }
}
