# MicroBlog

## Project Description

MicroBlog is an ASP.NET Core Razor Pages web application that allows users to create and view blog posts. This project demonstrates how to use application configuration and the Options pattern to control website settings.

## Features

* Display a list of blog posts.
* Create new blog posts.
* View individual post details.
* Configure the website name through `appsettings.json`.
* Enable or disable the comment form using configuration settings.
* Use dependency injection and the Options pattern to access application settings.

## Technologies Used

* C#
* ASP.NET Core Razor Pages
* .NET 10
* HTML and CSS
* JSON configuration files
* Visual Studio

## Configuration

The application uses `appsettings.json` to define the default website settings.

Example:

```json
"SiteOptions": {
  "SiteName": "My Micro Blog",
  "EnableComments": false
}
```

The `SiteOptions` class contains two properties:

* `SiteName`: Sets the name displayed on the website.
* `EnableComments`: Determines whether the comment form is displayed on the Details page.

The application registers these settings using the ASP.NET Core Options pattern and dependency injection.

### Development Settings

The `appsettings.Development.json` file can override the default comment setting during development.

Example:

```json
{
  "SiteOptions": {
    "EnableComments": true
  }
}
```

When the application runs in the Development environment, the comment form is displayed because `EnableComments` is set to `true`. When the setting is `false`, the form is hidden.

## How to Run the Application

1. Clone or download the repository.
2. Open `MicroBlog.csproj` in Visual Studio.
3. Restore the NuGet packages if prompted.
4. Make sure the configuration files contain valid JSON.
5. Build the project.
6. Run the application using Visual Studio.
7. Create a blog post and open its Details page to test the comment form.

## Project Structure

* `Pages/Index.cshtml` — Displays all blog posts.
* `Pages/Create.cshtml` — Provides the form for creating a post.
* `Pages/Details.cshtml` — Displays an individual post and conditionally displays the comment form.
* `Models/` — Contains the application's model classes, including `SiteOptions`.
* `appsettings.json` — Contains default application settings.
* `appsettings.Development.json` — Contains development-specific configuration overrides.
* `Program.cs` — Configures services, dependency injection, and the application pipeline.

## What I Learned

Through this project, I practiced working with ASP.NET Core configuration files, creating a strongly typed options class, registering services with dependency injection, and using configuration settings to control what appears on a Razor Page.

I also gained experience organizing a web application and documenting its features and setup instructions.

## Screenshots
<img width="624" height="125" alt="image" src="https://github.com/user-attachments/assets/44343272-d39d-4144-abb3-acac84743e66" />
<img width="627" height="242" alt="image" src="https://github.com/user-attachments/assets/acbc4363-e495-40b0-97dd-bf648a738698" />
<img width="627" height="260" alt="image" src="https://github.com/user-attachments/assets/6732e19c-edca-4879-9a8c-673b54a94aa0" />
<img width="1386" height="491" alt="image" src="https://github.com/user-attachments/assets/c009c91b-7dfb-4b04-af76-7884abbf5b70" />



* Blog posts page
* Create post page
* Details page with comments enabled
* Details page with comments disabled


