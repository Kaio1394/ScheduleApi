using System;
using System.Collections.Generic;

namespace ScheduleApi.Data
{
    public partial class Server
    {
        public int Id { get; set; }

        public string TagName { get; set; } = null!;

        public string Ipaddress { get; set; } = null!;

        public virtual ICollection<JobExecution> JobExecutions { get; set; } = new List<JobExecution>();
    }
}
