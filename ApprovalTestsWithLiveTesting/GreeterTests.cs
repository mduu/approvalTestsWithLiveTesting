using ApprovalTests;
using ApprovalTests.Reporters;
using Xunit;

namespace ApprovalTestsWithLiveTesting
{
    [UseReporter(typeof(DiffReporter))]
    public class GreeterTests
    {
        private readonly Greeter greeter = new Greeter();

        [Fact]
        public void TestWithName()
        {
            // Arrange
            var name = "John";

            // Act
            var greeting = greeter.GetHello(name);

            // Approve
            Approvals.Verify(greeting);
        }
    }
}
