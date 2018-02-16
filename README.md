# Word Counter

#### _An app to count words in a text string, 2/16/2018_

## Description
This is a C#/ASP.NET app that will take user-provided words and count the number of instances in another user-provided text string. User may submit multiple words in separate fields.

## Specs
* Program should take a word as input
  * Input: "cat"
  * Output: "cat"
  * Program should be able to set a single word like "cat" and should be able to retrieve that word later. This is an appropriate test because it's a simple word with noting interesting going on in it (punctuation, apostrophes, etc)

* Program should take a string of word as input
  * Input: "There is a cat over there. It is a big cat that I will pet."
  * Output: "There is a cat over there. It is a big cat that I will pet."
  * Program should be able to set a string of words like the above and should be able to retrieve it later. This is an appropriate test cause it has multiple words and some variation (2 sentences) but does not contain test cases for later requirements.

* Program should check to make sure input is valid by ensuring it is not empty or containing multiple words
  * Input: "" (empty string, false test)
  * Output: (Program does not continue)
  * Program should be able to identify an empty value and not continue. Two quotation marks signifies the empty value & will be used to test the check method.

* Program should count how many times the word input appears in the string of words input
  * Input: "cat", "There is a cat over there. It is a big cat that I will pet."
  * Output: 2
  * Program should be able to identify that the exact word "cat" appears in the sentence string two times. This case is appropriate because it does not include more complex cases such as handling case and punctuation as those are later requirements.

* Program should be able to identify the counted word regardless of case.
  * Input: "cat" or "CaT", "There is a Cat over there. It is a big cat that I will pet."
  * Output: 2
  * Program should be able to take the word input and identify it in the sentence input regardless of case. This is an appropriate test because it includes letters of varying case in both types of inputs and the potential for non-matches.

* Program should be able to identify the counted word regardless of punctuation.
  * Input: "Cat", "There is a CaT over there. It is a big cat."
  * Output: 2
  * Program should be able to take the word input and identify it in the sentence input regardless of punctuation in the input sentence. This is an appropriate test because it includes punctuation in the sentence input that has the potential for non-matches.

#### Tests & Methods for these added after development began
* Program should convey message to user if they have entered non-conforming entries like multiple words in word input
  * Input: "cat cat cat", "There is a CaT over there. It is a big cat."
  * Output: "Please enter one word per Word Box! Click 'Add another word' to count more words"
  * Because program is looking for matches on single words in the sentence array, a "word" entry that is multiple words (like the input above) will always fail. The program should let the user know this is happening. Message setting functionality was added to the IsValid method.

* Program should offer users the option to enter multiple words to count
    * Input: "cat"; "dog"; "the"; "the cat and the dog are great"
    * Output: cat: 1; dog: 1; the: 2;
    * This changes the structure of the program somewhat. Adding GetAll() and ClearAll() methods, as well as a static list. It will also change the form and the object passed to the Index page. The object test has been updated.

## Setup/Installation instructions
In terminal,
* git clone https://github.com/grepcats/word-counter to Desktop
* navigate to "WordCounter" folder one level down
* run "dotnet restore" in project folder to load dependencies
* run "dotnet build" to build project and its dependencies into a set of binaries
* run "dotnet run" to run the project

Open web browser and navigate to http://localhost:5000. Program will run as long as it is running in the terminal.

## Known Bugs
No known bugs at this time. Please report any bugs by opening a GitHub issue.

## Support and Contact Details
If there are any issues or questions, please contact me at kayla.renee at gmail dot com or create an issue in GitHub.

## Technologies Used
C#/ASP.NET Core, jQuery.

## License
Copyright (c) 2018 **Kayla Ondracek**

#### Color combo generated at https://coolors.co/393d3f-fdfdff-c6c5b9-62929e-546a7b
