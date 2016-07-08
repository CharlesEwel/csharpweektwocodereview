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
Count how many times the word appears, excluding partial matches but also missing if the word appears at the start or end of the string or is surrounded by punctuation| String "cat scatter 'cat' cat cathedral cat." Word: "cat" | 1 | This spec essentially changes the search term from "cat" to " cat " (note the addition of spaces) in an effort to catch only full matches. We're calling instances where the word is in quotes a 'full match', so it misses those, as it does instances where the word appears at the start or end of the string. The sample input contains two 'partial matches' (cathedral, scatter) that should be excluded, and four full matches that should, by the time we're done, be included. Currently both the partial matches are correctly excluded, but only the fourth term is included.
Include the match as long as it's surrounded by approved punctuation/spaces |String "cat scatter 'cat' cat cathedral cat." Word: "cat"| 3 | See above for explanation of the sample input. It now catches the third and sixth terms. The third term is counted because it is surrounded by single quotes, which are 'approved' punctuation for still being a full match. The sixth term is included because it is surrounded by a space and a period, both of which are allowed
Include All Full Matches|String "cat scatter 'cat' cat cathedral cat." Word: "cat"|4|Finally, we run a special check to see if the word is at the very end or very beginning of the string. This should allow us to catch the first term in the sample input.
Validation|String: "cat in the cathedral" Word: "in the" | Please enter a single word | This sample input was chosen becuase multiple word searches are not allowed

## Support and Contact Details

Contact Epicodus for support in running this program.

## Technologies Used

* HTML
* C#

## License

*This software is licensed under the Microsoft ASP.NET license.*

Copyright (c) 2016 Charles Ewel
