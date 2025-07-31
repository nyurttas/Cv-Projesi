using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Ymyp67CvEntity.Concrete;
using Ymyp67CvEntity.Dtos.About;
using Ymyp67CvEntity.Dtos.Certificate;
using Ymyp67CvEntity.Dtos.Contact;
using Ymyp67CvEntity.Dtos.Education;
using Ymyp67CvEntity.Dtos.Experince;
using Ymyp67CvEntity.Dtos.Interest;
using Ymyp67CvEntity.Dtos.Language;
using Ymyp67CvEntity.Dtos.PersonalInfo;
using Ymyp67CvEntity.Dtos.Skill;
using Ymyp67CvEntity.Dtos.SocialAccount;

namespace Ymyp67CvBusiness.Mappers.AutoMapper
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<About, AboutResponseDto>();
            CreateMap<About, AboutDetailResponseDto>();
            CreateMap<AboutCreateRequestDto, About>();
            CreateMap<AboutUpdateRequestDto, About>();

            CreateMap<Certificate, CertificateResponseDto>();
            CreateMap<Certificate, CertificateDetailResponseDto>();
            CreateMap<CertificateCreateRequestDto, Certificate>();
            CreateMap<CertificateUpdateRequestDto, Certificate>();

            CreateMap<Contact, ContactResponseDto>();
            CreateMap<ContactCreateRequestDto, Contact>();
            CreateMap<ContactUpdateRequestDto, Contact>();
            CreateMap<Contact, ContactDetailResponseDto>();

            CreateMap<Education, EducationResponseDto>();
            CreateMap<Education, EducationDetailResponseDto>();
            CreateMap<EducationCreateRequestDto, Education>();
            CreateMap<EducationUpdateRequestDto, Education>();

            CreateMap<Experience, ExperienceResponseDto>();
            CreateMap<Experience, ExperienceDetailResponseDto>();
            CreateMap<ExperienceCreateRequestDto, Experience>();
            CreateMap<ExperienceUpdateRequestDto, Experience>();

            CreateMap<Interest, InterestResponseDto>();
            CreateMap<Interest, InterestDetailResponseDto>();
            CreateMap<InterestCreateRequestDto, Interest>();
            CreateMap<InterestUpdateRequestDto, Interest>();

            CreateMap<Language, LanguageResponseDto>();
            CreateMap<Language, LanguageDetailResponseDto>();
            CreateMap<LanguageCreateRequestDto, Language>();
            CreateMap<LanguageUpdateRequestDto, Language>();

            CreateMap<PersonalInfo, PersonalInfoResponseDto>();
            CreateMap<PersonalInfo, PersonalInfoDetailResponseDto>();
            CreateMap<PersonalInfoCreateRequestDto, PersonalInfo>();
            CreateMap<PersonalInfoUpdateRequestDto, PersonalInfo>();

            CreateMap<Skill, SkillResponseDto>();
            CreateMap<Skill, SkillDetailResponseDto>();
            CreateMap<SkillCreateRequestDto, Skill>();
            CreateMap<SkillUpdateRequestDto, Skill>();

            CreateMap<SocialAccount, SocialAccountResponseDto>();
            CreateMap<SocialAccount, SocialAccountDetailResponseDto>();
            CreateMap<SocialAccountCreateRequestDto, SocialAccount>();
            CreateMap<SocialAccountUpdateRequestDto, SocialAccount>();
        }
    }

    
}
    