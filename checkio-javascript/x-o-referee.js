"use strict";

function xoReferee(data) {
    var currentRowIndex = 0
    for(currentRow in data){
        var colIndex = 0

        for(currentCol in currentRow)
        {
            checkWinner(currentCol, currentRow[colIndex])
            colIndex++
        }
        currentRowIndex++
    }

    return "D" || "X" || "O";
}

function checkWinner(colIndex, colVal){
    var rightCol = colIndex + 1
    if(){
        rightCol
    }
}

var assert = require('assert');

if (!global.is_checking) {
    assert.equal(xoReferee([
        "X.O",
        "XX.",
        "XOO"]), "X", "Xs wins");

    assert.equal(xoReferee([
        "OO.",
        "XOX",
        "XOX"]), "O", "Os wins");

    assert.equal(xoReferee([
        "OOX",
        "XXO",
        "OXX"]), "D", "Draw");

    assert.equal(xoReferee([
        "O.X",
        "XX.",
        "XOO"]), "X", "Xs wins again");

    console.log("Coding complete? Click 'Check' to review your tests and earn cool rewards!");
}
