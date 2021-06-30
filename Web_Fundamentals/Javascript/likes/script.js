// function likeBtnClicked(element) {
//     var value = parseInt(element.getElementsByClassName("numOfLikes")[0].innerHTML);
//     console.log(value+1);
//     element.getElementsByClassName("numOfLikes")[0].innerText = value+1;
//     var word = element.parentNode.getElementsByTagName("H2")[0].innerHTML;
//     alert(word + " was liked!");
// }

function likeBtnClicked(element) {
    var parent = element.parentNode;
    // console.log(parent);
    var index = null;
    for (var i = 0; i < parent.childNodes.length; i++) {
        console.log(parent.childNodes[i]);
        if (parent.childNodes[i].className == "numOfLikes") {
            index = i;
            break;
        }        
    }
    console.log(parseInt(parent.childNodes[index].innerHTML))
    var value = parseInt(parent.childNodes[index].innerHTML);
    parent.childNodes[index].innerHTML = value + 1 + " like(s)";
}