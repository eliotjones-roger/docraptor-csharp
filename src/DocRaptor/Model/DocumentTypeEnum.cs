using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DocRaptor.Model
{
    /// <summary>
    /// The type of document being created.
    /// </summary>
    /// <value>The type of document being created.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DocumentTypeEnum
    {
        /// <summary>
        /// Enum Pdf for value: pdf
        /// </summary>
        [EnumMember(Value = "pdf")]
        Pdf = 1,

        /// <summary>
        /// Enum Xls for value: xls
        /// </summary>
        [EnumMember(Value = "xls")]
        Xls = 2,

        /// <summary>
        /// Enum Xlsx for value: xlsx
        /// </summary>
        [EnumMember(Value = "xlsx")]
        Xlsx = 3
    }
}