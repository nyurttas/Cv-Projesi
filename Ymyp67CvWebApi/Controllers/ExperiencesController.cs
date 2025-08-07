using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ymyp67CvBusiness.Abstract;
using Ymyp67CvEntity.Dtos.Education;
using Ymyp67CvEntity.Dtos.Experince;

namespace Ymyp67CvWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExperiencesController : ControllerBase
    {
        private readonly IExperienceService _experienceService;

        public ExperiencesController(IExperienceService experienceService)
        {
            _experienceService = experienceService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _experienceService.GetAllAsync();
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            return Ok(result.Data);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var result = await _experienceService.GetByIdAsync(id);
            if (!result.Success)
            {
                return NotFound(result.Message);
            }
            return Ok(result.Data);
        }

        [HttpGet("[action]/{company}")]
        public async Task<IActionResult> GetExperiencesByCompany(string company)
        {
            var result = await _experienceService.GetExperiencesByCompanyAsync(company);
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            return Ok(result.Data);
        }


        [HttpPost]
        public async Task<IActionResult> Create(ExperienceCreateRequestDto dto)
        {
            if (dto == null)
            {
                return BadRequest("Geçersiz veri");
            }

            var result = await _experienceService.AddAsync(dto);
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            return Ok(result.Data);

        }

        [HttpPut]
        public async Task<IActionResult> Update(ExperienceUpdateRequestDto dto)
        {
            if (dto == null)
            {
                return BadRequest("Geçersiz veri");
            }

            var result = await _experienceService.UpdateAsync(dto);
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }

            return Ok(result.Message);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var result = await _experienceService.RemoveAsync(id);
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }

            return Ok(result.Message);
        }
    }
}
