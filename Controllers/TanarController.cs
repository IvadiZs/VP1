using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VizsgaPractice1.Models;

namespace VizsgaPractice1.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class TanarController : ControllerBase {

        [HttpGet]
        public ActionResult Get() {
            using (var context = new OsztalynaploContext()) {
                try {
                    return Ok(context.Tanaroks.ToList());
                }
                catch (Exception e) {

                    return StatusCode(400, e);
                }
            }
        }
    }
}
