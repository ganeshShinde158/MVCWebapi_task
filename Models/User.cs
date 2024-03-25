using System;
using System.Collections.Generic;

namespace MVCWebapi_task.Models;

public partial class User
{
    public int UserId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? City { get; set; }

    public int? Age { get; set; }

    public DateTime? DateOfJoining { get; set; }

    public string? Department { get; set; }
}
