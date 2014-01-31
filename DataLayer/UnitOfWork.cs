using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private Context Context { get; set; }
        private IUcastnikRepository _ucastnici;
        private CNarodnostRepository _cNarodnosti;

        public UnitOfWork()
        {
            CreateContext();
        }

        public IUcastnikRepository Ucastnici
        {
            get
            {
                if (_ucastnici == null)
                {
                    _ucastnici = new UcastnikRepository(Context);
                }

                return _ucastnici;
            }
        }

        public CNarodnostRepository CNarodnosti
        {
            get
            {
                if (_cNarodnosti == null)
                {
                    _cNarodnosti = new CNarodnostRepository(Context);
                }

                return _cNarodnosti;
            }
        }

        protected void CreateContext()
        {
            Context = new Context();

            // Do NOT enable proxied entities, else serialization fails.
            //if false it will not get the associated certification and skills when we
            //get the applicants
            //Context.Configuration.ProxyCreationEnabled = false;

            // Load navigation properties explicitly (avoid serialization trouble)
            //Context.Configuration.LazyLoadingEnabled = false;

            // Because Web API will perform validation, we don't need/want EF to do so
            //DbContext.Configuration.ValidateOnSaveEnabled = false;

            //DbContext.Configuration.AutoDetectChangesEnabled = false;
            // We won't use this performance tweak because we don't need 
            // the extra performance and, when autodetect is false,
            // we'd have to be careful. We're not being that careful.
        }        
 
        public void Commit()
        {             
            Context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (Context != null)
                {
                    Context.Dispose();
                }
            }
        }
    }
}
