using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ScheduleApi.Data;

namespace ScheduleApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobExecutionsController : ControllerBase
    {
        private readonly ScheduleApiDbContext _context;

        public JobExecutionsController(ScheduleApiDbContext context)
        {
            _context = context;
        }

        // GET: api/JobExecutions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<JobExecution>>> GetJobExecutions()
        {
            return await _context.JobExecutions.ToListAsync();
        }

        // GET: api/JobExecutions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<JobExecution>> GetJobExecution(int id)
        {
            var jobExecution = await _context.JobExecutions.FindAsync(id);

            if (jobExecution == null)
            {
                return NotFound();
            }

            return jobExecution;
        }

        // PUT: api/JobExecutions/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
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
