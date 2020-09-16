using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MicroServiceWithDocker.Models;
using MicroServiceWithDocker.Repository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MicroServiceWithDocker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManageStickyNotesController : ControllerBase
    {
        private IManageStickyNotesRepository _manageStickyNotesRepository;

        public ManageStickyNotesController(IManageStickyNotesRepository manageStickyNotesRepository)
        {
            _manageStickyNotesRepository = manageStickyNotesRepository;
        }
        // GET: api/<ManageStickyNotesController>
        [HttpPost]
        [Route("GetStickyNotes")]
        public async Task<IActionResult> GetStickyNotes()
        {
            var ListData = await _manageStickyNotesRepository.GetManageStickNotes();
            return Ok(new { IsSuccess = true, StickyNotesList = ListData });
        }

        // GET api/<ManageStickyNotesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ManageStickyNotesController>
        
        [HttpPost]
        [Route("SaveStickyNotes")]
        public async Task<IActionResult> Post()
        {
            Boolean result = false;
            var Title = Request.Form["Title"];
            var Description = Request.Form["Description"];
            var ColorName = Request.Form["ColorName"];
            ManageStickNotes manageStickNotes = new ManageStickNotes()
            {
                ColorName = ColorName,
                Title = Title,
                Description = Description,
                Active = true,
                CreateDate = DateTime.UtcNow,
                IsDeleted = false,
                ModifiedDate = DateTime.UtcNow
            };
            _manageStickyNotesRepository.InsertManageStickNotes(manageStickNotes);

            return Ok(new { IsSuccess = true, Message = "Note saved successfully." });
        }

        // PUT api/<ManageStickyNotesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ManageStickyNotesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
