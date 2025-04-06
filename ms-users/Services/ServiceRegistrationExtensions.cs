using System;
using System.Linq;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace ms_users.Services  // Puedes usar el espacio de nombres que prefieras
{
    public static class ServiceRegistrationExtensions
    {
        // Método para registrar todos los servicios en un ensamblaje
        public static void AddServices(this IServiceCollection services, Assembly assembly)
        {
            var types = assembly.GetTypes()
                .Where(t => t.IsClass && !t.IsAbstract)
                .ToList();

            foreach (var type in types)
            {
                var interfaces = type.GetInterfaces();
                foreach (var @interface in interfaces)
                {
                    services.AddScoped(@interface, type);
                }
            }
        }

        // Método para registrar servicios por convención (por ejemplo, en un namespace específico)
        public static void AddServicesByConvention(this IServiceCollection services, Assembly assembly)
        {
            var types = assembly.GetTypes()
                .Where(t => t.IsClass && !t.IsAbstract && t.Namespace == "ms_payments.Services")  // Puedes cambiar el namespace
                .ToList();

            foreach (var type in types)
            {
                var interfaces = type.GetInterfaces().Where(i => i.Name.StartsWith("I")).ToList();
                foreach (var @interface in interfaces)
                {
                    services.AddScoped(@interface, type);
                }
            }
        }
    }
}
