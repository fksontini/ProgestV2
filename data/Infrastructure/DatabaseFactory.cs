using data;
using Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DatabaseFactory : Disposable , IDatabaseFactory
    {
        private ContextProgest dataContext;
        public ContextProgest DataContext { get { return dataContext; } }

        public DatabaseFactory()
        {
            dataContext = new ContextProgest();
        }
        protected override void DisposeCore()
        {
            if (DataContext != null)
                DataContext.Dispose();
        }

    }
}
