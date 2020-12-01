# Introduction 

This project includes models and APIs for communicating with the Voicify Analytics APIs at https://analytics.voicify.com/swagger

# Getting Started

You can install this package from NuGet:

```
Install-Package Voicify.Sdk.Analytics
```

Then you can pull in the namespace:

```csharp
using Voicify.Sdk.Analytics.Api
```

Each service has its own API class to use in order to make requests against it. These are also typed against `interfaces` so you can optionally inject them or mock them during testing.


## Making Requests

To make requests, create an instance of the API you need, then call the appropriate method.

Voicify Partners and Customers can also check out the extended documentation and details at https://support.voicify.com

# Contributing

The Voicify core development team owns this repo and NuGet package, but all Voicify developers are welcome to contribute changes. Before contributing, please create an issue that you can track your PRs against and be sure there is not already a PR open for it.

# Build and Test

There are some steps to autogenerate the C# Clients and APIs from the swagger API models that Voicify outputs.

## Generate Api Clients from Swagger

First, make sure you get the latest version of `Voicify.Sdk.Core.Models` NuGet.

Then, get the latest APIs by generating from the latest models and https://analytics.voicify.com/swagger:

Sample:

```
java -jar swagger-codegen-cli.jar generate -i http://analytics.voicify.com/swagger/v1/swagger.json -l csharp -c ../csharp-options.json -Dapis -DsupportingFiles -DmodelTests=false -o ../../src/Voicify.Sdk.Analytics/Voicify.Sdk.Analytics/Generated
```


## Generate Tests from Swagger


```
java -jar swagger-codegen-cli.jar generate -i http://analytics.voicify.com/swagger/v1/swagger.json -l csharp -c ../csharp-options.json -DapiTests=true -o ../../src/Voicify.Sdk.Analytics/Voicify.Sdk.Analytics.Tests/Generated
```

Delete any duplicated stuff that is created in the test project

Then find and replace the expected models namespace everywhere.

Find: using Voicify.Sdk.Analytics.Model;
Replace with: using Voicify.Sdk.Core.Models.Model;

Then do any other replacements or fixes required in order to fix the build

Also be wary of generated tests overriding any that are explicitly setup. You may need to pull the accepted tests that are enabled out of the `Generated` folder.

Also, the generator will generate extra .csproj and .sln files. Be sure to delete those before pushing changes.