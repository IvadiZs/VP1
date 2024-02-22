using VizsgaPractice1.Models;
using VizsgaPractice1.Models.DTOs;

namespace VizsgaPractice1 {
    public static class Extensions {   

        public static DTOs.TantargyDTO AsTantargy(this Tantargyak targy) {
            return new (targy.Id, targy.TantargyNev, targy.TantargyLeiras);
        }

        public static DTOs.JegyDTO AsJegy(this Jegyek jegy) {
            return new(jegy.Id, jegy.JegySzammal, jegy.JegySzoveggel, jegy.BeirasDatuma, jegy.ModositasDatuma, jegy.IdTanarok, jegy.IdTantargyak);
        }
    }
}
