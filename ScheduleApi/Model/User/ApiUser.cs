using Microsoft.AspNetCore.Identity;

namespace ScheduleApi.Model.User
{
    public class ApiUser: IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
