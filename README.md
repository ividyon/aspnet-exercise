# ASP.NET Core API exercise project

An exercise project with an expected delivery time of ~8h which is intended to demonstrate my capabilities in a
professional setting involving the ASP.NET Core API and fundamental GitHub CI/CD understanding.

## Task summary (machine translated)

### 1. Development environment & project structure
- Framework: .NET 10 (ASP.NET Core Web API).
- Language: C#.
- IDE: Visual Studio (Code) or JetBrains Rider.

### 2. Functionality (API)
- Implementation of a REST endpoint GET /timestamp.
- The endpoint returns the current server date as a JSON object.

### 3. Quality assurance
- Creation of a unit test project within the solution.
- Implementation of an automated test that checks the validity of the endpoint's return value.
 
### 4. Versioning (Git)
- Initialization of a local Git repository.
- Deployment of the code in a public repository on GitHub (Free Tier).
- The development steps should be traceable based on the commit history.

### 5. Automation (CI/CD)
- Set up a GitHub Action.
- Configure the pipeline: Each time there is a push to the repository, the code should be automatically checked out, built, and tested (test execution).
- Success criterion: The pipeline completes successfully (green) if the code is error-free.

## My observations

- Work started at ~3:20 PM and concluded at ~5:10 PM, so ~2h total.
- No AI was used during execution (with the exception of Rider's line auto-complete feature)
- Most of the server functionality was already provided by the default ASP.NET Core Web API template.
- It looks quite simple and pleasant to spin up an API with this framework!
- I was already familiar with the unit testing and GitHub Actions steps through my [WitchyBND](https://github.com/ividyon/WitchyBND) project, so I was able to ~~copy-paste~~ learn from my previous work.

### Pain points

- I ran into trouble with NUnit's symbols not being recognized by Rider due to starting the project with a single-folder structure. Putting the server in its own project folder resolved this problem.
- Getting the Actions to run gave me a bit of trouble due to some issues with the handling of the package lock system in regards to specified runtime identifiers. This wasn't actually part of the task, but I decided to look into it here so that I can use the knowledge in my other projects. Specifically, I was blocked by what appears to be [known buggy behavior](https://github.com/NuGet/Home/issues/8287) with NuGet restore locked mode (packages.lock.json) and having multiple runtime identifiers. Bummer!