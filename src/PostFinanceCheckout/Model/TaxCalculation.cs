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
    /// Defines TaxCalculation
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum TaxCalculation
    {
        
        /// <summary>
        /// Enum TAX_INCLUDED for value: TAX_INCLUDED
        /// </summary>
        [EnumMember(Value = "TAX_INCLUDED")]
        TAX_INCLUDED,
        
        /// <summary>
        /// Enum TAX_NOT_INCLUDED for value: TAX_NOT_INCLUDED
        /// </summary>
        [EnumMember(Value = "TAX_NOT_INCLUDED")]
        TAX_NOT_INCLUDED
    }

}
