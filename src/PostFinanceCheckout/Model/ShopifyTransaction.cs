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
    /// ShopifyTransaction
    /// </summary>
    [DataContract]
    public partial class ShopifyTransaction : TransactionAwareEntity,  IEquatable<ShopifyTransaction>
    {
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public ShopifyTransactionState? State { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShopifyTransaction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public ShopifyTransaction()
        {
        }




        /// <summary>
        /// Gets or Sets CheckoutId
        /// </summary>
        [DataMember(Name="checkoutId", EmitDefaultValue=false)]
        public string CheckoutId { get; private set; }

        /// <summary>
        /// The date and time when the object was created.
        /// </summary>
        /// <value>The date and time when the object was created.</value>
        [DataMember(Name="createdOn", EmitDefaultValue=false)]
        public DateTime? CreatedOn { get; private set; }

        /// <summary>
        /// Gets or Sets DraftOrderId
        /// </summary>
        [DataMember(Name="draftOrderId", EmitDefaultValue=false)]
        public string DraftOrderId { get; private set; }

        /// <summary>
        /// Gets or Sets DraftOrderLegacyId
        /// </summary>
        [DataMember(Name="draftOrderLegacyId", EmitDefaultValue=false)]
        public string DraftOrderLegacyId { get; private set; }

        /// <summary>
        /// Gets or Sets Integration
        /// </summary>
        [DataMember(Name="integration", EmitDefaultValue=false)]
        public ShopifyV1Integration Integration { get; private set; }

        /// <summary>
        /// Gets or Sets OrderLegacyId
        /// </summary>
        [DataMember(Name="orderLegacyId", EmitDefaultValue=false)]
        public string OrderLegacyId { get; private set; }

        /// <summary>
        /// Gets or Sets OrderName
        /// </summary>
        [DataMember(Name="orderName", EmitDefaultValue=false)]
        public string OrderName { get; private set; }

        /// <summary>
        /// The date and time when the object is planned to be permanently removed. If the value is empty, the object will not be removed.
        /// </summary>
        /// <value>The date and time when the object is planned to be permanently removed. If the value is empty, the object will not be removed.</value>
        [DataMember(Name="plannedPurgeDate", EmitDefaultValue=false)]
        public DateTime? PlannedPurgeDate { get; private set; }


        /// <summary>
        /// Gets or Sets Transaction
        /// </summary>
        [DataMember(Name="transaction", EmitDefaultValue=false)]
        public Transaction Transaction { get; private set; }

        /// <summary>
        /// The version is used for optimistic locking and incremented whenever the object is updated.
        /// </summary>
        /// <value>The version is used for optimistic locking and incremented whenever the object is updated.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShopifyTransaction {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  LinkedTransaction: ").Append(LinkedTransaction).Append("\n");
            sb.Append("  CheckoutId: ").Append(CheckoutId).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  DraftOrderId: ").Append(DraftOrderId).Append("\n");
            sb.Append("  DraftOrderLegacyId: ").Append(DraftOrderLegacyId).Append("\n");
            sb.Append("  Integration: ").Append(Integration).Append("\n");
            sb.Append("  OrderLegacyId: ").Append(OrderLegacyId).Append("\n");
            sb.Append("  OrderName: ").Append(OrderName).Append("\n");
            sb.Append("  PlannedPurgeDate: ").Append(PlannedPurgeDate).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Transaction: ").Append(Transaction).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as ShopifyTransaction);
        }

        /// <summary>
        /// Returns true if ShopifyTransaction instances are equal
        /// </summary>
        /// <param name="input">Instance of ShopifyTransaction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShopifyTransaction input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && base.Equals(input) && 
                (
                    this.LinkedSpaceId == input.LinkedSpaceId ||
                    (this.LinkedSpaceId != null &&
                    this.LinkedSpaceId.Equals(input.LinkedSpaceId))
                ) && base.Equals(input) && 
                (
                    this.LinkedTransaction == input.LinkedTransaction ||
                    (this.LinkedTransaction != null &&
                    this.LinkedTransaction.Equals(input.LinkedTransaction))
                ) && base.Equals(input) && 
                (
                    this.CheckoutId == input.CheckoutId ||
                    (this.CheckoutId != null &&
                    this.CheckoutId.Equals(input.CheckoutId))
                ) && base.Equals(input) && 
                (
                    this.CreatedOn == input.CreatedOn ||
                    (this.CreatedOn != null &&
                    this.CreatedOn.Equals(input.CreatedOn))
                ) && base.Equals(input) && 
                (
                    this.DraftOrderId == input.DraftOrderId ||
                    (this.DraftOrderId != null &&
                    this.DraftOrderId.Equals(input.DraftOrderId))
                ) && base.Equals(input) && 
                (
                    this.DraftOrderLegacyId == input.DraftOrderLegacyId ||
                    (this.DraftOrderLegacyId != null &&
                    this.DraftOrderLegacyId.Equals(input.DraftOrderLegacyId))
                ) && base.Equals(input) && 
                (
                    this.Integration == input.Integration ||
                    (this.Integration != null &&
                    this.Integration.Equals(input.Integration))
                ) && base.Equals(input) && 
                (
                    this.OrderLegacyId == input.OrderLegacyId ||
                    (this.OrderLegacyId != null &&
                    this.OrderLegacyId.Equals(input.OrderLegacyId))
                ) && base.Equals(input) && 
                (
                    this.OrderName == input.OrderName ||
                    (this.OrderName != null &&
                    this.OrderName.Equals(input.OrderName))
                ) && base.Equals(input) && 
                (
                    this.PlannedPurgeDate == input.PlannedPurgeDate ||
                    (this.PlannedPurgeDate != null &&
                    this.PlannedPurgeDate.Equals(input.PlannedPurgeDate))
                ) && base.Equals(input) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && base.Equals(input) && 
                (
                    this.Transaction == input.Transaction ||
                    (this.Transaction != null &&
                    this.Transaction.Equals(input.Transaction))
                ) && base.Equals(input) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
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
                int hashCode = base.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.LinkedSpaceId != null)
                    hashCode = hashCode * 59 + this.LinkedSpaceId.GetHashCode();
                if (this.LinkedTransaction != null)
                    hashCode = hashCode * 59 + this.LinkedTransaction.GetHashCode();
                if (this.CheckoutId != null)
                    hashCode = hashCode * 59 + this.CheckoutId.GetHashCode();
                if (this.CreatedOn != null)
                    hashCode = hashCode * 59 + this.CreatedOn.GetHashCode();
                if (this.DraftOrderId != null)
                    hashCode = hashCode * 59 + this.DraftOrderId.GetHashCode();
                if (this.DraftOrderLegacyId != null)
                    hashCode = hashCode * 59 + this.DraftOrderLegacyId.GetHashCode();
                if (this.Integration != null)
                    hashCode = hashCode * 59 + this.Integration.GetHashCode();
                if (this.OrderLegacyId != null)
                    hashCode = hashCode * 59 + this.OrderLegacyId.GetHashCode();
                if (this.OrderName != null)
                    hashCode = hashCode * 59 + this.OrderName.GetHashCode();
                if (this.PlannedPurgeDate != null)
                    hashCode = hashCode * 59 + this.PlannedPurgeDate.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Transaction != null)
                    hashCode = hashCode * 59 + this.Transaction.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }

    }

}
