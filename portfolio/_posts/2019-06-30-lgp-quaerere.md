---
layout: post
title:  "Quaerere"
date:   2019-06-30 23:50:37 +0100
categories: jekyll update
tags: learn.jpg
author: Tiago
excerpt: A 2D game for the Minix operating system, developed in C using only the C standard library and Minix's OS API.
---

Programing Languages: `HTML, CSS, JavaScript`

# Description

This project was developed as a part of a project management class in which we formed a 40-person company named Feeka which held 4 sub-teams that each worked on their project for an external client. This company also had a governing c-suite, on which I filled the position of CTO at tried to oversee the development of all projects and established the expected quality guidelines for the company. Each team was made up of 7 developers, 1 manager, and 2 designers, this being said the number of designers was flexible so a to accommodate the larger needs of the company as a whole and each team.

My team was tasked with developing an e-learning platform for a private school, this project was named Quaerere. This project was aimed at students from 1st to 12th grade and as such had to be very flexible, supporting a wide variety of question types as well as having a relatively neutral design, that could be filled in by teachers in the quizzes. The project was developed as a desktop application per the client’s request as well as being expected to scale horizontally as such its backend was developed with a microservice architecture. The application was developed under electron, giving our team members that were focused on frontend development a flexible and comfortable platform under which they could do their best work, they also used react to help them develop. The backend server ran under docker and most services ran in NodeJS and interfaced with a MongoDB database, there was a special analytics service planned to be developed under C++, however, due to time constraints, this was never implemented. The only way for users to authenticate into the system was to use their school-supplied office 365 accounts, this meant that we also had to develop using test accounts supplied to use by our clients in order to assure that our implementation perfectly integrated with their particular office 365 configuration.

The entire project was developed under the agile scrum methodology, being constantly tested and analyzed under our GitLab ci configuration and with code reviews being mandatory for all merge requests.