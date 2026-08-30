using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Soenneker.Documents.Document.Abstract;
using Soenneker.Entities.Named.Abstract;

namespace Soenneker.Documents.Named.Abstract;

/// <summary>
/// Defines a document that has a name.
/// </summary>
public interface INamedDocument : IDocument
{
    /// <summary>
    /// Gets or sets the document's display name.
    /// </summary>
    [JsonPropertyName("name")]
    [JsonProperty("name")]
    string Name { get; set; }
}
