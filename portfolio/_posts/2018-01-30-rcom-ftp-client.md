---
layout: post
title:  "FTP Client"
date:   2018-01-30 23:50:37 +0100
categories: jekyll update
tags: ftp.jpg
author: Tiago
excerpt: A 2D game for the Minix operating system, developed in C using only the C standard library and Minix's OS API.
---

Programing Language: `C`

Repository: [`https://github.com/TiagoJoseMagalhaes/RCOMSockets`](https://github.com/TiagoJoseMagalhaes/RCOMSockets)

# Description

This work was developed as a part of an introductory computer networks class, and its objective was to teach us about the usage of sockets via the development of an FTP download client. This application would receive an FTP string and would have to parse it in order to obtain all the required information to download the files from an FTP server. After parsing the string a connection with the FTP server would be established via a TCP socket and the protocol would be followed as described in the RFC to begin the file download. This application was meant to work with any FTP server that properly follows the protocol.