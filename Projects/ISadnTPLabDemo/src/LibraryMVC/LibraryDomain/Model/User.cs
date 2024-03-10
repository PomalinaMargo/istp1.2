using System;
using System.Collections.Generic;
using LibraryDomain.Model;
using Microsoft.EntityFrameworkCore;


namespace LibraryDomain.Model;

public partial class User: Entity
{

    public string Surname { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public virtual ICollection<Possession> Possessions { get; set; } = new List<Possession>();
}
