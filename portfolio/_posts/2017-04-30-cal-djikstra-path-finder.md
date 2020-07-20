---
layout: post
title:  "Optimal Path Finder"
date:   2017-04-30 23:50:37 +0100
categories: jekyll update
tags: city-bp.jpg
author: Tiago
excerpt: A pathfinder that operates on openstreetmaps data and which is based on djikstra's algorithm.
---

Programming Language:`C++`

Repository: [`https://github.com/TiagoJoseMagalhaes/CAL-EcoDriving`](https://github.com/TiagoJoseMagalhaes/CAL-EcoDriving)

# Description

This work was developed as part of a unit centered around algorithms, and this project involved developing a pathfinder that uses Djikstra's algorithm and applies to data from open street maps.

Data from open street maps comes in XML format, so that would require writing an XML parser, as such for ease of use out teachers developed a piece of software that converted it from XML to a simpler text format that was easier to parse for the purposes of this assignment. So nodes and edge weights in the graph were obtained from this file with map data. In our case node weights were based on the geographic distance between nodes, this is because our version of the assignment focused on conserving the battery of an electric car, this also means that elevation increases have a greater cost than no elevation differences and elevation decreases. Open street maps data for the position comes in as longitude and latitude, which had to be converted to cartesian coordinates whose distance could be easily calculated.

Users could search for the nodes via approximate and exact string matching (the names of the nodes were their real-world counterparts), from that they selected their start and endpoint and the application would output a route via a graphical interface for graph's provided to us by our teachers.