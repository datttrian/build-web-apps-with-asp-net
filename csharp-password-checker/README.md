# Password Checker

A computer can run thousands of operations per minute. If someone wanted
to steal your information, they use each operation to make a guess at
your password. With one high-performance computer and the right
software, <a
href="https://en.wikipedia.org/wiki/Password_strength#Password_guess_validation"
class="e14vpv2g1 gamut-xro1w8-ResetElement-Anchor-AnchorBase e1bhhzie0"
target="_blank" rel="noopener">a 6 letter single-case password can be
broken in one day</a>.

Apart from quitting the internet entirely, what can we do to protect
ourselves? We can increase our password’s strength: make it longer and
more complex.

In this project you’ll make a program that measures the strength of any
given password based on the following criteria. A strong password:

-   is at least 8 characters long
-   has lowercase letters
-   has uppercase letters
-   has numerical digits
-   has symbols, like #, ?, !

The program will ask the user to input a password, and using conditional
logic and control flow, it will rate the password.

If you plan to do this project on your own computer, outside of
Codecademy, make sure to copy the **Tools.cs** file in addition to
**Program.cs**.

[C# Project Password Checker](https://www.youtube.com/watch?v=U_rcOw1aNHo)

## Setup

1.

Let’s start by defining all of the standards for a password.

-   `minLength` — a number with the minimum length
-   `uppercase` — a string with all uppercase letters
-   `lowercase` — a string with all lowercase letters
-   `digits` — a string with all 10 digits
-   `specialChars` — a string made of special characters




2.

Now we’ll capture input from the user. Ask the user to enter a password
and capture their input in a variable.




## Test

3.

We’ll score the user’s password: one point for each standard satisfied.
Define a variable `score` to hold their score and set it to `0`.




4.

If the password is greater than or equal to the minimum length, add a
point to the score. Use an `if` statement.




5.

If the password contains uppercase letters, add a point.

We’ve provided a custom tool that checks for certain characters in a
string, called `Tools.Contains()`.

Call it like this:

``` cs
Tools.Contains(target, list);
```

`target` would be the password and `list` would be a string of
characters you’d like to check for. If it finds a match, it returns
`true`. If it does not, it returns `false`.

For example:

``` cs
Tools.Contains("password", "abc"); // true
Tools.Contains("password", "123"); // false
```




6.

If the password contains lowercase letters, add a point.




7.

If the password contains digits, add a point.




8.

If the password contains special characters, add a point.




9.

Before we move on, make sure everything is working so far.

-   After the `if` statements, print the score to the console
-   Save your work
-   In the console, enter `dotnet run` and press
    <span class="kbd">Enter</span>
-   Try the examples in the hint!




## Tell the User

10.

Now that we’ve determined the password’s score, we need to let the user
know how they did.

Use a `switch` statement to log different messages for different scores:

-   For scores of 4 and 5, the password is extremely strong
-   For scores of 3, the password is strong
-   For scores of 2, the password is medium
-   For scores of 1, the password is weak
-   If none of those match, the password doesn’t meet any of the
    standards




Here’s a sample switch statement:

``` cs
switch (legs)
{
  case 8:
  case 6:
    Console.WriteLine("Bzzt, you're an insect.");
    break;
 case 4:
    Console.WriteLine("Woof, you're some kind of land animal.");
    break;
 case 2:
    Console.WriteLine("Hoohoo, you might be a human, you might be a bird.");
    break;
default:
    Console.WriteLine("Hmm, maybe a snake?");
    break;
}
```

11.

Test your program with a few passwords! Here are some examples to use:

-   `word` scores a 1. Weak.
-   `woRD` scores a 2. Medium.
-   `1woRD` scores a 3. Strong.
-   `2woRDsss` scores a 4. Extremely strong!
-   `2woRDsss!` scores a 5. Extremely strong again!
-   `" "` scores a 0. It’s a bunch of spaces…It doesn’t meet any of the
    standards.

If you want an extra challenge, try adding these requirements:

-   If the password is `password` or `1234`, give it a score of 0.
-   If you’re familiar with <a
    href="https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regex?view=netframework-4.8#examples"
    class="e14vpv2g1 gamut-xro1w8-ResetElement-Anchor-AnchorBase e1bhhzie0"
    target="_blank" rel="noopener">regular expressions</a>, use them
    instead of `Tools.Contains()`.

**Reference**: https://www.codecademy.com/paths/build-web-apps-with-asp-net/tracks/build-web-apps-asp-net-beginner-c-sharp/modules/learn-csharp-logic-conditionals/projects/csharp-password-checker
