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
    /// Summary information about an overall transaction.
    /// </summary>
    public class TransactionSummary
    {
        /// <summary>
        /// Two character ISO-3166 country code.
        /// </summary>
        public String country { get; set; }

        /// <summary>
        /// Two or three character ISO region, state or province code, if applicable.
        /// </summary>
        public String region { get; set; }

        /// <summary>
        /// The type of jurisdiction that collects this tax.
        /// </summary>
        public JurisdictionType? jurisType { get; set; }

        /// <summary>
        /// Jurisdiction Code for the taxing jurisdiction
        /// </summary>
        public String jurisCode { get; set; }

        /// <summary>
        /// The name of the jurisdiction that collects this tax.
        /// </summary>
        public String jurisName { get; set; }

        /// <summary>
        /// The unique ID of the Tax Authority Type that collects this tax.
        /// </summary>
        public Int32? taxAuthorityType { get; set; }

        /// <summary>
        /// The state assigned number of the jurisdiction that collects this tax.
        /// </summary>
        public String stateAssignedNo { get; set; }

        /// <summary>
        /// The tax type of this tax.
        /// </summary>
        public TaxType? taxType { get; set; }

        /// <summary>
        /// The name of the tax.
        /// </summary>
        public String taxName { get; set; }

        /// <summary>
        /// Group code when special grouping is enabled.
        /// </summary>
        public String taxGroup { get; set; }

        /// <summary>
        /// Indicates the tax rate type.
        /// </summary>
        public RateType? rateType { get; set; }

        /// <summary>
        /// Tax Base - The adjusted taxable amount.
        /// </summary>
        public Decimal? taxable { get; set; }

        /// <summary>
        /// Tax Rate - The rate of taxation, as a fraction of the amount.
        /// </summary>
        public Decimal? rate { get; set; }

        /// <summary>
        /// Tax amount - The calculated tax (Base * Rate).
        /// </summary>
        public Decimal? tax { get; set; }

        /// <summary>
        /// Tax Calculated by Avalara AvaTax.  This may be overriden by a TaxOverride.TaxAmount.
        /// </summary>
        public Decimal? taxCalculated { get; set; }

        /// <summary>
        /// The amount of the transaction that was non-taxable.
        /// </summary>
        public Decimal? nonTaxable { get; set; }

        /// <summary>
        /// The amount of the transaction that was exempt.
        /// </summary>
        public Decimal? exemption { get; set; }


    }
}