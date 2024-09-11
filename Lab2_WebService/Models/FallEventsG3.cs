using System;
using System.Collections.Generic;

namespace Lab2_WebService.Models;

public partial class FallEventsG3
{
    public int Id { get; set; }

    public string DeviceId { get; set; } = null!;

    public double Acceleration { get; set; }

    public string Location { get; set; } = null!;

    public DateTime Timestamp { get; set; }
}
