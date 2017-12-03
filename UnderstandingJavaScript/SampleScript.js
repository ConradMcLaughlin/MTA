username = prompt("Please enter your name");
message = "Hello, " + username + ". Your name has ";
if (username.length > 5)
    message = message + "more than ";
else if (username.length < 5)
    message = message + "less than ";
else
    message = message + "exactly ";
message = message + "5 characters.";
alert(message);