# Design Patterns Demo Repository

## Technologies
.NET 5

## Introduction
Most of the software developers are familiar with or, at least, heard of design patterns, but only few of them actually know exactly what are they, why are they so popular and how do they actually make our life easier by applying them in our code.
This in this simple console application I'm trying to demostrate the practical examples of how each design pattern works and what are their potential pros and cons.

## Description
As you can see in the source code, the main project is divided into separate groups:

* Solid
* Creational
* Structural
* Behavioral

You might notice that the last 3 parts are the general categories of design patterns [check out the link for more information about Gamma Categorization](https://en.wikipedia.org/wiki/Design_Patterns#Patterns_by_type). In each of these folders there are subfolders dedicated to every design pattern in that particular category. Examples are further divided into 2 versions: a bad one, which contains the code written with a bad practices and a good one, which is exactly the same example, but refactored using design pattern(s).

The Gamma Categorization:
<a href="https://imgur.com/nPdv8sH"><img src="https://imgur.com/nPdv8sH" title="source: imgur.com" /></a>

There is one more folder in the root of the main project called Solid. This isn't particularly yet another category of design patterns, but it's still critical to understand SOLID principles before we actually dive deep into design patterns. The reason is simple: every design pattern is based on those principles, so it will be much better if you start by understanding SOLID principles first.
You can check out the usage of some of the examples in the **program.cs** file, which demonstrates how the client (for example a developer using our libraries) would use them.

## Disclaimer
Most of the examples represented here are created by myself, but they're simple and general to make sure that whoever reviews the code, will be focused on how design patterns work instead of figuring out the specifics of the context behind the code, so some of the examples might look like copied from other sources, which definitely isn't.
Also note that each example is just a one application of each design pattern, which doesn't mean that that's the universal way of implementing it. Actually there can be many more interpretations, depending on the context and requirements.

# Open-source
This repository is intended for understanding design patterns, so feel free to fork and make changes, add other examples and so on. Good luck!