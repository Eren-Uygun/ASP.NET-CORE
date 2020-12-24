using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using JwtAuthenticationApiDemo.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace JwtAuthenticationApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private IConfiguration _configuration;
        public AuthController(IConfiguration configuration)
        {
            _configuration = configuration;
        } 

        private UserModel AuthenticateUser(UserModel login)
        {
            UserModel user = null;

            if (login.UserName=="test" && login.Password=="123")
            {
                user = new UserModel{UserName = "test",Password = "123"};
            }

            return user;
        }

        
        private string GenerateJSONWebToken(UserModel userinfo)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"])); //Jwt key Appsettings.Json dosyasının içine yazıldı.
            var credentials = new SigningCredentials(securityKey,SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, userinfo.UserName),
            };

            var token = new JwtSecurityToken(
                
                issuer:_configuration["Jwt:Issuer"],audience:_configuration["Jwt:Issuer"],claims,expires:DateTime.Now.AddMinutes(60),
                signingCredentials:credentials);

            var encodetoken = new JwtSecurityTokenHandler().WriteToken(token);
            return encodetoken;
        }

        [AllowAnonymous]
        [HttpPost("Login")]
        public IActionResult Login(string username,string pass)
        {
            UserModel login = new UserModel();
            login.UserName = username;
            login.Password = pass;
            IActionResult response = Unauthorized();

            var user = AuthenticateUser(login);

            if (user!=null)
            {
                var tokenstring = GenerateJSONWebToken(user);
                response = Ok(new {token = tokenstring});
            }

            return response;

        }


        [Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)] 
        [HttpPost("Post")]
        public string Post()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;
            IList<Claim> claim = identity.Claims.ToList();
            var userName = claim[0].Value; //Generate token metodunun içinde oluşturduğumuz claim'e erişir.
            return "Welcome To: " + userName;
        }






    }
}
