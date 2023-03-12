namespace NotePad.Models {
    public enum FileTypes { SysDrive, Drive, BackFolder, Folder, FILE }

    public class ItemFile {
        public ItemFile(FileTypes type, string name) {
            Type = type;
            Name = name;
        }
        public FileTypes Type { get; }
        public string Name { get; }
    }
}