---
layout: post
title:  "Multithreaded Sauna Simulator"
date:   2017-06-30 23:50:37 +0100
categories: jekyll update
tags: sauna.jpg
author: Tiago
excerpt: A 2D game for the Minix operating system, developed in C using only the C standard library and Minix's OS API.
---

Programing Language: `C`

Repository: [`https://github.com/TiagoJoseMagalhaes/mt_sauna`](https://github.com/TiagoJoseMagalhaes/mt_sauna)

# Description

This work was developed as part of an operating systems class and hand the goal of teaching us about semaphores, threads, conditional variables, and critical sections. In it, we developed a simulation of a sauna that only has a single room but must serve clients of male and female genders. There different applications were developed, one was the generated which generated client request for the sauna and sent them over a FIFO pipe. Then there was the sauna system that received and served the client requests. At any given time only clients of a single gender could be in the sauna and there was a limited number of slots in the sauna, the system had to manage this efficiently via the usage of threads and data locks.