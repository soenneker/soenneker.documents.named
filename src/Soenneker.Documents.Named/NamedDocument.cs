using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Soenneker.Documents.Named.Abstract;

namespace Soenneker.Documents.Named;

public class NamedDocument : Document.Document, INamedDocument
{
    [JsonPropertyName("name")]
    [JsonProperty("name")]
    public virtual string Name { get; set; } = null!;
}
