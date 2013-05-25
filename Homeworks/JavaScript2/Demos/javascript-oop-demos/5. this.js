function Person(name) {
	var self = this;
	//self.name = name;
  this.name = name;
  	//self.getName =
  this.getName = 
  	function getPersonName(name) {
    	//return this.name;
    	this.innerName=name;
    	return "Outer name: "+ this.name + " - inner name: " + this.innerName;
  	}
} 
var p = new Person("Gosho");
var d = new Person("Pesho");

var getName = p.getName();
console.log(getName); //Gosho ... undefined
console.log(d.getName("Peshev")); //Pesho... Peshev