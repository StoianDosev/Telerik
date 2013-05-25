 Function.prototype.inherit = function(parent) {
        this.prototype = new parent();
        this.prototype.constructor = parent;
};

function Person(name,age){
	this.name = name;
	this.age = age;

	this.toString = function(){
		var str ="";
		for (var prop in this){
			if(this.hasOwnProperty(prop) && (typeof this[prop]!=='function')){
				str+= "{"+prop+": "+this[prop]+"}, ";
			}
		}

		return str.substring(0,str.length-2);
	};
}

function Student(name,age,grade){
	Person.apply(this,arguments);
	this.grade = grade;
}


Student.inherit(Person);

var per = new Person("Gosho Peshev",11)
//console.log(per.toString());
console.log(per.age + " "+ per.name);

var st = new Student("Pesho",22,4);
//console.log(st.toString());
console.log(st.age + " "+st.grade);
//console.log(st instanceof Student);
//console.log(st instanceof Person);





function Prop(acceleration,bla) {
	this.acceleration = acceleration;
	this.bla = bla;
};

function Propel(acceleration, bla, power) {
    this.power = power;
    Prop.apply(this, arguments);
    
}
Propel.inherit(Prop);

var p = new Propel( 50,111,"bla");
console.log(p.power+ " " + p.acceleration+ " " + p.bla);

