using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsportsReplayManager.Modules.FileSystem;

internal class FileSystemService : IFileSystemService
{
    public IEnumerable<string> GetReplaysFromDisk()
    {
        const string replayFolder = "C:\\Users\\Micha\\OneDrive\\Documents\\My Games\\Rocket League\\TAGame\\Demos";
        IEnumerable<string> replayNames = Directory.EnumerateFiles(replayFolder);
        return replayNames;
    }
}
