setExample();

function setExample(){

let set =new Set();
// set is used to store unquie data.
set.add("item1")
set.add("item2")
set.add("item3")
set.add("item4")

if(set.has("item1")){
    console.log("Item is already present");
}
else{
    set.add("item1");
}
return set;
}


const items= new Map();
items.set("Apple",200);
items.set("Mangoes",500);

console.log(items.has("Mangoes"));

for(const pair of items)
{
    console.log(`key: ${pair}`);
}
