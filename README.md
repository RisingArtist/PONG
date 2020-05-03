# PONG
Made in Unity 2019.2

**A simple classic game of PONG**. 

*Two paddles. One ball.*

Mainly did this as a programming exercise and a way to get myself back to Unity after a long period of time away from it. It was a nice comeback project and feel good with the result. This is suppose to be a simple game and it is. Glad to not give in to any scope creep. 

In this version of **PONG**:

Inputs are based on Unity's *new input system*.
To move the paddle around, 
 * For Player 1: WASD keys...well more like W and S to go up and down, respectively.
 * For Player 2: Arrow keys. More specifically, the UP and DOWN keys. 

A little logic about the ball, it increases over time and prevents itself from going straight vertically or horizontally. To make the ball bounce around, I used a physics material called 'Bouncy' to set the friction to 0 and bounciness to 1. 

**For the code:** 

Game Manager is a singleton object that takes care of the game. It has access to the UI Manager which is responsible for the UI elements displaying and updating the UI elements. In addition, it has access to the goals and the ball. Part of the exercise is to refactor and organize code around. Keeping sections of the code more modular and following the SOLIDs principle as much as I can. 

Thank you for checking out this project. Hope you learn something code related or have a glimpse at how complex I made it seem. Lol. If you found a bug, congratulations! Good for you. Looking forward to continue more with Unity and making more projects with it! 

**OH! I tried out Unity's Github plugin. Seems nice and should use it more often. I messed up by pushing locally before trying to push remotely. Got this project up to here using the Git command lines, but can't wait to try it out again without messing up! :D**
