using LibNetCore.Core;
using System.Reflection;

namespace KTX
{
    public static class Register
    {
        public static void RegisterService(this IServiceCollection services)
        {
            var assemblyToScan = Assembly.GetAssembly(typeof(Register));

            services.RegisterAssemblyPublicNonGenericClasses(assemblyToScan)
              .Where(c => c.Name.EndsWith("Service"))
              .AsPublicImplementedInterfaces(); ;
        }
    }
}
