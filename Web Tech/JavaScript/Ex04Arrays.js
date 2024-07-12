const fruits=["Apples","Mangoes","Oranges"]
console.log(fruits)

for(let i=0;i<fruits.length;i++){
    const element = fruits[i]
    console.log(element)
}

// forof is similar to foreach in c#

for(const element of fruits){
    console.log(element);
}

for(const key in fruits){
    console.log(`Index: ${key}: Value: ${fruits[key]}`)
}

console.log("ES5 syntax of foreach statement using Arrow operator(lambda expression)");
fruits.forEach((element)=>{
    console.log(element)
})

// for add elements in array

fruits.push("Pinepple"); //used to add in the end
fruits.push("orange");
fruits.push("watermellon");

fruits.unshift("kiwi");   //used to add in the begining

console.log("trying to add in between");
fruits.splice(2,0,"chiku","grapes")  //splice method is used to remove , insert , replace  elements within the array
fruits.splice(2,1)

for(const element of fruits){
    console.log(element)
}