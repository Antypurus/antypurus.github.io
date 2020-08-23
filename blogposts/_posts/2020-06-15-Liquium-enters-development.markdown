---
layout: post
title:  "Liquium Devlog - Week 0: Beginning Of Development"
date:   2020-08-23 14:00:00 +0100
categories: jekyll update
tags: bistro.png
author: Tiago
excerpt: A new game engine enter development
---

Welcome fellow enthusiasts.

I write you this small blog post to introduce you to my new undertaking, the Liquium game engine. I can already hear you rolling your eyes at this statement, “Ohh yet another random guy developing an engine”. Well, it is true it is just another random guy developing an engine, and those who go down that line of thought I don’t think I will be able to persuade. Liquium is not a professionally developed engine, it is not a contender for engines like Unity and Unreal. Liquium is merely an exploratory learning endeavor where I can try out new things and learn more about the development of game engines as a whole. An endeavor that I will try to keep you all posted on in an attempt to share from my own learning experiences and to maybe even get some insights into things I don’t understand from you the reader. In a way this project follows from the development of the rendering engine which I used to implement my master’s thesis, which started its development long before I started implementing my thesis and started as a learning project for DirectX 12, and looking at it now, its clear there is a lot of legacy to this, many of its components were developed with an incorrect understanding of how the components of dx12 they represent work. Ultimately this is something I am doing because I feel like it and because I think it will be fun, and something that should not be taken super seriously.

The previous paragraph covered my motivation to start this project, however, I think it is important to define the constraints under which this project will operate and its development goals. I should make it clear that there are two particular things that currently I have no interest in, having it work on all platforms and having it support more than one rendering API. For the remainder of its lifetime this project will be Windows-only and it will use DirectX 12 as its underlying rendering API. Regarding not widely supported technologies, considering this is a learning endeavor my phylosophi is simples, it my machine supports it, I am allowed to use it, for this project I will be playing little to no attention to widespread support. 

The following table presents all constraints and development goals of the project.

<style>
table{
    border-collapse: collapse;
    border-spacing: 0;
    border:1px solid #000000;
	margin-left:auto; 
    margin-right:auto;
	border-spacing: 5px;
	
}

th{
    border:1px solid #000000;
	text-align:center;
}

td{
    border:1px solid #000000;
	padding-left:1vw;
	padding-right:1vw;
}
</style>



|Constraint| Notes/Explanation|
|:---------------------:|-----------|
|`Windows`|This application will only work on Windows|
|`DirectX 12`|DirectX 12 will be the only rendering API used in this project|
|`Shader Model 5.1`|This constraints comes in order to maintain compatibility with all graphics debuggers, currently RenderDoc only supports up to shader model 5.1, on the other hand, PIX and Nsight support the laters shader models. As RenderDoc catches up this restriction will ease up.|
|`Must Work With All Major Graphics Debuggers`|I belive it is important to have compatibility with all graphics debuggers as they all present different imformation or the same information in different ways which is very helpfull in certain situations, as such I am going to be going out of my way to make sure they all work with this application.|
|`Up to SSE 4.2`|My CPU supports up to this version of SSE|
|`Up to AVX2`|My CPU supports up to this version of AVX|
|`CMake Build System`|CMake will be used to manage the build system of this project|
|`Static Analyzer Usage`|I will be using a static analyzer integrated into the CI/CD pipeline of this project. Clang-tidy will be used for this, but I might also give pvs-studio a chance if I can integrate it into the pipeline.|
|`Linter/Formater Usage`|Automatic code linting and formating will be used to maintain a coherent code style, clang-format will be used for this and it will be integrated into the CI/CD pipeline|
|`Debug Visualizations Are Mandatory`|Whenever I deem it to make sense I will write debug visualizations for features. This comes from my experience with workin on features with no debug visualizations which made work significantly harder.|

<br>

This project will be hosted on a Gitlab repository, which will be mirrored to a Github repository. I believe that GitLab's feature set and implementation of common features is superior to that of Github, and as such have chosen to rely on that. You will find that all issues and development board will be GitLab, I am still pondering how to handle possible user created issues as I don't want those to be intermixed with development issues(aka user stories). One idea I have is to only allow user issues on GitHub, however, that would create a separation between the development platform and the platform where “bug reports” and “feature requests” are submitted. It is something that I will look into but for now, user issues are not allowed. I will try to have an agile cadence to this project, with a week-long sprint and a review, retrospective, and planing post at the end of each week.

Gitlab repository: [`https://gitlab.com/TiagoJoseMagalhaes/Liquium`](https://gitlab.com/TiagoJoseMagalhaes/Liquium)

Github repository: [`https://github.com/TiagoJoseMagalhaes/Liquium`](https://github.com/TiagoJoseMagalhaes/Liquium)

Thank you very much for taking the time to read this, if you wish to contact me you can do so at `tiagojsmagalhaes@gmail.com`.

<br>