using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        //class stu
        //{
        //    public int Id { get; set; }

        //    public string Name { get; set; }

        //    public int CategoryId { get; set; }
        //}

        //class Category
        //{
        //    public int Id { get; set; }

        //    public string Name { get; set; }
        //}
        static void Main(string[] args)
        {
            //    var Student = new List<students>()
            //    {
            //         new students(){Id = 1, Name="A 1", AddressId = 1},
            //         new students(){Id = 2, Name="A 2", AddressId = 0},
            //         new students(){Id = 3, Name="A 3", AddressId = 2},
            //         new students(){Id = 4, Name="A 4", AddressId = 0},
            //         new students(){Id = 5, Name="A 5", AddressId = 3},
            //    };

            //    var Addresses = new List<Address>()
            //    {
            //        new Address(){Id = 1, AddressLine = "Line 1"},
            //        new Address(){Id = 2, AddressLine = "Line 2"},
            //        new Address(){Id = 3, AddressLine = "Line 3"},
            //        new Address(){Id = 4, AddressLine = "Line 4"},
            //        new Address(){Id = 5, AddressLine = "Line 5"},
            //    };

            //    var Marks = new List<Marks>()
            //    {
            //        new Marks(){Id = 1, StudentId = 1, TMarks = 80},
            //        new Marks(){Id = 2, StudentId = 2, TMarks = 90},
            //        new Marks(){Id = 3, StudentId = 3, TMarks = 95},
            //    };

            //    //Query Syntax
            //    var qs = (from student in Student
            //              join address in Addresses
            //              on student.AddressId equals address.Id
            //              join mark in Marks
            //              on student.Id equals mark.StudentId
            //              select new
            //              {
            //                  StudentName = student.Name,
            //                  Line = address.AddressLine,
            //                  TotalMarks = mark.TMarks
            //              }).ToList();

            //    var stu = new List<stu>()
            //    {
            //        new stu(){Id=1, Name="A", CategoryId=1},
            //        new stu(){Id=2, Name="B", CategoryId=1},
            //        new stu(){Id=3, Name="C", CategoryId=2},
            //        new stu(){Id=4, Name="D", CategoryId=2},
            //        new stu(){Id=5, Name="E", CategoryId=3},
            //    };
            //    var cat = new List<Category>()
            //    {
            //        new Category(){Id=1, Name="F"},
            //        new Category(){Id=2, Name="G"},
            //        new Category(){Id=3, Name="H"},
            //    }; 


            //var qs = (from student in Student
            //          join address in Addresses
            //          on student.AddressId equals address.Id
            //          select new
            //          {
            //              StudentName = student.Name,
            //              Line = address.AddressLine
            //          }).ToList();

            //Method Syntax
            //var ms = Student.Join(Addresses,
            //                              std => std.AddressId,
            //                              address => address.Id,
            //                              (std, address) => new
            //                              {
            //                                  StudentName = std.Name,
            //                                  Line = address.AddressLine
            //                              }).ToList();
            //foreach (var item in ms)
            //{
            //    Console.WriteLine($"Name = {item.StudentName}, AddressLine = {item.Line}");
            //}

            //List<int> num = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //List<string> str = new List<string>() { "A", "B", "C", "D" };

            //var ms = num.First();
            ////var ms1 = num.Where(x => x > 5).First();
            //var ms2 = num.First(x => x > 5);

            //var ms1 = num.FirstOrDefault(x => x > 10);
            //var ms = num.ElementAt(11);
            //var ms = num.ElementAtOrDefault(11);

            //var qs = (from n in num
            //          select n).ElementAt(5);
            //var qs1 = (from n in num
            //          select n).ElementAtOrDefault(15);

            //var ms = str.ElementAt(1);
            //var ms1 = str.ElementAtOrDefault(50);

            //var qs = (from z in str
            //          select z).ElementAt(1);
            //var qs1 = (from z in str
            //          select z).ElementAtOrDefault(3);

            //List<Category> cat = new List<Category>()
            //{
            //    new Category(){Id = 1, Name="Ali Dilawar"},
            //    new Category(){Id = 2, Name="Ali Abbas"},
            //    new Category(){Id = 3, Name="Ali Raza"},
            //    new Category(){Id = 4, Name="Ali Akbar"},
            //};

            //var ms = cat.First(z => z.Id == 1 && z.Name == "Ali Dilawar");
            //var ms1 = cat.FirstOrDefault(z => z.Id == 1 && z.Name == "Ali");

            //var qs = (from n in cat
            //          select n).First(z => z.Id == 1 && z.Name == "Ali Dilawar");
            //var qs1 = (from n in cat
            //          select n).FirstOrDefault(z => z.Id == 1 && z.Name == "Ali");

            List<int> num = new List<int>() { 1, 2, 3};

            //var ms = num.Where(x => x > 1).Single();
            var ms1 = num.Where(x => x > 5).SingleOrDefault();

            //var ms = num.Last();
            //var ms1 = num.Where(x => x > 15).LastOrDefault();

            //var qs = (from n in num
            //          where  n > 15
            //          select n).Last();

            //var qs1 = (from n in num
            //           where n > 15
            //          select n).LastOrDefault();

            Console.ReadLine();
        }
    }
}
    //class StudentComparer : IEqualityComparer<Student>
    //{
    //    public bool Equals(Student x, Student y)
    //    {
    //        if (object.ReferenceEquals(x, y))
    //        {
    //            return true;
    //        }

    //        if (object.ReferenceEquals(x, null) || object.ReferenceEquals(y, null))
    //        {
    //            return false;
    //        }

    //        return x.StuId == y.StuId && x.StuName == y.StuName;
    //    }

    //    public int GetHashCode(Student obj)
    //    {
    //        if (object.ReferenceEquals(obj , null))
    //        {
    //            return 0;
    //        }

    //        var idHashCode = obj.StuId.GetHashCode();
    //        var nameHashCode = obj.StuName == null ? 0 : obj.StuName.GetHashCode();

    //        return idHashCode ^ nameHashCode;
    //    }
    //}


    //class studentComparer : IEqualityComparer<student>
    //{
    //    public bool Equals(student x, student y)
    //    {
    //        return x.Id.Equals(y.Id) && x.Name.Equals(y.Name);
    //    }

    //    public int GetHashCode(student obj)
    //    {
    //        int idhashCode = obj.Id.GetHashCode();
    //        int namehashCode = obj.Name.GetHashCode();

    //        return idhashCode ^ namehashCode;
    //    }
    //}
            //int totalnumberPageView = 4;
            //do
            //{
            //    Console.WriteLine("Enter Your Page Number");

            //    if(int.TryParse(Console.ReadLine(), out int pageNumber))
            //    {
            //        var ms = GetEmployees().Skip((pageNumber - 1) * totalnumberPageView).Take(totalnumberPageView);
            //        foreach (var item in ms)
            //        {
            //            Console.WriteLine($"Id = {item.Id}, Name = {item.Name}");
            //        }            
            //    }
            //    else
            //    {
            //        Console.WriteLine("Enter a Valid Page Number");
            //    }
            //} while (true);
        //public static List<employee> GetEmployees()
        //{
        //    return new List<employee>()
        //    {
        //        new employee(){Id=1, Name="A"},
        //        new employee(){Id=2, Name="B"},
        //        new employee(){Id=3, Name="C"},
        //        new employee(){Id=4, Name="D"},
        //        new employee(){Id=5, Name="E"},
        //        new employee(){Id=6, Name="F"},
        //        new employee(){Id=7, Name="G"},
        //        new employee(){Id=8, Name="H"},
        //        new employee(){Id=9, Name="I"},
        //        new employee(){Id=10, Name="J"},
        //        new employee(){Id=11, Name="K"},
        //        new employee(){Id=12, Name="L"},
        //        new employee(){Id=13, Name="M"},
        //        new employee(){Id=14, Name="N"},
        //        new employee(){Id=15, Name="O"},
        //        new employee(){Id=16, Name="P"},
        //        new employee(){Id=17, Name="Q"},
        //        new employee(){Id=18, Name="R"},
        //        new employee(){Id=19, Name="S"},
        //        new employee(){Id=20, Name="T"},
        //    };
        //}
    //class employee
    //{
    //    public int Id { get; set; }

    //    public string Name { get; set; }
    //}
            //List<student> students = new List<student>()
            //{
            //    new student() {Id=1,Name="Ali"},
            //    new student() {Id=2,Name="Aqib"},
            //    new student() {Id=3,Name="Afzal"},
            //    new student() {Id=4,Name="Azhar"},
            //};
            //List<student> students1 = new List<student>()
            //{
            //    new student() {Id=1,Name="Ali"},
            //    new student() {Id=2,Name="Aqib"},
            //    new student() {Id=5,Name="Afzal"},
            //    new student() {Id=6,Name="Azhar"},
            //};

            ////Annoynmous type
            //var ms = students.Except(students1, new studentComparer()).ToList();

            //var qs = (from x in students
            //          select x).Except(students1, new studentComparer()).ToList();

            //foreach (var item in qs)
            //{
            //  Console.WriteLine($"Id = {item.Id}, Name = {item.Name}");
            //}

            //List<string> dataSource1 = new List<string>() { "A", "B", "C", "D" };
            //List<string> dataSource2 = new List<string>() { "C", "D", "E", "F" };

            //var ms = dataSource1.Intersect(dataSource2).ToList();

            //var misS = (from ch in dataSource2
            //            select ch).Intersect(dataSource1).ToList();

            //List<student> student1 = new List<student>()
            //{
            //    new student() {Id = 1 , Name = "Ali"},
            //    new student() {Id = 2 , Name = "hadi"},
            //    new student() {Id = 3 , Name = "talha"},
            //    new student() {Id = 4 , Name = "osama"},
            //};
            //List<student> student2 = new List<student>()
            //{
            //    new student() {Id = 1 , Name = "Ali"},
            //    new student() {Id = 2 , Name = "hadi"},
            //    new student() {Id = 5 , Name = "talha"},
            //    new student() {Id = 6 , Name = "osama"},
            //};

            //ANNOUNMOUS TYPE
            //var ms = student1.Select(x => new { x.Id, x.Name }).Intersect(student2.Select(x => new { x.Id, x.Name })).ToList();

            //var ms = student1.Intersect(student2, new studComparer()).ToList();

            //List<string> dataSource1 = new List<string>() { "A", "A", "B", "C", "D" };
            //List<string> dataSource2 = new List<string>() { "C", "D", "E", "F" };

            //List<student> student1 = new List<student>()
            //{
            //    new student(){Id = 1, Name = "Ali"},
            //    new student(){Id = 2, Name = "hadi"},
            //    new student(){Id = 3, Name = "fahad"},
            //    new student(){Id = 4, Name = "jamal"},
            //};
            //List<student> student2 = new List<student>()
            //{
            //    new student(){Id = 1, Name = "Ali"},
            //    new student(){Id = 2, Name = "hadi"},
            //    new student(){Id = 5, Name = "fahad"},
            //    new student(){Id = 6, Name = "jamal"},
            //};
            //Announmous Type
            //var ms = student1.Select(x => new { x.Id, x.Name }).Union(student2.Select(x => new { x.Id, x.Name})).ToList();
            //var ms = student1.Union(student2, new studentComparer()).ToList();

            //int[] number = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            ////var ms = number.Where(x => x > 3).Take(5).ToArray();
            //var ms = number.Take(5).Where(x => x > 3).ToArray();

            //var mixedS = (from x in number 
            //              where x > 3
            //              select x).Take(4).ToList();
            //int[] number = new int[] { 1, 2, 6, 7, 8, 9, 10, 3,4,5 };
            ////var ms = number.Where(x => x > 11).ToList();

            //var ms = number.TakeWhile(x => x < 7).ToList();
            //var qs = (from x in number select x).TakeWhile(x => x < 7).ToList();

            //List<string> names = new List<string>()
            //{
            //    "kim",
            //    "John",
            //    "Mark",
            //    "Ada",
            //    "nitish"
            //};
            //var mss = names.TakeWhile((name, index) => name.Length > index).ToList();
            //var qss = (from x in names select x).TakeWhile((name, index) => name.Length > index).ToList();

            //int[] number = new int[] { 1, 2, 6, 7, 8, 9, 10, 3, 4, 5 };
            //List<string> names = new List<string>() { "kim", "john", "mark", "adam", "nitish" };

            //var ms = number.Where(x => x > 4).Skip(3).ToArray();
            //var mix = (from x in names select x).Skip(2).ToList();  

            //int[] number = new int[] { 1, 3, 4, 5, 6, 7, 8, 9, 10, 2 };
            //List<string> names = new List<string>() { "kim", "john", "mark", "adam", "nitish" };

            //var ms = number.SkipWhile(x => x < 6).ToArray();

            //var mix = (from x in number select x).SkipWhile(x => x < 5).ToArray();

            //var ms1 = names.SkipWhile((value, index) => value.Length > index).ToList();

            //Console.ReadLine();

            //List<student> stdudents = new List<student>
            //{
            //    new student() {Id = 1, Name = "John"},
            //    new student() {Id = 2, Name = "Kim"},
            //    new student() {Id = 3, Name = "John"},
            //    new student() {Id = 4, Name = "Mark"},
            //};          

            //var ms = stdudents.Distinct(new studentComparer()).ToList();


            //List<string> dataSource1 = new List<string>() { "A", "B", "C", "D" };
            //List<string> dataSource2 = new List<string>() { "C", "D", "E", "F" };

            //var ms = dataSource1.Except(dataSource2).ToList();

            //List<student> students = new List<student>()
            //{
            //    new student() {Id=1,Name="Ali"},
            //    new student() {Id=2,Name="Aqib"},
            //    new student() {Id=3,Name="Afzal"},
            //    new student() {Id=4,Name="Azhar"},
            //    new student() {Id=4,Name="bilal"},
            //};
            //List<student> students1 = new List<student>()
            //{
            //    new student() {Id=1,Name="Ali"},
            //    new student() {Id=2,Name="Aqib"},
            //    new student() {Id=5,Name="Afzal"},
            //    new student() {Id=6,Name="Azhar"},
            //};

            //var ms = students.Select(x => x.Name).Except(students1.Select(x => x.Name)).ToList();
            //Where Type

            //var obj = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            ////Query Syntax + Mixed syn.
            //var Query = (from num in obj
            //             where num > 5 || num < 5 || num <= 6 || num >=9 && num == 10 || num != 0
            //             select num).ToList();

            ////Method Syntax
            //var method = obj.Where(x => x > 5 || x < 5 || x <= 6 || x >= 9 && x == 10 || x != 0).ToList();

            //OffType

            //var dataSource = new List<object>() { "Ali", "Zafar", "Dilawar", "Farwa", 1, 2, 3, 45, 6, 7, 8, 9 };


            ////Method 
            //var metSyn = dataSource.OfType<string>().Where(x => x.Length > 3).ToList();

            ////Query
            //var QueSyn = (from x in dataSource
            //              where x is string
            //              select x).ToList();


            //Order By Syntax just Arrange Sort data 

            //var dataSourceInt = new List<int>() { 2, 6, 8, 5, 1, 3, 7, 10, 9 };

            //var dataSourceString = new List<string>()
            //{
            //    "Zafar",
            //    "waqas",
            //    "Ali",
            //    "Abid",
            //    "sajida"
            //};

            //var query = (from str in dataSourceString
            //             where str.Length > 4
            //             orderby str
            //             select str).ToList();

            //var method = dataSourceString.Where(x => x.Length > 4).OrderBy(x => x).ToList();

            //var query = (from num in dataSourceInt
            //             where num < 6
            //             orderby num
            //                  select num).ToList();

            //var method = dataSourceInt.Where(x => x < 6).OrderBy(x => x).ToList();

            //foreach (var item in method)
            //{
            //    Console.WriteLine(item);
            //}

            //var dataSourceEmp = new List<Employee>()
            //{
            //    new Employee()
            //    {
            //        id = 1,
            //        name = "wahaj",
            //        email = "this@this.com"
            //    },
            //    new Employee()
            //    {
            //        id = 2,
            //        name = "jafar",
            //        email = "this@this.com"
            //    },
            //    new Employee()
            //    {
            //        id = 3,
            //        name = "zafar",
            //        email = "this@this.com"
            //    },
            //    new Employee()
            //    {
            //        id = 4,
            //        name = "ali",
            //        email = "this@this.com"
            //    },
            //};

            //var query = (from x in dataSourceEmp
            //             where x.id > 2
            //             orderby x.id
            //             select x).ToList();

            //var method = dataSourceEmp.Where(x => x.id > 2).OrderBy(x => x.name).ToList();

            // OrderBy Descending Syntax just Arrange Sort data

            //var dataSourceInt = new List<int>() { 2, 6, 8, 5, 1, 3, 7, 10, 9 };

            //var query = (from x in dataSourceInt
            //             where x > 5
            //             orderby x descending
            //             select x).ToList();

            //var method = dataSourceInt.Where(x => x > 5).OrderByDescending(x => x).ToList();
            //foreach (var item in query)
            //{
            //    Console.WriteLine(item);
            //}


            //var dataSourceString = new List<string>()
            //{
            //    "Zafar",
            //    "waqas",
            //    "Ali",
            //    "Abid",
            //    "sajida"
            //};

            //var methodS = dataSourceString.Where(x => x.Length > 5).OrderByDescending(x => x).ToList();

            //var queryS = (from x in dataSourceString
            //              where x.Length > 5
            //              orderby x descending
            //              select x).ToList();

            //var dataSourceEmp = new List<Employee>()
            //{
            //    new Employee()
            //    {
            //        id = 3,
            //        name = "wahaj",
            //        email = "this@this.com"
            //    },
            //    new Employee()
            //    {
            //        id = 1,
            //        name = "jafar",
            //        email = "this@this.com"
            //    },
            //    new Employee()
            //    {
            //        id = 4,
            //        name = "zafar",
            //        email = "this@this.com"
            //    },
            //    new Employee()
            //    {
            //        id = 2,
            //        name = "ali",
            //        email = "this@this.com"
            //    },
            //};

            //var method = dataSourceEmp.Where(x => x.id > 2).OrderByDescending(x => x.id).ToList();

            //var query = (from x in dataSourceEmp
            //             where x.id > 2
            //             orderby x.name descending
            //             select x).ToList();

            //foreach (var item in method)
            //{
            //    Console.WriteLine($"{item.id}, name = {item.name}, email = {item.email}");
            //}

            //var ds = new List<Employee>()
            //{
            //    new Employee()
            //    {
            //        id = 1,
            //        name="Ali",
            //        email = "this@this.com"
            //    },
            //    new Employee()
            //    {
            //        id = 4,
            //        name="Alisba",
            //        email = "this@this.com"
            //    },
            //    new Employee()
            //    {
            //        id = 3,
            //        name="Alisha",
            //        email = "this@this.com"
            //    },
            //};

            //var ms = ds.OrderBy(x => x.name).ThenBy(x => x.name).ToList();

            //var qs = from x in ds
            //         orderby x.name descending, x.name descending
            //         select x;
            //foreach (var item in ms)
            //{
            //    Console.WriteLine($"{item.id}, name = {item.name}, email = {item.email}");
            //}


            //Student[] student = {new Student { StuName = "Ali", StuMarks = 90 },
            //                    new Student { StuName = "Kamran", StuMarks = 85 },
            //                    new Student { StuName = "Fahad", StuMarks = 75} };

            //var method = student.All(x => x.StuMarks > 80);

            //var query = (from x in student
            //             select x).All(x => x.StuMarks > 70);


            //Student[] student =
            //{
            //    new Student { 
            //        StuName = "Ali Dilawar", StuMarks = 80,
            //            Subject = new List<Subject>(){
            //                new Subject(){ subName = "DBMS", subMarks = 78},
            //                new Subject(){ subName = "AI", subMarks = 80},
            //                new Subject(){ subName = "Maths", subMarks = 90}
            //            }
            //    },
            //    new Student {
            //        StuName = "Kamran", StuMarks = 80,
            //            Subject = new List<Subject>(){
            //                new Subject(){ subName = "DBMS", subMarks = 88},
            //                new Subject(){ subName = "AI", subMarks = 70},
            //                new Subject(){ subName = "Maths", subMarks = 60}
            //            }
            //    },
            //     new Student {
            //        StuName = "Waqas", StuMarks = 75,
            //            Subject = new List<Subject>(){
            //                new Subject(){ subName = "DBMS", subMarks = 95},
            //                new Subject(){ subName = "AI", subMarks = 85},
            //                new Subject(){ subName = "Maths", subMarks = 65}
            //            }
            //    },

            //};

            //var ms = student.Where(std => std.Subject.All(x => x.subMarks > 70)).Select(std => std).ToList();

            //var qs = (from std in student
            //          where std.Subject.All(x => x.subMarks > 70)
            //          select std).ToList();

            //List<int> number = new List<int>() { 1, 2, 3, 4, 5 };

            //Student[] student = { new Student() { StuName = "Ali", StuMarks = 67 },
            //                      new Student() {StuName = "Hadi", StuMarks = 80},
            //                      new Student() {StuName = "Jamal", StuMarks = 96}};

            //var ms = student.Any(x => x.StuMarks > 90);

            //var qs = (from std in student
            //          select std).Any(x => x.StuMarks > 90);
            //var avaliable = number.Any(); 

            //Student[] student =
            //{
            //    new Student
            //    {
            //        StuName = "hadi", StuMarks = 76,
            //             Subject = new List<Subject>(){
            //                 new Subject(){subName = "Maths", subMarks = 80},
            //                 new Subject(){subName = "Eng", subMarks = 95}
            //             }
            //    },
            //    new Student
            //    {
            //        StuName = "Ali", StuMarks = 86,
            //             Subject = new List<Subject>(){
            //                 new Subject(){subName = "Maths", subMarks = 95},
            //                 new Subject(){subName = "Eng", subMarks = 100}
            //             }
            //    },
            //};

            //var ms = student.Where(std => std.Subject.Any(x => x.subMarks > 90)).Select(std => std).ToList();

            //var qs = (from std in student
            //          where std.Subject.Any(x => x.subMarks > 95)
            //          select std.StuName).ToList();

            //List<string> names = new List<string>() { "Ali", "zafar", "taqi" };

            //var ms = names.AsEnumerable().Contains("Ali");

            //var qs = (from std in names
            //          select std).Contains("Dilawar");

            //List<Student> students = new List<Student>()
            //{
            //    new Student(){StuId = 1, StuName = "Ali"},
            //    new Student(){StuId = 2, StuName = "zafar"}
            //};

            //var std = new Student() { StuId = 1, StuName = "Ali" };

            //students.Add(std);

            ////var isExist = students.Contains(new Student() { StuId = 1, StuName = "Ali" }); //Return false b/c reference is different
            ////var isExist = students.Contains(std);

            //var comparer = new StudentComparer();

            //var ms = students.Contains(new Student() { StuId = 1, StuName = "Ali" }, comparer);

            //var qs = (from x in students
            //          select x).Contains(new Student() { StuId = 1, StuName = "Ali" }, comparer);

            //List<int> num = new List<int>() { 1, 1, 2, 3, 4, 5, 4, 3, 5, 6, 7 };

            //var ms = num.Distinct().ToList();

            //var qs = (from x in num
            //          select x).Distinct().ToList();


            //Console.ReadLine();

            //List<Employee> myList = new List<Employee>()
            //{
            //    new Employee() {id = 1, name = "Ali", email = "this@this.com"},
            //    new Employee() {id = 2, name = "Ali B", email = "this@this12.com"},
            //    new Employee() {id = 3, name = "Ali C", email = "this@this123.com"},
            //    new Employee() {id = 4, name = "Ali D", email = "this@this211.com"},
            //    new Employee() {id = 4, name = "Ali D", email = "this@this211.com"},
            //};

            //var BasicQuery = (from emp in myList
            //                  select emp).ToList();

            //var BasicMethod = myList.ToList();


            ////-----------
            /////-----Operation
            ///////-------
            /////
            //var basicPropQuery = (from a in myList
            //                      select a.id.ToString()).ToList();

            //var basicPropMethod = myList.Select(b => b.id).ToList();

            //var selectQuery = (from emp in myList
            //                   select new Student()
            //                   {
            //                       StuId= emp.id,
            //                       StuName = emp.name,
            //                       StuEmail = emp.email
            //                   }).ToList();

            //var selectMethod = myList.Select(emp => new Student()
            //{
            //    StuId = emp.id,
            //    StuName = emp.name,
            //    StuEmail = emp.email
            //}).ToList();

            //var selectQuery = (from emp in myList
            //                   select new
            //                   {
            //                       CustomId = emp.id,
            //                       CustomName = emp.name,
            //                       CustomEmail = emp.email
            //                   }).ToList();

            //var selectMethod = myList.Select(emp => new
            //{
            //    CustomId = emp.id,
            //    CustomName = emp.name,
            //    CustomEmail = emp.email
            //}).ToList(); 

            //var Query = myList.Select((emp, index) => new { Index = index, FullName = emp.name }).ToList();

            //foreach (var item in Query)
            //{
            //    Console.WriteLine($"Id = {item.CustomId}, Name = {item.CustomName}, Email = {item.CustomEmail}");
            //}
            //Console.ReadLine();
            //Query Syntax
            //Console.WriteLine("----Query Syntax------");
            //List<int> mylist = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 }; //DataSourse

            //var querySyntax = from obj in mylist  //QuerySyntax
            //                  where obj > 2
            //                  select obj;

            //foreach (var item in querySyntax)  //Execution
            //{
            //    Console.WriteLine(item);
            //}

            ////Method Syntax
            //Console.WriteLine("-----Method Syntax-------");
            //var methodSyntax = mylist.Where(x => x > 2);
            //foreach (var item in methodSyntax)
            //{
            //    Console.WriteLine(item);
            //}

            ////Mixed Syntax
            //Console.WriteLine("-----Mixed Syntax------");
            //var mixedSyntax = (from x in mylist
            //                   select x).Max();
            //Console.WriteLine("Max value is: " + mixedSyntax);
            //Console.ReadLine();

            //IEnumerable is ana Interface

            //List<Employee> employees = new List<Employee>
            //{
            //    new Employee() {id=1, name="Ali"},
            //    new Employee() {id=2, name="Waqas"}
            //};

            //IEnumerable<Employee> query = from emp in employees
            //                         where emp.id == 1
            //                         select emp;

            //foreach (var item in query)
            //{
            //    Console.WriteLine("Id is = " + item.id + " Name = " + item.name);
            //}
            //Console.ReadLine();

            //List<Student> myList = new List<Student>
            //{
            //    new Student() {Id=1,name="fahad",Age=23},
            //    new Student() {Id=2,name="ali",Age=23},
            //    new Student() {Id=3,name="waqas",Age=23},
            //    new Student() {Id=4,name="hadi",Age=24},
            //};

            //IQueryable<Student> query = myList.AsQueryable().Where(x => x.Id == 1);

            //foreach (var item in query)
            //{
            //    Console.WriteLine("Id is: " + item.Id + " Name is " + item.name);
            //}
            //Console.ReadLine();
        //}
        //class student
        //{
        //    public int Id { get; set; }
        //    public string Name { get; set; }
        //}

        //class studentComparer : IEqualityComparer<student>
        //{
        //    public bool Equals(student x, student y)
        //    {
        //        return x.Id.Equals(y.Id) && x.Name.Equals(y.Name);
        //    }

        //    public int GetHashCode(student obj)
        //    {
        //        int idHash = obj.Id.GetHashCode();
        //        int nameHash = obj.Name.GetHashCode();

        //        return idHash ^ nameHash;
        //    }
        //}


        //class studentComparer : IEqualityComparer<student>
        //{
        //    public bool Equals(student x, student y)
        //    {
        //        return x.Id.Equals(y.Id) && x.Name.Equals(y.Name);
        //    }

        //    public int GetHashCode(student obj)
        //    {
        //        int idHashCode = obj.Id.GetHashCode();
        //        int nameHashcode = obj.Name.GetHashCode();

        //        return idHashCode ^ nameHashcode;
        //    }
        //}
        //class student : IEquatable<student>
        //{
        //    public int Id { get; set; }
        //    public string Name { get; set; }

        //    public bool Equals(student other)
        //    {
        //        if (object.ReferenceEquals(other, null))
        //        {
        //            return false;
        //        }

        //        if (object.ReferenceEquals(this,other))
        //        {
        //            return true;
        //        }

        //        return Id.Equals(other.Id) && Name.Equals(other.Name);
        //    }

        //    public override int GetHashCode()
        //    {
        //        int idhashCode = Id.GetHashCode();
        //        int namehashCode = Name.GetHashCode();

        //        return idhashCode ^ namehashCode;
        //    }
        //}

        //class Employee
        //{
        //    public int id { get; set; }

        //    public string name { get; set; }
        //}

        //class Student
        //{ 
        //    public int Id { get; set; }
        //    public string name { get; set; }
        //    public int Age { get; set; }
        //}
//    }
//}
