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
    /// Represents the execution of a query which has been submitted to Analytics.
    /// </summary>
    [DataContract]
    public partial class AnalyticsQueryExecution :  IEquatable<AnalyticsQueryExecution>
    {
        /// <summary>
        /// The current state of the query execution.
        /// </summary>
        /// <value>The current state of the query execution.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public AnalyticsQueryExecutionState? State { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsQueryExecution" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public AnalyticsQueryExecution()
        {
        }

        /// <summary>
        /// The account in which the query is executed.
        /// </summary>
        /// <value>The account in which the query is executed.</value>
        [DataMember(Name="account", EmitDefaultValue=false)]
        public long? Account { get; private set; }

        /// <summary>
        /// The error message that describes the reason for the failure of the query execution.
        /// </summary>
        /// <value>The error message that describes the reason for the failure of the query execution.</value>
        [DataMember(Name="errorMessage", EmitDefaultValue=false)]
        public string ErrorMessage { get; private set; }

        /// <summary>
        /// The external ID of the query if one was specified, otherwise null.
        /// </summary>
        /// <value>The external ID of the query if one was specified, otherwise null.</value>
        [DataMember(Name="externalId", EmitDefaultValue=false)]
        public string ExternalId { get; private set; }

        /// <summary>
        /// The reason for the failure of query execution.
        /// </summary>
        /// <value>The reason for the failure of query execution.</value>
        [DataMember(Name="failureReason", EmitDefaultValue=false)]
        public FailureReason FailureReason { get; private set; }

        /// <summary>
        /// A unique identifier for the object.
        /// </summary>
        /// <value>A unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

        /// <summary>
        /// The date and time when the processing of the query was completed. Null if the query execution has not yet been completed.
        /// </summary>
        /// <value>The date and time when the processing of the query was completed. Null if the query execution has not yet been completed.</value>
        [DataMember(Name="processingEndTime", EmitDefaultValue=false)]
        public DateTime? ProcessingEndTime { get; private set; }

        /// <summary>
        /// The date and time when the processing of the query was started.
        /// </summary>
        /// <value>The date and time when the processing of the query was started.</value>
        [DataMember(Name="processingStartTime", EmitDefaultValue=false)]
        public DateTime? ProcessingStartTime { get; private set; }

        /// <summary>
        /// The SQL statement which has been submitted for execution.
        /// </summary>
        /// <value>The SQL statement which has been submitted for execution.</value>
        [DataMember(Name="queryString", EmitDefaultValue=false)]
        public string QueryString { get; private set; }

        /// <summary>
        /// The amount of data that was scanned when processing the query (in GB).
        /// </summary>
        /// <value>The amount of data that was scanned when processing the query (in GB).</value>
        [DataMember(Name="scannedDataInGb", EmitDefaultValue=false)]
        public decimal? ScannedDataInGb { get; private set; }

        /// <summary>
        /// The maximal amount of data that this query is allowed to scan (in GB). If this limit is reached, the query will be canceled.
        /// </summary>
        /// <value>The maximal amount of data that this query is allowed to scan (in GB). If this limit is reached, the query will be canceled.</value>
        [DataMember(Name="scannedDataLimit", EmitDefaultValue=false)]
        public decimal? ScannedDataLimit { get; private set; }

        /// <summary>
        /// The spaces in which the query is executed. May be empty if all spaces of the specified account have been queried.
        /// </summary>
        /// <value>The spaces in which the query is executed. May be empty if all spaces of the specified account have been queried.</value>
        [DataMember(Name="spaces", EmitDefaultValue=false)]
        public List<long?> Spaces { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnalyticsQueryExecution {\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  FailureReason: ").Append(FailureReason).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ProcessingEndTime: ").Append(ProcessingEndTime).Append("\n");
            sb.Append("  ProcessingStartTime: ").Append(ProcessingStartTime).Append("\n");
            sb.Append("  QueryString: ").Append(QueryString).Append("\n");
            sb.Append("  ScannedDataInGb: ").Append(ScannedDataInGb).Append("\n");
            sb.Append("  ScannedDataLimit: ").Append(ScannedDataLimit).Append("\n");
            sb.Append("  Spaces: ").Append(Spaces).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
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
            return this.Equals(input as AnalyticsQueryExecution);
        }

        /// <summary>
        /// Returns true if AnalyticsQueryExecution instances are equal
        /// </summary>
        /// <param name="input">Instance of AnalyticsQueryExecution to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AnalyticsQueryExecution input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Account == input.Account ||
                    (this.Account != null &&
                    this.Account.Equals(input.Account))
                ) && 
                (
                    this.ErrorMessage == input.ErrorMessage ||
                    (this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(input.ErrorMessage))
                ) && 
                (
                    this.ExternalId == input.ExternalId ||
                    (this.ExternalId != null &&
                    this.ExternalId.Equals(input.ExternalId))
                ) && 
                (
                    this.FailureReason == input.FailureReason ||
                    (this.FailureReason != null &&
                    this.FailureReason.Equals(input.FailureReason))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.ProcessingEndTime == input.ProcessingEndTime ||
                    (this.ProcessingEndTime != null &&
                    this.ProcessingEndTime.Equals(input.ProcessingEndTime))
                ) && 
                (
                    this.ProcessingStartTime == input.ProcessingStartTime ||
                    (this.ProcessingStartTime != null &&
                    this.ProcessingStartTime.Equals(input.ProcessingStartTime))
                ) && 
                (
                    this.QueryString == input.QueryString ||
                    (this.QueryString != null &&
                    this.QueryString.Equals(input.QueryString))
                ) && 
                (
                    this.ScannedDataInGb == input.ScannedDataInGb ||
                    (this.ScannedDataInGb != null &&
                    this.ScannedDataInGb.Equals(input.ScannedDataInGb))
                ) && 
                (
                    this.ScannedDataLimit == input.ScannedDataLimit ||
                    (this.ScannedDataLimit != null &&
                    this.ScannedDataLimit.Equals(input.ScannedDataLimit))
                ) && 
                (
                    this.Spaces == input.Spaces ||
                    this.Spaces != null &&
                    input.Spaces != null &&
                    this.Spaces.SequenceEqual(input.Spaces)
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
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
                if (this.Account != null)
                    hashCode = hashCode * 59 + this.Account.GetHashCode();
                if (this.ErrorMessage != null)
                    hashCode = hashCode * 59 + this.ErrorMessage.GetHashCode();
                if (this.ExternalId != null)
                    hashCode = hashCode * 59 + this.ExternalId.GetHashCode();
                if (this.FailureReason != null)
                    hashCode = hashCode * 59 + this.FailureReason.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ProcessingEndTime != null)
                    hashCode = hashCode * 59 + this.ProcessingEndTime.GetHashCode();
                if (this.ProcessingStartTime != null)
                    hashCode = hashCode * 59 + this.ProcessingStartTime.GetHashCode();
                if (this.QueryString != null)
                    hashCode = hashCode * 59 + this.QueryString.GetHashCode();
                if (this.ScannedDataInGb != null)
                    hashCode = hashCode * 59 + this.ScannedDataInGb.GetHashCode();
                if (this.ScannedDataLimit != null)
                    hashCode = hashCode * 59 + this.ScannedDataLimit.GetHashCode();
                if (this.Spaces != null)
                    hashCode = hashCode * 59 + this.Spaces.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                return hashCode;
            }
        }

    }

}
