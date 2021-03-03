using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Jwt
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
        // Kullanıcı bilgileri girildikten sonra eğer doğru ise CreateToken çalışacak.
        //İlgili kullanıcı için veritabanına gidecek Claimlerini bulacak,claimlerini buluşturacak JWT üretecek Api'ye verecek.
    }
}
