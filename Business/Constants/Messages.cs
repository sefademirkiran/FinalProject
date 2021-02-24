using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi ";
        public static string ProductNameInvalid = "Ürün ismi geçersiz.. ";
        public static string MaintenanceTime ="Sistem Bakımda";
        public static string ProductListed ="Ürünler Listelendi";
        public static string ProductCountOfCategoryError="Maksimum 10 Adet ürün girilebilir. ";
        public static string ProductNameAlreadyExists="Bu isimde zaten başka bir ürün var.";
        public static string CategoryLimitExceded="Kategori limiti aşıldı. ";
    }
}
