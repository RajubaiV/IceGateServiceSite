using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
