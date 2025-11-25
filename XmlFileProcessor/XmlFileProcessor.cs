using Microsoft.AspNetCore.Components.Forms;

namespace XmlFileProcessor
{
    /// <summary>
    /// Main class for managing
    /// </summary>
    public class XmlFileProcessor
    {
        public string FileName { get; init; }
        /// <summary>
        /// File size in bytes.
        /// </summary>
        public long FileSize { get; init; }
        /// <summary>
        /// File size in megabytes.
        /// </summary>
        public long FileSizeMB => FileSize / 1024 / 1024;

        public XmlFileProcessor(IBrowserFile file) {
            if(file == null) throw new ArgumentNullException(nameof(file));

            FileName = file.Name;
            FileSize = file.Size;
        }
    }
}
