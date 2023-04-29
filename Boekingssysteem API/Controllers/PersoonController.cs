using AutoMapper;
using Boekingssysteem.Data;
using Boekingssysteem.Lib;
using Boekingssysteem.Models;
using Boekingssysteem_API.Data.Dto;
using Boekingssysteem_API.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Data;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Boekingssysteem_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]   
    public class PersoonController : ControllerBase
    {
        private readonly IPersoonRepository _persoonRepository;
        private readonly IMapper _mapper;

        public PersoonController(IPersoonRepository persoonRepository, IMapper mapper)
        {
            _persoonRepository = persoonRepository;
            _mapper = mapper;
        }

        [HttpGet("Personen")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Persoon>))]
        public IActionResult GetPersoon()
        {
            try
            {
                var persoon = _mapper.Map<List<PersoonDto>>(_persoonRepository.Getpersoonen());
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);
                return Ok(persoon);
            }
            catch (Exception e)
            {

                Foutenlogboek.FoutLoggen(e);
            }
            return BadRequest();
        }

        [HttpGet("get{id}")]
        [ProducesResponseType(200, Type = typeof(Persoon))]
        [ProducesResponseType(400)]
        public IActionResult GetPersoon(string id) 
        {
            try
            {
                if (!_persoonRepository.PersoonExists(id))
                    return NotFound();

                var persoon = _mapper.Map<Persoon>(_persoonRepository.GetPersoon(id));

                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                return Ok(persoon);
            }
            catch (Exception e)
            {

                Foutenlogboek.FoutLoggen(e);
            }
           return BadRequest();
        }

        [HttpPut("update{id}")]
        [ProducesResponseType(400)]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public IActionResult UpdatePersoon(string id, [FromBody]PersoonDto persoon)
        {
            try
            {
                if (persoon == null)
                    return BadRequest(ModelState);

                if (id != persoon.Personeelnummer)
                    return BadRequest(ModelState);

                if (!_persoonRepository.PersoonExists(id))
                    return NotFound();

                if (!ModelState.IsValid)
                    return BadRequest();

                var persoonAanwezig = _mapper.Map<Persoon>(persoon);
                if (!_persoonRepository.UpdatePersoon(persoonAanwezig))
                {
                    ModelState.AddModelError("", "Something went wrong updating");
                    return StatusCode(500, ModelState);
                }
                return NoContent();
            }
            catch (Exception e)
            {

                return BadRequest();
            }
            
        }
    }
}
