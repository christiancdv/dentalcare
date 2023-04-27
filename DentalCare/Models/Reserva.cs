using System;
using System.Collections.Generic;

namespace DentalCare.Models;

public partial class Reserva
{
    public int Id { get; set; }

    public DateTime Fecha { get; set; }

    public string Especialidad { get; set; } = null!;

    public string Especialista { get; set; } = null!;
}
