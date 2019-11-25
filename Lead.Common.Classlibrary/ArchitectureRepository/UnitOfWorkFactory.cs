
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lead.Common.Classlibrary.ArchitectureRepository;

namespace Lead.Common.Classlibrary.ArchitectureRepository
{
    public class UnitOfWorkFactory
    {
        #region Member Functions

        /// <summary>
        /// Creates a new unit of work using IoC container.
        /// </summary>
        /// <returns></returns>
        public static IUnitOfWork NewUnitOfWork(int clientId = 0)
        {
            return Ioc.Resolve<IUnitOfWork>(clientId);
        }

        #endregion Member Functions
    }
}
