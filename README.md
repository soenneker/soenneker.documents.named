[![](https://img.shields.io/nuget/v/Soenneker.Documents.Named.svg?style=for-the-badge)](https://www.nuget.org/packages/Soenneker.Documents.Named/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.documents.named/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.documents.named/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/Soenneker.Documents.Named.svg?style=for-the-badge)](https://www.nuget.org/packages/Soenneker.Documents.Named/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.documents.named/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.documents.named/actions/workflows/codeql.yml)

# Soenneker.Documents.Named

Provides a document model with an additional serialized `Name` field.

## Installation

```bash
dotnet add package Soenneker.Documents.Named
```

## Usage

```csharp
using Soenneker.Documents.Named;

var document = new NamedDocument
{
    DocumentId = "status-active",
    PartitionKey = "statuses",
    CreatedAt = DateTimeOffset.UtcNow,
    Name = "Active"
};
```

The model serializes these fields with both System.Text.Json and Newtonsoft.Json:

| Property | JSON name |
| --- | --- |
| `DocumentId` | `id` |
| `PartitionKey` | `partitionKey` |
| `CreatedAt` | `createdAt` |
| `ModifiedAt` | `modifiedAt` |
| `Name` | `name` |

`Id` remains the inherited, serializer-ignored composite convenience value. See `Soenneker.Documents.Document` for its partition-key and colon parsing rules.

`Name` is virtual so specialized documents can override it. The class does not initialize or validate names, identifiers, or timestamps; populate and validate them before persistence.

Use `INamedDocument` when APIs should accept any document carrying the same identity, timestamp, and name contract.
