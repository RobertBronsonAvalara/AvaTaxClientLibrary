/* 
 * AvaTax API
 *
 * REST interface to Avalara's enterprise tax service, AvaTax.
 *
 * OpenAPI spec version: v2
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Avalara.AvaTax.RestClient.Model
{
    /// <summary>
    /// Address Resolution Model
    /// </summary>
    [DataContract]
    public partial class AddressResolutionModel :  IEquatable<AddressResolutionModel>
    {
        /// <summary>
        /// The resolution quality of the geospatial coordinates
        /// </summary>
        /// <value>The resolution quality of the geospatial coordinates</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ResolutionQualityEnum
        {
            
            /// <summary>
            /// Enum NotCoded for "NotCoded"
            /// </summary>
            [EnumMember(Value = "NotCoded")]
            NotCoded,
            
            /// <summary>
            /// Enum External for "External"
            /// </summary>
            [EnumMember(Value = "External")]
            External,
            
            /// <summary>
            /// Enum CountryCentroid for "CountryCentroid"
            /// </summary>
            [EnumMember(Value = "CountryCentroid")]
            CountryCentroid,
            
            /// <summary>
            /// Enum RegionCentroid for "RegionCentroid"
            /// </summary>
            [EnumMember(Value = "RegionCentroid")]
            RegionCentroid,
            
            /// <summary>
            /// Enum PartialCentroid for "PartialCentroid"
            /// </summary>
            [EnumMember(Value = "PartialCentroid")]
            PartialCentroid,
            
            /// <summary>
            /// Enum PostalCentroidGood for "PostalCentroidGood"
            /// </summary>
            [EnumMember(Value = "PostalCentroidGood")]
            PostalCentroidGood,
            
            /// <summary>
            /// Enum PostalCentroidBetter for "PostalCentroidBetter"
            /// </summary>
            [EnumMember(Value = "PostalCentroidBetter")]
            PostalCentroidBetter,
            
            /// <summary>
            /// Enum PostalCentroidBest for "PostalCentroidBest"
            /// </summary>
            [EnumMember(Value = "PostalCentroidBest")]
            PostalCentroidBest,
            
            /// <summary>
            /// Enum Intersection for "Intersection"
            /// </summary>
            [EnumMember(Value = "Intersection")]
            Intersection,
            
            /// <summary>
            /// Enum Interpolated for "Interpolated"
            /// </summary>
            [EnumMember(Value = "Interpolated")]
            Interpolated,
            
            /// <summary>
            /// Enum Rooftop for "Rooftop"
            /// </summary>
            [EnumMember(Value = "Rooftop")]
            Rooftop,
            
            /// <summary>
            /// Enum Constant for "Constant"
            /// </summary>
            [EnumMember(Value = "Constant")]
            Constant
        }

        /// <summary>
        /// The resolution quality of the geospatial coordinates
        /// </summary>
        /// <value>The resolution quality of the geospatial coordinates</value>
        [DataMember(Name="resolutionQuality", EmitDefaultValue=false)]
        public ResolutionQualityEnum? ResolutionQuality { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddressResolutionModel" /> class.
        /// </summary>
        /// <param name="Address">The original address.</param>
        /// <param name="ValidatedAddresses">The validated address or addresses.</param>
        /// <param name="Coordinates">The geospatial coordinates of this address.</param>
        /// <param name="ResolutionQuality">The resolution quality of the geospatial coordinates.</param>
        /// <param name="TaxAuthorities">List of informational and warning messages regarding this address.</param>
        /// <param name="Messages">List of informational and warning messages regarding this address.</param>
        public AddressResolutionModel(AddressInfo Address = null, List<AddressInfo> ValidatedAddresses = null, CoordinateInfo Coordinates = null, ResolutionQualityEnum? ResolutionQuality = null, List<TaxAuthorityInfo> TaxAuthorities = null, List<AvaTaxMessage> Messages = null)
        {
            this.Address = Address;
            this.ValidatedAddresses = ValidatedAddresses;
            this.Coordinates = Coordinates;
            this.ResolutionQuality = ResolutionQuality;
            this.TaxAuthorities = TaxAuthorities;
            this.Messages = Messages;
        }
        
        /// <summary>
        /// The original address
        /// </summary>
        /// <value>The original address</value>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public AddressInfo Address { get; set; }
        /// <summary>
        /// The validated address or addresses
        /// </summary>
        /// <value>The validated address or addresses</value>
        [DataMember(Name="validatedAddresses", EmitDefaultValue=false)]
        public List<AddressInfo> ValidatedAddresses { get; set; }
        /// <summary>
        /// The geospatial coordinates of this address
        /// </summary>
        /// <value>The geospatial coordinates of this address</value>
        [DataMember(Name="coordinates", EmitDefaultValue=false)]
        public CoordinateInfo Coordinates { get; set; }
        /// <summary>
        /// List of informational and warning messages regarding this address
        /// </summary>
        /// <value>List of informational and warning messages regarding this address</value>
        [DataMember(Name="taxAuthorities", EmitDefaultValue=false)]
        public List<TaxAuthorityInfo> TaxAuthorities { get; set; }
        /// <summary>
        /// List of informational and warning messages regarding this address
        /// </summary>
        /// <value>List of informational and warning messages regarding this address</value>
        [DataMember(Name="messages", EmitDefaultValue=false)]
        public List<AvaTaxMessage> Messages { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddressResolutionModel {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  ValidatedAddresses: ").Append(ValidatedAddresses).Append("\n");
            sb.Append("  Coordinates: ").Append(Coordinates).Append("\n");
            sb.Append("  ResolutionQuality: ").Append(ResolutionQuality).Append("\n");
            sb.Append("  TaxAuthorities: ").Append(TaxAuthorities).Append("\n");
            sb.Append("  Messages: ").Append(Messages).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as AddressResolutionModel);
        }

        /// <summary>
        /// Returns true if AddressResolutionModel instances are equal
        /// </summary>
        /// <param name="other">Instance of AddressResolutionModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddressResolutionModel other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Address == other.Address ||
                    this.Address != null &&
                    this.Address.Equals(other.Address)
                ) && 
                (
                    this.ValidatedAddresses == other.ValidatedAddresses ||
                    this.ValidatedAddresses != null &&
                    this.ValidatedAddresses.SequenceEqual(other.ValidatedAddresses)
                ) && 
                (
                    this.Coordinates == other.Coordinates ||
                    this.Coordinates != null &&
                    this.Coordinates.Equals(other.Coordinates)
                ) && 
                (
                    this.ResolutionQuality == other.ResolutionQuality ||
                    this.ResolutionQuality != null &&
                    this.ResolutionQuality.Equals(other.ResolutionQuality)
                ) && 
                (
                    this.TaxAuthorities == other.TaxAuthorities ||
                    this.TaxAuthorities != null &&
                    this.TaxAuthorities.SequenceEqual(other.TaxAuthorities)
                ) && 
                (
                    this.Messages == other.Messages ||
                    this.Messages != null &&
                    this.Messages.SequenceEqual(other.Messages)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Address != null)
                    hash = hash * 59 + this.Address.GetHashCode();
                if (this.ValidatedAddresses != null)
                    hash = hash * 59 + this.ValidatedAddresses.GetHashCode();
                if (this.Coordinates != null)
                    hash = hash * 59 + this.Coordinates.GetHashCode();
                if (this.ResolutionQuality != null)
                    hash = hash * 59 + this.ResolutionQuality.GetHashCode();
                if (this.TaxAuthorities != null)
                    hash = hash * 59 + this.TaxAuthorities.GetHashCode();
                if (this.Messages != null)
                    hash = hash * 59 + this.Messages.GetHashCode();
                return hash;
            }
        }
    }

}