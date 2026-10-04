using Dapper;
using Microsoft.Data.SqlClient;
using Model;

namespace DataAccessLayer.Repositories
{
    public class DapperStudentRepository : IRepository<Student>
    {
        private readonly string connectionString;

        public DapperStudentRepository()
        {
            connectionString = DbSettings.ConnectionString;
        }

        public void Create(Student obj)
        {
            using var connection = new SqlConnection(connectionString);

            const string sql = """
                INSERT INTO Students (Name, Speciality, [Group])
                VALUES (@Name, @Speciality, @Group)
                """;

            connection.Execute(sql, obj);
        }

        public IEnumerable<Student> ReadAll()
        {
            using var connection = new SqlConnection(connectionString);

            const string sql = """
                SELECT Id, Name, Speciality, [Group]
                FROM Students
                """;

            return connection.Query<Student>(sql).ToList();
        }

        public Student? ReadById(int id)
        {
            using var connection = new SqlConnection(connectionString);

            const string sql = """
                SELECT Id, Name, Speciality, [Group]
                FROM Students
                WHERE Id = @Id
                """;

            return connection.QueryFirstOrDefault<Student>(
                sql,
                new { Id = id });
        }

        public void Update(Student obj)
        {
            using var connection = new SqlConnection(connectionString);

            const string sql = """
                UPDATE Students
                SET Name = @Name,
                    Speciality = @Speciality,
                    [Group] = @Group
                WHERE Id = @Id
                """;

            connection.Execute(sql, obj);
        }

        public void Delete(Student obj)
        {
            using var connection = new SqlConnection(connectionString);

            const string sql = """
                DELETE FROM Students
                WHERE Id = @Id
                """;

            connection.Execute(sql, new { Id = obj.Id });
        }
    }
}