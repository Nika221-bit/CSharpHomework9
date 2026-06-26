using  CSharpHomework9.Models.Person;

Person person = new Person("nika", "nikoladze", 18);
person.Print();
Student student = new Student("gio","giorgadze",22,"giorgi@gmail.com","gio123");
student.Print();
Faculty faculty = new Faculty("webdev" ,"web development",3,"educate@gmail.com","webdev123",
    250,2850);
faculty.Print();