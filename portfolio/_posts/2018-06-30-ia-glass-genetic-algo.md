---
layout: post
title:  "Genetic Algorithm For Glass Cutting"
date:   2018-06-30 23:50:37 +0100
categories: jekyll update
tags: genetic.png
author: Tiago
excerpt: A 2D game for the Minix operating system, developed in C using only the C standard library and Minix's OS API.
---

Programing Language: `C++`

Repository: [`https://github.com/TiagoJoseMagalhaes/GlassCuttingGeneticAlgo`](https://github.com/TiagoJoseMagalhaes/GlassCuttingGeneticAlgo)

# Description

This work was developed as part of an introductory class into artificial intelligence, and its goal was to teach us about the usage of genetic algorithms and gradient descent. To this end, we were tasked with developing an application that would take as input a description of a series of glass pieces with different sizes that must best cut, and the application must optimize their placement in the glass to be cut, to minimize the amount of wasted glass in the process. Placement optimization was done utilizing a genetic algorithm whose fitness function was based on academic papers we researched before starting development, the gradient descent used the same fitness function but with the required changes to accommodate for that algorithm's behavior. This work was implemented in C++ and made use of no additional libraries besides the C++ standard library. This program output into a file the overall fitness of each generation which for development purposes was then read in a small Python program and displayed in a graph, which allows us to better perceive if our algorithm was working as intended.

After the application was proven to work, it was optimized to be roughly 5 times faster via the usage of performance profilers to identify hot spots. One of the major optimizations done was the elimination of unnecessary object copies in the successor selection process. However, other hot spots were distributed throughout the code, despite not being as impactful still added up to the nice performance benefit we were able to achieve after the optimization process.