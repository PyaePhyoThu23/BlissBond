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

namespace BlissBond.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public RequestsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Requests
        public async Task<IActionResult> GetRequests()
        {
            var requests = await _unitOfWork.Requests.GetAll();
            return Ok(requests);
        }

        // GET: api/Requests/5
        [HttpGet("{id}")]
       public async Task<IActionResult> GetRequest(int id)
        {
            var request = await _unitOfWork.Requests.Get(q => q.Id == id);
            if (request == null)
            {
                return NotFound();
            }
            return Ok(request);
        }

        // PUT: api/Requests/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRequest(int id, Request request)
        {
            if (id != request.Id)
            {
                return BadRequest();
            }
            _unitOfWork.Requests.Update(request);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch(DbUpdateConcurrencyException)
            {
                if (!await RequestExists(id))
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

        // POST: api/Requests
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Request>> PostRequest(Request request)
        {
         await _unitOfWork.Requests.Insert(request);
         await _unitOfWork.Save(HttpContext);

        return CreatedAtAction("GetRequest", new { id = request.Id }, request);
        }

        // DELETE: api/Requests/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRequest(int id)
        {
           var request = await _unitOfWork.Requests.Get(q =>q.Id == id);
            if (request == null) 
            { 
                return NotFound();
            }

            await _unitOfWork.Requests.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> RequestExists(int id) 
        {
            var request = await _unitOfWork.Requests.Get(q => q.Id == id);
            return request != null;
        }
    }
}
