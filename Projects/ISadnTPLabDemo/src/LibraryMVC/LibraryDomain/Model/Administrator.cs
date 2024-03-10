using System;
using System.Collections.Generic;

namespace LibraryDomain.Model;

public partial class Administrator:Entity 
{
   

    public string Surname { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}
