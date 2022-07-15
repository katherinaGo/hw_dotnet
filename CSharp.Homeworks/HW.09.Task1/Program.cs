using HW._09.Task1;

Person personOne = new Person();
Student studentOne = new Student();
Teacher teacherOne = new Teacher();

int studentAge = studentOne.Age = 27;
int teacherAge = teacherOne.Age = 30;

personOne.SayHello("Person John");
studentOne.ShowAge(studentAge);

studentOne.SayHello("Student Kate");
studentOne.ShowAge(studentAge);

teacherOne.SayHello("Teacher Mr. Vadim");
teacherOne.Explain();