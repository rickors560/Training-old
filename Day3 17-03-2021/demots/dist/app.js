"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
console.log("Importing Different Class and using Function\n");
const demo_1 = require("./demo");
function newProduct() {
    let p = new demo_1.Product();
    p.Id = "1";
    p.Price = 200;
    p.Title = "taazaa";
    p.inStock = true;
    return p;
}
let p = newProduct();
console.log(p);
console.log("\n");
console.log("\nDifferent types of Data-Types\n");
var isdone = false;
var sandeep = "Engineer";
var ritik = "Stud";
var list = [1, 2, 3];
console.log(isdone);
console.log(sandeep);
console.log(ritik);
console.log(list);
console.log("\n");
console.log("\nUsing Union and Intersection with 'type'\n");
var x = [{
        name: 'Sandeep',
        grade: 7,
        age: 21,
        sportsname: 'kabaddi'
    },
    {
        name: 'Ritik',
        grade: 100,
        age: 21,
        sportsname: 'basketball'
    },
    {
        name: 'asif',
        grade: 7,
        age: 25,
        sportsname: 'nothing'
    }];
var y = [{
        name: 'Arpit',
        grade: 3,
        sportsname: 'criket'
    },
    {
        name: 'Harsh',
        age: 21,
        sportsname: 'chess'
    },
    {
        name: 'Harshit',
        grade: 7,
        age: 2
    }];
function prints(t) {
    t.forEach((t1) => {
        console.log(t1);
    });
    console.log("\n");
}
prints(x);
prints(y);
//# sourceMappingURL=app.js.map