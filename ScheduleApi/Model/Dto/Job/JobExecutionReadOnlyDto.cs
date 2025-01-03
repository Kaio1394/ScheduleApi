namespace ScheduleApi.Model.Dto.Job
{
    public class JobExecutionReadOnlyDto
    {
        public string Name { get; set; } = null!;

        public Guid GuidJob { get; set; }

        public int ServerId { get; set; }

        public DateOnly? DataExec { get; set; }

        public string? Description { get; set; }

        public int Priority { get; set; }
    }
}
