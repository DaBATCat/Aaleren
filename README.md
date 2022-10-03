# Aaleren
This is a little interpreter, with simple functions. The syntax is about eels, but in german. It's inspired by some esoteric programming languages like chicken, Brainf*ck, Malbolge, Chef, ...

# How does it work?
Until now, there are simple commands. You are able to print out up to 10 characters. You write your code in *Input.txt* and execute it with the *Aaleren.exe* file in the same directory. You have 10 Integers, which you can increment, reset and cast to a char. You acces everyone of them through an indexer, which you can also increment. The indexer will be resetted automaticly, if it's above the range.
The Syntax:

---|---
| Aal macht blubb | Prints out the resultated String of your chars |
| Aal wird gegessen | Terminates the program, should be in the last line of your code, else you may have a mess |
| Aal wird gegessen *is not in the last line* | Deactivates the *Aal schwurbelt* command |
| *Five times \n* | Your Integer based on the indexer will be incremented |
| Aal frisst Plankton | The indexer increments |
| Aal schaut umher | The Integer at the position of the indexer will be casted to a String |
| Aal schwurbelt | Resets the Integer to 0 at the position of the indexer |