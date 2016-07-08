# Csharp Week 2 Code Review

#### By Charlie Ewel, 07/08/2016

## Description

This program will tell a user how frequently a specified word appears in a given string

## Setup/Installation Requirements

This program can only be accessed on a PC with Windows 10, and with git and atom installed.

* Clone this repository
* Type following command into the Windows PowerShell > dnu restore
* Type following command into PowerShell > dnx kestrel
* Open Chrome and type in the following address: "localhost:5004"

## Known Bugs

No known bugs.

## Specifications

The program should ... | Example Input | Example Output | Why'd we choose this?
----- | ----- | -----
Recognize if the word matches the string exactly| String: "cat" Word: "cat" | 1 | This is a short example of a string that matches the specified word exactly.
Count how many times the word appears, including partial matches| String: "cat in the cathedral" | 2 | This is an example from two days ago of a string that contains both the word cat in isolation and also nested within a larger word
Count how many times the word appears, excluding partial matches but also missing if the word appears at the start or end of the string or is surrounded by punctuation| String "the scatter cat cathedral building" Word: "cat" | 1 | This spec essentially changes the search term from "cat" to " cat " (note the addition of spaces) in an effort to catch only full matches. This sample input let's us make sure it still catches the full match of cat, while excluding the partial matches found in cathedral and scatter.
Include the match as long as it's surrounded by approved punctuation/spaces |String "the 'cat' cat." Word: "cat"| 2 | This input lets us make sure we catch as full matches any instances of our word surrounded by punctuation or a mix of punctuation and spaces
Include Full Matches at beginning and end | String "cat by the cat" Word: "cat"| 2 |This sample input places a cat at the start and the end of the string. Previously we'd been looking at what's next to the term to see if it was a partial match, these have nothing next to them on one side.
Validation | String: "cat in the cathedral" Word: "in the" | Please enter a single word | This sample input was chosen because multiple word searches are not allowed

## Support and Contact Details

Contact Epicodus for support in running this program.

## Technologies Used

* HTML
* C#

## License

*This software is licensed under the Microsoft ASP.NET license.*

Copyright (c) 2016 Charles Ewel
