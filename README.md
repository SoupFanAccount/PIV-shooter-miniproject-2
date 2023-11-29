# PIV-shooter-Mini-Project-2

Programmering af Interaktive 3D Verdener - miniproject

Idea description
The idea of the game is to recreate the shooting mechanic of a first person shooter such as Counter Strike, Apex Legends, Call of Duty etc. except of course here the enemies just spawn near the player, rather than being other players. 
This idea is a last resolve as it is the fifth attempt at completing this project. The original idea was to combine the main mechanic of the game Minit with the trading sequence in The Legend of Zelda: Link’s Awakening. 
Minit is an adventure game where the players weapon is a cursed sword that makes the player die every 60 seconds. Every minute, the player respawns at a respawn point that can be changed throughout the game. Player inventory and quest progression are not affected by the dying, but the world is. Every enemy that has been killed, every box that has been pushed, every plant that has been hacked down etc. will respawn with the player. 
The trading sequence in Link’s Awakening has the player trade 14 different items, ending with the trade for an item necessary for finishing the game. The trades need to be made in a specific order and the progression is also dictated by the progression of the main quest. This means that some trades are not accessible before some achievement of the main quest has been made. 
The idea was that Minit can very easily be made worse by making the timer shorter (30 seconds). The quests in Minit vary and recreating them all was beyond the scope of this project, so a trading quest would have been something else for the player to do. It mainly entailed talking to NPCs. Getting to the NPCs within the time frame though and remembering who wants what, would be the challenging part.
I started working on this project at a reasonable time and got relatively far but had to start over three days before hand-in, as when I added a tilemap the transform component of multiple, but not all, GameObjects just no longer made sense, making it very hard to create interactions, and my screen started flashing black. I’m not sure what went wrong, but I think it might have been the 3D tilemap and ProBuilder disagreeing for some reason. I started over and worked on optimizing what I had already done in my first attempt but didn’t do much more as things like level-design and UI were easier to do with finished NPC interactions and perfect movement. I realized I no longer had time to finish the original idea as adjustment kept creating new problems and started working on something that could be finished in a few hours, but Unity crashed twice while working on this. It is very simple, so I don’t know why. This is what I have been able to finish.




Main parts of game
-	Player
o	Capsule moved with the WASD or arrow keys.
o	Camera in place of head being rotated around through mouse movement.
-	Enemies
o	Cube with red glowing material
o	Moving towards the player.
-	Gun
o	Placed at lower-right corner of field of vision.
Features
-	Cube spawning at random point within a radius of 10 from the player.
-	Shoots bullets when left mouse button is clicked.

Project parts
Scripts
-	FPSMovement
o	Player WASD / arrows movement and player rotation.
o	Camera rotation, restricted to 90° in each direction.
-	EnemySpawner
o	Instantiates an enemyPrefab at a random point within a circle of radius 10, around the player, at an interval of 10.
o	Attaches EnemyHealth and retrieves EnemyMovement on the instantiated enemy.
-	EnemyMovement
o	Moves enemies towards the player at a speed of 3.
-	EnemyHealth
o	Keeps track of the enemy health.
o	Reduces it when the enemy is shot.
o	Destroys the GameObject when the health <= 0.
-	ShootingScript (doesn't work)
o	Shoots bullets when left mouse button is clicked.
o	Checks time between shots and only allows shots every 0.5 seconds.
o	Checks if bullet collides with enemy and reduces its health if it does.
o	Destroys the bullet when colliding with anything.
Models
-	Player, gun, bullet- and enemy prefabs made with Unity primitive meshes.

