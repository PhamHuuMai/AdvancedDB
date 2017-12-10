using System.Collections.Generic;

namespace Jwt
{
    /// <summary>
    /// Builder for <see cref="JwtData"/> objects.
    /// </summary>
    public class JwtBuilder
    {
        private readonly JwtData _data = new JwtData();

        public JwtBuilder WithPayload(object payload)
        {
            _data.Payload = payload;
            return this;
        }

        public JwtBuilder IsSerialized()
        {
            _data.Serialized = true;
            return this;
        }

        public JwtBuilder WithKey(string key)
        {
            _data.Key = key;
            return this;
        }

        public JwtBuilder WithKey(byte[] keyBytes)
        {
            _data.KeyBytes = keyBytes;
            return this;
        }

        public JwtBuilder WithAlgorithm(JwtHashAlgorithm algorithm)
        {
            _data.Algorithm = algorithm;
            return this;
        }

        public JwtBuilder WithHeader(string key, object value)
        {
            if (_data.ExtraHeaders == null)
            {
                _data.ExtraHeaders = new Dictionary<string, object>();
            }

            _data.ExtraHeaders.Add(key, value);
            return this;
        }

        public JwtBuilder WithHeaders(IDictionary<string, object> dict)
        {
            _data.ExtraHeaders = dict;
            return this;
        }
        public JwtData Build()
        {
            return _data;
        }
    }
}