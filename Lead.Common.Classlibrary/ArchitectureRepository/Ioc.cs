
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Configuration;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;

namespace Lead.Common.Classlibrary.ArchitectureRepository
{
    public class Ioc
    {

        #region Private and Static Member Fields

        /// <summary>
        /// container
        /// </summary>
        private static readonly IUnityContainer Container;

        #endregion Private and Static Member Fields

        #region Member Function

        /// <summary>
        /// Method For Resolve Container
        /// </summary>
        /// <typeparam name="T">Domain Class Interface</typeparam>
        /// <returns>Domain Class Interface</returns>
        public static T Resolve<T>(int clientId=0)
        {
            return Container.Resolve<T>(new ParameterOverride("clientId",clientId));
        }

        #endregion Member Function

        #region Constructor

        /// <summary>
        /// Default constructor.
        /// </summary>
        static Ioc()
        {
            //Container = new UnityContainer();

            // Load information from the Unity section of the config file
            //var section
            //= (UnityConfigurationSection)ConfigurationManager.GetSection("unity");

            // Create and configure the container ('OrgContainer' is the name of container)
           // section.Configure(Container, "SEMSContainer");
        }

        #endregion  Constructor
    }
}
