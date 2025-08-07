using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ymyp67CvBusiness.Abstract;
using Ymyp67CvEntity.Dtos.Experince;
using Ymyp67CvEntity.Dtos.Language;
using Ymyp67CvEntity.Dtos.PersonalInfo;

namespace Ymyp67CvWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonalInfosController : ControllerBase
    {
        private readonly IPersonalInfoService _personalInfoService;

        public PersonalInfosController(IPersonalInfoService personalInfoService)
        {
            _personalInfoService = personalInfoService;
        }
        [HttpPost]

        public async Task<IActionResult> Create(PersonalInfoCreateRequestDto dto)
        {
            if (dto == null)
            {
                return BadRequest("Geçersiz veri");
            }

            var result = await _personalInfoService.AddAsync(dto);
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            return Ok(result.Data);

        }

        [HttpPut]
        public async Task<IActionResult> Update(PersonalInfoUpdateRequestDto dto)
        {
            if (dto == null)
            {
                return BadRequest("Geçersiz veri");
            }

            var result = await _personalInfoService.UpdateAsync(dto);
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }

            return Ok(result.Message);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var result = await _personalInfoService.RemoveAsync(id);
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }

            return Ok(result.Message);
        }
        [HttpGet]

        public async Task<IActionResult> GetAll()
        {
            var result = await _personalInfoService.GetAllAsync();
            if (!result.Success)
            {
                return NotFound(result.Message);
            }
            return Ok(result.Data);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var result = await _personalInfoService.GetByIdAsync(id);
            if (!result.Success)
            {
                return BadRequest(result.Message);

            }
            return Ok(result.Data);
        }
    }
}
