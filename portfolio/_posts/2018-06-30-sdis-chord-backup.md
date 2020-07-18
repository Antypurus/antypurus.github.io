---
layout: post
title:  "Chord Based Backup Network"
date:   2018-06-30 23:50:37 +0100
categories: jekyll update
tags: chord.png
author: Tiago
excerpt: A 2D game for the Minix operating system, developed in C using only the C standard library and Minix's OS API.
---

Programing Language: `Java`

Repository: [`https://github.com/TiagoJoseMagalhaes/SDISBackupProject`](https://github.com/TiagoJoseMagalhaes/SDISBackupProject)

# Description

This work was developed as a part of a distributed systems class and its goal was to develop a distributed peer-to-peer file backup network based on the chord algorithm. Additionally files sent over the network had the requirement of needing to be secure from access by the computers storing them, this was achieved by encripting all chunks with the AES-256 algorithm with a user defined password. This was developed in java using nothing but its standard library. File chunk were sent over regular TCP, additionally there was a well know control node up at all times that could be used to obtain the IP addres of other nodes. The contents of the first chunk of a file are hashed using SHA-256 in order to compute the network ID of the file and determine the nodes to send it to. Node IDs are computer based on their external network IP.