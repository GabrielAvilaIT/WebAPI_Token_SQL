using System;
using System.Collections.Generic;

namespace WebAPI_Token_SQL.Models;

public partial class Usuario
{
    public int Id { get; set; }

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Nombre { get; set; } = null!;
}
