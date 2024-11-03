#region 
// Student std1 = new Student();
// std1.Name = "Ruslan";
// std1.Surname = "Arabov";
// std1.Age = 18;
// std1.Grant = 100;
// std1.GroupNo = "pb503";

// std1.ShowFullData();

// public class Human
// {
//   public string Name;
//   public string Surname;
//   public byte Age;
// }
// public class Student : Human
// {
//    public double Grant;
//    public string GroupNo;
//    public void ShowFullData ()
//    {
//         System.Console.WriteLine($"Name: {Name} Surname: {Surname}  Age: {Age} Grant; {Grant} GroupNo {GroupNo}");
//    }

// }
// public class Teacher : Human
// {
//    public double Salary;
//    public string GroupNo;
// }


// Human human1 = new Human("Ruslan", "Arabov", 19);
// System.Console.WriteLine("humans data");
// human1.ShowFullData();

// public class Human
// {
//     public string Name = "noname";
//     public string Surname = "nosurname";
//     public byte Age = 18;


//     public Human()
//     {

//     }


//     public Human(string name)
//     {
//         Name = name;
//     }

//     public Human(string name, string surname) : this(name)
//     {
//         Surname = surname;
//     }

//     public Human(string name, string surname, byte age) : this(name,surname)
//     {
//         this.Age = age;
//     }

//     public void ShowFullData()
//     {
//         System.Console.WriteLine($"Name; {Name} Surname {Surname} age {Age}");
//     }
// }

#endregion


using Recap;

//Human human = new Human("Error" ,14);
Student student = new Student("sir", 10, 450); 
student.ShowFullData();