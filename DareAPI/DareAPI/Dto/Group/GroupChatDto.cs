using Dare.API.Data;
using MessagePack;

namespace Dare.API.Dto.Group;

[MessagePackObject(keyAsPropertyName: true)]
public record GroupChatDto(UserData User, GroupData Group,DateTime Time, string Message) : GroupDto(Group)
{
}