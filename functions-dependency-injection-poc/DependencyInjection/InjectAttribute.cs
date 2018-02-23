using Microsoft.Azure.WebJobs.Description;
using System;

namespace functions_dependency_injection_poc.DependencyInjection
{
    [Binding]
    [AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false)]
    public class InjectAttribute : Attribute
    {
    }
}