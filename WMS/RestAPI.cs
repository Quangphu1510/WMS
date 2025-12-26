using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace WMS
{
    public class FleetApiClient : IDisposable
    {
        private readonly HttpClient _httpClient;

        public FleetApiClient(string baseUrl, string token)
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(baseUrl),
                Timeout = TimeSpan.FromSeconds(10)
            };

            _httpClient.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", token);

            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        // ================================
        // Create Task / Mission
        // ================================
        public async Task<CreateTaskResponse> CreateTaskAsync(CreateTaskRequest request)
        {
            var json = JsonConvert.SerializeObject(request); 
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("/api/v1/tasks", content);
            response.EnsureSuccessStatusCode();

            var body = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<CreateTaskResponse>(body);
        }

        // ================================
        // Get Robot Status
        // ================================
        public async Task<RobotStatus> GetRobotStatusAsync(string robotId)
        {
            var response = await _httpClient.GetAsync($"/api/v1/robots/{robotId}/status");
            response.EnsureSuccessStatusCode();

            var body = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<RobotStatus>(body);
        }

        // ================================
        // Cancel Task
        // ================================
        public async Task<bool> CancelTaskAsync(string taskId)
        {
            var response = await _httpClient.DeleteAsync($"/api/v1/tasks/{taskId}");
            return response.IsSuccessStatusCode;
        }

        public void Dispose()
        {
            _httpClient?.Dispose();
        }
    }
    public class CreateTaskRequest
    {
        public string Mission { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        public int Priority { get; set; }
        public string Payload { get; set; }
    }

    public class CreateTaskResponse
    {
        public string TaskId { get; set; }
        public string Status { get; set; }
    }

    public class RobotStatus
    {
        public string RobotId { get; set; }
        public string State { get; set; }      // IDLE, MOVING, ERROR...
        public int Battery { get; set; }
        public string CurrentTaskId { get; set; }
    }
}
