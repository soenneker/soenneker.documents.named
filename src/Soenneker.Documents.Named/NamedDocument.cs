using System.Text.Json.Serialization;
using Soenneker.Documents.Named.Abstract;

namespace Soenneker.Documents.Named;

/// <inheritdoc cref="INamedDocument" />
public class NamedDocument : Document.Document, INamedDocument
{
    [JsonPropertyName("name")]
    public virtual string Name { get; set; } = null!;
}
