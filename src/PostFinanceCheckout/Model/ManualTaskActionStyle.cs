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
    /// Defines ManualTaskActionStyle
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ManualTaskActionStyle
    {
        
        /// <summary>
        /// Enum DEFAULT for value: DEFAULT
        /// </summary>
        [EnumMember(Value = "DEFAULT")]
        DEFAULT,
        
        /// <summary>
        /// Enum PRIMARY for value: PRIMARY
        /// </summary>
        [EnumMember(Value = "PRIMARY")]
        PRIMARY,
        
        /// <summary>
        /// Enum DANGER for value: DANGER
        /// </summary>
        [EnumMember(Value = "DANGER")]
        DANGER
    }

}
