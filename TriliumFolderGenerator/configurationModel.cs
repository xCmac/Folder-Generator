
using System.Collections.Generic;

namespace TriliumFolderGenerator
{
    class ConfigurationModel
    {
        public List<string> FoldersDPS { get; set; }
        public List<string> FoldersDPO { get; set; }
        public string JobDocumentsDirectory { get; set; }
        public string CreationDirectory { get; set; }
    }
}
