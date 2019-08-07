﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="RedactionAnnotation.cs">
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
    /// Provides RedactionAnnotation.
    /// </summary>
    [DataContract]
    public partial class RedactionAnnotation : Annotation,  IEquatable<RedactionAnnotation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RedactionAnnotation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RedactionAnnotation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RedactionAnnotation" /> class.
        /// </summary>
        /// <param name="Links">Link to the document.</param>
        /// <param name="Color">Color of the annotation.</param>
        /// <param name="Contents">Get the annotation content.</param>
        /// <param name="Modified">The date and time when the annotation was last modified.</param>
        /// <param name="Id">Gets ID of the annotation.</param>
        /// <param name="Flags">Gets Flags of the annotation.</param>
        /// <param name="Name">Gets Name of the annotation.</param>
        /// <param name="Rect">Gets Rect of the annotation. (required)</param>
        /// <param name="PageIndex">Gets PageIndex of the annotation.</param>
        /// <param name="ZIndex">Gets ZIndex of the annotation.</param>
        /// <param name="HorizontalAlignment">Gets HorizontalAlignment of the annotation.</param>
        /// <param name="VerticalAlignment">Gets VerticalAlignment of the annotation.</param>
        /// <param name="QuadPoint">An array of 8xN numbers specifying the coordinates of content region that is intended to be removed. </param>
        /// <param name="FillColor">Gets or sets color to fill annotation.</param>
        /// <param name="BorderColor">Gets or sets color of border which is drawn when redaction is not active.</param>
        /// <param name="OverlayText">Text to print on redact annotation.</param>
        /// <param name="Repeat">If true overlay text will be repated on the annotation. </param>
        /// <param name="TextAlignment">Gets or sets. Alignment of Overlay Text.</param>
        public RedactionAnnotation(List<Link> Links = default(List<Link>), Color Color = default(Color), string Contents = default(string), string Modified = default(string), string Id = default(string), List<AnnotationFlags> Flags = default(List<AnnotationFlags>), string Name = default(string), Rectangle Rect = default(Rectangle), int? PageIndex = default(int?), int? ZIndex = default(int?), HorizontalAlignment HorizontalAlignment = default(HorizontalAlignment), VerticalAlignment VerticalAlignment = default(VerticalAlignment), List<Point> QuadPoint = default(List<Point>), Color FillColor = default(Color), Color BorderColor = default(Color), string OverlayText = default(string), bool? Repeat = default(bool?), HorizontalAlignment TextAlignment = default(HorizontalAlignment))
        {
            // to ensure "Rect" is required (not null)
            if (Rect == null)
            {
                throw new InvalidDataException("Rect is a required property for RedactionAnnotation and cannot be null");
            }
            else
            {
                this.Rect = Rect;
            }
            this.Links = Links;
            this.Color = Color;
            this.Contents = Contents;
            this.Modified = Modified;
            this.Id = Id;
            this.Flags = Flags;
            this.Name = Name;
            this.PageIndex = PageIndex;
            this.ZIndex = ZIndex;
            this.HorizontalAlignment = HorizontalAlignment;
            this.VerticalAlignment = VerticalAlignment;
            this.QuadPoint = QuadPoint;
            this.FillColor = FillColor;
            this.BorderColor = BorderColor;
            this.OverlayText = OverlayText;
            this.Repeat = Repeat;
            this.TextAlignment = TextAlignment;
        }
        
        /// <summary>
        /// Link to the document.
        /// </summary>
        /// <value>Link to the document.</value>
        [DataMember(Name="Links", EmitDefaultValue=false)]
        public List<Link> Links { get; set; }

        /// <summary>
        /// Color of the annotation.
        /// </summary>
        /// <value>Color of the annotation.</value>
        [DataMember(Name="Color", EmitDefaultValue=false)]
        public Color Color { get; set; }

        /// <summary>
        /// Get the annotation content.
        /// </summary>
        /// <value>Get the annotation content.</value>
        [DataMember(Name="Contents", EmitDefaultValue=false)]
        public string Contents { get; set; }

        /// <summary>
        /// The date and time when the annotation was last modified.
        /// </summary>
        /// <value>The date and time when the annotation was last modified.</value>
        [DataMember(Name="Modified", EmitDefaultValue=false)]
        public string Modified { get; set; }

        /// <summary>
        /// Gets ID of the annotation.
        /// </summary>
        /// <value>Gets ID of the annotation.</value>
        [DataMember(Name="Id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets Flags of the annotation.
        /// </summary>
        /// <value>Gets Flags of the annotation.</value>
        [DataMember(Name="Flags", EmitDefaultValue=false)]
        public List<AnnotationFlags> Flags { get; set; }

        /// <summary>
        /// Gets Name of the annotation.
        /// </summary>
        /// <value>Gets Name of the annotation.</value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets Rect of the annotation.
        /// </summary>
        /// <value>Gets Rect of the annotation.</value>
        [DataMember(Name="Rect", EmitDefaultValue=false)]
        public Rectangle Rect { get; set; }

        /// <summary>
        /// Gets PageIndex of the annotation.
        /// </summary>
        /// <value>Gets PageIndex of the annotation.</value>
        [DataMember(Name="PageIndex", EmitDefaultValue=false)]
        public int? PageIndex { get; set; }

        /// <summary>
        /// Gets ZIndex of the annotation.
        /// </summary>
        /// <value>Gets ZIndex of the annotation.</value>
        [DataMember(Name="ZIndex", EmitDefaultValue=false)]
        public int? ZIndex { get; set; }

        /// <summary>
        /// Gets HorizontalAlignment of the annotation.
        /// </summary>
        /// <value>Gets HorizontalAlignment of the annotation.</value>
        [DataMember(Name="HorizontalAlignment", EmitDefaultValue=true)]
        public HorizontalAlignment HorizontalAlignment { get; set; }

        /// <summary>
        /// Gets VerticalAlignment of the annotation.
        /// </summary>
        /// <value>Gets VerticalAlignment of the annotation.</value>
        [DataMember(Name="VerticalAlignment", EmitDefaultValue=true)]
        public VerticalAlignment VerticalAlignment { get; set; }

        /// <summary>
        /// An array of 8xN numbers specifying the coordinates of content region that is intended to be removed. 
        /// </summary>
        /// <value>An array of 8xN numbers specifying the coordinates of content region that is intended to be removed. </value>
        [DataMember(Name="QuadPoint", EmitDefaultValue=false)]
        public List<Point> QuadPoint { get; set; }

        /// <summary>
        /// Gets or sets color to fill annotation.
        /// </summary>
        /// <value>Gets or sets color to fill annotation.</value>
        [DataMember(Name="FillColor", EmitDefaultValue=false)]
        public Color FillColor { get; set; }

        /// <summary>
        /// Gets or sets color of border which is drawn when redaction is not active.
        /// </summary>
        /// <value>Gets or sets color of border which is drawn when redaction is not active.</value>
        [DataMember(Name="BorderColor", EmitDefaultValue=false)]
        public Color BorderColor { get; set; }

        /// <summary>
        /// Text to print on redact annotation.
        /// </summary>
        /// <value>Text to print on redact annotation.</value>
        [DataMember(Name="OverlayText", EmitDefaultValue=false)]
        public string OverlayText { get; set; }

        /// <summary>
        /// If true overlay text will be repated on the annotation. 
        /// </summary>
        /// <value>If true overlay text will be repated on the annotation. </value>
        [DataMember(Name="Repeat", EmitDefaultValue=false)]
        public bool? Repeat { get; set; }

        /// <summary>
        /// Gets or sets. Alignment of Overlay Text.
        /// </summary>
        /// <value>Gets or sets. Alignment of Overlay Text.</value>
        [DataMember(Name="TextAlignment", EmitDefaultValue=true)]
        public HorizontalAlignment TextAlignment { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RedactionAnnotation {\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
            sb.Append("  Contents: ").Append(Contents).Append("\n");
            sb.Append("  Modified: ").Append(Modified).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Flags: ").Append(Flags).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Rect: ").Append(Rect).Append("\n");
            sb.Append("  PageIndex: ").Append(PageIndex).Append("\n");
            sb.Append("  ZIndex: ").Append(ZIndex).Append("\n");
            sb.Append("  HorizontalAlignment: ").Append(HorizontalAlignment).Append("\n");
            sb.Append("  VerticalAlignment: ").Append(VerticalAlignment).Append("\n");
            sb.Append("  QuadPoint: ").Append(QuadPoint).Append("\n");
            sb.Append("  FillColor: ").Append(FillColor).Append("\n");
            sb.Append("  BorderColor: ").Append(BorderColor).Append("\n");
            sb.Append("  OverlayText: ").Append(OverlayText).Append("\n");
            sb.Append("  Repeat: ").Append(Repeat).Append("\n");
            sb.Append("  TextAlignment: ").Append(TextAlignment).Append("\n");
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
            return this.Equals(obj as RedactionAnnotation);
        }

        /// <summary>
        /// Returns true if RedactionAnnotation instances are equal
        /// </summary>
        /// <param name="other">Instance of RedactionAnnotation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RedactionAnnotation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Links == other.Links ||
                    this.Links != null &&
                    this.Links.SequenceEqual(other.Links)
                ) && 
                (
                    this.Color == other.Color ||
                    this.Color != null &&
                    this.Color.Equals(other.Color)
                ) && 
                (
                    this.Contents == other.Contents ||
                    this.Contents != null &&
                    this.Contents.Equals(other.Contents)
                ) && 
                (
                    this.Modified == other.Modified ||
                    this.Modified != null &&
                    this.Modified.Equals(other.Modified)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Flags == other.Flags ||
                    this.Flags != null &&
                    this.Flags.SequenceEqual(other.Flags)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Rect == other.Rect ||
                    this.Rect != null &&
                    this.Rect.Equals(other.Rect)
                ) && 
                (
                    this.PageIndex == other.PageIndex ||
                    this.PageIndex != null &&
                    this.PageIndex.Equals(other.PageIndex)
                ) && 
                (
                    this.ZIndex == other.ZIndex ||
                    this.ZIndex != null &&
                    this.ZIndex.Equals(other.ZIndex)
                ) && 
                (
                    this.HorizontalAlignment == other.HorizontalAlignment ||
                    this.HorizontalAlignment != null &&
                    this.HorizontalAlignment.Equals(other.HorizontalAlignment)
                ) && 
                (
                    this.VerticalAlignment == other.VerticalAlignment ||
                    this.VerticalAlignment != null &&
                    this.VerticalAlignment.Equals(other.VerticalAlignment)
                ) && 
                (
                    this.QuadPoint == other.QuadPoint ||
                    this.QuadPoint != null &&
                    this.QuadPoint.SequenceEqual(other.QuadPoint)
                ) && 
                (
                    this.FillColor == other.FillColor ||
                    this.FillColor != null &&
                    this.FillColor.Equals(other.FillColor)
                ) && 
                (
                    this.BorderColor == other.BorderColor ||
                    this.BorderColor != null &&
                    this.BorderColor.Equals(other.BorderColor)
                ) && 
                (
                    this.OverlayText == other.OverlayText ||
                    this.OverlayText != null &&
                    this.OverlayText.Equals(other.OverlayText)
                ) && 
                (
                    this.Repeat == other.Repeat ||
                    this.Repeat != null &&
                    this.Repeat.Equals(other.Repeat)
                ) && 
                (
                    this.TextAlignment == other.TextAlignment ||
                    this.TextAlignment != null &&
                    this.TextAlignment.Equals(other.TextAlignment)
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
                if (this.Links != null)
                    hash = hash * 59 + this.Links.GetHashCode();
                if (this.Color != null)
                    hash = hash * 59 + this.Color.GetHashCode();
                if (this.Contents != null)
                    hash = hash * 59 + this.Contents.GetHashCode();
                if (this.Modified != null)
                    hash = hash * 59 + this.Modified.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Flags != null)
                    hash = hash * 59 + this.Flags.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Rect != null)
                    hash = hash * 59 + this.Rect.GetHashCode();
                if (this.PageIndex != null)
                    hash = hash * 59 + this.PageIndex.GetHashCode();
                if (this.ZIndex != null)
                    hash = hash * 59 + this.ZIndex.GetHashCode();
                if (this.HorizontalAlignment != null)
                    hash = hash * 59 + this.HorizontalAlignment.GetHashCode();
                if (this.VerticalAlignment != null)
                    hash = hash * 59 + this.VerticalAlignment.GetHashCode();
                if (this.QuadPoint != null)
                    hash = hash * 59 + this.QuadPoint.GetHashCode();
                if (this.FillColor != null)
                    hash = hash * 59 + this.FillColor.GetHashCode();
                if (this.BorderColor != null)
                    hash = hash * 59 + this.BorderColor.GetHashCode();
                if (this.OverlayText != null)
                    hash = hash * 59 + this.OverlayText.GetHashCode();
                if (this.Repeat != null)
                    hash = hash * 59 + this.Repeat.GetHashCode();
                if (this.TextAlignment != null)
                    hash = hash * 59 + this.TextAlignment.GetHashCode();
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
