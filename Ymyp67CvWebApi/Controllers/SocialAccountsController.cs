using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ymyp67CvBusiness.Abstract;
using Ymyp67CvEntity.Dtos.Interest;
using Ymyp67CvEntity.Dtos.SocialAccount;

namespace Ymyp67CvWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialAccountsController : ControllerBase
    {
        private readonly ISocialAccountService _socialaccountService;

        public SocialAccountsController(ISocialAccountService socialaccountService)
        {
            _socialaccountService = socialaccountService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _socialaccountService.GetAllAsync();
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            return Ok(result.Data);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var result = await _socialaccountService.GetByIdAsync(id);
            if (!result.Success)
            {
                return NotFound(result.Message);
            }
            return Ok(result.Data);
        }

        [HttpPost]
        public async Task<IActionResult> Create(SocialAccountCreateRequestDto dto)
        {
            if (dto == null)
            {
                return BadRequest("Geçersiz veri");
            }

            var result = await _socialaccountService.AddAsync(dto);
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            return Ok(result.Data);
        }

        [HttpPut]
        public async Task<IActionResult> Update(SocialAccountUpdateRequestDto dto)
        {
            if (dto == null)
            {
                return BadRequest("Geçersiz veri");
            }

            var result = await _socialaccountService.UpdateAsync(dto);
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }

            return Ok(result.Message);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var result = await _socialaccountService.RemoveAsync(id);
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }

            return Ok(result.Message);
        }

        [HttpGet("[action]/{paltform}")]
        public async Task<IActionResult> GetBySocialPlatform(string platform)
        {
            var result = await _socialaccountService.GetSocialAccountByNameAsync(platform);
            if (!result.Success)
            {
                return NotFound(result.Message);
            }
            return Ok(result.Data);
        }

        [HttpGet("[action]/{username}")]
        public async Task<IActionResult> GetByUsername(string username)
        {
            var result = await _socialaccountService.GetSocialAccountsByUserNameAsync(username);
            if (!result.Success)
            {
                return NotFound(result.Message);
            }
            return Ok(result.Data);
        }
    }
}
