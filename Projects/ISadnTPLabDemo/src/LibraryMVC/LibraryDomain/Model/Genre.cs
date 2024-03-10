using System;
using System.Collections.Generic;

namespace LibraryDomain.Model;

public partial class Genre: Entity
{

    public string GenreName { get; set; } = null!;

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}
