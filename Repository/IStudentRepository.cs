using TP4_Habib_Sellami.Models;

namespace TP4_Habib_Sellami.Repository;

public interface IStudentRepository : IRepository<Student>
{
    public List<String> GetAllCourses();
    public List<Student> GetStudentsByCourse(String course);

}
