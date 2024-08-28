using IGI.Icegate_Integration.Core.Domain.Entities;
using IGI.Icegate_Integration.Infrastructure.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IGI.Icegate_Integration.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArrivalDepartureRequestDetailsController : ControllerBase
    {
        private readonly IGIdbContext iGIdbContext;

        public ArrivalDepartureRequestDetailsController(IGIdbContext iGIdbContext)
        {
            this.iGIdbContext = iGIdbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetArrivalDepartureRequestDetails()
        {
            var requestdata = await iGIdbContext.ArrivalDepartureRequestDetails.ToListAsync();
            return Ok(requestdata);
        }

        [HttpPost]
        public async Task<ActionResult<ArrivalDepartureRequestDetails>> AddArrivalDepartureRequestDetails (ArrivalDepartureRequestDetailsJson arrivalDepartureRequestDetails)
        {
            var request = arrivalDepartureRequestDetails.Text;
            var addArrivalDepartureRequestDetails = new ArrivalDepartureRequestDetails()
            {
                RequestorId = request.RequestorId,
                RecordType = request.RecordType,
                PortCode = request.PortCode,
                VoyageCallNumber = request.VoyageCallNumber,
                TerminalOperatorCode = request.TerminalOperatorCode,
                ReportingEvent = request.ReportingEvent,
                TypeOfTransportMeans = request.TypeOfTransportMeans,
                IdentityOfTransportMeans = request.IdentityOfTransportMeans,
                BerthNumber = request.BerthNumber,                
                ManifestNumber = request.ManifestNumber,
                ManifestDate = request.ManifestDate,
                ARTerminalOperator = request.ARTerminalOperator,
                ArrivalDepartureTime = request.ArrivalDepartureTime,
                FinalAmendsArrivalDepartureTime = request.FinalAmendsArrivalDepartureTime,
                StateId = request.StateId
            };

            iGIdbContext.ArrivalDepartureRequestDetails.Add(addArrivalDepartureRequestDetails);
            await iGIdbContext.SaveChangesAsync();
            return CreatedAtAction("GetArrivalDepartureRequestDetails", new { id = addArrivalDepartureRequestDetails.ArrivalDepartureDetailsId }, arrivalDepartureRequestDetails); ;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ArrivalDepartureRequestDetails>> GetArrivalDepartureRequestDetails (int id)
        {
            var arrivalDepartureRequestDetails = await iGIdbContext.ArrivalDepartureRequestDetails.FindAsync(id);

            if (arrivalDepartureRequestDetails == null)
            {
                return NotFound();
            }

            return arrivalDepartureRequestDetails;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] ArrivalDepartureRequestDetailsJson arrivalDepartureRequestDetails)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var request = arrivalDepartureRequestDetails.Text;
            var contact = await iGIdbContext.ArrivalDepartureRequestDetails.FindAsync(id);
            if (contact == null)
            {
                return NotFound();
            }

            contact.AckId = request.AckId;
            contact.RequestorId = request.RequestorId;
            contact.RecordType = request.RecordType;
            contact.PortCode = request.PortCode;
            contact.VoyageCallNumber = request.VoyageCallNumber;
            contact.TerminalOperatorCode = request.TerminalOperatorCode;
            contact.ReportingEvent = request.ReportingEvent;
            contact.TypeOfTransportMeans = request.TypeOfTransportMeans;
            contact.IdentityOfTransportMeans = request.IdentityOfTransportMeans;
            contact.BerthNumber = request.BerthNumber;                
            contact.ManifestNumber = request.ManifestNumber;
            contact.ManifestDate = request.ManifestDate;
            contact.ARTerminalOperator = request.ARTerminalOperator;
            contact.ArrivalDepartureTime = request.ArrivalDepartureTime;
            contact.FinalAmendsArrivalDepartureTime = request.FinalAmendsArrivalDepartureTime;
            contact.StateId = request.StateId;

            await iGIdbContext.SaveChangesAsync();
            return Ok(contact);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteIntegrationRequest(int id)
        {
            var arrivalDepartureRequestDetails = await iGIdbContext.ArrivalDepartureRequestDetails.FindAsync(id);
            if (arrivalDepartureRequestDetails == null)
            {
                return NotFound();
            }

            iGIdbContext.ArrivalDepartureRequestDetails.Remove(arrivalDepartureRequestDetails);
            await iGIdbContext.SaveChangesAsync();

            return NoContent();
        }

    }
}
