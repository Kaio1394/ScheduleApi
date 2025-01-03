using System.ComponentModel.DataAnnotations;

namespace ScheduleApi.Model.Dto.Server
{
    public class ServerReadOnlyDto
    {
        [Required]
        [StringLength(50)]
        public string TagName { get; set; } = null!;
        [Required]
        public int ServerId { get; set; }
        [Required]
        public string Ipaddress { get; set; } = null!;
    }
}
