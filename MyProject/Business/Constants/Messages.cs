using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid= "Ürün İsmi Geçersiz";
        public static string MaintenanceTime="Sistem Bakımda";
        public static string ProductsListed="Ürünler Listelendi";
        public static string ProductCountOfCategoryError="Bir Kategoride en fazla 10 ürün girebilirsin.";
        public static string ProductNameAlreadyExists="Bu isimde zaten başka bir ürün var.";
        public static string CategoryLimitExceded="Kategori limiti aşıldığı için yeni ürün eklenemiyor.";
        public static string? AuthorizationDenied="Yetkiniz Yok";
        internal static string? AccessTokenCreated= "Erişim Jetonu Oluşturuldu";
        internal static string? UserAlreadyExists= "Kullanıcı Zaten Mevcut";
        internal static string? SuccessfulLogin = "Başarılı Giriş";
        internal static string? PasswordError = "Hatalı Şifre";
        internal static string? UserNotFound = "Kullanıcı Bulunamadı";
        internal static string? UserRegistered = "Kullanıcı Kayıtlı";
    }
}
