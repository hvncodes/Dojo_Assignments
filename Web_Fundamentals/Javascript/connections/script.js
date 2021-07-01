function editUser() {
    var profileName = document.querySelector("#profileName");
    profileName.innerText = "Mary Sue";
}
var requests = document.querySelectorAll(".requestsItem");
function removeUser(id) {
    requests[id].remove();
}
var numOfConnections = parseInt(document.querySelector("#connectionsBadge").innerText);
function addTotal() {
    numOfConnections++;
    document.querySelector("#connectionsBadge").innerText = numOfConnections;
}