---
layout: post
title:  "Fork Find"
date:   2017-04-30 23:50:37 +0100
categories: jekyll update
tags: find.webp
author: Tiago
excerpt: A 2D game for the Minix operating system, developed in C using only the C standard library and Minix's OS API.
---

Programming Language:`C`

Repository: [`https://github.com/TiagoJoseMagalhaes/fork_find`](https://github.com/TiagoJoseMagalhaes/fork_find)

# Description

This project was developed as a part of an operating systems class, and its objective was to develop a piece of software that did effectively the same thing as Linux's find tool. This was to be achieved through the usage of process forking and data pipes between them. The application starts from the working directory and looks at its contents to see if the desired file is there, if not it creates a fork for all folders in the working directory. This behavior is repeated recursively until either the desired file is found or there are no subfolders to go into. When a child finds the desired file, it transmits its path to its parent process via a pipe, which in turn sends it to its parent recursively until the original process receives the data.