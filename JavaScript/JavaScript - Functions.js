//Problem 1
console.log("Problem 1:");
let salaries = {
    John: 100,
    Ann: 160,
    Pete: 130
}
var sum = salaries.John + salaries.Ann + salaries.Pete;
console.log(sum);

//Problem 2
console.log("\nProblem 2:");
function multiplyNumeric(obj){
    for(let k in obj){
        if(typeof obj[k] == 'number'){
            obj[k] = obj[k] * 2;
        }
    }
}
let menu = {width: 200,height: 300,title: "My menu"};
console.log("width: " + menu.width);
console.log("height: " + menu.height);
console.log("title:" + menu.title);
multiplyNumeric(menu);
console.log("width: " + menu.width);
console.log("height: " + menu.height);
console.log("title:" + menu.title);

//Problem 3
console.log("\nProblem 3:");
function checkEmailId(str){
    if(str.length == 0){
        console.log("Invalid Email");
        return false;
    }
    if(str[0] == "@" || str[0] == "."){
        console.log("Invalid Email");
        return false;
    }
    var AtIndex = -1;
    var DotIndex = -1;
    for(var i = 1; i < str.length; i++){
        if(str[i]=="@"){
            AtIndex = i;
        }
        else if(str[i]=="."){
            if(AtIndex==-1){
                console.log("Invalid Email");
                return false;
            }
            else if(i-AtIndex==1){
                console.log("Invalid Email");
                return false;
            }
            DotIndex = i;
        }
    }
    if(AtIndex==-1||DotIndex==-1){
        console.log("Invalid Email");
        return false;
    }
    if(DotIndex==(str.length-1)){
        console.log("Invalid Email");
        return false;
    }
    console.log("Valid Email!");
    return true;

}
checkEmailId("Test");
checkEmailId("Test@.test");
checkEmailId("Test@test.");
checkEmailId("@Test.test");
checkEmailId("Test.te@st");
checkEmailId("Test@te.st");

//Problem 4
console.log("\nProblem 4:");
function truncate(str,maxlength){
    if(str.length<=maxlength){
        return str;
    }
    else{
        return str.substr(0,maxlength-1) + "…";
    }
}
console.log(truncate("What I'd like to tell on this topic is:", 20));
console.log(truncate("Hi everyone!", 20));

//Problem 5
console.log("\nProblem 5:");
var myArr = ["James","Brennie"];
console.log(myArr);
myArr.push("Robert");
console.log(myArr);
myArr[(myArr.length-1)/2] = "Calvin";
console.log(myArr);
myArr.shift();
console.log(myArr);
myArr.unshift("Rose","Regal");
console.log(myArr);