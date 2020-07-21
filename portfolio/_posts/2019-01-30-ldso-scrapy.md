---
layout: post
title:  "Web Scraping Platform"
date:   2019-01-30 23:50:37 +0100
categories: jekyll update
tags: scrapy.webp
author: Tiago
excerpt: A 2D game for the Minix operating system, developed in C using only the C standard library and Minix's OS API.
---

Programing Languages: `HTML, CSS, JavaScript, Python, PostgreSQL`

# Description

This work was developed as a part of a software development class and as a part of the coding for social impact project. In it, we worked with an external teacher that was our client (other groups had companies) to develop an easy to use web scraping platform. This web scraping platform had 3 main components; a frontend web application, the backend server for it, and the web scraping engine. The frontend used bootstrap for styling and in it, a block-based configuration system was created to make it easy to use (think something like unreal engine 4's blueprint system). The backend server was written in NodeJS and handled aspects of the platform related to use information as well as marshaling scraping data between the frontend and the scraping engine. The scraping engine was written in python and used the scrapy library. Lastly, our database was PostgreSQL.

This work was done in a team of 5 using the scrum agile methodology, utilizing CI/CD and code reviews. By the end of this project, my main job was handling all aspects related to the database as throughout the process I had been the only one to work with it, I handled the data scheme, triggers, optimizations as well as integrations with the scraping server and built queries to be used by the backend server developers. On top of this, I was responsible for the initial configuration of the CI/CD pipeline (GitLab ci) and for tracking the development of the project.

Bellow, you find a crappy sketch of the high-level platform architecture that I drew during the beginning of development.

<div class="row"><div class="mx-auto">
<img class="img-fluid" src="/images/scrapy_diag.jpg">
</div></div>

<br>