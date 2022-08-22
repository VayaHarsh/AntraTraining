function checkEmailId(str){
    var mailFormat = /^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/;
    if(str.match(mailFormat)){
        return true;
    }
    else {
        return false;
    }
}
var testStr = "abc@abc.in"

console.log(checkEmailId(testStr));
