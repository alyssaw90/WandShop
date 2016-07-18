using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotterWandShop
{
    class Wand
    {
        #region Properties
        /// <summary>
        /// Wand Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Wand Name
        /// </summary>
        public string WandName { get; set; }

        /// <summary>
        /// Wand Description
        /// </summary>
        public string WandDescription { get; set; }

        /// <summary>
        /// Wand Price
        /// </summary>
        public decimal WandPrice { get; set; }
        #endregion
    }
}
