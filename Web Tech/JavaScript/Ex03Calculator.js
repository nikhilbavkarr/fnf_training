let v1 = prompt("Enter the first value : ");
console.log(typeof(v1));
if(isNaN(v1))
{
alert("This si not a valid number , so taking zero ")
v1=0;
}
v1=parseFloat(v1);
let v2 = parseFloat(prompt("Enter the second value : "));
if(isNaN(v2))
    {
    alert("This si not a valid number , so taking zero ")
    v2=0;
    }
let op = prompt("Enter UR choice + , - , * , / : ");

switch(op){
    case "+":alert("added result:" + ( v1 + v2 ));
    break;
    case "-":alert("added result:" + ( v1 - v2 ));
    break;
    case "*":alert("added result:" + ( v1 * v2 ));
    break;
    case "/":alert("added result:" + ( v1 / v2 ));
    break;
    default:
        alert("unrecongnized choice");
        break;
}
