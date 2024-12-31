using System;
using System.Collections.Generic;

namespace ScheduleApi.Data;

public partial class JobHistoryModified
{
    public int Id { get; set; }

    public string NameJob { get; set; } = null!;

    public Guid GuidJob { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime LastUpdated { get; set; }
}
