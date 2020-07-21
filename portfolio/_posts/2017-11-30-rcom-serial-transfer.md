---
layout: post
title:  "Serial Port File Transfer Client"
date:   2017-11-30 23:50:37 +0100
categories: jekyll update
tags: serial.jpg
author: Tiago
excerpt: A 2D game for the Minix operating system, developed in C using only the C standard library and Minix's OS API.
---

Programing Language: `C`

Repository: [`https://github.com/TiagoJoseMagalhaes/RCOM`](https://github.com/TiagoJoseMagalhaes/RCOM)

# Description

This project was developed as a part of an introductory computer networks class and aimed to teach us basic concerns needed when transferring data over a network. To this end, an application meant to transfer data between two computers via the serial port was developed for Linux. In it, we had a completely custom multi-step protocol developed by our teacher, as well as having to detect any data corruption and having to escape special characters used for other aspects of the protocol. This application was developed using only C and its standard library, as well as the Linux file reading and writing API used to write and read from the serial port. Data also had to be split into chunks/packets of 65K bytes according to the protocol in use.