//This is my JS Ref file

/*

Numbers
String
Array
Object
Boolean (var pass= true; or var fail= false;)
*/// Possible variable & Data types

/*
var cityName = "BridgeTown";
//String
var busNumber = 12;
//Number

var shoppingList = ["Milk", "Eggs", 20, true];
//array

***? var living = {
    cityName: "London",
    country: "UK" //object

}
*/// Variable & Data types

/*

var firN = 25;
var secN = "15";

//If you start with a string it will assume the rest of the bracket is also a string rather than adding them together, console.log(firN+2+secN); would add them.

console.log(secN+2+firN);

*/// 1st method

/*
var myCar; // This is camel case
var MyCar; //This is Partial
var my_Car; //This is Underscore

*/// variables name types

/* 

// JavaScript Arrays are number index based starting from 0
//JavaScript Objects are name index based

/*var jsF = []; //Array literal, this is better than the constructor
var jsF = new Array(); // Array constructor*/

//var jsF = ["jQuery", "nodeJS", "reactJS"];
/*var jsF = new Array (3);*/

//jsF[0] = "Java"; // replaces the 0 value of the array with Java
//jsF.push("Jordan");// push adds Jordan onto the end of the array
//jsF.reverse();// reverses the order of the array, changing the first value to the last
//jsf.pop(); */// Arrays

/*for(var i=0; i< 6; i++){

    console.log(i)
}
*/// For loop

/*
// Do while loop

var myN = [32,75,3,6];
var i = 0;
do {

        console.log(i);
    i++;

}
//var i = index **
while (var i <= 10;)

*/// array for do while loop

/*

// === is more strict and means they need to be the same data type 
    if (6 == 6 && 4 != 3){
    
        console.log("This is true")
        
    }

    else {
    
        console.log("This is false")
    }

var car = "empty";

switch(car){

    case "BMW":
        alert("That's not my car");
        break;
        
        case "Mercedes":
        alert("I love this car");
        break;
        
        case "Mustang":
        alert("I want this car");
        break;
        
        case "Corsa":
        alert("This is my car");
        break;
        
    default:
        alert("none of the above");
        break;

}
*/// Conditions (If, Else, Switch)

/*
 Jsf.sort() is a method (which is the same as a function)
Jsf.length is a property because it doesnt have ()

*/// Method vs. Property

/*  
    // Java script function is a block of code designed to perform a particular task
    
    
var height = 5;
var width = 9;
//var total;

function area() 
{
// Remember to invoke/call the function (area();) and it must be outside the function block
    
total = height * width;
    
    
    console.log(total);

    return total;
}

   area();
    
//alert("OK Im here now")


*/// Functions

/*
//Anonymous functions are those without a name

// window.onload=function() means this function is called whenever the page is loaded.


window.onload=function()
{
alert("I have arrived")
}


setTimeout(function()
           {
           alert ("Sorry im late");
           }, 10000); // 10000 is in miliseconds and so is equal 10 seconds
*/// Anonymous Functions

/*

var height = 5;
var width = 9;
var total;


var area = function() 
{
// Remember to invoke/call the function (area();) and it must be outside the function block
    
total = height * width;
    
    
    console.log(total);

    return total;
}

area()
*/// Assigning a function to a variable

/*// Self encaupsulated/executible functions do not need to be called. Example (function(){}) ()


var height = 5;
var width = 9;
var total;


var area = function() 
{
// ** Remember when a function is encapsulated it does not need to be called, nor does it need to be assigned to a variable
    
total = height * width;
    
    
    console.log(total);

    //return total;
    
}()
*/// Self encaupsulated/executible functions

/*
// height, width & length are the parameters (parameters are also variables), parameters expect values

function calcVolume (height, width, length)
{

return height * width * length;

}

var livingRoom = calcVolume(3,5,4)
var kitchen = calcVolume(2,7,3)
var bedRoom = calcVolume(8,2,2)

// The values inside the parameters are arguments. Example calcVolume(3,5,4)

console.log(livingRoom)
console.log(kitchen)
console.log(bedRoom)
*/// Parameters & Aruguments

 /*// An object is an unordered collection of key value pairs.

// var student = new object (); this is an object constructor
// var student = {}; this is an object literal

// Not very good practise

var student = new Object();

student.firstName = "Jordan";
student.lastName = "Lewin";

console.log(student.firstName);

var ages = new Array(33);

console.log(ages);


// The good practice
var student = 
    {
   // When creating an object using literal you need to use a comma to seperate the properties (e.g. firstName: "Jordan",lastName: "Lewin"). **The last property should never have a comma
        
    firstName: "Jordan",
    lastName: "Lewin",
    getName: function()
        {
     return student.firstName + " " + this.lastName;
    // this. is used to show the property is part of the same object (e.g. student). 
            
    //student.firstName could be used instead but is bad practice because it is not necessary
        },
        
        address:
        {
            doorN: 12,
            street: "Borne Street",
            postCode:"EH3 4GT"
        }
         
        
    };

   console.log(student.getName());
   console.log(student.address.doorN);

var ages = [21];

console.log(ages);

 // The best practice of object programming is the follow Json format & understand OOP

*/// Objects

