// return a value between 1 through 6 at random
function d6() {
    var roll = Math.random();
    // Math.random will give us a value between 0 and 0.999
    // Math.random*6 will give us a value between 0 and 5.999,
    // flooring it will give us 0 ~ 5, 
    // add 1 to get 1 ~ 6
    return Math.floor(roll*6)+1;
}

var playerRoll = d6();
console.log("The player rolled: " + playerRoll);

// write a function that will answer all of our questions by randomly choosing a response
var lifesAnswers = [
    "It is certain.",
    "It is decidedly so.",
    "Without a doubt.",
    "Yes – definitely.",
    "You may rely on it.",
    "As I see it, yes.",
    "Most likely.",
    "Outlook good.",
    "Yes.",
    "Signs point to yes.",
    "Reply hazy, try again.",
    "Ask again later.",
    "Better not tell you now.",
    "Cannot predict now.",
    "Concentrate and ask again.",
    "Don't count on it.",
    "My reply is no.",
    "My sources say no.",
    "Outlook not so good.",
    "Very doubtful."
];

function oracle() {
    answer = Math.ceil(Math.random()*(lifesAnswers.length-1));
    return lifesAnswers[answer];
}

console.log(oracle());