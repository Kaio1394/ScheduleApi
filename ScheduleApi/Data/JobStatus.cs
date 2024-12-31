using System;
using System.Collections.Generic;

namespace ScheduleApi.Data;

public partial class JobStatus
{
    public int Id { get; set; }

    public Guid GuidJob { get; set; }

    public int Status { get; set; }
}
