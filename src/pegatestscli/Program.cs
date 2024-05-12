// Purpose: Entry point of the application. It is the main class that will be executed when the application is run.
using CliFx;


namespace PegaUnitTestsCli
{
    class Program
    {
        // The Main method is the entry point of the application.
        public static async Task<int> Main() => await new CliApplicationBuilder()
            .SetDescription("A simple CliFx dotnet command line tool to retrieve test results from the Pega Unit Tests endpoint.")
            .SetVersion("0.0.1-alpha")
            .AddCommand<PegaClient>()
            .Build()
            .RunAsync();

    }

}
