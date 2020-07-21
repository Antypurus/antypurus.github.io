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

This work was developed as a part of an introductory class into compilers. This work created a compiler for a programing language called YAL which was developed by our teacher, for simplicity of the compiler development this language only had strings, scalars and arrays of scalers as data types, however, it did include all the regular control flow statements and module imports. This compiler took the YAL source code and converted it into Java Bytecode that could then be compiled into an executable JVM binary. JJTree and JavaCC were used to simplify the lexical analysis and syntactical analysis stages, while the rest of the compilation stages were handled with fully handmade java code, using no libraries other than the java standard library.

The language grammar was supplied to as an LL(2) grammar, however, there was an attempt to convert it to an LL(1) language, this being said due to time constraints this was never implemented into the lexer or parser. Semantic analysis was implemented over the token data and was responsible for generating the IR. A basic block structure was used as an intermediate representation which made both code generation and optimizations relatively simple. Here contiguous blocks of code were grouped into sets of operations, these blocks were separated when new control flow statements were reached or when the end of a function was reached. Initial code generation aimed to do a 1:1 matching of the original code flow, merely optimizing the number of jump calls required.

After the compiled was proven to work for the code samples we had, 3 sets of optimizations were implemented. Register allocation optimization by running liveness analysis on the IR data and then using graph coloring to allocate registers. Constant propagation based on the IR data. And constant folding on simple arithmetic operations.

This is by far one of the most interesting projects I have developed at FEUP as it thought me the value of researching and reading papers during the process of searching for an intermedia representation structure. The project, in general, was also very interesting and fun to develop for me and is definitely one I will remember for years to come. Maybe I should try writing a compiler for a well-known language?