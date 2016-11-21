using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Avalara.AvaTax.RestClient
{
    /// <summary>
    /// Address Resolution Model
    /// </summary>
    public class AddressResolutionModel
    {
        /// <summary>
        /// The original address
        /// </summary>
        public AddressInfo address { get; set; }

        /// <summary>
        /// The validated address or addresses
        /// </summary>
        public AddressInfo[] validatedAddresses { get; set; }

        /// <summary>
        /// The geospatial coordinates of this address
        /// </summary>
        public CoordinateInfo coordinates { get; set; }

        /// <summary>
        /// The resolution quality of the geospatial coordinates
        /// </summary>
        public String resolutionQuality { get; set; }

        /// <summary>
        /// List of informational and warning messages regarding this address
        /// </summary>
        public TaxAuthorityInfo[] taxAuthorities { get; set; }

        /// <summary>
        /// List of informational and warning messages regarding this address
        /// </summary>
        public AvaTaxMessage[] messages { get; set; }


    }
}
