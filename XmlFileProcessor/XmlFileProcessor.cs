using Microsoft.AspNetCore.Components.Forms;

namespace XmlFileProcessor
{
    /// <summary>
    /// Main class for managing XML file processing.
    /// </summary>
    public class XmlFileProcessor
    {
        public string FileName { get; init; } = string.Empty;
        /// <summary>
        /// File size in bytes.
        /// </summary>
        public long FileSize { get; init; }
        /// <summary>
        /// File size in megabytes.
        /// </summary>
        public long FileSizeMB => FileSize / 1024 / 1024;


        private XmlFileProcessor() { }

        public XmlFileProcessor(IBrowserFile file) {
            if (file == null) throw new ArgumentNullException(nameof(file));

            FileName = file.Name;
            FileSize = file.Size;
        }


        public static readonly XmlFileProcessor Empty = new() { FileName = "<None>", FileSize = 0 };
    }
}
