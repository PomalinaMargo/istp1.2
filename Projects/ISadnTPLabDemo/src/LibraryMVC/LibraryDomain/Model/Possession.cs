using System;
using System.Collections.Generic;
using LibraryDomain.Model;
using Microsoft.EntityFrameworkCore;
namespace LibraryDomain.Model;


public partial class Possession: Entity
{

    public int Userid { get; set; }

    public int Bookid { get; set; }

    public virtual Book Book { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
