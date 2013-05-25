var fun = function max(arr){ 
	var max = arr[0];
	for(var i = 1; i< arr.length; i+=1){
		max = Math.max(max,arr[i]);
	}
	return max;
}
console.log(fun.length); //returns 1
console.log(fun.name); //returns "max"
//console.log((function(){}).name);