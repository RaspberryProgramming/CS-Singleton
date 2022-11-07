# CS Singleton - Developed On Linux

## Intro

According to Wikipedia, "the singleton pattern is a software design pattern that restricts the instantiation of a class to a singular instance. One of the well-known "Gang of Four" design patterns, which describe how to solve recurring problems in object-oriented software, the pattern is useful when exactly one object is needed to coordinate actions across a system." [Link](https://en.wikipedia.org/wiki/Singleton_pattern)

## Requirements - Linux
 - mono-complete package
 - git

## Installation

See [Link](https://www.geeksforgeeks.org/how-to-compile-decompile-and-run-c-code-in-linux/)
for information on installing mono-complete and compiling C# code.

Once mono-complete is installed, clone the repository

`git clone https://github.com/RaspberryProgramming/CS-Singleton`

Change directory to project folder

`cd CS-Singleton`

Compile the code

`mcs -out:Singleton.exe Singleton.cs`

Run the code

`mono Singleton.exe`