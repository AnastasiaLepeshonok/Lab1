using System.Text;
using BusinessLogic;
using DataAccessLayer;
using Model;

Console.OutputEncoding = Encoding.UTF8;

var logic = new Logic(new EntityRepository<Student>());
logic.AddStudent("Нигматуллин", "ПИ", "КИ21-01");

foreach (var s in logic.GetAllStudents())
    Console.WriteLine($"{s.Id} | {s.Name} | {s.Speciality} | {s.Group}");

Console.ReadKey();