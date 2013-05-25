function Person(name, age){ 
  this.name = name; 
  this.age = age; 
}

function Student(name, age, grade){
  Person.apply(this, arguments); 
  //Person.call(this, name, age);
  this.grade = grade;
}

Student.prototype = new Person();
Student.prototype.constructor = Student(); 

var a = new Person("Jo",11)
console.log(a.name);
var b = new Student("Bo",12,1);
console.log(b.grade);

