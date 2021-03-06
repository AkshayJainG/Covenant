﻿// Author: Ryan Cobb (@cobbr_io)
// Project: Covenant (https://github.com/cobbr/Covenant)
// License: GNU GPLv3

using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;

using Covenant.Hubs;
using Covenant.Core;
using Covenant.Models;
using Covenant.Models.Grunts;
using Covenant.Models.Covenant;

namespace Covenant.Controllers
{
    [Authorize(Policy = "RequireJwtBearer")]
    [ApiController]
    [Route("api/implanttemplates")]
    public class ImplantTemplateApiController : Controller
    {
        private readonly CovenantContext _context;

        public ImplantTemplateApiController(CovenantContext context)
        {
            _context = context;
        }

        // GET: api/implanttemplates
        // <summary>
        // Get a list of ImplantTemplates
        // </summary>
        [HttpGet(Name = "GetImplantTemplates")]
        public ActionResult<IEnumerable<ImplantTemplate>> GetImplantTemplates()
        {
            return _context.ImplantTemplates;
        }

        // GET api/implanttemplates/{id}
        // <summary>
        // Get a ImplantTemplate by id
        // </summary>
        [HttpGet("{id:int}", Name = "GetImplantTemplate")]
        public async Task<ActionResult<ImplantTemplate>> GetImplantTemplate(int id)
        {
            try
            {
                return await _context.GetImplantTemplate(id);
            }
            catch (ControllerNotFoundException e)
            {
                return NotFound(e.Message);
            }
            catch (ControllerBadRequestException e)
            {
                return BadRequest(e.Message);
            }
        }

        // GET: api/implanttemplates/{name}
        // <summary>
        // Get a ImplantTemplate by Name
        // </summary>
        [HttpGet("{name}", Name = "GetImplantTemplateByName")]
        public async Task<ActionResult<ImplantTemplate>> GetImplantTemplateByName(string name)
        {
            try
            {
                return await _context.GetImplantTemplateByName(name);
            }
            catch (ControllerNotFoundException e)
            {
                return NotFound(e.Message);
            }
            catch (ControllerBadRequestException e)
            {
                return BadRequest(e.Message);
            }
        }

        // GET api/implanttemplates/grunt/{id}
        // <summary>
        // Get an ImplantTemplate for a Grunt
        // </summary>
        [HttpGet("grunt/{id}", Name = "GetImplantTemplateForGrunt")]
        public async Task<ActionResult<ImplantTemplate>> GetImplantTemplateForGrunt(int id)
        {
            try
            {
                return await _context.GetImplantTemplateForGrunt(await _context.GetGrunt(id));
            }
            catch (ControllerNotFoundException e)
            {
                return NotFound(e.Message);
            }
            catch (ControllerBadRequestException e)
            {
                return BadRequest(e.Message);
            }
        }

        // POST api/implanttemplates
        // <summary>
        // Create an ImplantTemplate
        // </summary>
        [HttpPost(Name = "CreateImplantTemplate")]
        [ProducesResponseType(typeof(ImplantTemplate), 201)]
        public async Task<ActionResult<ImplantTemplate>> CreateImplantTemplate([FromBody]ImplantTemplate template)
        {
            try
            {
                ImplantTemplate createdTemplate = await _context.CreateImplantTemplate(template);
                return CreatedAtRoute(nameof(GetImplantTemplate), new { id = createdTemplate.Id }, createdTemplate);
            }
            catch (ControllerNotFoundException e)
            {
                return NotFound(e.Message);
            }
            catch (ControllerBadRequestException e)
            {
                return BadRequest(e.Message);
            }
        }

        // PUT api/implanttemplates
        // <summary>
        // Edit an ImplantTemplate
        // </summary>
        [HttpPut(Name = "EditImplantTemplate")]
        public async Task<ActionResult<ImplantTemplate>> EditImplantTemplate([FromBody] ImplantTemplate template)
        {
            try
            {
                return await _context.EditImplantTemplate(template);
            }
            catch (ControllerNotFoundException e)
            {
                return NotFound(e.Message);
            }
            catch (ControllerBadRequestException e)
            {
                return BadRequest(e.Message);
            }
        }

        // DELETE api/implanttemplates/{id}
        // <summary>
        // Delete an ImplantTemplate
        // </summary>
        [HttpDelete("{id}", Name = "DeleteImplantTemplate")]
        [ProducesResponseType(204)]
        public async Task<ActionResult> DeleteImplantTemplate(int id)
        {
            try
            {
                await _context.DeleteImplantTemplate(id);
                return new NoContentResult();
            }
            catch (ControllerNotFoundException e)
            {
                return NotFound(e.Message);
            }
            catch (ControllerBadRequestException e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
