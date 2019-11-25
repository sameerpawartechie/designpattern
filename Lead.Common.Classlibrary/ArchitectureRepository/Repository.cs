
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lead.Common.Classlibrary.ArchitectureRepository;
using Lead.Common.Classlibrary;
using Lead.CodeFirst.Repository;

namespace Lead.Common.Classlibrary.ArchitectureRepository
{
    public class Repository
    {

        /// <summary>
        /// UnitOfWork
        /// </summary>
        public IUnitOfWork UnitOfWork { get; set; }

        #region Properties

        /// <summary>
        /// OrgContextObject
        /// </summary>
        protected LeadEntities LeadContextObject
        {
            get
            {
                // check if unitOfWork is null
                if (null == UnitOfWork)
                    // if unitOfWork is null then throw new GEMS exception
                    throw new Exception("Unit Of Work Null");
                // check if unitOfWork is EFUnitOfWork
                if (UnitOfWork is EFUnitOfWork)
                    // GemsObjectContext property of UnitOfWork
                    return (UnitOfWork as EFUnitOfWork).LeadObjectContext;
                throw new Exception("UnitOfWorkObjectInvalid");
            }
        }

        #endregion Properties
    }
}
