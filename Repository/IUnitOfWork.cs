using TP4_Habib_Sellami.Models;

namespace TP4_Habib_Sellami.Repository;

public interface IUnitOfWork : IDisposable
{
    IStudentRepository Students { get; }
    bool Complete();
}
