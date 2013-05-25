var iife = function(){
	return "invoked!";
}();

console.log(iife);
(function(){
	console.log("invoked!");
}());

(function(){
	console.log("invoked!");
})();

!function(){
	console.log("invoked!");
}();