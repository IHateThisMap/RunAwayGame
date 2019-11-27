# RunAwayGame
 Made this in few hours. Just learning to code c# better, in mind.

Abstract
    Move 'P' with WASD, to the yellow #, as many times as you can, before your turns run out. 
    You spend a turn, every time you move.



PLAYER
    The green P. Its the Player character. You can controll it with WASD keys.

CONTROLS
    Use one of the wasd keys to move.
    Every time you move, one turn is spent.
    You have limited amount of turns.           (you can adjust this by changing "int turns" in Program.cs)
    You can adjust the maps SIZE by adjusting the "int mapHeight" in Program.cs
    And if you want, you can change the maps width to be anything you like to pretty much anything you like. Everything shoul work, as long as these values are greater than 4.

ENEMY
    The red E, is an enemy that tries to reach you. 
    It moves just every other turn. (you can adjust this by changing "int timer" in HostileObject.cs)

POINTS
    There is YELLOW # in the map. You must try and reach, if you want to get good score.
    You lose 1 point, every turn.
    Every time, you catch a POINT, you get ((room width+room height)/2) many points. And it spawns randomly somewhere in the map.