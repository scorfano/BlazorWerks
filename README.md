# ![Logo](logo-sm.png) BlazorWerks
- [Documentation](https://scorfano.github.io/BlazorWerks/)
- [NuGet Package](https://www.nuget.org/packages/BlazorWerks)
- [Release Notes](https://github.com/scorfano/BlazorWerks/releases)
- [License](LICENSE.md)
- [Stack Overflow](https://stackoverflow.com/questions/tagged/BlazorWerks)


### Introduction
This project is **in development** and is currently used for testing and demonstration only. The package allows .NET code to
interact with standard Twitter Bootstrap HTML components. The advantage is that this provides direct access Bootstrap
components without the need to wrap them in a Blazor component. This provides maximum flexibility, portability, and allows the 
developer to leverage their existing knowledge of Bootstrap. The methods of each component, such as show, hide, and toggle,
are then easily called from .NET code. In addition, all Bootstrap component events are passed to .NET for optional use by 
your Blazor application.  BlazorWerks also includes easy access to client side WebStorage classes 
ILocalStorage and ISessionStorage. These can be used to automatically serialize and deserialize data to the browser
cache on the client side.

### Quick Start

Add the following code to your Blazor Program.cs file:
```C#
using BlazorWerks;
...
builder.Services.AddBlazorWerks();

```
You may then inject the services into any Blazor page or component:

```C#

@using BlazorWerks.Twitter
@using BlazorWerks.WebStorage
@inject IBootstrap bootstrap
@inject ILocalStorage localStorage
@inject ISessionStorage sessionStorage

```

*more to come...*