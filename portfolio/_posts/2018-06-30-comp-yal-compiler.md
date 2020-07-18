---
layout: post
title:  "YAL Language Compiler"
date:   2018-06-30 23:50:37 +0100
categories: jekyll update
tags: compiler.jpg
author: Tiago
excerpt: A 2D game for the Minix operating system, developed in C using only the C standard library and Minix's OS API.
---

Programing Language: `Java`

Repository: [`https://github.com/TiagoJoseMagalhaes/Yal2JVMCompiler`](https://github.com/TiagoJoseMagalhaes/Yal2JVMCompiler)

# Description

This work was developed as a part of a introductory class into compilers. This work created a compiler for a programing language called YAL which was developed by our teacher, for simplicity of the compiler development this language had only string, scalars and arrays of scalers as data types, however, it did include all the regular control flow statements and module importing. This compiler took the YAL source code and converted it into Java Bytecode that could then be compiled into an executable jvm binary. JJTree and JavaCC were use to simplify the lexical analysis and syntatical analysis stages, while the rest of the compilation stages were handled with fully handmade java code, using no libraries other than the java standard library.