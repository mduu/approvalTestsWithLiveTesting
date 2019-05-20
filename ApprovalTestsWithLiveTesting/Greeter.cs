using System.Threading.Tasks;

namespace ApprovalTestsWithLiveTesting
{
    internal class Greeter
    {
        public string GetHello(string name) => $"Hello {name}!";

        public Task<string> GetHelloAsync(string name) => Task.FromResult($"Hello {name}");
    }
}
