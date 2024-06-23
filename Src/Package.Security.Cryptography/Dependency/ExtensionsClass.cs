using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using Package.Security.Cryptography.Contrasts;
using Package.Security.Cryptography.Services;

namespace Package.Security.Cryptography.Dependency
{
    public static class ExtensionsClass
    {
        public static void AddCryptographyService(this IServiceCollection services)
        {
            services.AddSingleton<ICryptographyService, CryptographyService>();
        }
    }
}
