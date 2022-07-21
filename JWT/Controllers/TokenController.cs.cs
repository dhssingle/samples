using System.Text;
using System.Security.Cryptography;
using System;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Linq;

namespace JWT.Controllers
{
    [ApiController]
    public class TokenController : ControllerBase
    {
        [HttpGet]
        [Route("[controller]")]
        public IActionResult Get()
        {
            var secret = "v8x/A?D(G+KbPeShVmYq3t6w9z$B&E)H@McQfTjWnZr4u7x!A%D*F-JaNdRgUkXp";
            var key = Encoding.UTF8.GetBytes(secret);
            var secretKey = new SymmetricSecurityKey(key);
            if(secretKey.Key.SequenceEqual(key))
            {
                var x = 1;
            }
            var issuer = "https://localhost:5001";
            var audience = "https://localhost:5001";

            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenDescriptor = new SecurityTokenDescriptor()
            {
                Subject = new ClaimsIdentity(new Claim[]{
                    new Claim(ClaimTypes.NameIdentifier,"1"),
                    new Claim(ClaimTypes.Name,"test")
                }),
                Expires = DateTime.UtcNow.AddSeconds(20),
                Issuer = issuer,
                Audience = audience,
                SigningCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return Ok(tokenHandler.WriteToken(token));
        }
    }
}
