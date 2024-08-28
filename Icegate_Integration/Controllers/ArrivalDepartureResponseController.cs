using IGI.Icegate_Integration.Core.Domain.Entities;
using IGI.Icegate_Integration.Infrastructure.Context;
using Microsoft.AspNetCore.Mvc;

namespace IGI.Icegate_Integration.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArrivalDepartureResponseController : ControllerBase
    {
        private readonly IGIdbContext iGIdbContext;
        public ArrivalDepartureResponseController(IGIdbContext iGIdbContext)
        {
            this.iGIdbContext = iGIdbContext;
        }

        [HttpGet]
        public IActionResult GetArrivalDepartureResponseDetails()
        {
            var responsedata = iGIdbContext.ArrivalDepartureResponseDetails.ToList();
            return Ok(responsedata);
        }

        [HttpPost]
        public async Task<ActionResult<ArrivalDepartureResponseDetails>> AddIntegrationResponse(ArrivalDepartureResponseDetails arrivalDepartureResponseDetails)
        {

            iGIdbContext.ArrivalDepartureResponseDetails.Add(arrivalDepartureResponseDetails);
            await iGIdbContext.SaveChangesAsync();

            return CreatedAtAction("GetArrivalDepartureResponseDetails", new { id = arrivalDepartureResponseDetails.ArrivalDepartureResponseId }, arrivalDepartureResponseDetails); ;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ArrivalDepartureResponseDetails>> GetArrivalDepartureResponseDetails(int id)
        {
            var arrivalDepartureResponseDetails = await iGIdbContext.ArrivalDepartureResponseDetails.FindAsync(id);

            if (arrivalDepartureResponseDetails == null)
            {
                return NotFound();
            }

            return arrivalDepartureResponseDetails;
        }
    }
}
