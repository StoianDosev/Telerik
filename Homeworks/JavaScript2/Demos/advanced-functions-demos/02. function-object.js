function one (a){
console.log(a);
}
one("aaa");

one.op = function a(b) {
	console.log(b);
};
one.op("bbb");

 var second = function dred(d){
	 console.log(d);
}

second.fun = function (fun){
	console.log(fun);
};
second.fun("fun");
second("ddd");
console.log(second.fun.toString());