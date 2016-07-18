using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotterWandShop
{
    class User
    {
        #region Properties
        /// <summary>
        /// User Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// User Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// User Email Address
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// User Password
        /// </summary>
        public string Password { get; set; }
        #endregion
    }
}
