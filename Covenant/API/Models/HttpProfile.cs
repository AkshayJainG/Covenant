// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Covenant.API.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class HttpProfile
    {
        /// <summary>
        /// Initializes a new instance of the HttpProfile class.
        /// </summary>
        public HttpProfile()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the HttpProfile class.
        /// </summary>
        /// <param name="type">Possible values include: 'HTTP'</param>
        public HttpProfile(IList<string> httpUrls = default(IList<string>), string httpMessageTransform = default(string), IList<HttpProfileHeader> httpRequestHeaders = default(IList<HttpProfileHeader>), IList<HttpProfileHeader> httpResponseHeaders = default(IList<HttpProfileHeader>), string httpPostRequest = default(string), string httpGetResponse = default(string), string httpPostResponse = default(string), int? id = default(int?), string name = default(string), string description = default(string), ProfileType? type = default(ProfileType?))
        {
            HttpUrls = httpUrls;
            HttpMessageTransform = httpMessageTransform;
            HttpRequestHeaders = httpRequestHeaders;
            HttpResponseHeaders = httpResponseHeaders;
            HttpPostRequest = httpPostRequest;
            HttpGetResponse = httpGetResponse;
            HttpPostResponse = httpPostResponse;
            Id = id;
            Name = name;
            Description = description;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "httpUrls")]
        public IList<string> HttpUrls { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "httpMessageTransform")]
        public string HttpMessageTransform { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "httpRequestHeaders")]
        public IList<HttpProfileHeader> HttpRequestHeaders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "httpResponseHeaders")]
        public IList<HttpProfileHeader> HttpResponseHeaders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "httpPostRequest")]
        public string HttpPostRequest { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "httpGetResponse")]
        public string HttpGetResponse { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "httpPostResponse")]
        public string HttpPostResponse { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'HTTP'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public ProfileType? Type { get; set; }

    }
}
