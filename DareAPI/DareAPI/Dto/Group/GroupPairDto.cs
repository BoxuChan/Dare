using Dare.API.Data;
using MessagePack;

namespace Dare.API.Dto.Group;

[MessagePackObject(keyAsPropertyName: true)]
public record GroupPairDto(GroupData Group, UserData User) : GroupDto(Group)
{
    public string UID => User.UID;
    public string? UserAlias => User.Alias;
    public string UserAliasOrUID => User.AliasOrUID;
}