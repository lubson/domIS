using System;
namespace DataLayer
{
    public interface IUnitOfWork
    {
        void Commit();

        // Repositories
        IUcastnikRepository Ucastnici { get; }
    }
}
