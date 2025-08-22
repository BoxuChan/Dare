using Dare.API.Data;
using Dare.API.Data.Enum;
using MessagePack;

namespace Dare.API.Dto.User;

[MessagePackObject(keyAsPropertyName: true)]
public record UserIndividualPairStatusDto(UserData User, IndividualPairStatus IndividualPairStatus) : UserDto(User);