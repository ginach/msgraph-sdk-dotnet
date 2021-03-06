// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type PageLinks.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class PageLinks
    {
    
        /// <summary>
        /// Gets or sets oneNoteClientUrl.
        /// Opens the page in the OneNote native client if it's installed.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "oneNoteClientUrl", Required = Newtonsoft.Json.Required.Default)]
        public ExternalLink OneNoteClientUrl { get; set; }
    
        /// <summary>
        /// Gets or sets oneNoteWebUrl.
        /// Opens the page in OneNote Online.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "oneNoteWebUrl", Required = Newtonsoft.Json.Required.Default)]
        public ExternalLink OneNoteWebUrl { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }
    
    }
}
