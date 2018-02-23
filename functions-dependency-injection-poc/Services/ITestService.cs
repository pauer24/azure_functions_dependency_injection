using System.Threading.Tasks;

namespace functions_dependency_injection_poc.Services
{
    public interface ITestService
    {
        Task<string> GetDescription();
    }
}