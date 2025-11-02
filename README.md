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
   - Searching
   - Vents / Holes
   - Lasers and Cameras
   - Trophies
   - Keycards
   - Escape Van
- Unadded Features
   - Breakable Glass
   - The Last Melon
- Visual Sprites
- Scripting
- Video Sources
- Other

## Gameplay Overview :video_camera:

https://github.com/user-attachments/assets/72af9d8c-5fee-4da4-b31d-a3c2e5accc71
<!-- This showcase video was 95.4mb and the max was 100mb. Crazy. -->

https://github.com/user-attachments/assets/dfa51531-cbb6-4dea-b27b-dd8f0bbc543e
<!-- Every single map in the game. Looks kinda laggy though -->

## Project Information

### General

<p align="justify"> In this game, "Roboto", you enter the game as one of three different blobs trying to steal as much money as possible from the three story bank before the time runs out. Each blob possesses two different abilities altering the games base mechanics and overall jist to the game. There are various features such as time penalties which lower the players time, making it more crucial whilst playing, and enemies that fire lasers, also lowering the player's time making it feel more engaging and fun. 

### Objective

<p align="justify"> The main objective of this game is to steal as much money as possible within the given time frame whilst trying to lose as minimal time as possible. There are different variations of money ranging from a stack of cash worth $10,000 to a diamond worth $100,000 giving more choice to the game, allowing the player to decide what the most optimal path is. The three different classes can help the player decide which style they want to play which could aid them in making quicker moves and stealing more money. After your run, you have to escape through the van before the time runs out, giving the player incentive to plan ahead of there heist so they make it back on time. Different endings depend on the amount of money you have stolen, which makes the player want to beat the game by unlocking all the endings.

## Main Features :star:

### Controls :musical_keyboard:

**Keyboard :keyboard:**

Main Menu
| Keybind | Action |
| ----------- | ----------- |
| ← | Go Left |
| → | Go Right |
| ↑| Go Up |
| ↓ | Go Down |
| Enter | Submit |

Game
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
| Tab | Pause |

**Xbox Controller :video_game:**

Main Menu
| Keybind | Action |
| ----------- | ----------- |
| Left Joystick : Left | Go Left |
| Left Joystick : Right | Go Right |
| Left Joystick : Up | Go Up |
| Left Joystick : Down | Go Down |
| A | Submit |


Game
| Keybind | Action |
| ----------- | ----------- |
| Left Joystick : Forward | Walk Forward |
| Left Joystick : Left | Walk Left |
| Left Joystick : Down | Walk Down |
| Left Joystick : Right | Walk Right |
| Left Trigger | Ability 1 |
| Right Trigger | Ability 2 |
| *Unsresponsive* | Inventory Slot 1 |
| *Unresponsive* | Inventory Slot 2 |
| B | Drop Item |
| *Unresponsive* | Pause |

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

#### Character 1 : Ghost :ghost:

