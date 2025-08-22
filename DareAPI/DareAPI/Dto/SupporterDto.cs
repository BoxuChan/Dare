using MessagePack;

namespace Dare.API.Dto;

[MessagePackObject(keyAsPropertyName: true)]
public record SupporterDto(List<string> Supporters);