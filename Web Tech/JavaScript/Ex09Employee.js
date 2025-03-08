class Employee {
    constructor(id, name, address, salary) {
        this.empId = id;
        this.empName = name;
        this.empAddress = address;
        this.empSalary = salary
    }
    // display=()=>`${this.name} is from ${this.address} and has salary. ${this.salary}`;
}

class EmployeeRepo {
    data = [
        new Employee(1,"nikhil","bangalore",15000),
        new Employee(2,"prithvi","belgaum",34000),
        new Employee(3,"yash k","bangalore",56000),
        new Employee(4,"yash p","belgaum",10000),
    ];

    constructor(){
        this.loadData();
    }
    loadData=()=>{
        if(localStorage.getItem("empList")!=null){
            const json = localStorage.getItem("empList");
            this.data=JSON.parse(json);
        }
    }
    saveData=()=>{
        const json=JSON.stringify(this.data)
        localStorage.setItem("empList",json);
    }
    //addNewEmployee = (emp) => this.data =[...this.data, emp];//new features of ES7.
    addNewEmployee = (emp) =>{
        this.loadData()
         this.data =[...this.data, emp];
         this.saveData()
    }

    deleteEmloyee = (id) => {
        let index = this.data.findIndex((e) => e.empId == id);
        this.data.splice(index, 1);//removing an element 
    }

    getAllEmployees = () => [...this.data]

    updateEmployees = (id, emp) => {
        let index = this.data.findIndex((e) => e.empId == id);
        this.data.splice(index, 1, emp);//removes and add the element
    }
}

//gobal functions//

const hideElements=(...e1)=>[...e1].forEach(e = e.style.display="none");

const hide = function(elements){
    elements.forEach(element =>{
        element.style.display="none"
    });
}

const show=(id)=>document.getElementById(id).style.display='block';