<!-- This is a comment so I won't forget how to do one -->

# <h1 align=center> :minidisc: 2025 Computer Tech Game Folio :minidisc: <br/> Roboto

<h3 align=center> Jeffrey Ngo

## Table of Contents :abacus:

- Gameplay Overview
- Project Information
   - General
   - Objective
- Main Features
   - Controls
   - Main Menu
   - Character Selection
      - Character 1
      - Character 2
      - Character 3
   - Enemies
- Extra Features
- Visual Sprites
- Scripting
- Video Sources
- Other

## Gameplay Overview :video_camera:

Hello

## Project Information

### General

<p align="justify"> In this game, "Roboto", you enter the game as one of three different blobs trying to steal as much money as possible from the three story bank before the time runs out. Each blob possesses two different abilities altering the games base mechanics and overall jist to the game. There are various features such as time penalties which lower the players time, making it more crucial whilst playing, and enemies that fire lasers, also lowering the player's time making it feel more engaging and fun. 

### Objective

<p align="justify"> The main objective of this game is to steal as much money as possible within the given time frame whilst trying to lose as minimal time as possible. There are different variations of money ranging from a stack of cash worth $10,000 to a diamond worth $100,000 giving more choice to the game, allowing the player to decide what the most optimal path is. The three different classes can help the player decide which style they want to play which could aid them in making quicker moves and stealing more money. After your run, you have to escape through the van before the time runs out, giving the player incentive to plan ahead of there heist so they make it back on time. Different endings depend on the amount of money you have stolen, which makes the player want to beat the game by unlocking all the endings.

## Main Features :star:

### Controls :keyboard:

**Main Menu**
| Keybind | Action |
| ----------- | ----------- |
| ← | Go Left |
| → | Go Right |
| ↓ | Go Down |
| ↑ | Go Up |
| Enter | Move |


**Keyboard**
| Keybind | Action |
| ----------- | ----------- |
| W | Walk Forward |
| A | Walk Left |
| S | Walk Down |
| D | Walk Right |
| Q | Ability 1 |
| E | Ability 2 |
| 1 | Inventory Slot 1 |
| 2 | Inventory Slot 2 |
| Space | Drop Item |

**Xbox Controller**
| Keybind | Action |
| ----------- | ----------- |
|  |  |

### Main Menu :clipboard:

<img width="865" height="349" alt="image" src="https://github.com/user-attachments/assets/f0b9fe7f-0bab-4459-99f4-0dd671a4d255" /> <br/>
Main Menu
<!-- Image of main menu -->

<p align="justify"> When opening the game, you are greeted with an intro showing year of the game, the developer and later game name all made by using Unity's animation. After the intro, you can press any key to zoom into the bullet board, which is the main menu. You then can use arrow keys and enter button to move around the bullet board to different places such as :

**Settings :** In settings, you can use the slider bar to change the start music, background music and game music <br/>
**Controls :** Controls show all the controls for the game <br/>
**Tutorial :** Shows an entire slide showing each characters abilities <br/>
**Credits :** Shows the people who made the game <br/>
**Play :** Decide which character to play

##### How I did it
<p align="justify"> It took a long time to decide on how I wanted to make for my main menu. I had alredy created a main menu before, by just following a tutorial on youtube for one of my other games to learn how unity worked, so I wanted to make something different while still in reach for making it. I then decided to create a bullet board, and since I knew how to use Unity's animation system, I was going to do that to make the camera move everytime you would press a button. Making most of the different sections were quite easy too, since most of them were just an image and some text on it (Controls, Credits). The Play section wasn't that hard either, as it only required some animations and 'yield return new WaitForSeconds' to then switch the scene. The tutorial section was just tedious as it required a massive chain of animations.

<p align="justify"> The only problem I had whilst making the menu was making it Xbox compatible. I'm not sure if we still have to do that, but I knew that trying to make it compatible with Xbox later, would've been a much bigger struggle so I decided to try and do it now. I used Unity's new input system, input maps to do it.

### Character Selection :ballot_box_with_check:

<img width="855" height="478" alt="image" src="https://github.com/user-attachments/assets/76793475-a874-47cc-9f47-6b975dc42577" /> <br/>
Character Selection
<!-- Image of character selection -->

