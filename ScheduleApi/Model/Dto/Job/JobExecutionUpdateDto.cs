using System.ComponentModel.DataAnnotations;

namespace ScheduleApi.Model.Dto.Job
{
    public class JobExecutionUpdateDto: DtoBase
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; } = null!;
        [Required]
        public Guid GuidJob { get; set; }
        public int ServerId { get; set; }
        [Required]
        public DateOnly? DataExec { get; set; }
        [Required]
        [StringLength(255)]
        public string? Description { get; set; }
        [Required]
        public string? Script { get; set; }
        [Required]
        public int Priority { get; set; }
        [Required]
        public string? Tag { get; set; }
        [Required]
        public int? Timeout { get; set; }
    }
}
