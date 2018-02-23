using System.Threading.Tasks;

namespace functions_dependency_injection_poc.Services
{
    public class TestService : ITestService
    {
        public Task<string> GetDescription()
        {
            return Task.FromResult("This is a default description");
        }
    }
}
