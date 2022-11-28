namespace Lesson_7.BLL
{
    public class TextPhoneBook
    {
        private StreamReader _streamReader;
        private StreamWriter _streamWriter;

        public TextPhoneBook(StreamReader streamReader, StreamWriter streamWriter)
        {
            _streamWriter = streamWriter;
            _streamReader = streamReader;
        }

        public Dictionary<string, long> Entries { get; } = new Dictionary<string, long>();

        public async Task<string> ReadFromPhoneBookAsync() => await _streamReader.ReadToEndAsync();

        public void CreatePhoneBookEntries(string content) 
        {
            foreach (var item in content.Split("\n"))
            {
                Entries.Add(item.Split("-")[0], long.Parse(item.Split("-")[1]));
            }
        }

        public async Task CopyPhoneBookAsynk() 
        {
            foreach (var item in Entries) 
            {
                await _streamWriter.WriteLineAsync($"{item.Key} has number {item.Value}");
            }
            _streamWriter.Close();
        }

    }
}
