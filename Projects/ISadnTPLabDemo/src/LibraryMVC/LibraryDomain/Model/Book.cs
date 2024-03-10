using System;
using System.Collections.Generic;

namespace LibraryDomain.Model;

public partial class Book: Entity
{

    public string Title { get; set; } = null!;

    public int Genreid { get; set; }

    public int Authorid { get; set; }

    public int Usersid { get; set; }

    public byte[] YearOfPublication { get; set; } = null!;

    public int NumberOfPages { get; set; }

    public string Description { get; set; } = null!;

    public int Administratorid { get; set; }

    public virtual Administrator Administrator { get; set; } = null!;

    public virtual Author Author { get; set; } = null!;

    public virtual Genre Genre { get; set; } = null!;

    public virtual ICollection<Possession> Possessions { get; set; } = new List<Possession>();
}
