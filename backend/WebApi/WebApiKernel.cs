using LanguageForge.Api.Entities;
using LanguageForge.WebApi.Services;
using MongoDB.Bson;

namespace LanguageForge.WebApi;

public static class WebApiKernel
{
    public static void Setup(IServiceCollection services)
    {
        services.AddSingleton<ProjectService>();
        services.AddSingleton<UserService>();
        //todo should be built from JWT
        services.AddSingleton(new WebUserContext
        {
            UserId = ObjectId.GenerateNewId().ToString(),
            Projects = new[]
            {
                new UserProjectRole("testId", ProjectRole.Manager)
            },
            Role = UserRole.SystemAdmin
        });
    }
}
