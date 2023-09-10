using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsportsReplayManager.Modules.FileSystem;

internal class FileSystemService : IFileSystemService
{
    public async Task<List<string>> GetReplaysFromDisk()
    {
        const string replayFolder = "C:\\Users\\Micha\\OneDrive\\Documents\\My Games\\Rocket League\\TAGame\\Demos";
        List<string> fullyQualifiedReplayFileNames = new(Directory.EnumerateFiles(replayFolder));
        await Task.Delay(5000);
        return await Task.FromResult(fullyQualifiedReplayFileNames);
    }
}
