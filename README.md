# Blazor.Bootstrap.Modal
Bootstrap 4 modal dialog for Asp.NET Blazor

[![Build Status](https://berserkerdotnet.visualstudio.com/Blazor.Bootstrap.Modal/_apis/build/status/BerserkerDotNet.Blazor.Bootstrap.Modal?branchName=master)](https://berserkerdotnet.visualstudio.com/Blazor.Bootstrap.Modal/_build/latest?definitionId=6&branchName=master)

## Prerequisites

Bootstrap 4, usually included with default Blazor template.

## Setup

1. Install BlazorBootstrap.Modal from NuGet by PowerShell:
    ```powershell
    Install-Package BlazorBootstrap.Modal
    ```
    or via `dotnet` CLI
    ```cmd
    dotnet add package BlazorBootstrap.Modal
    ```
1. Register services in `Startup.cs`
    ```csharp
    services.AddBootstrapModal();
    ```
1. Add modal to layout `MainLayout.razor` file
    ```html
    <BootstrapModal />
    ```
## Usage

1. Create modal dialog, for example `SimpleModal.razor`:
    ```html
    <p>Simple bootstrap 4 modal.</p>
    <span>Parameter: @SampleParameter</span>

    @code{
        [Parameter] string SampleParameter { get; set; }
    }
    ```
1. Inject modal service into your class
    ```csharp
    @inject IModal Modal
    ```
1. Invoke modal:
    ```csharp
        Modal.Show<SimpleModal>("Simple modal", ModalParameter.Get("SampleParameter", "This is a parameter"))
    ```
    where the first parameter is title of the modal window and second is a list of parameters to pass to the modal class.

    For more example refer to the `BlazorBootstrap.Modal.Samples` project.