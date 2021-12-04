function setActiveNavItem(item_id) {
    var tabs = document.querySelectorAll('.navbar-item');
    tabs.forEach(function (el) {
        var square = el.getElementsByClassName('check-square')[0]
        square.style.background = 'transparent'
    });
    activeNavItem = document.getElementById(item_id)
    var square = activeNavItem.getElementsByClassName('check-square')[0]
    square.style.background = '#123456'
}

