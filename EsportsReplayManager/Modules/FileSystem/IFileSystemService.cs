using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsportsReplayManager.Modules.FileSystem;

public interface IFileSystemService
{
    Task<List<string>> GetReplaysFromDisk();
}
