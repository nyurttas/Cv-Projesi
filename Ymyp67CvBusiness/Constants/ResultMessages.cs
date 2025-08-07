using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ymyp67CvBusiness.Constants
{
    public static class ResultMessages
    {
        public static string SuccessAboutCreated => "Hakkımda bilgisi başarıyla eklendi.";
        public static string SuccessAboutUpdated => "Hakkımda bilgisi başarıyla güncellendi.";
        public static string SuccessAboutDeleted => "Hakkımda bilgisi başarıyla silindi.";
        public static string SuccessAboutListed => "Hakkımda bilgisi başarıyla listelendi.";
        public static string SuccessAboutGet => "Hakkımda bilgisi başarıyla getirildi.";


        public static string ErrorAboutCreated => "Hakkımda bilgisi  eklenemedi.";
        public static string ErrorAboutUpdated => "Hakkımda bilgisi  güncellenemedi.";
        public static string ErrorAboutDeleted => "Hakkımda bilgisi silinemedi.";
        public static string ErrorAboutListed => "Hakkımda bilgisi listelenemedi.";
        public static string ErrorAboutGet => "Hakkımda bilgisi getirilemedi.";


        public static string SuccessCreated => "Bilgi başarıyla eklendi.";
        public static string SuccessUpdated => "Bilgi başarıyla güncellendi.";
        public static string SuccessDeleted => "Bilgi başarıyla silindi.";
        public static string SuccessListed => "Bilgiler başarıyla listelendi.";
        public static string SuccessGet => "Bilgi başarıyla getirildi.";


        public static string ErrorCreated => "Bilgi eklenemedi.";
        public static string ErrorUpdated => "Bilgi güncellenemedi.";
        public static string ErrorDeleted => "Bilgi silinemedi.";
        public static string ErrorListed => "Bilgiler listelenemedi.";
        public static string ErrorGet => "Bilgi getirilemedi.";

        public static string IsTrue = "Evet";
        public static string IsFalse = "Hayır";



    }
}
