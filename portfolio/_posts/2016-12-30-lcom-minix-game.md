---
layout: post
title:  "Minix 2D Game"
date:   2016-12-30 23:50:37 +0100
categories: jekyll update
tags: minix.jpg
author: Tiago
excerpt: A 2D game for the Minix operating system, developed in C using only the C standard library and Minix's OS API.
---

Progaming Language: `C`

Code Repository: [`https://github.com/TiagoJoseMagalhaes/lcom`](https://github.com/TiagoJoseMagalhaes/lcom)

# Description

Developed as a course assignment, this work created a 2D game for the Minix3 operating system's graphical mode. This game was a top down target shooter.

This application ran in kernel mode in order to have access to all devices via system interrupts. This application made use of the mouse, keyboard and timer, as well as having to write straight into video memory for the graphical mode. The mouse was used to control the player's aim, the keyboard controlled the player's movement and the timer controls the movement of projectiles. Additionaly, the timer controls copys from the bakcbuffer to the display buffer, so its controls the swapchain.

This game makes use of randomly placed walls and enemies and the players objetive is to hit all the enemies/targets in the smallest amount of time possible.


# Looking back in 2020

This is a fun one to look back at, in a good and a bad way! When I developed this software, I was essentially in my first year of actual software engineering after having transfered over from electrical engineering, I had at most 100 or so hour of experience by that point and it shows. God, when I look at some of this code I just have to ask what kind of acid I was on. But at the same time, it shows that I have learned, after at the time this seemed like perfectly fine code to me. To a degree I almost want to revisit Minix and have some fun with it. Anyways, all I have to say to anyone looking at this code is to never ever, in your wildest dreams think of using the code here on your own project, its very very very bad code. And as always take this small reflection as half-serious half-satire and in good fun, it is my own code after all, so I get to make fun of it all I want.