using System.Text;
using BusinessLogic;
using DataAccessLayer;
using Model;

Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

var logic = new Logic(new EntityRepository<Student>());

while (true)
{
    PrintMenu();
    var choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            AddStudent(logic);
            break;
        case "2":
            DeleteStudent(logic);
            break;
        case "3":
            ShowAllStudents(logic);
            break;
        case "4":
            ShowSpecialityDistribution(logic);
            break;
        case "0":
            return;
        default:
            Console.WriteLine("Неверный пункт меню. Попробуйте ещё раз.");
            break;
    }

    Console.WriteLine();
}

static void PrintMenu()
{
    Console.WriteLine("===== DecanatPRO =====");
    Console.WriteLine("1 - Добавить студента");
    Console.WriteLine("2 - Удалить студента");
    Console.WriteLine("3 - Показать список студентов");
    Console.WriteLine("4 - Показать распределение по специальностям");
    Console.WriteLine("0 - Выход");
    Console.Write("Выберите пункт: ");
}

static string ReadNonEmpty(string prompt)
{
    string? value;
    do
    {
        Console.Write(prompt);
        value = Console.ReadLine();
    }
    while (string.IsNullOrWhiteSpace(value));

    return value.Trim();
}

static void AddStudent(Logic logic)
{
    var name = ReadNonEmpty("ФИО студента: ");
    var speciality = ReadNonEmpty("Направление подготовки: ");
    var group = ReadNonEmpty("Группа: ");

    logic.AddStudent(name, speciality, group);
    Console.WriteLine("Студент добавлен.");
}

static void DeleteStudent(Logic logic)
{
    var students = logic.GetAllStudents();

    if (students.Count == 0)
    {
        Console.WriteLine("Список студентов пуст.");
        return;
    }

    ShowAllStudents(logic);

    Console.Write("Введите номер (Id) студента для удаления: ");
    if (!int.TryParse(Console.ReadLine(), out var id))
    {
        Console.WriteLine("Нужно ввести число.");
        return;
    }

    var student = students.FirstOrDefault(s => s.Id == id);
    if (student == null)
    {
        Console.WriteLine("Студент с таким номером не найден.");
        return;
    }

    logic.DeleteStudent(student);
    Console.WriteLine("Студент удалён.");
}

static void ShowAllStudents(Logic logic)
{
    var students = logic.GetAllStudents();

    if (students.Count == 0)
    {
        Console.WriteLine("Список студентов пуст.");
        return;
    }

    Console.WriteLine($"{"Id",-5} {"ФИО",-25} {"Направление",-25} {"Группа",-10}");
    Console.WriteLine(new string('-', 68));

    foreach (var student in students)
    {
        Console.WriteLine($"{student.Id,-5} {student.Name,-25} {student.Speciality,-25} {student.Group,-10}");
    }
}

static void ShowSpecialityDistribution(Logic logic)
{
    var distribution = logic.GetSpecialityDistribution();

    if (distribution.Count == 0)
    {
        Console.WriteLine("Список студентов пуст.");
        return;
    }

    Console.WriteLine("Распределение студентов по специальностям:");

    foreach (var pair in distribution.OrderByDescending(p => p.Value))
    {
        var bar = new string('*', pair.Value);
        Console.WriteLine($"{pair.Key,-25} | {bar} ({pair.Value})");
    }
}