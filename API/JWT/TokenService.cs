using API.Models;
using Jwt;
using System;

namespace API.JWT
{
    public class TokenService
    {
        public String createToken(TokenData data)
        {
            try
            {
                return JsonWebToken.Encode(data, API.Utils.Constant.SIGNATURE, JwtHashAlgorithm.HS256);
            }
            catch
            {
                throw new Exception("Create token fail !");
            }
        }
        public TokenData verifyToken(String token)
        {
            try
            {
                return JsonWebToken.DecodeToObject<TokenData>(token, API.Utils.Constant.SIGNATURE);
            }
            catch(Exception e )
            {
                throw new SignatureVerificationException("Token invalid");
            }
        }

    }
}