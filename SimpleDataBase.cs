namespace modul5_1302210090
{
    internal class SimpleDataBase<T>{
        private List<T> storedData;
        private List<DateTime> date;

        public SimpleDataBase()
        {
            storedData= new List<T>();
            date= new List<DateTime>();
        }
        public void AddNewData(T data)
        {
            storedData.Add(data);
            date.Add(DateTime.Now);

        }
        public void PrintAllData()
        {
            for (int i = 0; i < storedData.Count; i++)
            {
                Console.WriteLine(storedData[i] + " " + date[i]);
            }
        }
    }
}
