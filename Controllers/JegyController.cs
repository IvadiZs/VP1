using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using VizsgaPractice1.Models;
using static VizsgaPractice1.Models.DTOs.DTOs;

namespace VizsgaPractice1.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class JegyController : ControllerBase {

        [HttpGet]
        public ActionResult Get() {
            using (var context = new OsztalynaploContext()) {
                try {
                    return Ok($"Összes jegy száma: {context.Tantargyaks.ToList().Count}");
                }
                catch (Exception e) {

                    return StatusCode(400, e);
                }
            }
        }

        [HttpPost]
        public ActionResult<JegyDTO> Post(CreateJegyDTO grade) {
            try {
                using (var context = new OsztalynaploContext()) {

                    var request = new Jegyek {

                        Id = grade.Id,
                        JegySzammal = grade.JegySzammal,
                        JegySzoveggel = grade.JegySzoveggel,
                        BeirasDatuma = DateTime.Now,
                        ModositasDatuma = DateTime.Now,
                        IdTanarok = grade.IdTanarok,
                        IdTantargyak = grade.IdTantargyak

                    };

                    context.Jegyeks.Add(request);
                    context.SaveChanges();
                    return Ok(request.AsJegy());
                }
            }
            catch (Exception e) {

                return StatusCode(400, e);
            }
        }
    }
}
