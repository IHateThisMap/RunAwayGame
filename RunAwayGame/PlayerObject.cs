using System;

namespace JotainMuuta
{
    class PlayerObject
    {
        public int xPos;
        public int yPos;
        /*public int width;
        public int height;*/

        public PlayerObject(int x, int y){
            xPos = x;
            yPos = y;
        }

        public void MoveWASD(int mapWidth, int mapHeight){
            char wasd;
            Console.WriteLine("Move player with WASD keys.\n\n");
            /*try { wasd = Console.ReadKey().KeyChar;}//Console.WriteLine(wasd);
            catch(Exception) { Console.WriteLine("ERROR(in obj movement)"); }//finally{ tryCount++; }*/
            wasd = Console.ReadKey().KeyChar;
            switch (wasd){
                case 'w':
                    if(yPos != 0) yPos--;
                    break;
                case 'a':
                    if(xPos != 0) xPos--;
                    break;
                case 's':
                    if(yPos != mapHeight-1) yPos++;
                    break;
                case 'd':
                    if(xPos != mapWidth-1) xPos++;
                    break;
            }

        }
    }
}