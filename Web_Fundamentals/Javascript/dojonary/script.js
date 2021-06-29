function loginLogout(element) {
    if (element.innerText == "Login") {
        element.innerText = "Logout"
    } else {
        element.innerText = "Login"
    }
}

function addDef(element) {
    element.remove();
}

function likeBtnClicked(element) {
    var value = parseInt(element.getElementsByClassName("numOfLikes")[0].innerHTML);
    console.log(value+1);
    element.getElementsByClassName("numOfLikes")[0].innerText = value+1;
    var word = element.parentNode.getElementsByTagName("H2")[0].innerHTML;
    alert(word + " was liked!");
}