﻿using System;
using System.Collections.Generic;

namespace ScheduleApi.Data
{
    public partial class JobExecution
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public Guid GuidJob { get; set; }

        public int ServerId { get; set; }

        public DateOnly? DataExec { get; set; }

        public string? Description { get; set; }

        public string? Script { get; set; }

        public int Priority { get; set; }

        public string? Tag { get; set; }

        public int? Timeout { get; set; }

        // Propriedade de navegação
        public virtual Server Server { get; set; } = null!;
    }
}
