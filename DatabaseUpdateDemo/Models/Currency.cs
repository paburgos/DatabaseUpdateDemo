using System;
using System.Collections.Generic;

namespace DatabaseUpdateDemo.Models;

public partial class Currency
{
    public int CurrencyId { get; set; }

    public string Name { get; set; } = null!;
    public string Country { get; set; } = null!;
    public string Abbreviation { get; set; } = null!;
}
