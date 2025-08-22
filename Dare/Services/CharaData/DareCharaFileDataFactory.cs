using Dare.API.Data;
using Dare.FileCache;
using Dare.Services.CharaData.Models;

namespace Dare.Services.CharaData;

public sealed class DareCharaFileDataFactory
{
    private readonly FileCacheManager _fileCacheManager;

    public DareCharaFileDataFactory(FileCacheManager fileCacheManager)
    {
        _fileCacheManager = fileCacheManager;
    }

    public DareCharaFileData Create(string description, CharacterData characterCacheDto)
    {
        return new DareCharaFileData(_fileCacheManager, description, characterCacheDto);
    }
}