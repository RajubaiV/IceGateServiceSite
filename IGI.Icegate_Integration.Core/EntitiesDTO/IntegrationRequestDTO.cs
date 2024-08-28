using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGI.Icegate_Integration.Core.EntitiesDTO
{
    public class IntegrationRequestDTO
    {
        public string? RequestorId { get; set; }
        public char? RecordType { get; set; }
        public string? VoyageCallNumber { get; set; }
        public string? ModeOfTransport { get; set; }
        public string? TypeOfTransportMeans { get; set; }
        public string? IdentityOfTransportMeans { get; set; }
        public string? VesselCode { get; set; }
        public string? VoyageNumber { get; set; }
        public string? TypeOfVessel { get; set; }
        public string? PurposeOfCall { get; set; }
        public string? ShippingAgentCode { get; set; }
        public string? LineCode { get; set; }
        public string? TerminalOperatorCode { get; set; }
        public string? PortCode { get; set; }
        public DateTime? ExpectedDateTimeOfArrival { get; set; }
        public DateTime? ExpectedDateTimeOfDeparture { get; set; }
        public DateTime? RequestePostedDate { get; set; }
        public string? ServiceName { get; set; }
        public DateTime? AllotmentDate { get; set; }
        public string? ManifestNumberOrRotationNumber { get; set; }
        public DateTime? ManifestDateOrRotationDate { get; set; }
    }
}
