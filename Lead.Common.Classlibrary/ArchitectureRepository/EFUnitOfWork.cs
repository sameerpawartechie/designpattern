
using Lead.CodeFirst.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lead.Common.Classlibrary.ArchitectureRepository
{
    public class EFUnitOfWork : IUnitOfWork
    {
        #region Field Member and Constants

        /// <summary>
        /// gemsObjectContext
        /// </summary>
        private readonly LeadEntities semsObjectContext;

        #endregion Field Member and Constants

        #region Member Functions

        /// <summary>
        /// Method for resolve IOC pattern of Repository Class
        /// </summary>
        /// <typeparam name="T">IBaseRepository Class object</typeparam>
        /// <returns>IBaseRepository Class object</returns>
        public T Repository<T>() where T : IBaseRepository
        {

            var returnObject = Ioc.Resolve<T>();
            returnObject.UnitOfWork = this;
            return returnObject;
        }

        /// <summary>
        /// Disposes current session.
        /// </summary>
        public void Dispose()
        {
            // Check gemsObjectContext whether null or not
            if (null != semsObjectContext) semsObjectContext.Dispose();
        }

        #endregion Member Functions

        #region Constructor




        /// <summary>
        /// Constructor (Opens Entity Framework Entities object when constructed).
        /// </summary>
        /// 






        public EFUnitOfWork(int clientId = 0)
        {

            string conn = "SEMSEntities";
            //MemoryCache mem = MemoryCache.Default;
            //var output = mem.Get("key");
            //if (output == null)
            //{
            //    conn = getConnection(clientId).Connection;
            //    mem.Add("key", conn, DateTimeOffset.UtcNow.AddHours(1));
            //}
            //else
            //{

            //    conn = Convert.ToString(output);
            //}
            semsObjectContext = new LeadEntities();
            //semsObjectContext.LazyLoadingEnabled = false;
            //Commnted after the  error of ContextOptions 19/08/2013
            //semsObjectContext.ContextOptions.LazyLoadingEnabled = false;
        }

        #endregion Constructor

        #region Properties

        /// <summary>
        /// Returns the ObjectContext
        /// </summary>
        public LeadEntities LeadObjectContext
        {
            get
            {
                // Check gemsObjectContext whether null or not
                if (null == semsObjectContext)
                    // if gemsObjectContext is null then throw new GEMS exception
                    throw new Exception("SEMS Object Null");
                //   throw ;

                // return org object context
                return semsObjectContext;
            }
        }

        #endregion Properties

        //private tblClientDataBase getConnection(int clientId = 0)
        //{
        //    using (MasterEntities masterentity = new MasterEntities())
        //    {
        //        return masterentity.tblClientDataBase.Where(c => c.Id == clientId).FirstOrDefault();

        //    }
            
        //}

    }
}









