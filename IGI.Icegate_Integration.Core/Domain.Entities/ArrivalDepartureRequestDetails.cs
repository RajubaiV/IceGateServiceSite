using System.ComponentModel.DataAnnotations;

namespace IGI.Icegate_Integration.Core.Domain.Entities
{
    public class ArrivalDepartureRequestDetails
    {
        [Key]
        public int ArrivalDepartureDetailsId { get; set; }
        public Guid? AckId { get; set; }
        public string? RequestorId { get; set; }
        public string? RecordType { get; set; }
        public string? PortCode { get; set; }
        public string? VoyageCallNumber { get; set; }
        public string? TerminalOperatorCode { get; set; }
        public string? ReportingEvent { get; set; }
        public string? TypeOfTransportMeans { get; set; }
        public string? IdentityOfTransportMeans { get; set; }
        public string? BerthNumber { get; set; }
        public string? ManifestNumber { get; set; }
        public DateTimeOffset? ManifestDate { get; set; }
        public string? ARTerminalOperator { get; set; }
        public DateTimeOffset? ArrivalDepartureTime { get; set; }
        public DateTimeOffset? FinalAmendsArrivalDepartureTime { get; set; }
        public string? StateId { get; set; }
    }
    public class ArrivalDepartureRequestDetailsJson
    {
        public ArrivalDepartureRequestDetails? Text { get; set; }
    }
}
