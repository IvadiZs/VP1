namespace VizsgaPractice1.Models.DTOs {
    public class DTOs {
        public record JegyDTO(int Id, int JegySzammal, string JegySzoveggel, DateTime BeirasDatuma, DateTime ModositasDatuma,
                              int IdTanarok, int IdTantargyak);

        public record CreateJegyDTO(int Id, int JegySzammal, string JegySzoveggel, DateTime BeirasDatuma, DateTime ModositasDatuma,
                                    int IdTanarok, int IdTantargyak);

        public record UpdateJegyDTO(int JegySzammal, string JegySzoveggel, DateTime ModositasDatuma);


        public record TanarDTO(int Id, string VezetekNev, string KeresztNev, string Email, string Nem);
        public record CreateTanarDTO(int Id, string VezetekNev, string KeresztNev, string Email, string Nem);
        public record UpdateTanarDTO(string VezetekNev, string KeresztNev, string Email, string Nem);

        public record TantargyDTO(int Id, string TantargyNev, string TantargyLeiras);
        public record CreateTantargyDTO(int Id, string TantargyNev, string TantargyLeiras);
        public record UpdateTantargyDTO(string TantargyNev, string TantargyLeiras);

    }
}
