using System;
using System.Collections.Generic;

namespace VizsgaPractice1.Models;

public partial class Tanarok
{
    public int Id { get; set; }

    public string? VezetekNev { get; set; }

    public string? KeresztNev { get; set; }

    public string? Email { get; set; }

    public string? Nem { get; set; }

    public virtual ICollection<Jegyek> Jegyeks { get; set; } = new List<Jegyek>();
}
