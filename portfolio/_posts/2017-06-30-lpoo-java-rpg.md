---
layout: post
title:  "LibGDX Strategy RPG"
date:   2017-06-30 23:50:37 +0100
categories: jekyll update
tags: lpoo.jpg
author: Tiago
excerpt: A 2D game for the Minix operating system, developed in C using only the C standard library and Minix's OS API.
---

Programming Language: `Java`

Repository: [`https://github.com/TiagoJoseMagalhaes/LPOO1617_T5G4`](https://github.com/TiagoJoseMagalhaes/LPOO1617_T5G4)

# Description

This work was developed as part of an object-oriented programing class. For this, a simple 2D strategy RPG game was created, which was developed with the intent of easy to extend RPG systems. The spell list would be easy to increase as well as adding new units to the field. A spell could have a completely custom area of effect or range which was programmatically defined. There was an elemental defense system where different characters had different elemental strengths and resistances and the player was meant to exploit them. The enemy units were designed via a behavior tree which due to time constraints was emulated based on good old if statements. The game also had a simple Facebook integration to share when a player was playing or when he won a match. All graphical and sound aspects of the game were developed via the LibGDX library.

# Looking back in 2020

Looking back at this project, I feel like a lot of time was wasted on things that ended up not being used due to simply not having time to use it, including a player character leveling system and a detailed stat system that was barely used besides basic per-unit values. This was in detriment of other features such as an actual behavior tree instead of just emulating the desired model and fully-fledged animations instead of just constant sprite changes and only having an idle animation. At the end of the day, one must live and learn, this was in my first year of software engineering so there was still a lot that I had to learn back then, and today as well. Maybe one day I will also have a look at the code for this project and maybe have a good laugh. I am sure that it can not be as bad the one for the Minix game, after all this code was evaluated on how "good" it was (a discussion for another time I guess).