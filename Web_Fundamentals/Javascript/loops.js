// Print odds 1-20
// Using a loop write code that will console.log all of the odd values from 1 up to 20.

var odds = 1;
while (odds <= 20) {
    if (odds % 2 == 1) {
        console.log(odds);
    }
    odds++;
}

// Decreasing Multiples of 3
// Using a loop write code that will console.log all of the values that are evenly 
// divisible by 3 from 100 down to 0.

var multiples3 = 100;
while (multiples3 >= 0) {
    if (multiples3 % 3 == 0) {
        console.log(multiples3);
    }
    multiples3--;
}

// Using a loop write code that will console.log the values in this sequence:
// 4, 2.5, 1, -0.5, -2, -3.5.
var sequence = 4;
while (sequence > -4) {
    console.log(sequence);
    sequence -= 1.5;
}

// Sigma
// Write code that will add all of the values from 1-100 onto some variable sum and 
// at the end console.log the result 1 + 2 + 3 + ... + 98 + 99 + 100. 
// We should get back 5050 at the end.
var sigma = 0;
var counter = 1;
while (counter <= 100) {
    sigma = sigma + counter;
    counter++;
}
console.log(sigma);

var sigma = 0;
for (var i = 1; i <= 100; i++) {
    sigma = sigma + i;
}
console.log(sigma);

// Factorial
// Write code that will multiply all of the values from 1-12 onto some variable product
// and at the end console.log the result 1 * 2 * 3 * ... * 10 * 11 * 12.
// We should get back 479001600 at the end.
var factorial = 1;
for (var i = 1; i <= 12; i++) {
    factorial = factorial * i;
}
console.log(factorial);