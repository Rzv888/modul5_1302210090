using System.ComponentModel;

namespace modul5_1302210090
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SimpleDataBase<int> storedData = new SimpleDataBase<int>();
            storedData.AddNewData(123456);
            storedData.PrintAllData();
        }
    }
}