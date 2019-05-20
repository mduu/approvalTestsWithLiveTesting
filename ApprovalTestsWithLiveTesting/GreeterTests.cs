using System.Threading.Tasks;
using ApprovalTests;
using Xunit;

namespace ApprovalTestsWithLiveTesting
{
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

        [Fact]
        public async Task TestWithNameAsync()
        {
            // Arrange
            const string name = "John";

            // Act
            var greeting = await greeter.GetHelloAsync(name);

            // Approve
            Approvals.Verify(greeting);
        }
    }
}
