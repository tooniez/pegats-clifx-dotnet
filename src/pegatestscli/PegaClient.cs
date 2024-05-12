
// The PegaCli class is the command that retrieves test results from PegaUnit tests.
using System.Net.Http.Headers;
using CliFx;
using CliFx.Attributes;
using CliFx.Infrastructure;

namespace PegaUnitTestsCli
{
    [Command]

    public class PegaClient : ICommand
    {
        // Create a new HttpClient instance
        private static readonly HttpClient client = new HttpClient();

        // Define the command parameters
        [CommandParameter(0, Description = "The Test Suite ID to retrieve results from.", IsRequired = true)]
        public string? TestId { get; set; }

        [CommandParameter(1, Description = "Your Pega Access Token", IsRequired = true)]
        public string? AccessToken { get; set; }

        // The ExecuteAsync method is called when the command is executed
        public async ValueTask ExecuteAsync(IConsole console)
        {
            // Build the URL to retrieve test results

            // string baseUrl = Environment.GetEnvironmentVariable("BASE_URL");
            string baseUrl = "http://example.com/prweb/api/v1/pegaunits/"; // Use the environment variable in production
            string apiUrl = $"{baseUrl}execute/{TestId}/results";

            // Set header options
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AccessToken);

            try
            {
                // Make the HTTP request
                HttpResponseMessage response = await client.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    // Retrieve the response body
                    string responseBody = await response.Content.ReadAsStringAsync();
                    console.Output.WriteLine(responseBody);
                }
                else
                {
                    // Handle the error
                    console.Error.WriteLine($"Failed to retrieve test results. Status code: {response.StatusCode}");
                }
            }
            // Handle HTTP request exceptions
            catch (HttpRequestException ex)
            {
                console.Error.WriteLine($"An error occurred while making the HTTP request: {ex.Message}");
            }
            // Handle general exceptions
            catch (Exception ex)
            {
                console.Error.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }
    }
}