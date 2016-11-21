"use strict";

function binaryCount(number){
    if(number != 1){
        var maybeBinary = (number >>> 0).toString(2).split("").map(x => parseInt(x))
        var x = maybeBinary.reduce(reduceFunction, 0)
        return x
    }
    return number
}

function reduceFunction(prev, current){
    return current === 1 ? prev + 1 : prev
}

var assert = require('assert');

if (!global.is_checking) {
    assert.equal(binaryCount(1), 1);
    assert.equal(binaryCount(15), 4);
    assert.equal(binaryCount(1), 1);
    assert.equal(binaryCount(1022), 9);
    console.log("Coding complete? Click 'Check' to review your tests and earn cool rewards!");
}
