
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lead.Common.Classlibrary.ArchitectureRepository
{
    public interface IBaseRepository
    {
        /// <summary>
        /// UnitOfWork
        /// </summary>
        IUnitOfWork UnitOfWork { get; set; }

    }
}
