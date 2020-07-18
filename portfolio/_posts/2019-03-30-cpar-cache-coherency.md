---
layout: post
title:  "Cache Coherency Analysis"
date:   2019-03-30 23:50:37 +0100
categories: jekyll update
tags: cache.jpg
author: Tiago
excerpt: A 2D game for the Minix operating system, developed in C using only the C standard library and Minix's OS API.
---

Programing Language: `C++`

Repository: [`https://github.com/TiagoJoseMagalhaes/cparp1`](https://github.com/TiagoJoseMagalhaes/cparp1)

# Description

This work was developed as a part of a parallel computing class and its objetive was for us to understand the importance of cache and how missess at different cache levels affected performance. This analysis was done through the traditional matrix multiplication case study, we had to implemente it via the traditional 3 for way, by inverting the second and third for order and lastly via a block based multplication algorithm. Additionally I tried to study the effect of data representation on these algorithms, in a sense this was replicating the old discussion of array of structure vs structure of array. One of the most interesting things that came out of this analysis for me was the hidden cost of polymorphism, I implemted the data structures via a polymorphic data structure in order to be able to easily swap out implementations, however, what I realized is that when polymorphism is used, algorithms that should have been much faster were not, my assumption to this point is that the usage of the virtual table with every data access was to intense or it was maybe even creating extra cache misses.