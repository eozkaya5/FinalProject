using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Encryption
{
   public class SigningCredentialsHelper
    {
        //wep tokenlerın oluşturulabilmesi için anahtar 
        //Giriş bilgilerin
        public static SigningCredentials CreatSigningCredentails(SecurityKey securityKey)
        {
            return new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature);
            //Hangi anahtar hangi algoritma kullanılacak ? sorusunun karşılığı
        }
    }
}
