/*
 * DocRaptor
 *
 * A native client library for the DocRaptor HTML to PDF/XLS service.
 *
 * OpenAPI spec version: 2.0.0
 *
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace DocRaptor.Model
{
    /// <summary>
    /// PrinceOptions
    /// </summary>
    [DataContract]
    public partial class PrinceOptions :  IEquatable<PrinceOptions>, IValidatableObject
    {
        /// <summary>
        /// Specify the input format.
        /// </summary>
        /// <value>Specify the input format.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum InputEnum
        {

            /// <summary>
            /// Enum Html for value: html
            /// </summary>
            [EnumMember(Value = "html")]
            Html = 1,

            /// <summary>
            /// Enum Xml for value: xml
            /// </summary>
            [EnumMember(Value = "xml")]
            Xml = 2,

            /// <summary>
            /// Enum Auto for value: auto
            /// </summary>
            [EnumMember(Value = "auto")]
            Auto = 3
        }

        /// <summary>
        /// Specify the input format.
        /// </summary>
        /// <value>Specify the input format.</value>
        [DataMember(Name="input", EmitDefaultValue=false)]
        public InputEnum? Input { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PrinceOptions" /> class.
        /// </summary>
        /// <param name="baseurl">Set the baseurl for assets..</param>
        /// <param name="noXinclude">Disable XML inclusion..</param>
        /// <param name="noNetwork">Disable network access..</param>
        /// <param name="noParallelDownloads">Disables parallel fetching of assets during PDF creation. Useful if your asset host has strict rate limiting..</param>
        /// <param name="httpUser">Set the user for HTTP authentication..</param>
        /// <param name="httpPassword">Set the password for HTTP authentication..</param>
        /// <param name="httpProxy">Set the HTTP proxy server..</param>
        /// <param name="httpTimeout">Set the HTTP request timeout..</param>
        /// <param name="insecure">Disable SSL verification..</param>
        /// <param name="media">Specify the CSS media type. Defaults to \&quot;print\&quot; but you may want to use \&quot;screen\&quot; for web styles. (default to &quot;print&quot;).</param>
        /// <param name="noAuthorStyle">Ignore author stylesheets..</param>
        /// <param name="noDefaultStyle">Ignore default stylesheets..</param>
        /// <param name="noEmbedFonts">Disable font embedding in PDFs..</param>
        /// <param name="noSubsetFonts">Disable font subsetting in PDFs..</param>
        /// <param name="noCompress">Disable PDF compression..</param>
        /// <param name="encrypt">Encrypt PDF output..</param>
        /// <param name="keyBits">Set encryption key size..</param>
        /// <param name="userPassword">Set the PDF user password..</param>
        /// <param name="ownerPassword">Set the PDF owner password..</param>
        /// <param name="disallowPrint">Disallow printing of this PDF..</param>
        /// <param name="disallowCopy">Disallow copying of this PDF..</param>
        /// <param name="disallowAnnotate">Disallow annotation of this PDF..</param>
        /// <param name="disallowModify">Disallow modification of this PDF..</param>
        /// <param name="debug">Enable Prince debug mode..</param>
        /// <param name="input">Specify the input format. (default to InputEnum.Html).</param>
        /// <param name="version">Deprecated, use the appropriate &#x60;pipeline&#x60; version. Specify a specific verison of PrinceXML to use..</param>
        /// <param name="javascript">Enable PrinceXML JavaScript. DocRaptor JavaScript parsing is also available elsewhere..</param>
        /// <param name="cssDpi">Set the DPI when rendering CSS. Defaults to 96 but can be set with Prince 9.0 and up..</param>
        /// <param name="profile">In Prince 9.0 and up you can set the PDF profile..</param>
        /// <param name="pdfTitle">Specify the PDF title, part of the document&#39;s metadata..</param>
        public PrinceOptions(string baseurl = default(string), bool? noXinclude = default(bool?), bool? noNetwork = default(bool?), bool? noParallelDownloads = default(bool?), string httpUser = default(string), string httpPassword = default(string), string httpProxy = default(string), int? httpTimeout = default(int?), bool? insecure = default(bool?), string media = "print", bool? noAuthorStyle = default(bool?), bool? noDefaultStyle = default(bool?), bool? noEmbedFonts = default(bool?), bool? noSubsetFonts = default(bool?), bool? noCompress = default(bool?), bool? encrypt = default(bool?), int? keyBits = default(int?), string userPassword = default(string), string ownerPassword = default(string), bool? disallowPrint = default(bool?), bool? disallowCopy = default(bool?), bool? disallowAnnotate = default(bool?), bool? disallowModify = default(bool?), bool? debug = default(bool?), InputEnum? input = InputEnum.Html, string version = default(string), bool? javascript = default(bool?), int? cssDpi = default(int?), string profile = default(string), string pdfTitle = default(string))
        {
            this.Baseurl = baseurl;
            this.NoXinclude = noXinclude;
            this.NoNetwork = noNetwork;
            this.NoParallelDownloads = noParallelDownloads;
            this.HttpUser = httpUser;
            this.HttpPassword = httpPassword;
            this.HttpProxy = httpProxy;
            this.HttpTimeout = httpTimeout;
            this.Insecure = insecure;
            // use default value if no "media" provided
            if (media == null)
            {
                this.Media = "print";
            }
            else
            {
                this.Media = media;
            }
            this.NoAuthorStyle = noAuthorStyle;
            this.NoDefaultStyle = noDefaultStyle;
            this.NoEmbedFonts = noEmbedFonts;
            this.NoSubsetFonts = noSubsetFonts;
            this.NoCompress = noCompress;
            this.Encrypt = encrypt;
            this.KeyBits = keyBits;
            this.UserPassword = userPassword;
            this.OwnerPassword = ownerPassword;
            this.DisallowPrint = disallowPrint;
            this.DisallowCopy = disallowCopy;
            this.DisallowAnnotate = disallowAnnotate;
            this.DisallowModify = disallowModify;
            this.Debug = debug;
            // use default value if no "input" provided
            if (input == null)
            {
                this.Input = InputEnum.Html;
            }
            else
            {
                this.Input = input;
            }
            this.Version = version;
            this.Javascript = javascript;
            this.CssDpi = cssDpi;
            this.Profile = profile;
            this.PdfTitle = pdfTitle;
        }

        /// <summary>
        /// Set the baseurl for assets.
        /// </summary>
        /// <value>Set the baseurl for assets.</value>
        [DataMember(Name="baseurl", EmitDefaultValue=false)]
        public string Baseurl { get; set; }

        /// <summary>
        /// Disable XML inclusion.
        /// </summary>
        /// <value>Disable XML inclusion.</value>
        [DataMember(Name="no_xinclude", EmitDefaultValue=false)]
        public bool? NoXinclude { get; set; }

        /// <summary>
        /// Disable network access.
        /// </summary>
        /// <value>Disable network access.</value>
        [DataMember(Name="no_network", EmitDefaultValue=false)]
        public bool? NoNetwork { get; set; }

        /// <summary>
        /// Disables parallel fetching of assets during PDF creation. Useful if your asset host has strict rate limiting.
        /// </summary>
        /// <value>Disables parallel fetching of assets during PDF creation. Useful if your asset host has strict rate limiting.</value>
        [DataMember(Name="no_parallel_downloads", EmitDefaultValue=false)]
        public bool? NoParallelDownloads { get; set; }

        /// <summary>
        /// Set the user for HTTP authentication.
        /// </summary>
        /// <value>Set the user for HTTP authentication.</value>
        [DataMember(Name="http_user", EmitDefaultValue=false)]
        public string HttpUser { get; set; }

        /// <summary>
        /// Set the password for HTTP authentication.
        /// </summary>
        /// <value>Set the password for HTTP authentication.</value>
        [DataMember(Name="http_password", EmitDefaultValue=false)]
        public string HttpPassword { get; set; }

        /// <summary>
        /// Set the HTTP proxy server.
        /// </summary>
        /// <value>Set the HTTP proxy server.</value>
        [DataMember(Name="http_proxy", EmitDefaultValue=false)]
        public string HttpProxy { get; set; }

        /// <summary>
        /// Set the HTTP request timeout.
        /// </summary>
        /// <value>Set the HTTP request timeout.</value>
        [DataMember(Name="http_timeout", EmitDefaultValue=false)]
        public int? HttpTimeout { get; set; }

        /// <summary>
        /// Disable SSL verification.
        /// </summary>
        /// <value>Disable SSL verification.</value>
        [DataMember(Name="insecure", EmitDefaultValue=false)]
        public bool? Insecure { get; set; }

        /// <summary>
        /// Specify the CSS media type. Defaults to \&quot;print\&quot; but you may want to use \&quot;screen\&quot; for web styles.
        /// </summary>
        /// <value>Specify the CSS media type. Defaults to \&quot;print\&quot; but you may want to use \&quot;screen\&quot; for web styles.</value>
        [DataMember(Name="media", EmitDefaultValue=false)]
        public string Media { get; set; }

        /// <summary>
        /// Ignore author stylesheets.
        /// </summary>
        /// <value>Ignore author stylesheets.</value>
        [DataMember(Name="no_author_style", EmitDefaultValue=false)]
        public bool? NoAuthorStyle { get; set; }

        /// <summary>
        /// Ignore default stylesheets.
        /// </summary>
        /// <value>Ignore default stylesheets.</value>
        [DataMember(Name="no_default_style", EmitDefaultValue=false)]
        public bool? NoDefaultStyle { get; set; }

        /// <summary>
        /// Disable font embedding in PDFs.
        /// </summary>
        /// <value>Disable font embedding in PDFs.</value>
        [DataMember(Name="no_embed_fonts", EmitDefaultValue=false)]
        public bool? NoEmbedFonts { get; set; }

        /// <summary>
        /// Disable font subsetting in PDFs.
        /// </summary>
        /// <value>Disable font subsetting in PDFs.</value>
        [DataMember(Name="no_subset_fonts", EmitDefaultValue=false)]
        public bool? NoSubsetFonts { get; set; }

        /// <summary>
        /// Disable PDF compression.
        /// </summary>
        /// <value>Disable PDF compression.</value>
        [DataMember(Name="no_compress", EmitDefaultValue=false)]
        public bool? NoCompress { get; set; }

        /// <summary>
        /// Encrypt PDF output.
        /// </summary>
        /// <value>Encrypt PDF output.</value>
        [DataMember(Name="encrypt", EmitDefaultValue=false)]
        public bool? Encrypt { get; set; }

        /// <summary>
        /// Set encryption key size.
        /// </summary>
        /// <value>Set encryption key size.</value>
        [DataMember(Name="key_bits", EmitDefaultValue=false)]
        public int? KeyBits { get; set; }

        /// <summary>
        /// Set the PDF user password.
        /// </summary>
        /// <value>Set the PDF user password.</value>
        [DataMember(Name="user_password", EmitDefaultValue=false)]
        public string UserPassword { get; set; }

        /// <summary>
        /// Set the PDF owner password.
        /// </summary>
        /// <value>Set the PDF owner password.</value>
        [DataMember(Name="owner_password", EmitDefaultValue=false)]
        public string OwnerPassword { get; set; }

        /// <summary>
        /// Disallow printing of this PDF.
        /// </summary>
        /// <value>Disallow printing of this PDF.</value>
        [DataMember(Name="disallow_print", EmitDefaultValue=false)]
        public bool? DisallowPrint { get; set; }

        /// <summary>
        /// Disallow copying of this PDF.
        /// </summary>
        /// <value>Disallow copying of this PDF.</value>
        [DataMember(Name="disallow_copy", EmitDefaultValue=false)]
        public bool? DisallowCopy { get; set; }

        /// <summary>
        /// Disallow annotation of this PDF.
        /// </summary>
        /// <value>Disallow annotation of this PDF.</value>
        [DataMember(Name="disallow_annotate", EmitDefaultValue=false)]
        public bool? DisallowAnnotate { get; set; }

        /// <summary>
        /// Disallow modification of this PDF.
        /// </summary>
        /// <value>Disallow modification of this PDF.</value>
        [DataMember(Name="disallow_modify", EmitDefaultValue=false)]
        public bool? DisallowModify { get; set; }

        /// <summary>
        /// Enable Prince debug mode.
        /// </summary>
        /// <value>Enable Prince debug mode.</value>
        [DataMember(Name="debug", EmitDefaultValue=false)]
        public bool? Debug { get; set; }


        /// <summary>
        /// Deprecated, use the appropriate &#x60;pipeline&#x60; version. Specify a specific verison of PrinceXML to use.
        /// </summary>
        /// <value>Deprecated, use the appropriate &#x60;pipeline&#x60; version. Specify a specific verison of PrinceXML to use.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; set; }

        /// <summary>
        /// Enable PrinceXML JavaScript. DocRaptor JavaScript parsing is also available elsewhere.
        /// </summary>
        /// <value>Enable PrinceXML JavaScript. DocRaptor JavaScript parsing is also available elsewhere.</value>
        [DataMember(Name="javascript", EmitDefaultValue=false)]
        public bool? Javascript { get; set; }

        /// <summary>
        /// Set the DPI when rendering CSS. Defaults to 96 but can be set with Prince 9.0 and up.
        /// </summary>
        /// <value>Set the DPI when rendering CSS. Defaults to 96 but can be set with Prince 9.0 and up.</value>
        [DataMember(Name="css_dpi", EmitDefaultValue=false)]
        public int? CssDpi { get; set; }

        /// <summary>
        /// In Prince 9.0 and up you can set the PDF profile.
        /// </summary>
        /// <value>In Prince 9.0 and up you can set the PDF profile.</value>
        [DataMember(Name="profile", EmitDefaultValue=false)]
        public string Profile { get; set; }

        /// <summary>
        /// Specify the PDF title, part of the document&#39;s metadata.
        /// </summary>
        /// <value>Specify the PDF title, part of the document&#39;s metadata.</value>
        [DataMember(Name="pdf_title", EmitDefaultValue=false)]
        public string PdfTitle { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PrinceOptions {\n");
            sb.Append("  Baseurl: ").Append(Baseurl).Append("\n");
            sb.Append("  NoXinclude: ").Append(NoXinclude).Append("\n");
            sb.Append("  NoNetwork: ").Append(NoNetwork).Append("\n");
            sb.Append("  NoParallelDownloads: ").Append(NoParallelDownloads).Append("\n");
            sb.Append("  HttpUser: ").Append(HttpUser).Append("\n");
            sb.Append("  HttpPassword: ").Append(HttpPassword).Append("\n");
            sb.Append("  HttpProxy: ").Append(HttpProxy).Append("\n");
            sb.Append("  HttpTimeout: ").Append(HttpTimeout).Append("\n");
            sb.Append("  Insecure: ").Append(Insecure).Append("\n");
            sb.Append("  Media: ").Append(Media).Append("\n");
            sb.Append("  NoAuthorStyle: ").Append(NoAuthorStyle).Append("\n");
            sb.Append("  NoDefaultStyle: ").Append(NoDefaultStyle).Append("\n");
            sb.Append("  NoEmbedFonts: ").Append(NoEmbedFonts).Append("\n");
            sb.Append("  NoSubsetFonts: ").Append(NoSubsetFonts).Append("\n");
            sb.Append("  NoCompress: ").Append(NoCompress).Append("\n");
            sb.Append("  Encrypt: ").Append(Encrypt).Append("\n");
            sb.Append("  KeyBits: ").Append(KeyBits).Append("\n");
            sb.Append("  UserPassword: ").Append(UserPassword).Append("\n");
            sb.Append("  OwnerPassword: ").Append(OwnerPassword).Append("\n");
            sb.Append("  DisallowPrint: ").Append(DisallowPrint).Append("\n");
            sb.Append("  DisallowCopy: ").Append(DisallowCopy).Append("\n");
            sb.Append("  DisallowAnnotate: ").Append(DisallowAnnotate).Append("\n");
            sb.Append("  DisallowModify: ").Append(DisallowModify).Append("\n");
            sb.Append("  Debug: ").Append(Debug).Append("\n");
            sb.Append("  Input: ").Append(Input).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Javascript: ").Append(Javascript).Append("\n");
            sb.Append("  CssDpi: ").Append(CssDpi).Append("\n");
            sb.Append("  Profile: ").Append(Profile).Append("\n");
            sb.Append("  PdfTitle: ").Append(PdfTitle).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as PrinceOptions);
        }

        /// <summary>
        /// Returns true if PrinceOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of PrinceOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PrinceOptions input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Baseurl == input.Baseurl ||
                    (this.Baseurl != null &&
                    this.Baseurl.Equals(input.Baseurl))
                ) &&
                (
                    this.NoXinclude == input.NoXinclude ||
                    (this.NoXinclude != null &&
                    this.NoXinclude.Equals(input.NoXinclude))
                ) &&
                (
                    this.NoNetwork == input.NoNetwork ||
                    (this.NoNetwork != null &&
                    this.NoNetwork.Equals(input.NoNetwork))
                ) &&
                (
                    this.NoParallelDownloads == input.NoParallelDownloads ||
                    (this.NoParallelDownloads != null &&
                    this.NoParallelDownloads.Equals(input.NoParallelDownloads))
                ) &&
                (
                    this.HttpUser == input.HttpUser ||
                    (this.HttpUser != null &&
                    this.HttpUser.Equals(input.HttpUser))
                ) &&
                (
                    this.HttpPassword == input.HttpPassword ||
                    (this.HttpPassword != null &&
                    this.HttpPassword.Equals(input.HttpPassword))
                ) &&
                (
                    this.HttpProxy == input.HttpProxy ||
                    (this.HttpProxy != null &&
                    this.HttpProxy.Equals(input.HttpProxy))
                ) &&
                (
                    this.HttpTimeout == input.HttpTimeout ||
                    (this.HttpTimeout != null &&
                    this.HttpTimeout.Equals(input.HttpTimeout))
                ) &&
                (
                    this.Insecure == input.Insecure ||
                    (this.Insecure != null &&
                    this.Insecure.Equals(input.Insecure))
                ) &&
                (
                    this.Media == input.Media ||
                    (this.Media != null &&
                    this.Media.Equals(input.Media))
                ) &&
                (
                    this.NoAuthorStyle == input.NoAuthorStyle ||
                    (this.NoAuthorStyle != null &&
                    this.NoAuthorStyle.Equals(input.NoAuthorStyle))
                ) &&
                (
                    this.NoDefaultStyle == input.NoDefaultStyle ||
                    (this.NoDefaultStyle != null &&
                    this.NoDefaultStyle.Equals(input.NoDefaultStyle))
                ) &&
                (
                    this.NoEmbedFonts == input.NoEmbedFonts ||
                    (this.NoEmbedFonts != null &&
                    this.NoEmbedFonts.Equals(input.NoEmbedFonts))
                ) &&
                (
                    this.NoSubsetFonts == input.NoSubsetFonts ||
                    (this.NoSubsetFonts != null &&
                    this.NoSubsetFonts.Equals(input.NoSubsetFonts))
                ) &&
                (
                    this.NoCompress == input.NoCompress ||
                    (this.NoCompress != null &&
                    this.NoCompress.Equals(input.NoCompress))
                ) &&
                (
                    this.Encrypt == input.Encrypt ||
                    (this.Encrypt != null &&
                    this.Encrypt.Equals(input.Encrypt))
                ) &&
                (
                    this.KeyBits == input.KeyBits ||
                    (this.KeyBits != null &&
                    this.KeyBits.Equals(input.KeyBits))
                ) &&
                (
                    this.UserPassword == input.UserPassword ||
                    (this.UserPassword != null &&
                    this.UserPassword.Equals(input.UserPassword))
                ) &&
                (
                    this.OwnerPassword == input.OwnerPassword ||
                    (this.OwnerPassword != null &&
                    this.OwnerPassword.Equals(input.OwnerPassword))
                ) &&
                (
                    this.DisallowPrint == input.DisallowPrint ||
                    (this.DisallowPrint != null &&
                    this.DisallowPrint.Equals(input.DisallowPrint))
                ) &&
                (
                    this.DisallowCopy == input.DisallowCopy ||
                    (this.DisallowCopy != null &&
                    this.DisallowCopy.Equals(input.DisallowCopy))
                ) &&
                (
                    this.DisallowAnnotate == input.DisallowAnnotate ||
                    (this.DisallowAnnotate != null &&
                    this.DisallowAnnotate.Equals(input.DisallowAnnotate))
                ) &&
                (
                    this.DisallowModify == input.DisallowModify ||
                    (this.DisallowModify != null &&
                    this.DisallowModify.Equals(input.DisallowModify))
                ) &&
                (
                    this.Debug == input.Debug ||
                    (this.Debug != null &&
                    this.Debug.Equals(input.Debug))
                ) &&
                (
                    this.Input == input.Input ||
                    (this.Input != null &&
                    this.Input.Equals(input.Input))
                ) &&
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) &&
                (
                    this.Javascript == input.Javascript ||
                    (this.Javascript != null &&
                    this.Javascript.Equals(input.Javascript))
                ) &&
                (
                    this.CssDpi == input.CssDpi ||
                    (this.CssDpi != null &&
                    this.CssDpi.Equals(input.CssDpi))
                ) &&
                (
                    this.Profile == input.Profile ||
                    (this.Profile != null &&
                    this.Profile.Equals(input.Profile))
                ) &&
                (
                    this.PdfTitle == input.PdfTitle ||
                    (this.PdfTitle != null &&
                    this.PdfTitle.Equals(input.PdfTitle))
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
                if (this.Baseurl != null)
                    hashCode = hashCode * 59 + this.Baseurl.GetHashCode();
                if (this.NoXinclude != null)
                    hashCode = hashCode * 59 + this.NoXinclude.GetHashCode();
                if (this.NoNetwork != null)
                    hashCode = hashCode * 59 + this.NoNetwork.GetHashCode();
                if (this.NoParallelDownloads != null)
                    hashCode = hashCode * 59 + this.NoParallelDownloads.GetHashCode();
                if (this.HttpUser != null)
                    hashCode = hashCode * 59 + this.HttpUser.GetHashCode();
                if (this.HttpPassword != null)
                    hashCode = hashCode * 59 + this.HttpPassword.GetHashCode();
                if (this.HttpProxy != null)
                    hashCode = hashCode * 59 + this.HttpProxy.GetHashCode();
                if (this.HttpTimeout != null)
                    hashCode = hashCode * 59 + this.HttpTimeout.GetHashCode();
                if (this.Insecure != null)
                    hashCode = hashCode * 59 + this.Insecure.GetHashCode();
                if (this.Media != null)
                    hashCode = hashCode * 59 + this.Media.GetHashCode();
                if (this.NoAuthorStyle != null)
                    hashCode = hashCode * 59 + this.NoAuthorStyle.GetHashCode();
                if (this.NoDefaultStyle != null)
                    hashCode = hashCode * 59 + this.NoDefaultStyle.GetHashCode();
                if (this.NoEmbedFonts != null)
                    hashCode = hashCode * 59 + this.NoEmbedFonts.GetHashCode();
                if (this.NoSubsetFonts != null)
                    hashCode = hashCode * 59 + this.NoSubsetFonts.GetHashCode();
                if (this.NoCompress != null)
                    hashCode = hashCode * 59 + this.NoCompress.GetHashCode();
                if (this.Encrypt != null)
                    hashCode = hashCode * 59 + this.Encrypt.GetHashCode();
                if (this.KeyBits != null)
                    hashCode = hashCode * 59 + this.KeyBits.GetHashCode();
                if (this.UserPassword != null)
                    hashCode = hashCode * 59 + this.UserPassword.GetHashCode();
                if (this.OwnerPassword != null)
                    hashCode = hashCode * 59 + this.OwnerPassword.GetHashCode();
                if (this.DisallowPrint != null)
                    hashCode = hashCode * 59 + this.DisallowPrint.GetHashCode();
                if (this.DisallowCopy != null)
                    hashCode = hashCode * 59 + this.DisallowCopy.GetHashCode();
                if (this.DisallowAnnotate != null)
                    hashCode = hashCode * 59 + this.DisallowAnnotate.GetHashCode();
                if (this.DisallowModify != null)
                    hashCode = hashCode * 59 + this.DisallowModify.GetHashCode();
                if (this.Debug != null)
                    hashCode = hashCode * 59 + this.Debug.GetHashCode();
                if (this.Input != null)
                    hashCode = hashCode * 59 + this.Input.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.Javascript != null)
                    hashCode = hashCode * 59 + this.Javascript.GetHashCode();
                if (this.CssDpi != null)
                    hashCode = hashCode * 59 + this.CssDpi.GetHashCode();
                if (this.Profile != null)
                    hashCode = hashCode * 59 + this.Profile.GetHashCode();
                if (this.PdfTitle != null)
                    hashCode = hashCode * 59 + this.PdfTitle.GetHashCode();
                return hashCode;
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
