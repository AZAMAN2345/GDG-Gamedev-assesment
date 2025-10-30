Intermediate Game Dev Task: "Coin Quest Platformer"
Welcome to the intermediate challenge! This task will help you level up your skills by creating a complete platformer game with multiple levels, collectibles, and a persistent scoring system.

🎯 The Goal
Create a platformer game where the player collects coins across multiple levels, with a high score system that persists between game sessions.

🛠 What You'll Create
A player character with platformer physics (running, jumping)

Coin collectibles that increase score

Multiple levels with increasing difficulty

Scene management to transition between levels

A persistent high score system that saves between plays

A main menu and game over screen

📋 Step-by-Step Instructions
Phase 1: Project Setup & Basic Movement
Step 1: Project Foundation
Create a new Unity 2D project

Set up your folder structure:

text
/Scripts
  /Managers
  /Player
  /UI
/Scenes
/Prefabs
/Art
/Data
Step 2: Create Your Player with Platformer Physics
Create a player GameObject with Sprite Renderer and Rigidbody2D

Set Rigidbody2D: Gravity Scale = 3, Linear Drag = 0.5 (for better air control)

Add a Capsule Collider 2D for character shape

Create PlayerMovement.cs:


Step 3: Set Up Ground Detection
Create an empty child object called "GroundCheck" at the bottom of your player

Create a "Ground" layer and assign it to your platforms

In the PlayerMovement script, assign the GroundCheck transform and Ground layer

Phase 2: Gameplay Systems
Step 4: Create Coin Collectibles
Create a coin sprite (simple yellow circle works)


Make the coin a prefab

Step 5: Build Your First Level
Create platforms using tiles or sprites

Place several coins around the level

Add a "LevelEnd" trigger at the end of the level


Phase 3: Scene Management & Multiple Levels
Step 6: Create Scene Management System
Create at least 3 different level scenes:

MainMenu

Level1

Level2

Level3

GameOver


Step 7: Build Multiple Levels
Design each level with increasing difficulty:

Level 1: Basic platforms, easy coin placement

Level 2: Added obstacles, platforms that move, harder jumps

Level 3: Complex platforming challenges, timed elements

Phase 4: High Score & Data Persistence
Step 8: Create Game Manager
Create an empty GameObject called "GameManager" and make it persist between scenes:

csharp
using UnityEngine;
using UnityEngine.SceneManagement;


Step 9: Create UI System
Create a Canvas with:

Current score display

High score display

Level name display

Create UIManager.cs:

csharp
using UnityEngine;
using UnityEngine.UI;
using TMPro;


Phase 5: Polish & Completion
Step 10: Main Menu & Game Over
Create MainMenu.cs:

csharp
using UnityEngine;
using UnityEngine.UI;
using TMPro;

