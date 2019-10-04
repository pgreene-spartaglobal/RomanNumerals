# Roman Numerals Project Euler

## Roman Numeral Converter, that functions to both convert integers to numerals or vice versa

### Information
[Project Euler Roman Numerals](https://projecteuler.net/about=roman_numerals)

This project was created using a TDD approach.

The first hurdle to overcome when solving this problem was to first gain a more complete understanding on how roman numerals work and how to convert them by hand before attempting to write code to solve the problem.

### Conversion table

| Value | Numeral |
|:-----:|:-------:|
| 1000  | M |
| 900  | CM |
| 500  |  D |
| 400 | CD  |
| 100 | C  |
| 90 | XC  |
| 50 | L  |
| 40 | XL  |
| 10 | X  |
| 9 | IX  |
| 5 | V  |
| 4 | IV  |
| 1 | I  |

After familiarising myself with the system I then created two tests that would act as the end point for what I wanted to achieve.

### Implementation

The **RomanNumeralConverter** class contains two functions and associated tests **IntToRomanNumeral()** and **RomanNumeralToInt()** as well as a dictionary that would be used to convert between to determine the correct output value.  

#### Integer to Roman Numeral
To convert an integer to a roman numeral the approach used was to check if the current value could be subtracted with an appropriate numeral before appending the correct symbol to an output string. This value is then subtracted and this continues until the total reaches 0. 

#### Example
##### Convert 2419 to roman numerals

2419 | M (1000) can be subtracted (Output string: M)

1419 | M (1000) can be subtracted (Output string: MM)

419 | CD (400) can be subtracted (Output string: MMCD)

19 | X (10) can be subtracted (Output string: MMCDX)

9 | IX (9) can be subtracted (Output string: MMCDXIX)

0 | The process has finished as the entire number has now been converted
#### 2419 = MMCDXIX

#### Roman Numerals to Integer

To convert a roman numeral to an int the string is read character by character whilst also checking the next character to see if it is larger than the current character (For example IV and 4). If this is the case a subtraction is peformed on a running total, otherwise the matching value for the symbol is added to the total. 

#### Example
##### Convert XLIV to integer

CurrentIndex 0, NextIndex 1 | X is checked with L | L is larger than X | Total -= 10 | Total is -10

CurrentIndex 1, NextIndex 2 | L is compared with I | I is not larger than L | Total += 50 | Total is 40

CurrentIndex 2, NextIndex 3 | I is compared with V | V is larger than I | Total -= 1 | Total is 39

CurrentIndex 3, At final element so NextIndex is not needed therefore we can add the current symbol | Total += 5 | Total is 44

#### XLIV = 44 
