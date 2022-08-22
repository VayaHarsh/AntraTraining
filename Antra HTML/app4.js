truncate("What I'd like to tell on this topic is:", 20);

function truncate(str, maxlength){
    var newStr = "";
    if(str.length > maxlength){
        newStr = str.substr(0, maxlength - 1)
        newStr = newStr + '...';
    }
    else
        newStr = str;

    console.log(newStr);
}