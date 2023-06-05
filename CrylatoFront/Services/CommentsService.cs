using Comments.Data.Dtos;
using Comments.Data.Responses;
using Newtonsoft.Json;
using System.Text;

namespace CrylatoFront.Services
{
    public class CommentsService
    {
        public HttpClient _httpClient;

        public CommentsService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<BaseResponse<IEnumerable<CompleteCommentDto>>> GetAllComplete()
        {
            var url = _httpClient.BaseAddress;

            var response = await _httpClient.GetAsync($"{url}/Comment/GetAllComplete");
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<BaseResponse<IEnumerable<CompleteCommentDto>>>(json);
        }

        public async Task Insert(CommentDto commentDto)
        {
            var url = _httpClient.BaseAddress;
            var json = JsonConvert.SerializeObject(commentDto);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            await _httpClient.PostAsync($"{url}/Comment", content);
        }

        public async Task DeleteCommentById(Guid commentId)
        {
            var url = _httpClient.BaseAddress;
            var response = await _httpClient.DeleteAsync($"{url}/Comment?id={commentId}");
            response.EnsureSuccessStatusCode();
        }
    }
}
