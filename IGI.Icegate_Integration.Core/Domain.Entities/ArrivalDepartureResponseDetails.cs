using System.ComponentModel.DataAnnotations;

namespace IGI.Icegate_Integration.Core.Domain.Entities
{
    public class ArrivalDepartureResponseDetails
    {
        [Key]
        public int ArrivalDepartureResponseId { get; set; }
        public string? Status { get; set; }
        public string? ErrorCode { get; set; }
        public string? CommonRefNumber { get; set; }
        public string? Message { get; set; }
        public string? RequestorId { get; set; }
        public Guid? AckId { get; set; }
    }
}
