using Newtonsoft.Json;
using Phrases.Data.Dtos;
using Phrases.Data.Responses;

namespace CrylatoFront.Services
{
    public class PhrasesService
    {
        public HttpClient _httpClient; 

        public PhrasesService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<BaseResponse<IEnumerable<CompletePhraseDto>>> GetAllComplete()
        {
            var url = _httpClient.BaseAddress;

            var response = await _httpClient.GetAsync($"{url}/Phrase/GetAllComplete");
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<BaseResponse<IEnumerable<CompletePhraseDto>>>(json);
        }

        public async Task DeletePhraseById(Guid phraseId)
        {
            var url = _httpClient.BaseAddress;
            var response = await _httpClient.DeleteAsync($"{url}/Phrase?id={phraseId}");
            response.EnsureSuccessStatusCode();
        }

        public async Task UpdateLikesById(Guid phraseId)
        {
            var url = _httpClient.BaseAddress;
            var response = await _httpClient.PutAsync($"{url}/Phrase/UpdateLikesById?id={phraseId}", null);
            response.EnsureSuccessStatusCode();
        }
    }
}
