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

---Added later
* Program should convey message to user if they have entered non-conforming entries like multiple words in word input
  * Input: "cat cat cat", "There is a CaT over there. It is a big cat."
  * Output: "Please enter a single word"
  * Because program is looking for matches on single words in the sentence array, a "word" entry that is multiple words (like the input above) will always fail. The program should let the user know this is happening.