![Ghost Demo Video](https://github.com/user-attachments/assets/73c4985d-3ea7-43ec-bc99-9c91ba3f9c8e)
Ghost Demo
<!-- Demo of character Ghost -->

<p align="justify"> "Ghost" is the first character choice in this game as changes up the game quite a lot. Most notably, it's ability too phase through anything across the whole map. The game requires you too collect items such as keycards in order to access more doors / vaults / areas of the map, but when you pick "Ghost", you can freely move around the map. But this character does have it's drawbacks such as being able to be 'one shot' by any robot in the game and a reduced timer only being 3 minutes. From the video above, I haven't implemented the unique abilities from each character yet.

#### Character 2 : Normal :balloon:

![Normal Demo Video](https://github.com/user-attachments/assets/4a074f75-843e-473f-9e91-ead9229dd5cf)
Normal Demo
<!-- Demo of character Normal -->

<p align="justify"> The only completed character in my game is "Normal". This character is more like the basic character in the game, with both abiltities just being a simple dash mechanic and speed up. In this gamemode, you get five minutes to run around the bank trying to steal as much money as possible, and the robots in the game just deal damage.

#### Character 3 : Blitz :crossed_swords:

![Blitz Demo Video](https://github.com/user-attachments/assets/56b5deed-9fa4-4420-a0dc-57fb210e1131)
Blitz Demo
<!-- Just the animations for Blitz -->

<p align="justify"> "Blitz" is the final character choice in this game and is meant to be a much more quicker pace of the game. one of the mechanics that was supposed to be in this game is being able to takedown robots with your weapon which is in the first inventory slot. There were also other weapons that were meant to be in the game but they're primarily used for support. But that mechanic was never implemented into the game to Blitz is more of just a harder version of normal since the robot count is meant to be five times more than usual. "Blitz's" first ability is just a much shorter in both length and cooldown dash when compared to "Normal". But it's save to say this game mode wasn't really completed at all.

### Enemies :robot:

<img width="803" height="458" alt="image" src="https://github.com/user-attachments/assets/8210267c-19b2-491e-9fd4-550fab077060" /> <br/>
Different Enemies
<!-- All 5 different types of enemies in the game -->

<p align="justify"> In my game there are 5 different types of enemies (robots) that attack the player when they get close. Although each enemy functions through the same two scripts, by changing the values for each one, it makes it almost seem like they are complete different enemies. Changing the values then made it really easy to create such a fundemental mechanic towards my game, whilst being the most efficient possible. Some values that help differentiate each enemy are: detection range, attack speed, move speed, wait time between each waypoint, projectile speed, life time and penalty time (damage).

#### How I did it

<img width="438" height="327" alt="image" src="https://github.com/user-attachments/assets/30b606c0-6600-4da1-9115-2dda89a0400f" /> <img width="439" height="327" alt="image" src="https://github.com/user-attachments/assets/b6007c28-6383-424e-a5d5-aabdad63cc9c" /> <br/> 
Waypoint Mover script, Laser script (Left to Right)
<!-- Waypoint mover script, Laser script -->

<p align="justify"> All the enemies in my game run through two scripts. One for the functionality, kind of like the player movement and another script is for the laser. The animations are run exactly the same as the different players, through a sprite library. Both scripts were done by following a tutorial, which taught how to make the enemy move and create animations for the movement. 


## Extra Features :star2:

### Searching :file_cabinet:

<img width="531" height="459" alt="image" src="https://github.com/user-attachments/assets/7da8dbe4-152b-4ce7-86e7-a750e63c002a" /> <br/>
Bins outside
<!-- Example of bars above searching thing -->

<p align="justify"> Searching is one of the extra features that make the game feel so much more immersive. The game could've been made without searching, but having the player be able to search things such as mini vaults, bins and ATMs, it allows much more choice that the player can choose between when planning there heist. Keycards could also be inside things that could be searched, thanks to the inventory system that was made.

### Vents / Holes :hole:

<img width="500" height="390" alt="image" src="https://github.com/user-attachments/assets/97688276-a71c-4a3e-9cc0-60ab2ceb4053" /> <img width="500" height="390" alt="image" src="https://github.com/user-attachments/assets/474a77cd-c9e6-4daa-87cd-2de00dd43b12" /> <br/>
Showcase of a hole, Red Vent (Left to Right)
<!-- Hole, Red Vent -->

<p align="justify"> Vents / Holes are another extra feature towards the game. It allows the player to move around much more, by going through vents or holes which teleport them to another area. It makes the game feel more connected, as there are extra ways to move around the map. The difference between vents and holes are that vents have a cooldown whenever the player goes through it. Red vents also give a time penalty whenever the player goes through but have a much shorter cooldown when compared to the regular one.

### Lasers and Cameras :camera:

<img width="750" height="408" alt="image" src="https://github.com/user-attachments/assets/852726be-d326-4631-9562-ff1d40b3351f" /> <br/>
Lasers and Cameras
<!-- Why do I still do this? -->

<p align="justify"> When the player walks through a laser, they instantly get a five second time penalty. The camera gives a ten second time penalty. This was done by having a box collider set to trigger, so when the player enters the room or walks past a laser, the trigger will create the time penalty. There is also another trigger at the power box, which turns off all lasers and cameras box collider allowing the player to walk through without any penalty.

<img width="867" height="376" alt="image" src="https://github.com/user-attachments/assets/d81fd040-633b-45a6-bf92-918ac6b23eda" /> <br/>
Powerbox
<!-- Maybe I should stop doing this -->

### Trophies :trophy:

<img width="448" height="464" alt="image" src="https://github.com/user-attachments/assets/b11e82e2-69ea-4eb2-9993-5128d604d12f" /> <br/>
This room is meant to resemble C10 at Tempe High School
<!-- Trophy -->

<p align="justify"> Trophies are the most valuable item to steal in the game. This creates incentive for the player to aim for the trophies since they would make the most money in the least amount of time. Something that wasn't ever implemented into the game though was that the trophies were actually meant to be items that they player would have to carry in their inventory, and would only get the money once they escaped the van.

### Keycards :credit_card:

<img width="726" height="436" alt="image" src="https://github.com/user-attachments/assets/5c7299a0-67ee-43ef-8792-a6db62168b8c" /> <br/>
Red Keycard
<!-- Keycard -->

<p align="justify"> Keycards help put more depth into the game because the player can't access every door. The player has to navigate around the bank to get keycards and enter the vaults and rooms with the most money. Originally, the variations of keycards were double the amount in the current version, which limited the player's planning by a lot. That's why the amount of keycards are only a few, so the player still has lots of options to choose from.

### Escape Van :blue_car:

<img width="516" height="281" alt="image" src="https://github.com/user-attachments/assets/2ac33c8d-ed06-4114-87c1-73c0405a5e19" /> <br/>
Van
<!-- Escape Van -->

<p align-"justify"> The van is the only way for the player to escape in the game. After the player escapes, an ending will pop up showing the amount of money that was stolen and the remaining.

## Unadded Features :stars:

### Breakable Glass :door:

![Breakable Glass](https://github.com/user-attachments/assets/cae6fcb3-e76a-4251-9c1b-14cc562c539e) <br/>
Breakable Glass Showcase
<!-- Dash through to break glass -->

<p align="justify"> The glass door was meant to be a feature in the game that the player can only get though if they dash through the door. The functionality for the door still works as shown in the video above, but was ultimately never added into the game because the player actually teleports into the next room, making it weird if the player has to dash through two glass doors. I didn't want to spend any more time making it so two doors would break if the player dashes through it so this idea was just scrapped.


### The Last Melon :watermelon:

![DoDo Showcase](https://github.com/user-attachments/assets/f9d93da0-d579-46e7-af82-5b85801901b7) <br/>
Dodo Room Showcase
<!-- Dodo's are cool -->

<p align="justify"> The Last Melon was meant to be an easter egg towards the game, like the replica of C10, where the player would obtain the watermelon trophy. This whole feature was meant to be a reference to a scene in 'Ice Age 1' where the dodos would be fighting for the last watermelon. The player was meant to obtain a watermelon through searching bins outside the bank and place it on a pedestal. That would then trigger a hord of Dodo enemies which would chase the player and explode. The video above just shows the Dodo's animations, the watermelon item, watermelon pedestal and trophy. The room shown in the video was also meant to be the room where 'The Last Melon' would occur (books are place holders).

## Visual Sprites :paintbrush:

![Tile Palette Showcase](https://github.com/user-attachments/assets/9ecdbbcd-af20-42e3-a30f-9e281e30e8e1) <br/>
Tile Palette Showcase
<!-- Shows all the tile palette sprites -->

<p align="justify"> Most sprites in the game were added using Unity's tile palette mechanic. This allows sprites to be made like painting. My game consisted of one large map with around thirty rooms for the player to explore. Each room is filled with other sprites that were either added in by hand or by tile palette. Some of the sprites aren't shown in the tile palettes because they were functional sprites that needed to be added in by hand. Some of these items were bins that the player could search, or cameras that would make the player lose time whenever they entered the room.

#### How I did it

<p align="justify"> Most of the sprites were made in an app called 'Aseprite'. I found that this was the best tool to easily make sprites and create massive animations such as the title animation and the player selection animations. Although, I did use another app called 'Piskel' which I mainly used for all of the player and enemy animations, since they were small and repetitve too do. Overall though, the biggest problem I had was juggling between the two softwares keybinds. I originally was used to using the 'Piskel' keybinds but then switched over to asesprite as the tools were easier and better such as using the mouse scroll wheel to change the size of the brush. Some of the sprites were never added into the game such as the watermelon pedestal, because it required more coding to actually make that section of the game functional.

![All Sprites Showcase](https://github.com/user-attachments/assets/a138c037-f2ea-4db1-b0f4-ecd55e4ed875) <br/> 
All Sprite Showcase
<!-- Files in Unity -->

<img width="321" height="512" alt="image" src="https://github.com/user-attachments/assets/7b25ff97-1e0f-460b-918b-905a7a435b03" /> <br/>
Organized Files
<!-- All sprites ever made -->

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

<!-- LAST THING LEFT JUST DO THIS AND I AM DONE I HOPE I DON'T FORGET ABOUT THIS -->

## Other

### Authors

:art: Sprite Maker - Yuna Le <br/>
:computer: Developer - Jeffrey Ngo

### License

This project is licensed under the [Jeffrey Ngo] License - see the LICENSE.md file for details

### Acknowledgments

:kiwi_fruit: Music - Music sourced from BTD6, Thanks **Ninja Kiwi**
