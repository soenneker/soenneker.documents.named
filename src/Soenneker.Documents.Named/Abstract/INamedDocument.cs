using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Soenneker.Documents.Document.Abstract;
using Soenneker.Entities.Named.Abstract;

namespace Soenneker.Documents.Named.Abstract;

/// <summary>
/// Essentially provides a Name string property on Document <para/>
/// <inheritdoc cref="IDocument"/>
/// </summary>
public interface INamedDocument : IDocument
{
    /// <summary>
    /// Gets or sets name.
    /// </summary>
    [JsonPropertyName("name")]
    [JsonProperty("name")]
    string Name { get; set; }
}