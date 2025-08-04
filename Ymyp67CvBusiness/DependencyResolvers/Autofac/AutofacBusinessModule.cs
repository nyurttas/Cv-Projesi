using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Core.UnitOfWorks;
using Ymyp67CvBusiness.Concrete;
using Ymyp67CvDataAccess.Abstract;
using Ymyp67CvDataAccess.Concrete;
using Ymyp67CvDataAccess.UnitOfWork;
using Ymyp67CvProject.DataAccess.Abstract;

namespace Ymyp67CvBusiness.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<EfAboutRepository>().As<IAboutRepository>();
            builder.RegisterType<AboutManager>().As<IAboutRepository>();

            builder.RegisterType<EfCertificateRepository>().As<ICertificateRepository>();
            builder.RegisterType<CertificateManager>().As<ICertificateRepository>();

            builder.RegisterType<EfContactRepository>().As<IContactRepository>();
            builder.RegisterType<ContactManager>().As<IContactRepository>();

            builder.RegisterType<EfEducationRepository>().As<IEducationRepository>();
            builder.RegisterType<EducationManager>().As<IEducationRepository>();

            builder.RegisterType<EfExperienceRepository>().As<IExperienceRepository>();
            builder.RegisterType<ExperienceManager>().As<IExperienceRepository>();

            builder.RegisterType<EfInterestRepository>().As<IInterestRepository>();
            builder.RegisterType<InterestManager>().As<IInterestRepository>();

            builder.RegisterType<EfLanguageRepository>().As<ILanguageRepository>();
            builder.RegisterType<LanguageManager>().As<ILanguageRepository>();

            builder.RegisterType<EfPersonalInfoRepository>().As<IPersonalInfoRepository>();
            builder.RegisterType<PersonalInfoManager>().As<IPersonalInfoRepository>();

            builder.RegisterType<EfSkillRepository>().As<ISkillRepository>();
            builder.RegisterType<SkillManager>().As<ISkillRepository>();

            builder.RegisterType<EfSocialAccountRepository>().As<ISocialAccountRepository>();
            builder.RegisterType<SocialAccountManager>().As<ISocialAccountRepository>();

            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();
        }
    }
}
