using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Jwt
{
    //Anlamsızz karakterlerden oluşan erişim anahtarıdır.
    public class AccessToken //Erişim anahtarı
    {
        public string Token { get; set; }
        public DateTime Expiration  { get; set; } //Bitiş tarihi
    }
}
