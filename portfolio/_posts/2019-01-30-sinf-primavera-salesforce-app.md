---
layout: post
title:  "Salesforce Android App For The Primavera ERP"
date:   2019-01-30 23:50:37 +0100
categories: jekyll update
tags: primavera.jpg
author: Tiago
excerpt: A 2D game for the Minix operating system, developed in C using only the C standard library and Minix's OS API.
---

Programing Languages: `Java, Python, MS SQL Server`

Repository: [`https://github.com/TiagoJoseMagalhaes/AndroidERPSinf`](https://github.com/TiagoJoseMagalhaes/AndroidERPSinf)

# Description

This work was developed as a part of introductory class into information systems and its focus was on integration with a comercial ERP, in this case Primavera which was at the time developing a web API for their system and we were the perfect guinea pigs for this...

Our job was to develop an application that allows the salesforce to integrate with ERP when doing their work, this includes viewing a product catalog and its details, issuing purchase orders via this application and scheduling meetings. It was decided that a mobile application would be the best fit for these needs, as such one was developed using the android SDK. This application would receive the API key via authenticating with a second server developed by us, that would then give the application the API key required to interact withe Primavera API (primavera at the time had no form of user authentication via its API). We also considered having our server act as a proxy for the Primavera API with cached values, since the ERP was very very slow to respond, however, due to time constraints this was not feasable and as such we stuck to just a proof of concept. Besieds the android SDK and the java standard library no other libraries were used.

Looking back, this was a bittersweet project, primavera is without a doubt a garbage piece of software, however, we learned a lot about project development through this long process, and this was likely to be the moment that I knew without a shadow of a doubt in my mind that performance is always important. This being said we will never forget how we were accused by our teacher of being idiots for developing our own authentication server during the presentation (long story short primavera's garbage software had gone down as it often did and we had a bug in our login error reporter that was telling us it was our auth server, however, it responded to requests from postman so we were clueless, rebooting primavera fixed the issue), lets just say that we were not very happy after that presentation.

