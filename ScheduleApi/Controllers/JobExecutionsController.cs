using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ScheduleApi.Data;
using ScheduleApi.Model.Dto.Job;
using ScheduleApi.Static;

namespace ScheduleApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobExecutionsController : ControllerBase
    {
        private readonly ScheduleApiDbContext _context;
        private readonly IMapper _mapper;
        private readonly ILogger<JobExecutionsController> _logger;

        public JobExecutionsController(ScheduleApiDbContext context, IMapper mapper, ILogger<JobExecutionsController> logger)
        {
            _context = context;
            _mapper = mapper;
            _logger = logger;
        }

        // GET: api/JobExecutions
        [HttpGet]
        [Authorize(Roles = $"{ClaimType.ADMIN},{ClaimType.USER_JOB_CREATOR},{ClaimType.USER_EXECUTOR}")]
        public async Task<ActionResult<IEnumerable<JobExecutionReadOnlyDto>>> GetJobExecutions()
        {
            try
            {
                var listJobs = await _context.JobExecutions.ToListAsync();
                var listJobsDto = _mapper.Map< IEnumerable<JobExecutionReadOnlyDto>>(listJobs);
                return Ok(listJobsDto);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error performing GET in {nameof(GetJobExecutions)}");
                return StatusCode(500, Messages.ERROR_500);
            }
        }

        // GET: api/JobExecutions/5
        [HttpGet("{id}")]
        [Authorize(Roles = $"{ClaimType.ADMIN},{ClaimType.USER_JOB_CREATOR},{ClaimType.USER_EXECUTOR}")]
        public async Task<ActionResult<JobExecutionReadOnlyDto>> GetJobExecution(int id)
        {
            try
            {
                var jobExecution = await _context.JobExecutions.FindAsync(id);

                if (jobExecution == null)
                {
                    _logger.LogWarning($"Record Not Found: {nameof(GetJobExecution)}");
                    return NotFound();
                }
                var model = _mapper.Map<JobExecutionReadOnlyDto>(jobExecution);
                return Ok(model);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error performing GET in {nameof(GetJobExecutions)}");
                return StatusCode(500, Messages.ERROR_500);
            }
        }

        // PUT: api/JobExecutions/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        [Authorize(Roles = $"{ClaimType.ADMIN},{ClaimType.USER_JOB_CREATOR}")]
        public async Task<IActionResult> PutJobExecution(int id, JobExecution jobExecution)
        {
            if (id != jobExecution.Id)
            {
                return BadRequest();
            }

            _context.Entry(jobExecution).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JobExecutionExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/JobExecutions
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Authorize(Roles = $"{ClaimType.ADMIN},{ClaimType.USER_JOB_CREATOR}")]
        public async Task<ActionResult<JobExecution>> PostJobExecution(JobExecution jobExecution)
        {
            _context.JobExecutions.Add(jobExecution);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (JobExecutionExists(jobExecution.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetJobExecution", new { id = jobExecution.Id }, jobExecution);
        }

        // DELETE: api/JobExecutions/5
        [HttpDelete("{id}")]
        [Authorize(Roles = $"{ClaimType.ADMIN},{ClaimType.USER_JOB_CREATOR}")]
        public async Task<IActionResult> DeleteJobExecution(int id)
        {
            var jobExecution = await _context.JobExecutions.FindAsync(id);
            if (jobExecution == null)
            {
                return NotFound();
            }

            _context.JobExecutions.Remove(jobExecution);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool JobExecutionExists(int id)
        {
            return _context.JobExecutions.Any(e => e.Id == id);
        }
    }
}
