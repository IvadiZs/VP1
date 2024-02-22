using System;
using System.Collections.Generic;

namespace VizsgaPractice1.Models;

public partial class Tantargyak
{
    public int Id { get; set; }

    public string? TantargyNev { get; set; }

    public string? TantargyLeiras { get; set; }

    public virtual ICollection<Jegyek> Jegyeks { get; set; } = new List<Jegyek>();
}
