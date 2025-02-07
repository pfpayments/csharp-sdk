using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = PostFinanceCheckout.Client.SwaggerDateConverter;

namespace PostFinanceCheckout.Model
{
    /// <summary>
    /// AnalyticsQuery
    /// </summary>
    [DataContract]
    public partial class AnalyticsQuery :  IEquatable<AnalyticsQuery>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsQuery" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AnalyticsQuery() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsQuery" /> class.
        /// </summary>
        /// <param name="accountId">The ID of the account in which the query is to be executed. (required).</param>
        public AnalyticsQuery(long? accountId)
        {
            // to ensure "accountId" is required (not null)
            if (accountId == null)
            {
                throw new InvalidDataException("accountId is a required property for AnalyticsQuery and cannot be null");
            }
            this.AccountId = accountId;
        }

        /// <summary>
        /// The ID of the account in which the query is to be executed.
        /// </summary>
        /// <value>The ID of the account in which the query is to be executed.</value>
        [DataMember(Name="accountId", EmitDefaultValue=false)]
        public long? AccountId { get; set; }

        /// <summary>
        /// A client-generated nonce which uniquely identifies some action to be executed. Subsequent requests with the same external ID do not execute the action again, but return the original result.
        /// </summary>
        /// <value>A client-generated nonce which uniquely identifies some action to be executed. Subsequent requests with the same external ID do not execute the action again, but return the original result.</value>
        [DataMember(Name="externalId", EmitDefaultValue=false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// The maximum age (in minutes) of queries already executed that are to be taken into account. If an equivalent query is already available and not older than the specified age, its result will be returned instead of re-executing it. To force a new execution, specify a new, unique external ID and no maximum cache age.
        /// </summary>
        /// <value>The maximum age (in minutes) of queries already executed that are to be taken into account. If an equivalent query is already available and not older than the specified age, its result will be returned instead of re-executing it. To force a new execution, specify a new, unique external ID and no maximum cache age.</value>
        [DataMember(Name="maxCacheAge", EmitDefaultValue=false)]
        public int? MaxCacheAge { get; set; }

        /// <summary>
        /// The PrestoDB/Athena SQL statement to be executed.
        /// </summary>
        /// <value>The PrestoDB/Athena SQL statement to be executed.</value>
        [DataMember(Name="queryString", EmitDefaultValue=false)]
        public string QueryString { get; set; }

        /// <summary>
        /// The maximum amount of data that the query is allowed to scan. After the limit is reached, the query will be canceled.
        /// </summary>
        /// <value>The maximum amount of data that the query is allowed to scan. After the limit is reached, the query will be canceled.</value>
        [DataMember(Name="scannedDataLimit", EmitDefaultValue=false)]
        public decimal? ScannedDataLimit { get; set; }

        /// <summary>
        /// The IDs of the spaces belonging to the specified account in which the query is to be executed. Do not provide any value to query all spaces in the specified account.
        /// </summary>
        /// <value>The IDs of the spaces belonging to the specified account in which the query is to be executed. Do not provide any value to query all spaces in the specified account.</value>
        [DataMember(Name="spaceIds", EmitDefaultValue=false)]
        public List<long?> SpaceIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnalyticsQuery {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  MaxCacheAge: ").Append(MaxCacheAge).Append("\n");
            sb.Append("  QueryString: ").Append(QueryString).Append("\n");
            sb.Append("  ScannedDataLimit: ").Append(ScannedDataLimit).Append("\n");
            sb.Append("  SpaceIds: ").Append(SpaceIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AnalyticsQuery);
        }

        /// <summary>
        /// Returns true if AnalyticsQuery instances are equal
        /// </summary>
        /// <param name="input">Instance of AnalyticsQuery to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AnalyticsQuery input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.ExternalId == input.ExternalId ||
                    (this.ExternalId != null &&
                    this.ExternalId.Equals(input.ExternalId))
                ) && 
                (
                    this.MaxCacheAge == input.MaxCacheAge ||
                    (this.MaxCacheAge != null &&
                    this.MaxCacheAge.Equals(input.MaxCacheAge))
                ) && 
                (
                    this.QueryString == input.QueryString ||
                    (this.QueryString != null &&
                    this.QueryString.Equals(input.QueryString))
                ) && 
                (
                    this.ScannedDataLimit == input.ScannedDataLimit ||
                    (this.ScannedDataLimit != null &&
                    this.ScannedDataLimit.Equals(input.ScannedDataLimit))
                ) && 
                (
                    this.SpaceIds == input.SpaceIds ||
                    this.SpaceIds != null &&
                    input.SpaceIds != null &&
                    this.SpaceIds.SequenceEqual(input.SpaceIds)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.AccountId != null)
                    hashCode = hashCode * 59 + this.AccountId.GetHashCode();
                if (this.ExternalId != null)
                    hashCode = hashCode * 59 + this.ExternalId.GetHashCode();
                if (this.MaxCacheAge != null)
                    hashCode = hashCode * 59 + this.MaxCacheAge.GetHashCode();
                if (this.QueryString != null)
                    hashCode = hashCode * 59 + this.QueryString.GetHashCode();
                if (this.ScannedDataLimit != null)
                    hashCode = hashCode * 59 + this.ScannedDataLimit.GetHashCode();
                if (this.SpaceIds != null)
                    hashCode = hashCode * 59 + this.SpaceIds.GetHashCode();
                return hashCode;
            }
        }

    }

}
