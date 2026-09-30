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
        private List<Student> students = new List<Student>();

        public void AddStudent(string name, string speciality, string group)
        {
            students.Add(new Student
            {
                Name = name,
                Speciality = speciality,
                Group = group
            });
        }

        public void DeleteStudent(int index)
        {
            if (index >= 0 && index < students.Count)
            {
                students.RemoveAt(index);
            }
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