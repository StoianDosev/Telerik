
function printMsg(msg){
  console.log("Message: " + msg);  
}
printMsg.call(null, ["Important message"]);

var numbers = [1,3,4,5,6,2,1,3,4,5,56];

var max = Math.max.apply (null, numbers);
var max2 = Math.max(1,1,1,2,436,76,89);

console.log(max);
console.log(max2);
//here this is null, since it is not used anywhere in //the function
//more about this in OOP
