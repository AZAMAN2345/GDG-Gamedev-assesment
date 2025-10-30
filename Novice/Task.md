 Novice Game Dev Task: "Avoid the Squares!"
Welcome to your first game development task! This is designed to be beginner-friendly and help you learn core game development concepts. Don't worry if you're new to this - we'll break it down into manageable steps.

🎯 The Goal
Create a simple game where you control a character to avoid falling squares. The game ends if you get hit.

🛠 What You'll Create
A player character (circle or square) that you can move with keyboard keys

Randomly spawning enemy squares that fall from the top

Collision detection - game ends when hit

A "Player Layer" for your character

📋 Step-by-Step Instructions
Step 1: Set Up Your Project
Create a new Unity 2D project

Create these folders in your Project window:

Scripts

Scenes

Prefabs

Step 2: Create Your Player
In the Hierarchy, right-click → 2D Object → Sprite → Square (or Circle)

Name this object "Player"

In the Inspector, find the "Layer" dropdown and click "Create New Layer..."

Name the new layer "Player Layer"

Select your Player object and assign it to the "Player Layer"

Step 3: Make Your Player Move
In the Scripts folder, create a new C# script called PlayerController

Open the script and add this basic movement code:


Attach this script to your Player object

Step 4: Create Enemy Squares
Create a new Square sprite in Hierarchy, name it "Enemy"

Give it a different color than your player (e.g., red)

Create a new script called EnemySpawner:



Step 5: Make Enemies Fall
Turn your Enemy object into a prefab by dragging it from Hierarchy to the Prefabs folder

Delete the Enemy from the Hierarchy (keep the prefab)

Create an empty GameObject called "GameManager" and attach the EnemySpawner script

Drag your Enemy prefab into the enemyPrefab slot in the Inspector

Step 6: Add Collision Detection
Add this to your PlayerController script:


Make sure your Enemy prefab has a "Enemy" tag (create one if needed)

Add Collider components to both Player and Enemy objects

Step 7: Test Your Game!
Press Play in Unity and test:

Can you move with arrow keys/WASD?

Do enemies spawn from the top?

Does the game stop when you hit an enemy?

