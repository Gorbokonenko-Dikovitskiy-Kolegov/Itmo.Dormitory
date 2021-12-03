﻿

function getRandom() {
    // 16777215 (decimal) == ffffff in hexidecimal
    var newColor = '#' + Math.floor(Math.random() * 16777215).toString(16);
    return newColor;
};

function paint() {
    var items = document.getElementsByClassName("announcements__item ");
    for (let i = 0; i < items.length; i++) {
        items[i].style.borderColor = getRandom();
    }
}