using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ymyp67CvBusiness.Abstract;
using Ymyp67CvEntity.Dtos.About;
using Ymyp67CvEntity.Dtos.Education;

namespace Ymyp67CvWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EducationsController : ControllerBase
    {
        private readonly IEducationService _educationService;

        public EducationsController(IEducationService educationService)
        {
            _educationService = educationService;
        }
        [HttpPost]
        public async Task<IActionResult> Create(EducationCreateRequestDto dto)
        {
            if (dto == null)
            {
                return BadRequest("Geçersiz veri");
            }

            var result = await _educationService.AddAsync(dto);
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            return Ok(result.Data);
        }

        [HttpPut]
        public async Task<IActionResult> Update(EducationUpdateRequestDto dto)
        {
            if (dto == null)
            {
                return BadRequest("Geçersiz veri");
            }

            var result = await _educationService.UpdateAsync(dto);
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }

            return Ok(result.Message);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var result = await _educationService.RemoveAsync(id);
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            return Ok(result.Message);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _educationService.GetAllAsync();
            if (!result.Success)
            {
                return NotFound(result.Message);
            }
            return Ok(result.Data);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var result = await _educationService.GetByIdAsync(id);
            if (!result.Success)
            {
                return BadRequest(result.Message);

            }
            return Ok(result.Data);
        }

        [HttpGet("[action]/{grade}")]
        public async Task<IActionResult> GetEducationByGrade(string grade)
        {
            var result = await _educationService.GetEducationAsync(grade);
            if (!result.Success)
            {
                return NotFound(result.Message);
            }
            return Ok(result.Data);
        }


        [HttpGet("[action]")]
        public async Task<IActionResult> IsStudent()
        {
            var result = await _educationService.AnyContinueAsync();
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            return Ok(result.Message);
        }
    }
}
