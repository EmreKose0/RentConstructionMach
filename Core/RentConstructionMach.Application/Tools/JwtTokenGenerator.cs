using Microsoft.IdentityModel.Tokens;
using RentConstructionMach.Application.Dtos;
using RentConstructionMach.Application.Features.Mediator.Queries.AppUserQueries;
using RentConstructionMach.Application.Features.Mediator.Results.AppUserResults;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RentConstructionMach.Application.Tools
{
    public class JwtTokenGenerator
    {
        public static TokenResponseDto GenerateToken (GetCheckAppUserQueryResult result )
        {
            var claims = new List<Claim>();
            if(!string.IsNullOrWhiteSpace(result.Role))
            {
                claims.Add(new Claim(ClaimTypes.Role, result.Role));
                claims.Add(new Claim(ClaimTypes.NameIdentifier, result.Id.ToString()));

            }
            if (!string.IsNullOrWhiteSpace(result.Username))
            {
                claims.Add(new Claim("Username", result.Username));
            }

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JwtTokenDefauls.Key));

            var siginCredentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var expireDate = DateTime.UtcNow.AddDays(JwtTokenDefauls.Expire);

            JwtSecurityToken token = new JwtSecurityToken(
                                     issuer: JwtTokenDefauls.ValidIssuer,
                                     audience: JwtTokenDefauls.ValidAudience,
                                     claims: claims,
                                     notBefore: DateTime.UtcNow,
                                     expires: expireDate,
                                     signingCredentials: siginCredentials);

            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
            return new TokenResponseDto(tokenHandler.WriteToken(token), expireDate);

        }
    }
}
