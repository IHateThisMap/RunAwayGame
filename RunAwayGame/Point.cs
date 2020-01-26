using System;

namespace JotainMuuta
{
    class Point
    {
        public int xPos;
        public int yPos;
        /*public int width;
        public int height;*/
        int points = 0;
        const int slowness = 5;
        int timer = 3;

        public Point(int x, int y){
            xPos = x;
            yPos = y;
        }

        public int Move(int PlayerX, int PlayerY, int mapWidth, int mapHeight){
            if(xPos == PlayerX && yPos == PlayerY){
                Random random = new Random();
                xPos = random.Next(0, mapWidth-1);
                yPos = random.Next(0, mapHeight-1);
                points += mapWidth+mapHeight/2;
            }

            if(timer != 0){
                timer--;
                points--;
            }else{
                timer = slowness;
                if(xPos > PlayerX && xPos != mapWidth-1) xPos++;
                else if(xPos < PlayerX &&  xPos != 0) xPos--;
                if(yPos > PlayerY && yPos != mapHeight-1) yPos++;
                else if(yPos < PlayerY && yPos != 0) yPos--;
            }
            return(points);
        }
    }
}