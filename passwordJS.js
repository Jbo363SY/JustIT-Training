
var access = "Jordan";

var wrongPassword = [];

var i = 0;

document.getElementById("myButton").addEventListener("click", checkPassword, false);

function checkPassword() {

    
    var userPassword = document.getElementById("userP").value;

    
    
  if (userPassword === "")
  {
      
  alert("Please enter a password");
      
  }
    if (userPassword == access)
 {
 alert("Well done this password is correct");
 }
    
}