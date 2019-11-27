using System;

namespace JotainMuuta
{
    class HostileObject
    {
        public int xPos;
        public int yPos;
        /*public int width;
        public int height;*/

        const int slowness = 1;
        int timer = 3;

        public HostileObject(int x, int y){
            xPos = x;
            yPos = y;
        }

        public void FollowXY(int targX, int targY){
            
            if(timer != 0){
                timer--;
                return;
            }else{
                timer = slowness;
                if(targX != xPos){
                    if(xPos < targX) xPos++;
                    else xPos--;
                }
                if(targY != yPos){
                    if(yPos < targY) yPos++;
                    else yPos--;
                }
            }

        }
    }
}