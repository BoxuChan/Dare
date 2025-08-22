using Dare.API.Data;
using Dare.API.Data.Enum;
using MessagePack;

namespace Dare.API.Dto.Group;

[MessagePackObject(keyAsPropertyName: true)]
public record GroupPermissionDto(GroupData Group, GroupPermissions Permissions) : GroupDto(Group);