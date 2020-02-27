using System.IO;
using System.Text;

namespace TextEditor.BL
{
    public interface IFileManager
    {
        string GetContent(string filepath);
        string GetContent(string filepath, Encoding encoding);
        void SaveContent(string content, string filepath);
        void SaveContent(string content, string filepath, Encoding encoding);
        int GetSymbolCount(string content);
        bool IsExist(string filepath);
    }
    public class FileManager : IFileManager
    {
        private readonly Encoding _defaultEncoding = Encoding.GetEncoding(1251);

        public bool IsExist(string filepath)
        {
            bool isExist = File.Exists(filepath);
            return isExist;
        }

        public string GetContent (string filepath)
        {
            return GetContent(filepath, _defaultEncoding);
        }
        public string GetContent (string filePath, Encoding encoding)
        {
            string content = File.ReadAllText(filePath, encoding);
            return content;
        }

        public void SaveContent (string content, string filepath)
        {
            SaveContent(content, filepath, _defaultEncoding);
        }

        public void SaveContent(string content, string filepath, Encoding encoding)
        {
            File.WriteAllText(filepath, content, encoding);
        }

        public int GetSymbolCount(string content)
        {
            int count = content.Length;
            return count;
        }
    }
}
