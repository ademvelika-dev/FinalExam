using System.Text.Json;

namespace FinalExam
{
    public static class JsonFileReader
    {

        /// <summary>
        /// replace dynamic with right model 
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static dynamic ReadCustomers()
        {
            try
            {
                string text = File.ReadAllText(@"./customer-data.json");
                var data = JsonSerializer.Deserialize<dynamic>(text);
                return data;
            }
            catch(Exception e)
            {
                throw new Exception($"Error in reading file{e}");
            }
        }
    }
}
