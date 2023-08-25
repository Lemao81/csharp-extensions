using System.Collections.Generic;

namespace Tests.Helpers;

public class TestClass
{
    public TestEnum EnumProperty { get; set; }
    public string StringProperty { get; set; }
    public IEnumerable<string> EnumerableProperty { get; set; }

    [Test]
    public string AttributeProperty { get; set; }
}
