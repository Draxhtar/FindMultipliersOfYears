# Find Multipliers of Years

## Description
**Find Multipliers of Years** is a C# console application that calculates and prints all the factors of date numbers generated for each day, starting from January 1, 2039. The date numbers are constructed based on the format of `DDMMYYYY`, where the day is padded with a leading zero if the month is less than October.

## Note
This readme file is written with the help of ChatGPT.

## Features
- Generates date numbers for each day for a period of 18,629 days starting from January 1, 2039.
- Calculates and displays all factors of each generated date number.
- Demonstrates the use of basic date manipulation and arithmetic in C#.

## How It Works
1. The program initializes a starting date and iterates through a specified number of days.
2. For each day, it creates a date number based on the day, month, and year.
3. It then calls a function to return all factors of the generated date number.

## Code Structure
- **Main Method**: The entry point of the application where date numbers are generated.
- **ReturnAllFactors Method**: A helper method that calculates and prints all factors of a given number.

## Usage
To run the program, ensure you have a C# environment set up. Compile and execute the `FindMultipliersOfYears` class. The program will print the date numbers and their factors to the console.

## Acknowledgements
- Thank you to the C# community for ongoing support and resources.
