---
layout: post
title:  "WebGL 3D Scene"
date:   2017-06-30 23:50:37 +0100
categories: jekyll update
tags: cgra.png
author: Tiago
excerpt: A 2D game for the Minix operating system, developed in C using only the C standard library and Minix's OS API.
---

Programing Language: `JavaScript`

Repository: [`https://github.com/TiagoJoseMagalhaes/cgra`](https://github.com/TiagoJoseMagalhaes/cgra)

# Description

This project was developed as part of an introductory computer graphics class. The objective of this assignment was to learn about transforms, texturing, bezier curves, framerate independence, and simple primitive-based modeling. To do this we were tasked with developing a scene that had a moving submarine with swappable texture and targets that the submarine would shoot at with missiles, missiles then followed a bezier curve path to hit the targets, when they hit an explosion would be generated, additionally, the scene had an analog clock that would display the current system time. The submarine had to be modeled via the usage of simple primitives and transforms ( spheres, cylinders, and scaling transforms were all that was needed). These primitives had previously been implemented as algorithms that generated the index, vertex, and texture coordinate lists. There was also a simple HTML based GUI that could be used to control the submarines speed on each axis and its direction. All movements had to be independent of the system framerate.

<br>

<div class="row">
<div class="mx-auto">
    <img class="img img-fluid" src="/images/cgra.png"> 
</div>
</div>

<br>

<div class="row">
<div class="mx-auto">
<iframe width="784" height="441" src="https://www.youtube.com/embed/ntMpEKkZEbs" frameborder="0" allow="accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>
</div>
</div>