﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
   public static class Messages //static verdiğinde new' lemene gerek kalmaz
    {
        public static string ProductAdded = "Ürün eklendi.";

        public static string ProductNameInvalid = "Ürün ismi geçersizdir.";

        public static string MaintenanceTime="Sistem bakımdadır";

        public static string ProductListed="Ürünler Listelendi.";

        public static string ProductCountOfCategoryError = "";
    }
}
