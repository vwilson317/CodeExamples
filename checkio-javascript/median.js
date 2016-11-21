"use strict";

function median(data) {
    data = data.sort((x,y) => {return x - y});

    var dataLength = data.length;
    var isOddNumer = dataLength % 2 != 0
    if(isOddNumer)
        return data[Math.round(dataLength/2) - 1]

    //Even length array have no signle middle element
    var middleLeftIndex = dataLength/2 -1
    var middleRightIndex = middleLeftIndex + 1 
    return (data[middleLeftIndex] + data[middleRightIndex]) / 2
}

var assert = require('assert');

if (!global.is_checking) {
    assert.equal(median([1, 2, 3, 4, 5]), 3, "1st example");
    assert.equal(median([3, 1, 2, 5, 3]), 3, "2nd example");
    assert.equal(median([1, 300, 2, 200, 1]), 2, "3rd example");
    assert.equal(median([3, 6, 20, 99, 10, 15]), 12.5, "4th example");
    console.log("Coding complete? Click 'Check' to review your tests and earn cool rewards!");
}
