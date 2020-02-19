using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kassandra.API.Models.Response
{
    /// <summary>
    /// Base Kassandra Response
    /// </summary>
    public class RequestResponse
    {
        /// <summary>
        /// Informative message from request processing
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }
    }

    /// <summary>
    /// Base response from all api requests
    /// </summary>
    public class RequestResponse<TEntity> : RequestResponse where TEntity : class
    {
        /// <summary>
        /// Data result from request processing
        /// </summary>
        [JsonProperty("response")]
        public TEntity Response { get; set; }
    }
}