<p align="justify"> By pressing the "Play" button in the main menu, the camera then moves down as if you are looking around the bullet board to the play section. In this section, the player then chooses between three characters each with it's own abilities changing the games mechanics. Each character chosen also changes the number of robots around the map, and the amount of damage they do, so each character isn't the exact same stuff but almost an entire new game mode the player can choose from. None of these characters are locked so the player is freely able to choose which ever character they feel like playing.

##### How I did it
<p align="justify"> Instead of recreating every single animation sheet for every single character, I just used a sprite library which allowed me to copy all of the animation frame positions and replace it with different sprites so I could change character easily. I also got a sprite resolver which allows all of the animations to work.

<p align="justify"> There was just one problem but it was a quick fix while doing this. I also did this for all my enemies in the game, but for some reason, it wouldn't work if some of the animations had more sprites than the original. Since my original sprites were four different frames, that meant that for all my other characters, I also had to make them only four frames each.

#### Character 1 : Ghost

![Ghost Demo Video](https://github.com/user-attachments/assets/73c4985d-3ea7-43ec-bc99-9c91ba3f9c8e)
Ghost Demo
<!-- Demo of character Ghost -->

<p align="justify"> "Ghost" is the first character choice in this game as changes up the game quite a lot. Most notably, it's ability too phase through anything across the whole map. The game requires you too collect items such as keycards in order to access more doors / vaults / areas of the map, but when you pick "Ghost", you can freely move around the map. But this character does have it's drawbacks such as being able to be 'one shot' by any robot in the game and a reduced timer only being 3 minutes. From the video above, I haven't implemented the unique abilities from each character yet.

#### Character 2 : Normal

![Normal Demo Video](https://github.com/user-attachments/assets/4a074f75-843e-473f-9e91-ead9229dd5cf)
Normal Demo
<!-- Demo of character Normal -->

<p align="justify"> The only completed character in my game is "Normal". This character is more like the basic character in the game, with both abiltities just being a simple dash mechanic and speed up. In this gamemode, you get five minutes to run around the bank trying to steal as much money as possible, and the robots in the game just deal damage.

#### Character 3 : Blitz

![Blitz Demo Video](https://github.com/user-attachments/assets/56b5deed-9fa4-4420-a0dc-57fb210e1131)
Blitz Demo
<!-- Just the animations for Blitz -->

<p align="justify"> "Blitz" is the final character choice in this game and is meant to be a much more quicker pace of the game. one of the mechanics that was supposed to be in this game is being able to takedown robots with your weapon which is in the first inventory slot. There were also other weapons that were meant to be in the game but they're primarily used for support. But that mechanic was never implemented into the game to Blitz is more of just a harder version of normal since the robot count is meant to be five times more than usual. "Blitz's" first ability is just a much shorter in both length and cooldown dash when compared to "Normal". But it's save to say this game mode wasn't really completed at all.

### Enemies :robot:

<img width="803" height="458" alt="image" src="https://github.com/user-attachments/assets/8210267c-19b2-491e-9fd4-550fab077060" /> <br/>
Different Enemies
<!-- All 5 different types of enemies in the game -->

<p align="justify"> In my game there are 5 different types of enemies (robots) that attack the player when they get close. All the different enemies have different detection ranges, which they will then move towards player and fire lasers at the player. The variations for each enemy was easily done by changing the attack speed, and the penalty time through the laser prefab.

#### How I did it

<img width="438" height="340" alt="image" src="https://github.com/user-attachments/assets/30b606c0-6600-4da1-9115-2dda89a0400f" /> <br/>
Functions shown in Unity
<!-- Waypoint mover script -->

<p align="justify"> All the enemies in my game run through two scripts. One for the functionality, kind of like the player movement and another script is for the laser. The animations are run exactly the same as the different players, through a sprite library.


## Extra Features

Hello

## Visual Sprites

Hello

## Scripting

**All Scipts**
- [Camera](https://github.com/TempeHS/2025CT_Jeffrey.N_name/blob/main/Assets/Scripts/Defense/Cameras.cs)
- [PowerBox](https://github.com/TempeHS/2025CT_Jeffrey.N_name/blob/main/Assets/Scripts/Defense/PowerBox.cs)
- [Bankbuilding](https://github.com/TempeHS/2025CT_Jeffrey.N_name/blob/main/Assets/Scripts/Doors/BankBuilding.cs)
- [Brown](https://github.com/TempeHS/2025CT_Jeffrey.N_name/blob/main/Assets/Scripts/Doors/BrownDoor.cs)
- [Laser](https://github.com/TempeHS/2025CT_Jeffrey.N_name/blob/main/Assets/Scripts/Enemy/Laser.cs)
- [LaserV2](https://github.com/TempeHS/2025CT_Jeffrey.N_name/blob/main/Assets/Scripts/Enemy/LaserV2.cs)
- [Waypoint Mover](https://github.com/TempeHS/2025CT_Jeffrey.N_name/blob/main/Assets/Scripts/Enemy/WayPointMover.cs)
- [Coin Controller](https://github.com/TempeHS/2025CT_Jeffrey.N_name/blob/main/Assets/Scripts/GameManager/CoinController.cs)
- [Floor Tab Controller](https://github.com/TempeHS/2025CT_Jeffrey.N_name/blob/main/Assets/Scripts/GameManager/FloorTabController.cs)
- [Game Stats](https://github.com/TempeHS/2025CT_Jeffrey.N_name/blob/main/Assets/Scripts/GameManager/GameStats.cs)
- [Inv Slot](https://github.com/TempeHS/2025CT_Jeffrey.N_name/blob/main/Assets/Scripts/GameManager/InvSlot.cs)
- [Inventory Controller](https://github.com/TempeHS/2025CT_Jeffrey.N_name/blob/main/Assets/Scripts/GameManager/InventoryController.cs)
- [Map Controller](https://github.com/TempeHS/2025CT_Jeffrey.N_name/blob/main/Assets/Scripts/GameManager/MapController.cs)
- [Menu Controller](https://github.com/TempeHS/2025CT_Jeffrey.N_name/blob/main/Assets/Scripts/GameManager/MenuController.cs)
- [Pause Controller](https://github.com/TempeHS/2025CT_Jeffrey.N_name/blob/main/Assets/Scripts/GameManager/PauseController.cs)
- [Tab Controller](https://github.com/TempeHS/2025CT_Jeffrey.N_name/blob/main/Assets/Scripts/GameManager/TabController.cs)
- [Timer Controller](https://github.com/TempeHS/2025CT_Jeffrey.N_name/blob/main/Assets/Scripts/GameManager/TimerController.cs)
- [ATM](https://github.com/TempeHS/2025CT_Jeffrey.N_name/blob/main/Assets/Scripts/Interactable/ATM%20Mach.cs)
- [Breakable Glass](https://github.com/TempeHS/2025CT_Jeffrey.N_name/blob/main/Assets/Scripts/Interactable/BreakableGlass.cs)
- [Coin Add](https://github.com/TempeHS/2025CT_Jeffrey.N_name/blob/main/Assets/Scripts/Interactable/CoinAdd.cs)
- [Door](https://github.com/TempeHS/2025CT_Jeffrey.N_name/blob/main/Assets/Scripts/Interactable/Door.cs)
- [EscapeVan](https://github.com/TempeHS/2025CT_Jeffrey.N_name/blob/main/Assets/Scripts/Interactable/EscapeVan.cs)
- [VaultV1](https://github.com/TempeHS/2025CT_Jeffrey.N_name/blob/main/Assets/Scripts/Interactable/VaultV1.cs)
- [VaultV2](https://github.com/TempeHS/2025CT_Jeffrey.N_name/blob/main/Assets/Scripts/Interactable/VaultV2.cs)
- [Item](https://github.com/TempeHS/2025CT_Jeffrey.N_name/blob/main/Assets/Scripts/Item/Item.cs)
- [JetPack](https://github.com/TempeHS/2025CT_Jeffrey.N_name/blob/main/Assets/Scripts/Item/JetPack.cs)
- [Keycard](https://github.com/TempeHS/2025CT_Jeffrey.N_name/blob/main/Assets/Scripts/Item/Keycard.cs)
- [ChooseGamemode](https://github.com/TempeHS/2025CT_Jeffrey.N_name/blob/main/Assets/Scripts/MainMenu/ChooseGameMode.cs)
- [Escape](https://github.com/TempeHS/2025CT_Jeffrey.N_name/blob/main/Assets/Scripts/MainMenu/Escape.cs)
- [Input Manager](https://github.com/TempeHS/2025CT_Jeffrey.N_name/blob/main/Assets/Scripts/MainMenu/InputManager.cs)
- [Intro](https://github.com/TempeHS/2025CT_Jeffrey.N_name/blob/main/Assets/Scripts/MainMenu/Intro.cs)
- [Start Any Key](https://github.com/TempeHS/2025CT_Jeffrey.N_name/blob/main/Assets/Scripts/MainMenu/StartAnyKey.cs)
- [Title](https://github.com/TempeHS/2025CT_Jeffrey.N_name/blob/main/Assets/Scripts/MainMenu/Title.cs)
- [Tutorial](https://github.com/TempeHS/2025CT_Jeffrey.N_name/blob/main/Assets/Scripts/MainMenu/Tutorial.cs)
- [Emergency Map Transition](https://github.com/TempeHS/2025CT_Jeffrey.N_name/blob/main/Assets/Scripts/MapTransition/EmergenMapTransition.cs)
- [Floor Map Transition](https://github.com/TempeHS/2025CT_Jeffrey.N_name/blob/main/Assets/Scripts/MapTransition/FloorMapTransition.cs)
- [Hole](https://github.com/TempeHS/2025CT_Jeffrey.N_name/blob/main/Assets/Scripts/MapTransition/Hole.cs)
- [Map Transition](https://github.com/TempeHS/2025CT_Jeffrey.N_name/blob/main/Assets/Scripts/MapTransition/MapTransition.cs)
- [Vent Map Transition](https://github.com/TempeHS/2025CT_Jeffrey.N_name/blob/main/Assets/Scripts/MapTransition/VentMapTransition.cs)
- [Vent Map Transition Time](https://github.com/TempeHS/2025CT_Jeffrey.N_name/blob/main/Assets/Scripts/MapTransition/VentMapTransitionTime.cs)
- [Coin](https://github.com/TempeHS/2025CT_Jeffrey.N_name/blob/main/Assets/Scripts/Money/Coin.cs)
- [Coin2](https://github.com/TempeHS/2025CT_Jeffrey.N_name/blob/main/Assets/Scripts/Money/Coin2.cs)
- [Game Music](https://github.com/TempeHS/2025CT_Jeffrey.N_name/blob/main/Assets/Scripts/Music/Game%20Music.cs)
- [Music Manager](https://github.com/TempeHS/2025CT_Jeffrey.N_name/blob/main/Assets/Scripts/Music/MusicManager.cs)
- [Start Music](https://github.com/TempeHS/2025CT_Jeffrey.N_name/blob/main/Assets/Scripts/Music/StartMusic.cs)
- [Player Item Pickup](https://github.com/TempeHS/2025CT_Jeffrey.N_name/blob/main/Assets/Scripts/Player/PlayerItemPickUp.cs)
- [Player Movement](https://github.com/TempeHS/2025CT_Jeffrey.N_name/blob/main/Assets/Scripts/Player/PlayerMovement.cs)

**Main Menu**

<img width="897" height="421" alt="image" src="https://github.com/user-attachments/assets/0956049b-a1e5-4cb2-a4a7-5352cd6a529d" /> <br/>
Input Map
<!-- Image of input map -->

<img width="294" height="877" alt="image" src="https://github.com/user-attachments/assets/d99e2209-d254-4a1c-a7c8-eac78b661cd2" /> <img width="326" height="877" alt="image" src="https://github.com/user-attachments/assets/50aaa75e-f4cb-40a8-9041-9ac333569b65" /> <br/>
Input Manager Script, Intro Script (Left to Right)
<!-- Input Manager Script --> <!-- Intro Script -->

<img width="1547" height="631" alt="image" src="https://github.com/user-attachments/assets/6af9d359-5fa3-49bd-b1cc-1cf6adbeb55e" /> <br/>
Input Manager Animation
<!-- Input Manager Animation -->

**Character Selection**

<img width="698" height="566" alt="image" src="https://github.com/user-attachments/assets/86a09d7e-958e-416e-8e28-30a6c12badfc" /> <br/>
Sprite Library Editor
<!-- Sprite Library Editor -->

## Video Sources

Hello

## Other

### Authors

Contributors names and contact info

ex. Mr Jones
ex. [@benpaddlejones](https://github.com/benpaddlejones)

### License

This project is licensed under the [NAME HERE] License - see the LICENSE.md file for details

### Acknowledgments

Inspiration, code snippets, etc.
* [Github md syntax](https://docs.github.com/en/get-started/writing-on-github/getting-started-with-writing-and-formatting-on-github/basic-writing-and-formatting-syntax)
* [TempeHS Unity template](https://github.com/TempeHS/TempeHS_Unity_DevContainer)
