using CSharpier.Tests.TestFileTests;
using NUnit.Framework;

namespace CSharpier.Tests.TestFiles
{
    public class ElementAccessExpressionTests : BaseTest
    {
        [Test]
        public void BasicElementAccessExpression()
        {
            this.RunTest(
                "ElementAccessExpression",
                "BasicElementAccessExpression");
        }
    }
}