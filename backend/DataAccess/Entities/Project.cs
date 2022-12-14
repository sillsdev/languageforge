namespace LanguageForge.Api.Entities;

public class Project : EntityDocument<Project>
{
    public required string ProjectName { get; init; }
    public required string ProjectCode { get; init; }
    public required bool AllowSharing { get; init; }
    public required Dictionary<string, InputSystem> InputSystems { get; init; }
    /// <summary>
    /// dictionary of user ids as the key
    /// </summary>
    public required Dictionary<LfId<User>, ProjectUser> Users { get; init; }
}
