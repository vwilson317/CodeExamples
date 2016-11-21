"use strict";

function mostWanted(data) {
    var sorted = data.toLowerCase().split("").sort()//(a,b) => {return a -b});
    var lettersReg = /^[A-Za-z]+$/
    var keyValuePair = new Object();
    var highestOccurance =  null;

    for(var i =0; i < sorted.length; i++)
    {
        //sort returns special charaters and numbers at the start of the array
        var currentItem = sorted[i]

        if(!currentItem.match(lettersReg)){
        }
        else
        {
            if(keyValuePair[currentItem] == null){
                keyValuePair[currentItem] = 1;
            }

            if(i != sorted.length -1 && currentItem === (sorted[i + 1]))
            {
                keyValuePair[currentItem]++
            }

            if(highestOccurance === null || keyValuePair[highestOccurance] < keyValuePair[currentItem]){
                highestOccurance = currentItem
            }
        }
    }
        return highestOccurance;
    
}

var assert = require('assert');

if (!global.is_checking) {
    assert.equal(mostWanted("Lorem ipsum dolor sit amet"), "m", "1st example");
    assert.equal(mostWanted("How do you do?"), "o", "2nd example");
    assert.equal(mostWanted("One"), "e", "3rd example");
    assert.equal(mostWanted("Oops!"), "o", "4th example");
    assert.equal(mostWanted("AAaooo!!!!"), "a", "Letters");
    console.log("Coding complete? Click 'Check' to review your tests and earn cool rewards!");
}
