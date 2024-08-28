using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
            
namespace IGI.Icegate_Integration.Core.Domain.Entities
{
    public class IntegrationResponse
    {
        [Key]
        public int IntegrationResponseId { get; set; }
        public string? Status { get; set; }
        public string? ErrorCode { get; set; }
        public string? CommonRefNumber { get; set; }
        public string? Message { get; set; }
        public string? RequestorId { get; set; }
        public Guid? AckId { get; set; }
        public string? ManifestNumberOrRotationNumber { get; set; }
        public DateTimeOffset? ManifestDateOrRotationDate { get; set; }
        public DateTimeOffset? ResponseRecivedDate { get; set; }
    }
}
