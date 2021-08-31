console.log(example);
let example = "I'm the example!";    
// let not hoisted, throws error

console.log(hello);
var hello = 'world';
// var hello;
// console.log(hello); // hello is undefined
// hello = 'world'

var needle = 'haystack';
test();
function test(){
    var needle = 'magnet';
    console.log(needle);
}
// var needle = 'haystack'; // needle hoisted and declared
// test(); // test is undefined
// function test(){
//     var needle = 'magnet'; // needle hoisted to top of test() method and declared as magnet
//     console.log(needle); // logs magnet instead of haystack
// }
var brendan = 'super cool';
function print(){
    brendan = 'only okay';
    console.log(brendan);
}
console.log(brendan);

// var brendan; // hoisted
// function print(){
//     brendan = 'only okay'; // hoisted within print
//     console.log(brendan); // doesn't get called since print is never called
// }
// brendan = 'super cool'; // global
// console.log(brendan); // prints 'super cool'

var food = 'chicken';
console.log(food);
eat();
function eat(){
    food = 'half-chicken';
    console.log(food);
    var food = 'gone';
}

// var food;                     // hoisted
// food = 'chicken';             // declared
// console.log(food);            // prints chicken
// eat();                        ~~// called before defined?~~
// function eat(){               // hoisted
//     var food;                 // hoisted
//     food = 'half-chicken';    // declared
//     console.log(food);        // prints 'half-chicken'
//     food = 'gone';            // declared
// }
// food = 'chicken';  // global

mean();
console.log(food);
var mean = function() {
    food = "chicken";
    console.log(food);
    var food = "fish";
    console.log(food);
}
console.log(food);
// var mean;               // hoisted
// mean();                 // mean is not a function
// console.log(food);      // code already broke, food isn't a variable
// mean = function() {
//     var food
//     food = "chicken";
//     console.log(food);
//     food = "fish";
//     console.log(food);
// }
// console.log(food);


console.log(genre);
var genre = "disco";
rewind();
function rewind() {
    genre = "rock";
    console.log(genre);
    var genre = "r&b";
    console.log(genre);
}
console.log(genre);

// var genre;                  // hoisted
// console.log(genre);         // undefined
// genre = "disco";            // assigned
// rewind();                   // undefined
// function rewind() {
//     var genre;              // hoisted within rewind()
//     genre = "rock";         // assigned
//     console.log(genre);     // prints "rock"
//     genre = "r&b";          // re-assigned
//     console.log(genre);     // prints "r&b"
// }
// console.log(genre);         // prints "disco/"

dojo = "san jose";
console.log(dojo);
learn();
function learn() {
    dojo = "seattle";
    console.log(dojo);
    var dojo = "burbank";
    console.log(dojo);
}
console.log(dojo);

// dojo = "san jose";            // assigned
// console.log(dojo);            // prints "san jose"
// learn();                      // ~~undefined~~
// function learn() {
//     var dojo                  // hoisted
//     dojo = "seattle";         // assigned
//     console.log(dojo);        // prints "seattle"
//     dojo = "burbank";         // re-assigned
//     console.log(dojo);        // prints "burbank"
// }
// console.log(dojo);            // prints "san jose" again

// ACTUAL
// function learn() {
//     var dojo
//     dojo = "seattle";
//     console.log(dojo);
//     dojo = "burbank";
//     console.log(dojo);
// }
// dojo = "san jose";
// console.log(dojo);
// learn();
// console.log(dojo);