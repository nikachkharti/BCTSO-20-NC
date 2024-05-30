using Newtonsoft.Json;
using System.Text;
using Todo.Web.Interfaces;
using Todo.Web.Models;

namespace Todo.Web.Services
{
    public class BaseService : IBaseService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public BaseService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<ApiResponse> SendAsync(ApiRequest request)
        {
            try
            {
                HttpClient client = _httpClientFactory.CreateClient("TodoAPI");
                HttpRequestMessage message = new();
                message.Headers.Add("Accept", "application/json");
                //token

                message.RequestUri = new Uri(request.Url);
                if (request.Data != null)
                {
                    message.Content = new StringContent(JsonConvert.SerializeObject(request.Data), Encoding.UTF8, "application/json");
                }

                HttpResponseMessage apiResponse = new();

                switch (request.ApiType)
                {
                    case ApiType.POST:
                        message.Method = HttpMethod.Post;
                        break;
                    case ApiType.PATCH:
                        message.Method = HttpMethod.Patch;
                        break;
                    case ApiType.PUT:
                        message.Method = HttpMethod.Put;
                        break;
                    case ApiType.DELETE:
                        break;
                    default:
                        message.Method = HttpMethod.Get;
                        break;
                }

                apiResponse = await client.SendAsync(message);

                switch (apiResponse.StatusCode)
                {
                    case System.Net.HttpStatusCode.NotFound:
                        return new ApiResponse() { IsSuccess = false, Message = "Not Found" };
                    case System.Net.HttpStatusCode.Forbidden:
                        return new ApiResponse() { IsSuccess = false, Message = "Access denied" };
                    case System.Net.HttpStatusCode.BadRequest:
                        return new ApiResponse() { IsSuccess = false, Message = "Invalid parameter passed" };
                    case System.Net.HttpStatusCode.Unauthorized:
                        return new ApiResponse() { IsSuccess = false, Message = "Unauthorized" };
                    case System.Net.HttpStatusCode.InternalServerError:
                        return new ApiResponse() { IsSuccess = false, Message = "Internal server error" };
                    default:
                        var apiContent = await apiResponse.Content.ReadAsStringAsync();
                        var result = JsonConvert.DeserializeObject<ApiResponse>(apiContent);
                        return result;
                }

            }
            catch (Exception ex)
            {
                ApiResponse result = new()
                {
                    Message = ex.Message,
                    IsSuccess = false
                };

                return result;
            }
        }
    }
}
