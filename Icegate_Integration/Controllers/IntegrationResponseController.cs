using IGI.Icegate_Integration.Core.Domain.Entities;
using IGI.Icegate_Integration.Infrastructure.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IGI.Icegate_Integration.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IntegrationResponseController : ControllerBase
    {
        private readonly IGIdbContext iGIdbContext;
        public IntegrationResponseController(IGIdbContext iGIdbContext)
        {
            this.iGIdbContext = iGIdbContext;
        }

        [HttpGet]
        public IActionResult GetIntegrationResponse()
        {
            var responsedata = iGIdbContext.IntegrationResponse.ToList();
            return Ok(responsedata);
        }

        [HttpPost]
        public async Task<ActionResult<IntegrationResponse>> AddIntegrationResponse(IntegrationResponse integrationResponse)
        {

            iGIdbContext.IntegrationResponse.Add(integrationResponse);
            await iGIdbContext.SaveChangesAsync();

            return CreatedAtAction("GetIntegrationResponse", new { id = integrationResponse.IntegrationResponseId }, integrationResponse); ;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IntegrationResponse>> GetIntegrationResponse(int id)
        {
            var integrationResponseDetails = await iGIdbContext.IntegrationResponse.FindAsync(id);

            if (integrationResponseDetails == null)
            {
                return NotFound();
            }

            return integrationResponseDetails;
        }

    }
}
