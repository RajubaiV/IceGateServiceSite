using IGI.Icegate_Integration.Core.Domain.Entities;
using IGI.Icegate_Integration.Infrastructure.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace IGI.Icegate_Integration.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IntegrationRequestController : ControllerBase
    {
        private readonly IGIdbContext iGIdbContext;

        public IntegrationRequestController(IGIdbContext iGIdbContext)
        {
            this.iGIdbContext = iGIdbContext;
        }
        [HttpGet]
        public async Task<IActionResult> GetIntegrationRequest()
        {
            var requestdata = await iGIdbContext.IntegrationRequest.ToListAsync();
            return Ok(requestdata);

        }

        [HttpPost]
        public async Task<ActionResult<IntegrationRequest>> AddIntegrationRequest(IntegrationRequestJson integrationRequest)
        {

            var request = integrationRequest.Text;
            var addIntegrationRequest = new IntegrationRequest()
            {
                RequestorId = request.RequestorId,
                RecordType = request.RecordType,
                VoyageCallNumber = request.VoyageCallNumber,
                ModeOfTransport = request.ModeOfTransport,
                TypeOfTransportMeans = request.TypeOfTransportMeans,
                IdentityOfTransportMeans = request.IdentityOfTransportMeans,
                VesselCode = request.VesselCode,
                VoyageNumber = request.VoyageNumber,
                TypeOfVessel = request.TypeOfVessel,
                PurposeOfCall = request.PurposeOfCall,
                ShippingAgentCode = request.ShippingAgentCode,
                LineCode = request.LineCode,
                TerminalOperatorCode = request.TerminalOperatorCode,
                PortCode = request.PortCode,
                ExpectedDateTimeOfArrival = request.ExpectedDateTimeOfArrival,
                ExpectedDateTimeOfDeparture = request.ExpectedDateTimeOfDeparture,
                RequestePostedDate = request.RequestePostedDate,
                ServiceName = request.ServiceName,
                AllotmentDate = request.AllotmentDate,
                ManifestNumberOrRotationNumber = request.ManifestNumberOrRotationNumber,
                ManifestDateOrRotationDate = request.ManifestDateOrRotationDate,
                StateId = request.StateId
            };

            iGIdbContext.IntegrationRequest.Add(addIntegrationRequest);
            await iGIdbContext.SaveChangesAsync();
            return CreatedAtAction("GetIntegrationRequest", new { id = addIntegrationRequest.IntegrationRequestId }, integrationRequest); ;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IntegrationRequest>> GetIntegrationRequest(int id)
        {
            var integrationRequestDetails = await iGIdbContext.IntegrationRequest.FindAsync(id);

            if (integrationRequestDetails == null)
            {
                return NotFound();
            }

            return integrationRequestDetails;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] IntegrationRequestJson integrationRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var request = integrationRequest.Text;
            var contact = await iGIdbContext.IntegrationRequest.FindAsync(id);
            if (contact == null)
            {
                return NotFound();
            }

            contact.AckId = request.AckId;
            contact.RequestorId = request.RequestorId;
            contact.RecordType = request.RecordType;
            contact.VoyageCallNumber = request.VoyageCallNumber;
            contact.ModeOfTransport = request.ModeOfTransport;
            contact.TypeOfTransportMeans = request.TypeOfTransportMeans;
            contact.IdentityOfTransportMeans = request.IdentityOfTransportMeans;
            contact.VesselCode = request.VesselCode;
            contact.VoyageNumber = request.VoyageNumber;
            contact.TypeOfVessel = request.TypeOfVessel;
            contact.PurposeOfCall = request.PurposeOfCall;
            contact.ShippingAgentCode = request.ShippingAgentCode;
            contact.LineCode = request.LineCode;
            contact.TerminalOperatorCode = request.TerminalOperatorCode;
            contact.PortCode = request.PortCode;
            contact.ExpectedDateTimeOfArrival = request.ExpectedDateTimeOfArrival;
            contact.ExpectedDateTimeOfDeparture = request.ExpectedDateTimeOfDeparture;
            contact.RequestePostedDate = request.RequestePostedDate;
            contact.ServiceName = request.ServiceName;
            contact.AllotmentDate = request.AllotmentDate;
            contact.ManifestNumberOrRotationNumber = request.ManifestNumberOrRotationNumber;
            contact.ManifestDateOrRotationDate = request.ManifestDateOrRotationDate;
            contact.StateId = request.StateId;

            await iGIdbContext.SaveChangesAsync();
            return Ok(contact);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteIntegrationRequest(int id)
        {
            var integrationRequest = await iGIdbContext.IntegrationRequest.FindAsync(id);
            if (integrationRequest == null)
            {
                return NotFound();
            }

            iGIdbContext.IntegrationRequest.Remove(integrationRequest);
            await iGIdbContext.SaveChangesAsync();

            return NoContent();
        }

    }
}
