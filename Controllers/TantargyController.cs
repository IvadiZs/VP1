using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VizsgaPractice1.Models;

namespace VizsgaPractice1.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class JegyController : ControllerBase {

        [HttpGet]
        public ActionResult Get() {
            using (var context = new OsztalynaploContext()) {
                try {
                    return Ok(context.Tantargyaks.ToList());
                }
                catch (Exception e) {

                    return StatusCode(400, e);
                }
            }
        }

        [HttpGet("{nev}")]
        public ActionResult Get(string nev) {
            using (var context = new OsztalynaploContext()) {
                try {
                    var result = context.Tantargyaks.FirstOrDefault(x => x.TantargyNev == nev);
                    return Ok(result.AsTantargy());
                }
                catch (Exception e) {

                    return StatusCode(400, e);
                }
            }
        }
    }
}
