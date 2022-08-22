let menu = {width: 200, height: 300, title: "My menu"};

function multiplyNumeric(menu){
    menu.width = 2 * menu.width;
    menu.height = 2 * menu.height;
}

multiplyNumeric(menu);

console.log(menu);