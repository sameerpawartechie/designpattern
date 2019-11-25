using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lead.Common.Classlibrary.ArchitectureRepository
{
    public interface IUnitOfWork:IDisposable
    {

        /// <summary>
        /// Gets specified repository setup for this unit of work.
        /// </summary>
        /// <typeparam name="T">Domain Class object</typeparam>
        /// <returns>Domain Class object</returns>
        T Repository<T>() where T : IBaseRepository;
    }
}
