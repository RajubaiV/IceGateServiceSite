using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGI.Icegate_Integration.Core.EntitiesDTO
{
    public class IntegrationResponseDTO
    {
        public string? Status { get; set; }
        public string? ErrorCode { get; set; }
        public string? CommonRefNumber { get; set; }
        public string? Message { get; set; }
        public string? RequestorId { get; set; }
        public string? AckId { get; set; }
        public string? ManifestNumberOrRotationNumber { get; set; }
        public DateTime? ManifestDateOrRotationDate { get; set; }
        public DateTime? ResponseRecivedDate { get; set; }
    }
}
