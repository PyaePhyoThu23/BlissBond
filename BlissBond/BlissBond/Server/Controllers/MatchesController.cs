using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BlissBond.Server.Data;
using BlissBond.Shared.Domain;
using BlissBond.Server.IRepository;
using System.Reflection.Metadata.Ecma335;

namespace BlissBond.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatchesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public MatchesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Matches
        [HttpGet]
        public async Task<ActionResult> GetMatches()
        {
            var matches = await _unitOfWork.Matches.GetAll();
            return Ok(matches);

        }

        // GET: api/Matches/5
        [HttpGet("{id}")]
        public async Task<ActionResult> GetMatch(int id)
        {
            var match = await _unitOfWork.Matches.Get(q => q.Id == id);
            if(match == null)
            {
                return NotFound();
            }
            return Ok(match);
        }

        // PUT: api/Matches/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMatch(int id, Match match)
        {
            if (id != match.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Matches.Update(match);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await MatchExists(id))
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

        // POST: api/Matches
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Match>> PostMatch(Match match)
        {
            await _unitOfWork.Matches.Insert(match);
            await _unitOfWork.Save(HttpContext);
            return CreatedAtAction("GetMatch", new { id = match.Id }, match);
        }

        // DELETE: api/Matches/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMatch(int id)
        {
           var match = await _unitOfWork.Matches.Get(q=>q.Id == id);
            if (match == null)
            {
                return NotFound();
            }
            await _unitOfWork.Matches.Delete(id);
            await _unitOfWork.Save(HttpContext);
            return NoContent();
        }

        private async Task<bool> MatchExists(int id)
        {
            var match = await _unitOfWork.Matches.Get(q=>q.Id==id);
            return match != null;
        }
    }
}
