using  CSharpHomework9.Models.Person;

Person person = new Person("nika", "nikoladze", 18);
person.Print();
Console.WriteLine("\n");
Student student = new Student("gio","giorgadze",22,"giorgi@gmail.com","gio123");
student.Print();
Console.WriteLine("\n");

Faculty faculty = new Faculty("webdev" ,"web development",3,"educate@gmail.com","webdev123",
    250,2850); 
faculty.Print();
Console.WriteLine("\n");

Course course = new Course("C# course","backend dev",2,3,2);
course.Print();
Console.WriteLine("\n");

Teacher teacher = new Teacher("Anders","Hejlsberg",60, 5000,30);
teacher.Print();
Console.WriteLine("\n");

Subject subject = new Subject("programming","developerment",2,"Web Development + Game Development",360);
subject.Print();
Console.WriteLine("\n");

ExperienceYears experience = new ExperienceYears("beso", "lomidze", 24, 5);
experience.Print();
Console.WriteLine("\n");

Administrator administrator = new Administrator("uncle", "BoB", 55, "Clean Code", 30);
administrator.Print();
Console.WriteLine("\n");

Position position = new Position("Nika","lekishvili",17,2000,511123321,"Software Engineer");
position.Print();


 