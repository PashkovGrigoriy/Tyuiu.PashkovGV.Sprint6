using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.PashkovGV.Sprint6.Task6.V10.Lib
{
    public class Data : ISprint6Task6V10
    {
        public string CollectTextFromFile(string path)
        {
            string content = File.ReadAllText(path);
            var words = content.Split(new[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            var resultWords = words.Where(word => word.Contains('w'));
            return string.Join(" ", resultWords);
        }
    }
}
