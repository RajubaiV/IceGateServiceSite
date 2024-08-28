using IGI.Icegate_Integration.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGI.Icegate_Integration.Core.Context
{
    public interface IIGIdbContext
    {
        public DbSet<IntegrationRequest> IntegrationRequest { get; set; }
        public DbSet<IntegrationResponse> IntegrationResponse { get; set; }
        public DbSet<ArrivalDepartureRequestDetails> ArrivalDepartureRequestDetails { get; set; }
        public DbSet<ArrivalDepartureResponseDetails> ArrivalDepartureResponseDetails { get; set; }

    }
}
