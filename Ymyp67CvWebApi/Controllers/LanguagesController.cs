using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ymyp67CvBusiness.Abstract;
using Ymyp67CvEntity.Dtos.Experince;
using Ymyp67CvEntity.Dtos.Language;

namespace Ymyp67CvWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguagesController : ControllerBase
    {
        private readonly ILanguageService _languageService;

        public LanguagesController(ILanguageService languageService)
        {
            _languageService = languageService;
        }

        [HttpPost]
        public async Task<IActionResult> Create(LanguageCreateRequestDto dto)
        {
            if (dto == null)
            {
                return BadRequest("Geçersiz veri");
            }

            var result = await _languageService.AddAsync(dto);
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            return Ok(result.Data);

        }

        [HttpPut]
        public async Task<IActionResult> Update(LanguageUpdateRequestDto dto)
        {
            if (dto == null)
            {
                return BadRequest("Geçersiz veri");
            }

            var result = await _languageService.UpdateAsync(dto);
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }

            return Ok(result.Message);
        }

        [HttpDelete ("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var result = await _languageService.RemoveAsync(id);
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }

            return Ok(result.Message);
        }

        [HttpGet]

        public async Task<IActionResult> GetAll()
        {
            var result = await _languageService.GetAllAsync();
            if (!result.Success)
            {
                return NotFound(result.Message);
            }
            return Ok(result.Data);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var result = await _languageService.GetByIdAsync(id);
            if (!result.Success)
            {
                return BadRequest(result.Message);

            }
            return Ok(result.Data);
        }

        [HttpGet("[action]/{level}")]
        public async Task<IActionResult> GetByGreaterLevel(byte level)
        {
            var result = await _languageService.GetLanguagesGraterLevelAsync(level);
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            return Ok(result.Data);
        }
    }
}
