using AutoMapper;
using ScheduleApi.Data;
using ScheduleApi.Model.Dto.Job;
using ScheduleApi.Model.Dto.Server;
using ScheduleApi.Model.Dto.User;
using ScheduleApi.Model.User;

namespace ScheduleApi.Configurations
{
    public class MapperConfig: Profile
    {
        public MapperConfig()
        {
            CreateMap<ApiUser, UserDto>().ReverseMap();

            #region JobExecution
            CreateMap<JobExecution, JobExecutionReadOnlyDto>().ReverseMap();
            CreateMap<JobExecution, JobExecutionUpdateDto>().ReverseMap();
            CreateMap<JobExecutionReadOnlyDto, JobExecution>().ReverseMap();
            #endregion

            #region Server
            CreateMap<Server, ServerReadOnlyDto>().ReverseMap();
            CreateMap<Server, ServerUpdateDto>().ReverseMap();
            CreateMap<Server, ServerCreateDto>().ReverseMap();
            #endregion

        }
    }
}
