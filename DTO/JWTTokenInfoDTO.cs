using System;

namespace TaskList.DTO
{
    public class JWTTokenInfoDTO
    {

        public string AccessToken { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}
