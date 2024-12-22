using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Documents.Named.Tests;

[Collection("Collection")]
public class NamedDocumentTests : FixturedUnitTest
{
    public NamedDocumentTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
