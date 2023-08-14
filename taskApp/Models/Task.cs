using System;
using System.Collections.Generic;

namespace taskApp.Models;

public partial class Task
{
    public int TaskId { get; set; }

    public int? UserId { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public DateTime? CreationDate { get; set; }

    public virtual User? User { get; set; }
}
