using System;
namespace DataLayer
{
    public interface IUnitOfWork : IDisposable
    {
        Context Context();
        int Commit();
    }
}
