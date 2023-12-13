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
        public static List<Customer> ReadCustomers()
        {
            try
            {
                string text = File.ReadAllText(@"./customer-data.json");
                List<Customer> data = JsonSerializer.Deserialize<List<Customer>>(text);
                return data;
            }
            catch (Exception e)
            {
                throw new Exception($"Error in reading file{e}");
            }
        }
    }
}
