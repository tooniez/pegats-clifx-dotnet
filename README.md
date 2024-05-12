# Pega Unit Test Results Retriever CliFx

## Description

A simple CliFx dotnet command line tool to retrieve test reports from a test suite ID from the Pega Unit Tests endpoint.

## Usage

To use the Pega Unit Test Retriever CLI, follow these steps:

1. Open a command prompt or terminal.
2. Clone repository.
3. Run the program using the following command:

```shell
➜  scripts/run.sh
Missing required parameter(s):
<testid> <accesstoken>

pegatestscli 0.0.1-alpha
  A simple CLI tool to retrieve PegaUnit tests results.

USAGE
  dotnet pegatestscli.dll <testid> <accesstoken> [options]

PARAMETERS
* testid            The Test Suite ID to retrieve results from.
* accesstoken       Your Pega Access Token

OPTIONS
  -h|--help         Shows help text.
  --version         Shows version information.
```

> Replace `<TestID>` with the ID of the test you want to retrieve results for, and `<Access Token>` with your Pega access token.

4. The program will make an HTTP request to retrieve the test results from the Pega Unit Test API.
5. If the request is successful, the program will display the test results in the console.
6. If the request fails, an error message will be displayed indicating the reason for the failure.

## References

- [https://academy.pega.com/topic/integration-pega-unit-tests-cicd/v1](https://academy.pega.com/topic/integration-pega-unit-tests-cicd/v1)

##  License

📝 Copyright © 2024 [tooniez](https://github.com/tooniez). <br />
This project is [MIT](https://github.com/tooniez/vuejs-typescript-cypress/blob/main/LICENSE) licensed.
