

using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace IGI.Icegate_Integration.Core.Program
{
    public static class ProgramExtension
    {
        public static void Addservice(this IServiceCollection service)
        {
            service.AddMediatR(typeof(ProgramExtension));
        }
    }
}
