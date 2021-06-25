// Write a function reverse(arr) to reverse an array.

// If we were given:
// ["a", "b", "c", "d", "e"];

// we expect to get back:
// ["e", "d", "c", "b", "a"]

var myArr = ["a", "b", "c", "d", "e", "z"];

function reverse(arr) {
    var firstIndex = 0;
    var lastIndex = arr.length-1;
    while (firstIndex < lastIndex) {
        var temp = arr[firstIndex];
        arr[firstIndex] = arr[lastIndex];
        arr[lastIndex] = temp;
        firstIndex++;
        lastIndex--;
    }
    return arr;
}
console.log(reverse(myArr));
