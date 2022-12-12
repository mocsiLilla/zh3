using System;
using System.Collections.Generic;

namespace zh3.Models;

public partial class Nyersanyagok
{
    public int NyersanyagId { get; set; }

    public string? NyersanyagNev { get; set; }

    public int? MennyisegiEgysegId { get; set; }

    public decimal? Egysegar { get; set; }

    public virtual MennyisegiEgysegek? MennyisegiEgyseg { get; set; }

    public virtual ICollection<Receptek> Receptek { get; } = new List<Receptek>();
}
