using System;


namespace JotainMuuta
{
    class Game
    {
        static void Main(string[] args)
        {
            int mapHeight = 10;             //näitä voi muokata oman maun mukaan paremmiksi
            int mapWidth = mapHeight*3;
            //int mapWidth = 4;
            int turns = 300;

            PlayerObject player = new PlayerObject(1, 1);
            HostileObject enemy = new HostileObject(mapWidth-2, mapHeight-2);
            Point piste = new Point(mapWidth/2+1, mapHeight/2-1);
            int points = 0;

            Console.WriteLine("\nGame Objects Created!\n");
            char[,] map = new char[mapWidth, mapHeight];
            Array.Clear(map, 0, mapWidth*mapHeight);

            map[player.xPos, player.yPos] = 'P';
            map[enemy.xPos, enemy.yPos] = 'E';
            map[piste.xPos, piste.yPos] = '#';
            drawMap(map, mapWidth, mapHeight);
            do{
                Array.Clear(map, 0, mapWidth*mapHeight);       //tyhjenetään kartta

                player.MoveWASD(mapWidth, mapHeight);                   //liikkuvat objektit liikkuu
                enemy.FollowXY(player.xPos, player.yPos);
                points = piste.Move(player.xPos, player.yPos, mapWidth, mapHeight);
                
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("          Turns left: " + turns);      //tulostetaan pisteet pelaajan näkyville
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("               Points: " + points);      //tulostetaan pisteet pelaajan näkyville
                Console.ForegroundColor = ConsoleColor.White;

                map[player.xPos, player.yPos] = 'P';        //kerrotaan kartalle, missä objektit menevät
                map[enemy.xPos, enemy.yPos] = 'E';
                map[piste.xPos, piste.yPos] = '#';

                drawMap(map, mapWidth, mapHeight);                      //kartta piirtää objektit

                turns--;                //yksi vuoro(turn) käytetty. 
                if(turns == 0){             //Tarkistetaan onko vuoroja jäljellä.
                    Console.Write("You Won the game!\n Points:" + points);
                    return;
                }

            }while (player.xPos != enemy.xPos || player.yPos != enemy.yPos);
            Console.Write("You lost.\n Dont let the enemy ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("E");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" get to you!");

        }
        static void drawMap(char[,] map, int mapWidth, int mapHeight){          //piirtää kartan
            for(int h = 0; h != mapHeight; h++){
                    for(int w = 0; w != mapWidth; w++){
                        switch(map[w, h]){
                            case 'P':
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write(map[w, h] + " ");
                                break;
                            case 'E':
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write(map[w, h] + " ");
                                break;
                            case '#':
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write(map[w, h] + " ");
                                break;
                            default:
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.Write("# ");
                                break;
                        }
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                Console.Write("\n");
            }
        }
    }
}



