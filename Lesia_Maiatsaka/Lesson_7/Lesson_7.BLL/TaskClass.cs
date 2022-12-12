using System.IO;

namespace Lesson_7.BLL
{
    public class TaskClass
    {
        public TaskClass()
        {
            string fileName = @"D:\Lessons\";
            string directory = Path.GetDirectoryName(fileName);
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
        }

        // method to create file
        public async Task CreateFileAsync(string path, string content) 
        {
            using (StreamWriter sw = new StreamWriter(path)) 
            {
                await sw.WriteLineAsync(content);
            } 
        }

        // method to copy file
        public async Task CopyFileAsync(string source, string target) 
        {
            var src = await ReadFileAsync(source);
            await CreateFileAsync(target, src);
        }

        // method to read file
        public async Task<string> ReadFileAsync(string path) 
        {
            using (StreamReader sr = new StreamReader(path))
            {
                return await sr.ReadToEndAsync();
            }
        }

        // get Directory
        public List<FileInfo> GetAllInDirectory() 
        {
            var listNew = new List<FileInfo>();
            string[] allfiles = Directory.GetFiles(@"D:\Lessons", "*.*", SearchOption.AllDirectories);
            foreach (var file in allfiles)
            {
                FileInfo info = new FileInfo(file);
                listNew.Add(info);
            }
            return listNew;
        }
    }
}