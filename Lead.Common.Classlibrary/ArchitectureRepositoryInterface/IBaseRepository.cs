/*--------------------------------------------------
 * School Education ManageMent System
 * 
 * created By Sagar Bhagwant Kalokhe
 * -------------------------------------------------
 * File Name:-IBaseRepository Interface
 * 
 * Created Date :- 26/03/2013 10.25 PM
 * 
 * 
 --------------------------------------------------*/
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
