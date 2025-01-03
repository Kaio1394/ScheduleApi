using System.ComponentModel.DataAnnotations;

namespace ScheduleApi.Model.Dto.Server
{
    public class ServerCreateDto
    {
        [Required]
        [StringLength(50)]
        public string? TagName { get; set; }
        [Required]
        public string? IPAddress { get; set; }
    }
}
