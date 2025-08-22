using Dare.API.Data;
using MessagePack;

namespace Dare.API.Dto.User;

[MessagePackObject(keyAsPropertyName: true)]
public record UserDto(UserData User);