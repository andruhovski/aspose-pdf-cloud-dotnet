﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="StrikeOutAnnotationsResponse.cs">
//   Copyright (c) 2019 Aspose.PDF Cloud
// </copyright>
// <summary>
//   Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

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
using System.Net;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Aspose.Pdf.Cloud.Sdk.Client.SwaggerDateConverter;

namespace Aspose.Pdf.Cloud.Sdk.Model
{
    /// <summary>
    /// Represents response containing multiple strikeout annotation objects
    /// </summary>
    [DataContract]
    public partial class StrikeOutAnnotationsResponse : AsposeResponse,  IEquatable<StrikeOutAnnotationsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StrikeOutAnnotationsResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StrikeOutAnnotationsResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StrikeOutAnnotationsResponse" /> class.
        /// </summary>
        /// <param name="Code">Response status code. (required).</param>
        /// <param name="Status">Response status..</param>
        /// <param name="Annotations">Strikeout annotations object.</param>
        public StrikeOutAnnotationsResponse(int? Code = default(int?), string Status = default(string), StrikeOutAnnotations Annotations = default(StrikeOutAnnotations))
        {
            // to ensure "Code" is required (not null)
            if (Code == null)
            {
                throw new InvalidDataException("Code is a required property for StrikeOutAnnotationsResponse and cannot be null");
            }
            else
            {
                this.Code = Code;
            }
            this.Status = Status;
            this.Annotations = Annotations;
        }
        
        /// <summary>
        /// Response status code.
        /// </summary>
        /// <value>Response status code.</value>
        [DataMember(Name="Code", EmitDefaultValue=false)]
        public int? Code { get; set; }

        /// <summary>
        /// Response status.
        /// </summary>
        /// <value>Response status.</value>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Strikeout annotations object
        /// </summary>
        /// <value>Strikeout annotations object</value>
        [DataMember(Name="Annotations", EmitDefaultValue=false)]
        public StrikeOutAnnotations Annotations { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StrikeOutAnnotationsResponse {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Annotations: ").Append(Annotations).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public  new string ToJson()
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
            return this.Equals(obj as StrikeOutAnnotationsResponse);
        }

        /// <summary>
        /// Returns true if StrikeOutAnnotationsResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of StrikeOutAnnotationsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StrikeOutAnnotationsResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Code == other.Code ||
                    this.Code != null &&
                    this.Code.Equals(other.Code)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.Annotations == other.Annotations ||
                    this.Annotations != null &&
                    this.Annotations.Equals(other.Annotations)
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
                if (this.Code != null)
                    hash = hash * 59 + this.Code.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.Annotations != null)
                    hash = hash * 59 + this.Annotations.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
