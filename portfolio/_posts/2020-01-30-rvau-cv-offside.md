---
layout: post
title:  "Soccer Computer Vision Offside System"
date:   2020-01-30 23:50:37 +0100
categories: jekyll update
tags: city-bp.jpg
author: Tiago
excerpt: A 2D game for the Minix operating system, developed in C using only the C standard library and Minix's OS API.
---

Programing Language: `Python`

Repository: [`https://github.com/rendoir/feup-rvau-2`](https://github.com/rendoir/feup-rvau-2)

# Description

This project was developed as a part of an introductory virtual reality class and its goal was to teach us about computer vision and its usages. This project was applied to soccer and the goal was to draw a HUD into an image to identify offside situations such as what is done in professional match broadcasts. In its base form, a homography for the field must be manually defined, however, we were able to automate this process in some scenarios via the usage of image segregation, line detection, and line intersection. This allows us to automate this process for images where the small area is the only one visible and no other line intersections interfere. Additionally, image segregation was used to separate the players from the field such that the HUD was not drawn over them. The placement of the soccer ball is always manual. This project was developed in Python and made usage of the OpenCV library.