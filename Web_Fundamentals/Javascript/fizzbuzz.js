// Write code that will go through each number from 1 to 100 and:
// For each number that is a multiple of 3, print "Fizz"
// For each number that is a multiple of 5, print "Buzz"
// For numbers which are a multiple of both 3 and 5, print "FizzBuzz"
// All other numbers should just print normally
var i = 1;
while (i <= 100) {
    // multiple of 3 and 5
    if (i % 3 == 0 && i % 5 == 0) {
        console.log("Fizzbuzz" + i);
    // multiple of 3
    } else if (i % 3 == 0) { 
        console.log("Fizz" + i);
    // multiple of 5
    } else if (i % 5 == 0) {
        console.log("Buzz" + i);
    // neither
    } else {
        console.log(i);
    }
    i++;
}