var school = (function() {
    var students = [];
    var teachers = [];
    function addStudent(name, grade) {
        students.push({name:name,grade:grade});
    }
    function addTeacher(name, specialty) {
        teachers.push({name:name,specialty:specialty});    
    }
    function getTeachers(specialty) {
        var selected = [];
        for (var i = 0; i < teachers.length; i++) {
            if((specialty && specialty == teachers[i].specialty) || (!specialty) ){
                selected.push(teachers[i]);
            }
        };
        return selected;
    }
    function getStudents(grade) {
        var selected = [];
        if(grade){
            for (var i = 0; i < students.length; i++) {
                if(grade == students[i].grade){
                    selected.push(students[i])
                }
            };
        }
        else{
            for (var i = 0; i < students.length; i++) {
                    selected.push(students[i])
            };
        }
        // for (var i = 0; i < students.length; i++) {
            // if((grade && grade == students[i].grade) || (!grade) ){
                // selected.push(students[i]);
            // }
        // };   
        return selected;
   }
    return {
        addStudent: addStudent,
        addTeacher: addTeacher,
        getTeachers: getTeachers,
        getStudents: getStudents
    };
})();

//console.log(school);
school.addStudent("Peter",2);
school.addStudent("Georgi",4);
school.addStudent("Maria",3);
school.addStudent("Stamat",2);
school.addTeacher("Zoran","Math")
school.addTeacher("Boran","Music")
console.log(school.getStudents());
console.log(school.getStudents(2));
console.log(school.getTeachers());
