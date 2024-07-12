//In JS , a class is created in 4 possible ways : 3 based on old format and 1 on ES6 format
//singleton object

const emp={
    empName:"nikhil",
    empAddress:"belgaum",
    empSalary: 60000
}

console.log(emp)

const emp2=emp;
emp2.empSalary=700000;

console.log(emp.empSalary);
console.log(emp2.empSalary);

for(const key in emp){
    console.log(`property: ${key},Value :${emp[key]}`);
}


const emp3={...emp,empDesignation:"Trainer"};
console.log(emp3);

// creating multipule object
//Earlier syntax was to treat a function as an object

const employee=function(id,name,address){
    this.empId=id;
    this.empName=name;
    this.empAddress=address
    this.display=function(){
        return `${this.empName}is from ${this.empAddress}`
    }
}

const employee1=new employee(1,"nikhil","belgaum");
const employee2=new employee(2,"prithvi","belgaum");

alert(employee2.display());

employee2.empAddress="bangalore";

console.log(employee1.empAddress);
console.log(employee2.empAddress);


////ES6 syntax

class Customer{
    constructor(id,name,address,bill){
        this.id=id;
        this.name=name;
        this.address=address;
        this.BillAmount=bill
    }
    display=()=>`${this.name} is from ${this.address} and has raised the bill amount of Rs. ${this.BillAmount}`;
}

const cst=new Customer(1,"yash","belgaum",50000);
alert(cst.display())
