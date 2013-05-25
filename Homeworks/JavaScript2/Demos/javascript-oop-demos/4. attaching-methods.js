function Person(name,age){
  this.name = name;
  this.age = age;
}
Person.prototype.sayHello = function(){
  console.log("My name is " + this.name + " and I am " + 
        this.age + "-years old.");
};



var varadin =new Person("Varadin",12);
console.log(varadin.name);
varadin.sayHello();

var v = new Person("Pesho",22).sayHello();
