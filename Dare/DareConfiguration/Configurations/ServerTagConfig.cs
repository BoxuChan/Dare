using Dare.DareConfiguration.Models;

namespace Dare.DareConfiguration.Configurations;

public class ServerTagConfig : IDareConfiguration
{
    public Dictionary<string, ServerTagStorage> ServerTagStorage { get; set; } = new(StringComparer.OrdinalIgnoreCase);
    public int Version { get; set; } = 0;
}