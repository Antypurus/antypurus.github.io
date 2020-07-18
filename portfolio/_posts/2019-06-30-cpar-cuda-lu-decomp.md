---
layout: post
title:  "Multithreaded LU Decomposition Analysis"
date:   2019-06-30 23:50:37 +0100
categories: jekyll update
tags: city-bp.jpg
author: Tiago
excerpt: A 2D game for the Minix operating system, developed in C using only the C standard library and Minix's OS API.
---

Programming Language:`C++, CUDA`

Repository: [`https://github.com/TiagoJoseMagalhaes/lu_decomp`](https://github.com/TiagoJoseMagalhaes/lu_decomp)

# Description

This work was developed as a part of a paralel computing class and its objective was to understand different ways to implement the same algorithm in a parallel way. The 3 ways we had to implement it were single threaded (just to understand how the algorithm works in its simplest form), using OpenMP and using CUDA. We implemented matrix LU decomposition using Doolittle's method. The OpenMP implementation achieved quite nice results, however, the most interesting one was the CUDA implementation. This is the project where I learned that usually iterative algorithms dont adapt themselves well to highly paralelized environments, in our case we hit the max thread limit per group of cuda very quickly, and could not find a way to split computations over different groups, this yielded not only a very small maximum matrix size, but when accounting for data transfer time over the PCI bus made the usage of Doolittle's method in CUDA make no sense at all. This being said using another algorithm to do this operation is an option as proven by CUBLAS, which can do this operation very efficiently. Overall it was an interesting experiment, however, we did wish our teacher bothered to explain to us what algorithm we were using to begin with since most of us were not acquainted with the vast miriad of matrix LU decomposition methods.