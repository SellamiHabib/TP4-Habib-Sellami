using TP4_Habib_Sellami.Data;

namespace TP4_Habib_Sellami.Repository;

public class UnitOfWork : IUnitOfWork
{
    private readonly UniversityContext context;
    public IStudentRepository Students { get; private set; }
    public UnitOfWork(UniversityContext context)
    {
        this.context = context;
        Students = new StudentRepository(context);
    }
    public bool Complete()
    {
        try
        {
            int result = context.SaveChanges();
            return result > 0;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public void Dispose()
    {
        context.Dispose();
    }
}
