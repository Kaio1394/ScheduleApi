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
using ScheduleApi.Model.Dto.Server;
using ScheduleApi.Static;

namespace ScheduleApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServersController : ControllerBase
    {
        private readonly ScheduleApiDbContext _context;
        private readonly IMapper _mapper;
        private readonly ILogger<ServersController> _logger;

        public ServersController(ScheduleApiDbContext context, IMapper mapper, ILogger<ServersController> logger)
        {
            _context = context;
            _mapper = mapper;
            _logger = logger;
        }

        // GET: api/Servers
        [HttpGet]
        [Authorize(Roles = $"{ClaimType.ADMIN},{ClaimType.USER_JOB_CREATOR},{ClaimType.USER_EXECUTOR}")]
        public async Task<ActionResult<IEnumerable<ServerReadOnlyDto>>> GetServers()
        {
            try
            {
                var listServers = await _context.Servers.ToListAsync();
                var listServersDto = _mapper.Map<IEnumerable<ServerReadOnlyDto>>(listServers);
                return Ok(listServers);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error performing GET in {nameof(GetServers)}");
                return StatusCode(500, Messages.ERROR_500);
            }
        }

        // GET: api/Servers/5
        [HttpGet("{id}")]
        [Authorize(Roles = $"{ClaimType.ADMIN},{ClaimType.USER_JOB_CREATOR},{ClaimType.USER_EXECUTOR}")]
        public async Task<ActionResult<ServerReadOnlyDto>> GetServer(int id)
        {
            try
            {
                var server = await _context.Servers.FindAsync(id);

                if (server == null)
                {
                    _logger.LogWarning($"Record Not Found: {nameof(GetServer)}");
                    return NotFound();
                }
                var model = _mapper.Map<ServerReadOnlyDto>(server);
                return Ok(model);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error performing GET in {nameof(GetServers)}");
                return StatusCode(500, Messages.ERROR_500);
            }
        }

        // PUT: api/Servers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        [Authorize(Roles = $"{ClaimType.ADMIN},{ClaimType.USER_JOB_CREATOR}")]
        public async Task<IActionResult> PutServer(int id, ServerUpdateDto serverDto)
        {
            if (id != serverDto.Id)
            {
                return BadRequest();
            }
            var server = await _context.Servers.FindAsync(id);

            if (server == null)
            {
                _logger.LogWarning($"Record Not Found: {nameof(PutServer)}");
                return NotFound();
            }
            _mapper.Map(serverDto, server);
            _context.Entry(server).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                if (!ServerExists(id))
                {
                    return NotFound();
                }
                else
                {
                    _logger.LogError(ex.Message);
                    return BadRequest(ex.Message);
                }
            }

            return NoContent();
        }

        // POST: api/Servers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Authorize(Roles = $"{ClaimType.ADMIN},{ClaimType.USER_JOB_CREATOR}")]
        public async Task<ActionResult<ServerCreateDto>> PostServer(ServerCreateDto serverDto)
        {
            try
            {
                var server = _mapper.Map<Server>(serverDto);
                _context.Servers.Add(server);
                await _context.SaveChangesAsync();
                return CreatedAtAction($"{nameof(PostServer)}", new { id = server.Id }, server);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error performing GET in {nameof(PostServer)}");
                return StatusCode(500, Messages.ERROR_500);
            }
        }

        // DELETE: api/Servers/5
        [HttpDelete("{id}")]
        [Authorize(Roles = $"{ClaimType.ADMIN},{ClaimType.USER_JOB_CREATOR}")]
        public async Task<IActionResult> DeleteServer(int id)
        {
            try
            {
                var server = await _context.Servers.FindAsync(id);
                if (server == null)
                {
                    return NotFound();
                }

                _context.Servers.Remove(server);
                await _context.SaveChangesAsync();

                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error performing GET in {nameof(DeleteServer)}");
                return StatusCode(500, Messages.ERROR_500);
            }
        }

        private bool ServerExists(int id)
        {
            return _context.Servers.Any(e => e.Id == id);
        }
    }
}
