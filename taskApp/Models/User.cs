﻿using System;
using System.Collections.Generic;

namespace taskApp.Models;

public partial class User
{
    public int UserId { get; set; }

    public string? Name { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }

    public DateTime? RegisterDate { get; set; }

    public virtual ICollection<Task> Tasks { get; set; } = new List<Task>();
}
