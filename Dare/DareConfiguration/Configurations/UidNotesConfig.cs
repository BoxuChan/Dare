using Dare.DareConfiguration.Models;

namespace Dare.DareConfiguration.Configurations;

public class UidNotesConfig : IDareConfiguration
{
    public Dictionary<string, ServerNotesStorage> ServerNotes { get; set; } = new(StringComparer.Ordinal);
    public int Version { get; set; } = 0;
}
