---
layout: post
title:  "Frogger 3D Game Client"
date:   2017-12-30 23:50:37 +0100
categories: jekyll update
tags: laig.png
author: Tiago
excerpt: A 2D game for the Minix operating system, developed in C using only the C standard library and Minix's OS API.
---

Programing Language: `JavaScript, GLSL`

Repository: [`https://github.com/TiagoJoseMagalhaes/LAIG_T1`](https://github.com/TiagoJoseMagalhaes/LAIG_T1)

# Description

This work was developed as a part of a second computer graphics class, in which we were though to work with scene graps (or scenes defined in files in general), NURB surfaces, programmable shaders, and animations. To this end, we developed a 3D client for a board game that ran on an external Prolog server which handled the game logic and just sent us the game board state. All visual aspects were defined in a scene graph file, this included the overall ambient, the game board, and the various game pieces. The player could choose their play via the mouse on our game client, which would then be translated by the client into a corresponding network command to the game server. This would also require animating the player's move if the server told the client it was a valid move. Afterward, we would receive information about what moves the AI made and those would be animated. When a player selects a piece it will be in a pulsing state which is done by special shaders made just to handle this pulsing animation. NURBS had previously been implemented into the underlying engine for a previous assignment, however, due to the logic of the game we had been assigned, their usage was not required, nor made sense.

At the very core of this application was a library developed by our teachers that wrapped around WebGL to greatly simplify aspects that had neither been thaught to use, nor were the focus of the unit.

<br>
<div class="row"><div class="mx-auto">
<img class="img img-fluid" src="/images/laig.png">
</div></div>
<br>