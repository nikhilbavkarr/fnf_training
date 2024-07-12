const items =[];

const addItem = (item) => items.push(item);

const removeItem = (item) => {
    let index= items.indexOf(item);
    if(index<0){
        throw "Item Not Found to Remove";
    }
    items.splice(index,1);
}

const GetAllItems = () => items;