using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ymyp67CvBusiness.Abstract;
using Ymyp67CvEntity.Dtos.Interest;

namespace Ymyp67CvWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InterestsController : ControllerBase
    {
        private readonly IInterestService _interestService;

        public InterestsController(IInterestService interestService)
        {
            _interestService = interestService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _interestService.GetAllAsync();
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            return Ok(result.Data);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var result = await _interestService.GetByIdAsync(id);
            if (!result.Success)
            {
                return NotFound(result.Message);
            }
            return Ok(result.Data);
        }

        [HttpPost]
        public async Task<IActionResult> Create(InterestCreateRequestDto dto)
        {
            if (dto == null)
            {
                return BadRequest("Geçersiz veri");
            }

            var result = await _interestService.AddAsync(dto);
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            return Ok(result.Data);
        }

        [HttpPut]
        public async Task<IActionResult> Update(InterestUpdateRequestDto dto)
        {
            if (dto == null)
            {
                return BadRequest("Geçersiz veri");
            }

            var result = await _interestService.UpdateAsync(dto);
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }

            return Ok(result.Message);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var result = await _interestService.RemoveAsync(id);
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }

            return Ok(result.Message);
        }
    }
}
