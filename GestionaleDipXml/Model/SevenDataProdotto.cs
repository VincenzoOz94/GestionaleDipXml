using System;
using System.Collections.Generic;

namespace GestionaleDipXml.Model;

public partial class SevenDataProdotto
{
    public int Oid { get; set; }

    public string Nome { get; set; } = null!;

    public int CodiceJson { get; set; }

    public bool Attivo { get; set; }

    public int CodicePdf { get; set; }
}
