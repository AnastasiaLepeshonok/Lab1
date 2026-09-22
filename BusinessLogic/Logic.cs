using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace BusinessLogic
{
    public class Logic
    {
        public List<Student> students { get; set; } = new List<Student>();

        public void AddStudent(string name, string speciality, string group)
        {
            students.Add(new Student
            {
                Name = name,
                Speciality = speciality,
                Group = group
            });
        }

        public void DeleteStudent(string name, string speciality, string group)
        {
            var student = students.FirstOrDefault(s =>
                s.Name == name &&
                s.Speciality == speciality &&
                string.Equals(s.Group, group, StringComparison.OrdinalIgnoreCase));

            if (student != null)
                students.Remove(student);
        }

        public List<Student> GetAllStudents()
        {
            return students;
        }

        public Dictionary<string, int> GetSpecialityDistribution()
        {
            return students
                .GroupBy(s => s.Speciality)
                .ToDictionary(g => g.Key, g => g.Count());
        }
    }
}