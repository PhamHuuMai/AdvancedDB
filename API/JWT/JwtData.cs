using System.Collections.Generic;

namespace Jwt
{
    /// <summary>
    /// Represents a JSON Web Token.
    /// </summary>
    public class JwtData
    {
        public byte[] KeyBytes { get; set; }
        public string Key { get; set; }
        public object Payload { get; set; }
        public JwtHashAlgorithm Algorithm { get; set; } = JwtHashAlgorithm.HS256;
        public bool Serialized { get; set; }
        public IDictionary<string, object> ExtraHeaders { get; set; }
    }
}
