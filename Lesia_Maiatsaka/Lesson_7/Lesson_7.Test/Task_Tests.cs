using Lesson_7.BLL;

namespace Lesson_7.Test
{
    [TestClass]
    public class Task_Tests
    {
        [TestMethod]
        public async Task CreateCopyFile()
        {
            var path = @"D:\Lessons\data.txt";
            var task = new TaskClass();
            await task.CreateFileAsync(path, "Hello Piper Cat");
            Assert.IsTrue(File.Exists(path));

            var file = await task.ReadFileAsync(path);
            Assert.IsTrue(file.Length > 0);
            Assert.IsTrue(file.Contains("Hello Piper Cat"));

            var rez = @"D:\Lessons\rez.txt";
            await task.CopyFileAsync(path, rez);
            var file2 = await task.ReadFileAsync(rez);
            Assert.IsTrue(file2.Length > 0);
            Assert.IsTrue(file2.Contains("Hello Piper Cat"));

            var file3 = task.GetAllInDirectory();
            Assert.IsTrue(file3.Count > 0);

            var path2 = @"D:\Lessons\DirectoryD.txt";
            await task.CreateFileAsync(path2, String.Join("\n", file3.Select(fileInfo => $"{fileInfo.Name} | {fileInfo.Extension} | {fileInfo.Length}" )));
            Assert.IsTrue(File.Exists(path2));


        }
    }
}