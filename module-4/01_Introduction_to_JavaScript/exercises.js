﻿// 1. **sumDouble** Given two int values, return their sum. Unless the two values are the same, then return double their sum.

// 		sumDouble(1, 2) → 3
// 		sumDouble(3, 2) → 5
// 		sumDouble(2, 2) → 8

// 		function sumDouble(x, y) {
// 			// do logic here
// 			// return result;
// 			return x + y;
// 		}

function sumDouble(x, y) {
    // do logic here
    // return result;
    if(x==y){
        return 2*(x + y);
    }
    else {
        return x + y;
    }
}


// 2. **hasTeen** We'll say that a number is "teen" if it is in the range 13..19 inclusive. Given 3 int values, return true if 1 or 
// more of them are teen.

// 		hasTeen(13, 20, 10) → true
// 		hasTeen(20, 19, 10) → true
// 		hasTeen(20, 10, 13) → true

function hasTeen(n1, n2, n3) {
    return (isTeen(n1) || isTeen(n2) || isTeen(n3));
}

function isTeen(number){
    if (number >= 13 && number <= 19){
        return true;
    }
    else{
        return false;
    }
}

// 3. **lastDigit** Given two non-negative int values, return true if they have the same last digit, 
// such as with 27 and 57.

// 		lastDigit(7, 17) → true
// 		lastDigit(6, 17) → false
// 		lastDigit(3, 113) → true
function lastDigit(n1, n2){
    return ((n1 % 10) == (n2 % 10));
}


// 4. **seeColor** Given a string, if the string begins with "red" or "blue" return that 
// color string, otherwise return the empty string.

// 		seeColor("redxx") → "red"
// 		seeColor("xxred") → ""
// 		seeColor("blueTimes") → "blue"
function seeColor(color){
    if (color.indexOf("red") == 0)
    {
        return "red";
    }
    else if (color.indexOf("blue") == 0){
        return "blue";
    }
    else{
        return "";    
    }
}

// 5. **oddOnly** Write a function that given an array of integer of any length, filters 
// out the even number, and returns a new array of just the the odd numbers.

// 		oddOnly([1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11]) → [1, 3, 5, 7, 9, 11];
// 		oddOnly([2, 4, 8, 32, 256]); → []
function oddOnly(values){
    return values.filter( (number) => {
        return number % 2 === 1;
    });
}


// 6. **frontAgain** Given a string, return true if the first 2 chars in the string also 
// appear at the end of the string, such as with "edited".

// 		frontAgain("edited") → true
// 		frontAgain("edit") → false
// 		frontAgain("ed") → true
function frontAgain(entry){
    return (entry[0] == entry[entry.length-2] && entry[1] == entry[entry.length-1]);
}


// 7. **cigarParty** When squirrels get together for a party, they like to have cigars. 
// A squirrel party is successful when the number of cigars is between 40 and 60, inclusive.
// Unless it is the weekend, in which case there is no upper bound on the number of cigars. 
// Write a squirrel party function that return true if the party with the given values is 
// successful, or false otherwise.

// 		cigarParty(30, false) → false
// 		cigarParty(50, false) → true
// 		cigarParty(70, true) → true

function cigarParty(cigars, weekend){
    if (!weekend){
        return (cigars >= 40 && cigars <= 60);
    }
    else{
        return (cigars >= 40);
    }
}

/**
 * @returns 
 */
function sample{
    var result = "thing";
    return result;
}


// 8. **fizzBuzz** Because you know you can't live without it, FizzBuzz.

// 		fizzBuzz(3) → "Fizz"
// 		fizzBuzz(1) → 1
// 		fizzBuzz(10) → "Buzz"
// 		fizzBuzz(15) → "FizzBuzz"
// 		fizzBuzz(8) → 8
function fizzBuzz(value){
    if (value % 3 == 0 && value % 5 == 0){
        return 'FizzBuzz';
    }
    else if (value % 3 == 0){
        return 'Fizz';
    }
    else if (value % 5 == 0){
        return 'Buzz';
    }
    else
    {
        return value;
    }
}

// 9. **filterEvens** Write a function that filters an array to only include even numbers.

// 	```
// 	filterEvens([]) → []
// 	filterEvens([1, 3, 5]) → []
// 	filterEvens([2, 4, 6]) → [2, 4, 6]
// 	filterEvens([100, 8, 21, 24, 62, 9, 7]) → [100, 8, 24, 62]
// 	```
function filterEvens(values){
    return values.filter( (number) => {
        return number % 2 === 0;
    });
}

// 10. **filterBigNumbers** Write a function that filters numbers greater than or equal to 100.

// 	```
// 	filterBigNumbers([7, 10, 121, 100, 24, 162, 200]) → [121, 100, 162, 200]
// 	filterBigNumbers([3, 2, 7, 1, -100, -120]) → []
// 	filterBigNumbers([]) → []
// 	```
function filterBigNumbers(values){
    return values.filter( (number) => {
        return number >= 100;
    });
}


// 11. **filterMultiplesOfX** Write a function to filter numbers that are a multiple of a paremeter, 
// `x` passed in.

// 	```
// 	filterMultiplesOfX([3, 5, 1, 9, 18, 21, 42, 67], 3) → [3, 9, 18, 21, 42]
// 	filterMultiplesOfX([3, 5, 10, 20, 18, 21, 42, 67], 5) → [5, 10, 20]
// 	```
function filterMultiplesOfX(values, x){
    return values.filter( (number) => {
        return number % x === 0;
    });
}


// 12. **createObject** Write a function that creates an object with a property called firstName, 
// lastName, and age. Populate the properties with your values.

// 	```
// 	createObject() →

// 	{
// 		firstName,
// 		lastName,
// 		age
// 	}
// 	```
function createObject(){
    return {firstName:'David', lastName:'Vanderburgh', age:33};    
}


// ## Challenge Exercises

// 1. **iqTest** Bob is preparing to pass an IQ test. The most frequent task in this test is 
//to find out which one of the given numbers differs from the others. Bob observed that one 
//number usually differs from the others in evenness. Help Bob — to check his answers, he 
//needs a program that among the given numbers finds one that is different in evenness, and 
//return the position of this number. _Keep in mind that your task is to help Bob solve a real 
//IQ test, which means indexes of the elements start from 1 (not 0)_

// 		iqTest("2 4 7 8 10") → 3 //third number is odd, while the rest are even
// 		iqTest("1 2 1 1") → 2 // second number is even, while the rest are odd
// 		iqTest("") → 0 // there are no numbers in the given set
// 		iqTest("2 2 4 6") → 0 // all numbers are even, therefore there is no position of an odd number



// 2. **titleCase** Write a function that will convert a string into title case, given an 
//optional list of exceptions (minor words). The list of minor words will be given as a 
//string with each word separated by a space. Your function should ignore the case of the 
//minor words string -- it should behave in the same way even if the case of the minor word 
//string is changed.


// * First argument (required): the original string to be converted.
// * Second argument (optional): space-delimited list of minor words that must always be 
//lowercase except for the first word in the string. The JavaScript tests will pass undefined 
//when this argument is unused.


// 		titleCase('a clash of KINGS', 'a an the of') // should return: 'A Clash of Kings'
// 		titleCase('THE WIND IN THE WILLOWS', 'The In') // should return: 'The Wind in the Willows'
// 		titleCase('the quick brown fox') // should return: 'The Quick Brown Fox'