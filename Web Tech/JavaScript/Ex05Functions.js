//named functions
function AddFunc(v1,v2)
{
    return(v1+v2);
}

//func can be represented as variables and used. creating anonymous methods in javascripts.

const SubFunc = function(v1,v2)
{
    return(v1-v2);
}

//anonymous methods are simolified using lambda methods.

const MulFunc = (v1,v2) => v1*v2;

const DivFunc = (v1,v2) => v1/v2;



// const v1 = parseFloat(prompt("Enter the first value : "));
// const v2 = parseFloat(prompt("Enter the second value : "));
// const res=AddFunc(v1,v2); //or use let and keep a single variable for result 
// const res1=SubFunc(v1,v2);
// console.log(res);
// console.log(res1);
// console.log(MulFunc(v1,v2));