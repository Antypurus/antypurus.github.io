---
layout: post
title:  "Knocky Shooty - A Unity VR Game"
date:   2019-11-30 23:50:37 +0100
categories: jekyll update
tags: city-bp.jpg
author: Tiago
excerpt: A 2D game for the Minix operating system, developed in C using only the C standard library and Minix's OS API.
---

Programing Language: `C#`

Repository: [`https://github.com/rendoir/feup-rvau`](https://github.com/rendoir/feup-rvau)

# Description

This work was developed as a part of a virtual reality class, and its objective was to develop a VR game that made use of natural locomotion and diegetic interfaces. To this end, it seemed to us like it would be fun and straightforward to develop a carnival-based game, and that is how Knocky Shooty was born. This game only has 2 minigames, a shooting time base game, and a level-based can knockdown game. This game was developed in Unity using valves VR libraries for unity and tested/designed with the HTC Vive.

The can knockdown game was a fully natural game where the user had to pick up a ball and throw it as in real-life, the rest of the process would be handled by the physics system and some clever detection of when a can is knocked down. There was also a panel that the user would interact with the start/restart the game and view his score, interaction would be done via gaze input. The second game had a series of targets that could vary in movement, amount, and placement, and the player's goal was to knock them down as fast as possible. The user could move either through a teleport system which was there for a user such as myself who can not handle walking in a virtual environment while not walking in real-life, alternatively, the player can use the HTC Vive controllers touchpad to guide their movement, with their forward direction being controlled by the HMD’s view direction in real-life.

<div class="row"><div class="mx-auto">
<iframe width="560" height="315" src="https://www.youtube.com/embed/xkCBryY-0pE" frameborder="0" allow="accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>
</div></div>
<br>