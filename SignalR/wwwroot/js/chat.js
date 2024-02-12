document.addEventListener('DOMContentLoaded', function () {
    var userName = prompt("Please Enter Your Name: ");

    var messageInput = document.getElementById("messageInp")
    var GroupNameInput = document.getElementById("GroupNameInp")
    var messageToGroupInput = document.getElementById("messageToGroupInp")

    messageInput.focus();

    var proxyConnection = new signalR.HubConnectionBuilder().withUrl("/Chat").build();

    proxyConnection.start().then(function () {

        document.getElementById("sendMessageBtn").addEventListener("click", function (e) {
            e.preventDefault();
            proxyConnection.invoke("Send", userName, messageInput.value);
        });

        document.getElementById("JoinGroupBtn").addEventListener("click", function (e) {
            e.preventDefault();
            proxyConnection.invoke("JoinGroup", GroupNameInput.value, userName);
        });

        document.getElementById("SendMessageToGroupBtn").addEventListener("click", function (e) {
            e.preventDefault();
            proxyConnection.invoke("SendMessageToGroup", GroupNameInput.value, userName, messageToGroupInput.value);
        });
    }).catch(function (error) {
        console.log(error);
    });

    proxyConnection.on("ReceiveMessage", function (userName, message) {
        var listelement = document.createElement("li");
        listelement.innerHTML = `<strong>${userName} : </strong> ${message}`;
        document.getElementById("Conversation").appendChild(listelement)
    })

    proxyConnection.on("NewMemberJoin", function (userName, groupName) {
        var listelement = document.createElement("li");
        listelement.innerHTML = `<i>${userName} has Joined </i> ${groupName}`;
        document.getElementById("groupConversationUl").appendChild(listelement)
    })

    proxyConnection.on("ReceiveMessageFromGroup", function (message, sender) {
        document.getElementById("messageToGroupInp").value = "";
        var listelement = document.createElement("li");
        listelement.innerHTML = `<strong>${sender} : </strong> ${message}`;
        document.getElementById("groupConversationUl").appendChild(listelement)
    })

});  