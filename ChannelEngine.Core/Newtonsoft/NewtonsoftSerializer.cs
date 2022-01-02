using System;
using System.Buffers;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Threading.Tasks;
using ChannelEngine.Core.Abstraction.Serialization;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;

namespace ChannelEngine.Core.Newtonsoft
{
    public class NewtonSerializer : ISerializer
    {
        private readonly NewtonsoftSerializerOptions _options;

        public NewtonSerializer(IOptions<NewtonsoftSerializerOptions> options)
        {
            _options = options.Value;
        }

        public string Format => "Json";

        public string Serialize(object obj)
        {
            return JsonConvert.SerializeObject(obj, _options.JsonSerializerSettings);
        }

        public T Deserialize<T>(string input)
        {
            return JsonConvert.DeserializeObject<T>(input, _options.JsonSerializerSettings);
        }

        public async Task<string> SerializeAsync(object obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }

            return await Task.Factory.StartNew(() =>
                JsonConvert.SerializeObject(obj, _options.JsonSerializerSettings));
        }

        public async Task<T> DeserializeAsync<T>(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return default;
            }

            return await Task.Factory.StartNew(() =>
                JsonConvert.DeserializeObject<T>(input, _options.JsonSerializerSettings));
        }
    }
}
