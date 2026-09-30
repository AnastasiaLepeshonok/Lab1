using DataAccessLayer;
using Model;

namespace BusinessLogic
{
    public class Logic
    {
        private readonly IRepository<Student> repository;

        public Logic(IRepository<Student> repository)
        {
            this.repository = repository;
        }

        public void AddStudent(string name, string speciality, string group)
        {
            repository.Create(new Student
            {
                Name = name,
                Speciality = speciality,
                Group = group
            });
        }

        public void DeleteStudent(Student student)
        {
            repository.Delete(student);
        }

        public List<Student> GetAllStudents()
        {
            return repository.ReadAll().ToList();
        }

        public Dictionary<string, int> GetSpecialityDistribution()
        {
            return GetAllStudents()
                .GroupBy(s => s.Speciality)
                .ToDictionary(g => g.Key, g => g.Count());
        }
    }
}
