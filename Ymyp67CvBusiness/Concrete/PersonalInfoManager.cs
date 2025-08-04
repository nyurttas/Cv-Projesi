using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Core.UnitOfWorks;
using Core.Utilities.Results;
using Microsoft.EntityFrameworkCore;
using Ymyp67CvBusiness.Abstract;
using Ymyp67CvBusiness.Constants;
using Ymyp67CvDataAccess.Abstract;
using Ymyp67CvEntity.Concrete;
using Ymyp67CvEntity.Dtos.PersonalInfo;

namespace Ymyp67CvBusiness.Concrete
{
    public class PersonalInfoManager : IPersonalInfoService
    {

        private readonly IPersonalInfoRepository _personalInfoRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public PersonalInfoManager(IPersonalInfoRepository personalInfoRepository, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _personalInfoRepository = personalInfoRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }


        public async Task<IDataResult<PersonalInfoResponseDto>> AddAsync(PersonalInfoCreateRequestDto dto)
        {
            try
            {
                var personalInfo = _mapper.Map<PersonalInfo>(dto);
                await _personalInfoRepository.AddAsync(personalInfo);
                await _unitOfWork.CommitAsync();
                var response = _mapper.Map<PersonalInfoResponseDto>(personalInfo);
                return new SuccessDataResult<PersonalInfoResponseDto>(response, ResultMessages.SuccessCreated);
            }
            catch (Exception e)
            {
                return new ErrorDataResult<PersonalInfoResponseDto>(e.Message);
            }
        }

        public async Task<IResult> UpdateAsync(PersonalInfoUpdateRequestDto dto)
        {
            try
            {
                var personalInfo = _mapper.Map<PersonalInfo>(dto);
                personalInfo.UpdatedAt = DateTime.Now;
                _personalInfoRepository.Update(personalInfo);
                await _unitOfWork.CommitAsync();
                return new SuccessResult(ResultMessages.SuccessUpdated);
            }
            catch (Exception e)
            {
                return new ErrorResult(e.Message);
            }
        }

        public async Task<IResult> RemoveAsync(Guid id)
        {
            try
            {
                var personalInfo = await _personalInfoRepository.GetAsync(p => p.Id == id);
                if (personalInfo == null)
                {
                    return new ErrorResult(ResultMessages.ErrorGet);
                }
                personalInfo.UpdatedAt = DateTime.Now;
                personalInfo.IsDeleted = true;
                personalInfo.IsActive = false;
                _personalInfoRepository.Update(personalInfo);
                await _unitOfWork.CommitAsync();
                return new SuccessResult(ResultMessages.SuccessDeleted);
            }
            catch (Exception e)
            {
                return new ErrorResult(e.Message);
            }
        }

        public async Task<IDataResult<PersonalInfoResponseDto>> GetByIdAsync(Guid id)
        {
            try
            {
                var personalInfo = await _personalInfoRepository.GetAsync(p => p.Id == id);
                if (personalInfo == null)
                {
                    return new ErrorDataResult<PersonalInfoResponseDto>(ResultMessages.ErrorGet);
                }

                var response = _mapper.Map<PersonalInfoResponseDto>(personalInfo);
                return new SuccessDataResult<PersonalInfoResponseDto>(response, ResultMessages.SuccessGet);
            }
            catch (Exception e)
            {
                return new ErrorDataResult<PersonalInfoResponseDto>(e.Message);
            }
        }

        public async Task<IDataResult<IEnumerable<PersonalInfoResponseDto>>> GetAllAsync()
        {
            try
            {
                var personalInfos = await _personalInfoRepository.GetAll(p => !p.IsDeleted).ToListAsync();
                if (personalInfos == null)
                {
                    return new ErrorDataResult<IEnumerable<PersonalInfoResponseDto>>(ResultMessages.ErrorListed);
                }

                var response = _mapper.Map<IEnumerable<PersonalInfoResponseDto>>(personalInfos);
                return new SuccessDataResult<IEnumerable<PersonalInfoResponseDto>>(response, ResultMessages.SuccessListed);
            }
            catch (Exception e)
            {
                return new ErrorDataResult<IEnumerable<PersonalInfoResponseDto>>(e.Message);
            }
        }
    }
}
