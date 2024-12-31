using System;
using System.Collections.Generic;

namespace ScheduleApi.Data;

public partial class JobHistoryExecution
{
    public int Id { get; set; }

    public string NameJob { get; set; } = null!;

    public Guid GuidJob { get; set; }

    public DateTime LastExecution { get; set; }

    public string ErrorMessage { get; set; } = null!;

    public int StatusEnd { get; set; }
}
