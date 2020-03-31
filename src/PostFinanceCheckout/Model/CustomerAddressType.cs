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
    /// Defines CustomerAddressType
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum CustomerAddressType
    {
        
        /// <summary>
        /// Enum BILLING for value: BILLING
        /// </summary>
        [EnumMember(Value = "BILLING")]
        BILLING,
        
        /// <summary>
        /// Enum SHIPPING for value: SHIPPING
        /// </summary>
        [EnumMember(Value = "SHIPPING")]
        SHIPPING,
        
        /// <summary>
        /// Enum BOTH for value: BOTH
        /// </summary>
        [EnumMember(Value = "BOTH")]
        BOTH
    }

}
