using Dare.API.Data;
using MessagePack;

namespace Dare.API.Dto.User;

[MessagePackObject(keyAsPropertyName: true)]
public record ApplyMoodlesByStatusDto(UserData User, string Statuses) : UserDto(User);