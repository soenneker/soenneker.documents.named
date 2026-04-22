using Soenneker.Tests.HostedUnit;

namespace Soenneker.Documents.Named.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class NamedDocumentTests : HostedUnitTest
{
    public NamedDocumentTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
