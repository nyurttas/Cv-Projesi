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
using Ymyp67CvEntity.Dtos.Certificate;

namespace Ymyp67CvBusiness.Concrete
{


    public class CertificateManager : ICertificateService
    {
        private readonly ICertificateRepository _certificateRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public CertificateManager(ICertificateRepository certificateRepository, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _certificateRepository = certificateRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }
        public async Task<IDataResult<CertificateResponseDto>> AddAsync(CertificateCreateRequestDto dto)
        {
            try
            {
                var certificate = _mapper.Map<Certificate>(dto);
                await _certificateRepository.AddAsync(certificate);
                await _unitOfWork.CommitAsync();
                var response = _mapper.Map<CertificateResponseDto>(certificate);
                return new SuccessDataResult<CertificateResponseDto>(response, ResultMessages.SuccessCreated);
            }
            catch (Exception e)
            {
                return new ErrorDataResult<CertificateResponseDto>(e.Message);
            }
        }

        public async Task<IDataResult<IEnumerable<CertificateResponseDto>>> GetAllAsync()
        {
            try
            {
                var certificates = await _certificateRepository.GetAll(c=> !c.IsDeleted).ToListAsync();
                if (certificates == null)
                {
                    return new ErrorDataResult<IEnumerable<CertificateResponseDto>>(ResultMessages.ErrorListed);
                }
                var dtos = _mapper.Map<IEnumerable<CertificateResponseDto>>(certificates);
                return new SuccessDataResult<IEnumerable<CertificateResponseDto>>(dtos, ResultMessages.SuccessListed);

            }
            catch (Exception e)
            {

            return new ErrorDataResult<IEnumerable<CertificateResponseDto>>(e.Message);
            }
           
        }

        public async Task<IDataResult<CertificateResponseDto>> GetByIdAsync(Guid id)
        {
            try
            {
                var certificate = await _certificateRepository.GetAsync(c => c.Id == id);
                if (certificate == null)
                {
                    return new ErrorDataResult<CertificateResponseDto>(ResultMessages.ErrorGet);
                }

                var response = _mapper.Map<CertificateResponseDto>(certificate);
                return new SuccessDataResult<CertificateResponseDto>(response, ResultMessages.SuccessGet);
            }
            catch (Exception e)
            {
                return new ErrorDataResult<CertificateResponseDto>(ResultMessages.ErrorGet);
            }
        }

        public async Task<IDataResult<IEnumerable<CertificateResponseDto>>> GetCertificatesByOrganisationAsync(string organisation)
        {
            try
            {
            var certificates = await _certificateRepository
                .GetAll(c => !c.IsDeleted && c.Organisation == organisation )
                .ToListAsync();
                if (certificates == null )
                {
                    return new ErrorDataResult<IEnumerable<CertificateResponseDto>>(ResultMessages.ErrorListed);
                }
                var dtos = _mapper.Map<IEnumerable<CertificateResponseDto>>(certificates);
                return new SuccessDataResult<IEnumerable<CertificateResponseDto>>(dtos, ResultMessages.SuccessListed);
            }
            catch (Exception e)
            {

               return new ErrorDataResult<IEnumerable<CertificateResponseDto>>(e.Message + " " + ResultMessages.ErrorListed);
            }
        }

        public async Task<IResult> RemoveAsync(Guid id)
        {
            try
            {
                var certificate = await _certificateRepository.GetAsync(x => x.Id == id);
                if (certificate == null)
                {
                    return new ErrorResult(ResultMessages.ErrorGet);

                }
                certificate.UpdatedAt = DateTime.Now;
                certificate.IsDeleted = true;
                certificate.IsActive = false;
                _certificateRepository.Update(certificate);
                await _unitOfWork.CommitAsync();
                return new SuccessResult(ResultMessages.SuccessDeleted);
            }
            catch (Exception)
            {

               return new ErrorResult(ResultMessages.ErrorDeleted);
            }
        }

        public async Task<IResult> UpdateAsync(CertificateUpdateRequestDto dto)
        {
            try
            {
                var certificate = _mapper.Map<Certificate>(dto);
                certificate.UpdatedAt = DateTime.Now;
                _certificateRepository.Update(certificate);
                await _unitOfWork.CommitAsync();
                return new SuccessResult(ResultMessages.SuccessUpdated);

            }
            catch (Exception e)
            {

               return new ErrorResult(e.Message + " "+ ResultMessages.ErrorUpdated);
            }
        }
    }
}
