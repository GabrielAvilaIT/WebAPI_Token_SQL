using System;
using System.Collections.Generic;

namespace WebAPI_Token_SQL.Models;

public partial class Alumno
{
    public int Id { get; set; }

    public string? Nombres { get; set; }

    public string? Apellidos { get; set; }

    public string? Direccion { get; set; }

    public string? Telefono { get; set; }
}
