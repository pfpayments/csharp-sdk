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
    /// AbstractHumanUserUpdate
    /// </summary>
    [DataContract]
    public partial class AbstractHumanUserUpdate :  IEquatable<AbstractHumanUserUpdate>
    {
        /// <summary>
        /// The object&#39;s current state.
        /// </summary>
        /// <value>The object&#39;s current state.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public CreationEntityState? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractHumanUserUpdate" /> class.
        /// </summary>
        public AbstractHumanUserUpdate()
        {
        }

        /// <summary>
        /// The user&#39;s email address.
        /// </summary>
        /// <value>The user&#39;s email address.</value>
        [DataMember(Name="emailAddress", EmitDefaultValue=false)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// The user&#39;s first name.
        /// </summary>
        /// <value>The user&#39;s first name.</value>
        [DataMember(Name="firstname", EmitDefaultValue=false)]
        public string Firstname { get; set; }

        /// <summary>
        /// The user&#39;s preferred language.
        /// </summary>
        /// <value>The user&#39;s preferred language.</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; set; }

        /// <summary>
        /// The user&#39;s last name.
        /// </summary>
        /// <value>The user&#39;s last name.</value>
        [DataMember(Name="lastname", EmitDefaultValue=false)]
        public string Lastname { get; set; }

        /// <summary>
        /// The user&#39;s mobile phone number.
        /// </summary>
        /// <value>The user&#39;s mobile phone number.</value>
        [DataMember(Name="mobilePhoneNumber", EmitDefaultValue=false)]
        public string MobilePhoneNumber { get; set; }


        /// <summary>
        /// The user&#39;s time zone. If none is specified, the one provided by the browser will be used.
        /// </summary>
        /// <value>The user&#39;s time zone. If none is specified, the one provided by the browser will be used.</value>
        [DataMember(Name="timeZone", EmitDefaultValue=false)]
        public string TimeZone { get; set; }

        /// <summary>
        /// Whether two-factor authentication is enabled for this user.
        /// </summary>
        /// <value>Whether two-factor authentication is enabled for this user.</value>
        [DataMember(Name="twoFactorEnabled", EmitDefaultValue=false)]
        public bool? TwoFactorEnabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AbstractHumanUserUpdate {\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  Firstname: ").Append(Firstname).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  Lastname: ").Append(Lastname).Append("\n");
            sb.Append("  MobilePhoneNumber: ").Append(MobilePhoneNumber).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
            sb.Append("  TwoFactorEnabled: ").Append(TwoFactorEnabled).Append("\n");
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
            return this.Equals(input as AbstractHumanUserUpdate);
        }

        /// <summary>
        /// Returns true if AbstractHumanUserUpdate instances are equal
        /// </summary>
        /// <param name="input">Instance of AbstractHumanUserUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AbstractHumanUserUpdate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EmailAddress == input.EmailAddress ||
                    (this.EmailAddress != null &&
                    this.EmailAddress.Equals(input.EmailAddress))
                ) && 
                (
                    this.Firstname == input.Firstname ||
                    (this.Firstname != null &&
                    this.Firstname.Equals(input.Firstname))
                ) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && 
                (
                    this.Lastname == input.Lastname ||
                    (this.Lastname != null &&
                    this.Lastname.Equals(input.Lastname))
                ) && 
                (
                    this.MobilePhoneNumber == input.MobilePhoneNumber ||
                    (this.MobilePhoneNumber != null &&
                    this.MobilePhoneNumber.Equals(input.MobilePhoneNumber))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.TimeZone == input.TimeZone ||
                    (this.TimeZone != null &&
                    this.TimeZone.Equals(input.TimeZone))
                ) && 
                (
                    this.TwoFactorEnabled == input.TwoFactorEnabled ||
                    (this.TwoFactorEnabled != null &&
                    this.TwoFactorEnabled.Equals(input.TwoFactorEnabled))
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
                if (this.EmailAddress != null)
                    hashCode = hashCode * 59 + this.EmailAddress.GetHashCode();
                if (this.Firstname != null)
                    hashCode = hashCode * 59 + this.Firstname.GetHashCode();
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.Lastname != null)
                    hashCode = hashCode * 59 + this.Lastname.GetHashCode();
                if (this.MobilePhoneNumber != null)
                    hashCode = hashCode * 59 + this.MobilePhoneNumber.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.TimeZone != null)
                    hashCode = hashCode * 59 + this.TimeZone.GetHashCode();
                if (this.TwoFactorEnabled != null)
                    hashCode = hashCode * 59 + this.TwoFactorEnabled.GetHashCode();
                return hashCode;
            }
        }

    }

}
