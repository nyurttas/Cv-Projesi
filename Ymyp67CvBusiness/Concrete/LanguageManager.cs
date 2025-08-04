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
using Ymyp67CvEntity.Dtos.Language;

namespace Ymyp67CvBusiness.Concrete
{
    public class LanguageManager : ILanguageService
    {

        private readonly ILanguageRepository _languageRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public LanguageManager(ILanguageRepository languageRepository, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _languageRepository = languageRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }
        public async Task<IDataResult<LanguageResponseDto>> AddAsync(LanguageCreateRequestDto dto)
        {
            try
            {
                var language = _mapper.Map<Language>(dto);
                await _languageRepository.AddAsync(language);
                await _unitOfWork.CommitAsync();
                var response = _mapper.Map<LanguageResponseDto>(language);
                return new SuccessDataResult<LanguageResponseDto>(response, ResultMessages.SuccessCreated);
            }
            catch (Exception e)
            {
                return new ErrorDataResult<LanguageResponseDto>(e.Message);
            }
        }

        public async Task<IResult> UpdateAsync(LanguageUpdateRequestDto dto)
        {
            try
            {
                var language = _mapper.Map<Language>(dto);
                language.UpdatedAt = DateTime.Now;
                _languageRepository.Update(language);
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
                var language = await _languageRepository.GetAsync(l => l.Id == id);
                if (language == null)
                {
                    return new ErrorResult(ResultMessages.ErrorGet);
                }
                language.UpdatedAt = DateTime.Now;
                language.IsDeleted = true;
                language.IsActive = false;
                _languageRepository.Update(language);
                await _unitOfWork.CommitAsync();
                return new SuccessResult(ResultMessages.SuccessDeleted);
            }
            catch (Exception e)
            {
                return new ErrorResult(e.Message);
            }
        }

        public async Task<IDataResult<LanguageResponseDto>> GetByIdAsync(Guid id)
        {
            try
            {
                var language = await _languageRepository.GetAsync(l => l.Id == id);
                if (language == null)
                {
                    return new ErrorDataResult<LanguageResponseDto>(ResultMessages.ErrorGet);
                }

                var response = _mapper.Map<LanguageResponseDto>(language);
                return new SuccessDataResult<LanguageResponseDto>(response, ResultMessages.SuccessGet);
            }
            catch (Exception e)
            {
                return new ErrorDataResult<LanguageResponseDto>(e.Message);
            }
        }

        public async Task<IDataResult<IEnumerable<LanguageResponseDto>>> GetAllAsync()
        {
            try
            {
                var languages = await _languageRepository.GetAll(l => !l.IsDeleted).ToListAsync();
                if (languages == null)
                {
                    return new ErrorDataResult<IEnumerable<LanguageResponseDto>>(ResultMessages.ErrorListed);
                }

                var response = _mapper.Map<IEnumerable<LanguageResponseDto>>(languages);
                return new SuccessDataResult<IEnumerable<LanguageResponseDto>>(response, ResultMessages.SuccessListed);
            }
            catch (Exception e)
            {
                return new ErrorDataResult<IEnumerable<LanguageResponseDto>>(e.Message);
            }
        }

        public async Task<IDataResult<IEnumerable<LanguageResponseDto>>> GetLanguagesGraterLevelAsync(byte level)
        {
            try
            {
                var languages = await _languageRepository.GetAll(l => !l.IsDeleted && l.Level >= level).ToListAsync();
                if (languages is null)
                {
                    return new ErrorDataResult<IEnumerable<LanguageResponseDto>>(ResultMessages.ErrorListed);
                }

                var response = _mapper.Map<IEnumerable<LanguageResponseDto>>(languages);
                return new SuccessDataResult<IEnumerable<LanguageResponseDto>>(response, ResultMessages.SuccessListed);
            }
            catch (Exception e)
            {
                return new ErrorDataResult<IEnumerable<LanguageResponseDto>>(e.Message);
            }
        }
    }
}
