# Lab 1 Assignment
This project is done as part of the Lab 1 assignment for IMTC 505 course.
Unity 2022.3.46f1 is used.

## Description
The goal of this project was to implement several interactive elements to explore and learn Unity. Please refer to the Table of Content an d the subsequest sections for further details.

## Video Demo
The video demonstrates all of the created elements in the project.

[![Lab 1 Video Demo](https://img.youtube.com/vi/8yEMFoMFF1g/0.jpg)](https://youtu.be/8yEMFoMFF1g))

## Table of Contents
- [Rescaling Cube](#rescaling-cube)
- [Floating Sphere](#floating-sphere)
- [Cylinder Grabbing](#cylinder-grabbing)
- [Catch the Cubes: mini-game](#catch-the-cubes-mini-game)
- [Bonus Objective](#bonus-objective)
- [UI Menu](#ui-menu)


## Rescaling Cube
A simple cube object is placed in the scene, upon playing the game - the scale of the object is changing, i.e. it is growing and then shrinking. Customization from the Unity Inspect menu is added, so the user may edit the speed of scaling, anbd also the scale increase (how much from the original size, the cube would grow or srink). Furthermore,the color change is added. At first, the cube's color is between white and black, but the user may choose any two colors, and the colors transition speed can also be adjusted.

## Floating Sphere
A sphere is added to the scene, and upon playing it moves in the XY plane usingh WASD or arrow keys. The space button on the keyboard resets the object's position (to the origin).

## Cylinder Grabbing
An interection with the computer mouse is investigated. A yellow cylinder is placed in the middle, and its movement is limited to XY plane. The mouse left-click on the cylinder is detected, and it allows to drag the cylinder around the game screen.

## Catch the Cubes: mini-game
This interactive "element" resembles a demo for a mini game. The small cubes are generated at the random locations at the top of the screen. Meanwhile at the botton, the user controls a platform with the A and D buttons to move left and right to try and catch these falling cubes. Upon collision ('catching') of the cube by the platform, the cube disappears shortly. 

## Bonus Objective
The Lab Assignment originally contained a bonus objective - to create a cube controlled by the user (through WASD), which leaves a trail of small spheres of always changing colors. So, the implmenetation provides the user with a cube that moves in XZ plane, and leaves little sphereas behind as a trail, the color for each sphere is chosen randomly. 

## UI Menu
For a more convinient interaction with the above-mentioned elements within the same scene, a menu UI is added. All elements are set to inactive, and only one at a time is activated through the dropdown menu.
