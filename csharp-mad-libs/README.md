# Mad Libs

In C#, variables and string interpolation allow us to transform a piece
of text by swapping out different pieces of information.

In this project, we’ll use C# to write a Mad Libs word game! Mad Libs
are short stories with blanks for the player to fill in that represent
different parts of speech. The end result is a really hilarious and
strange story.

Here’s an example of the “Roses are Red” poem changed into a Mad Lib:

<img
src="https://content.codecademy.com/courses/learn-c-sharp/data-types-variables/C%23_Madlib_1_DarkBG-01.png"
class="styles_img__AdU20" alt="roses are red" />

Mad Libs require: A short story with blank spaces (asking for different
types of words). Words from the player to fill in those blanks.

For this project, we have provided the story, but it will be up to you
to complete the following: Prompt the user for inputs. Print the story
with the inputs in the right places.

It’s important to note that for this project, you should test your app
periodically — when you hit save, your app will not run! To run your
app, enter `dotnet run` into the terminal.

<img
src="https://content.codecademy.com/courses/learn-c-sharp/hello-world/dotnet-run-ex.gif"
class="styles_img__AdU20" alt="dotnet" />

Let’s begin!

[C# Project Mad Libs](https://www.youtube.com/watch?v=yVAxbEW9ej4)

## MadLibs Set Up

1.

Begin by completing the multi-line comment that describes this program.



Multi-line comments look like this:

``` cs
/*
This program does
the following...
 
Author: your-name
*/
```

It’s helpful to let other programmers know what your program does when
they are reading your code.

2.

Inform the user that the program is running. You need to be constantly
thinking from the users’ point of view – they are the ones who run your
program. Make sure that your program is easy for others to understand!

Before the string `story`, print a message to let the user know that Mad
Libs has started.




3.

Give your story a title. Change the value of the variable `title` to a
title that you like.




4.

Take a look at the string variable named `story`. It is set equal to a
string that contains our story.

## Creating the Variables

5.

Now we’re going to start creating the variables that we will use in our
story. Make sure to declare *all* of your variables *above* the variable
`story`, otherwise you won’t be able to use them in the story!

The story that we have provided is going to need a main character. Ask
the user to input a name, and store the user’s input in a variable with
a string type:

``` cs
Console.Write("Enter a name: ");
string name = Console.ReadLine();
```

Note: It’s good practice to use short, but descriptive variable names.




6.

You will need to ask the user for three
<a href="https://en.wikipedia.org/wiki/Adjective"
class="e14vpv2g1 gamut-xro1w8-ResetElement-Anchor-AnchorBase e1bhhzie0"
target="_blank" rel="noopener">adjectives</a>. An adjective is a word
that describes a noun, like a color (‘blue’), or feeling (‘silly’),
texture (‘soft’).

Ask the user for input three separate times. Store each adjective that
the user inputs into variables with descriptive names, like you did when
you asked the user for a name.




7.

It’s a good practice to save and run your code every few steps to make
sure there are no bugs. In the terminal, type the following command and
press <span class="kbd">Enter</span> on your keyboard: `dotnet run`




8.

Moving on! You’ll also need to ask the user for one
<a href="https://en.wikipedia.org/wiki/Verb"
class="e14vpv2g1 gamut-xro1w8-ResetElement-Anchor-AnchorBase e1bhhzie0"
target="_blank" rel="noopener">verb</a>. A verb is a word that
represents an action, like ‘sit’, ‘eat’, ‘sleep’

Ask the user to input a verb and store their response in a variable.

9.

The story also needs two <a href="https://en.wikipedia.org/wiki/Noun"
class="e14vpv2g1 gamut-xro1w8-ResetElement-Anchor-AnchorBase e1bhhzie0"
target="_blank" rel="noopener">nouns</a>. A noun is a person (‘girl’),
place (‘cabin’), or thing (‘toaster’).

Ask the user to input two nouns. Store each noun in its own variable.

10.

This is where the story can get really fun and weird. Ask the user to
input one of each of the following:

-   An animal
-   A food
-   A fruit
-   A superhero
-   A country
-   A dessert
-   A year

Make sure to save the inputs into different variables. Run your code
again to make sure you have everything in place before the next task!

## Using String Interpolation

11.

At this point, we have all the words needed for the story. Great job!

The next step is to insert all of the user’s inputs into the blank
spaces of the story using string interpolation.

Put a `$` in front of the first quotation mark `"` in `story` and
replace each underscore `_` with a set of empty braces`{}`.




12.

Write the names of each variable inside of the brackets. Here’s the
order that they should appear in:

1.  Name
2.  First adjective
3.  Second adjective
4.  Animal
5.  Food
6.  Verb
7.  First noun
8.  Fruit
9.  Third adjective
10. Name
11. Superhero
12. Name
13. Country
14. Name
15. Dessert
16. Name
17. Year
18. Second noun




## Complete and Run the Program

13.

Write a line of code that prints out the completed story to the
terminal.




14.

Let’s run the program!

Save the program. Then, in the terminal, type the following command and
press <span class="kbd">Enter</span>:

``` cs
dotnet run
```

**Reference**: https://www.codecademy.com/paths/build-web-apps-with-asp-net/tracks/build-web-apps-asp-net-beginner-c-sharp/modules/learn-csharp-module-ii/projects/csharp-mad-libs
