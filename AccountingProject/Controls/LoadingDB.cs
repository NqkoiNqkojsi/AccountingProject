using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using AccountingProject.Models;


namespace AccountingProject.Controls
{
    class LoadingDB
    {
        static public bool IsDBEmpty()
        {
            string text = System.IO.File.ReadAllText(@"..\..\Database\workers.json");
            Console.WriteLine($"text={text}");
            if (text.Length<5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static public List<Person> DeserializePeople()
        {
            string text = System.IO.File.ReadAllText(@"..\..\Database\people.json");
            try
            {
                return JsonConvert.DeserializeObject<List<Person>>(text);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        static public List<Worker> DeserializeWorkers()
        {
            string text = System.IO.File.ReadAllText(@"..\..\Database\workers.json");
            try
            {
                return JsonConvert.DeserializeObject<List<Worker>>(text);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        static public List<WorkDay> DeserializeDays()
        {
            string text = System.IO.File.ReadAllText(@"..\..\Database\workdays.json");
            try
            {
                return JsonConvert.DeserializeObject<List<WorkDay>>(text);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        static public void SerializePeople(List<Person> workers)
        {
            System.IO.File.WriteAllText(@"..\..\Database\people.json", JsonConvert.SerializeObject(workers));
        }
        static public void SerializeWorkers(List<Worker> workers)
        {
            System.IO.File.WriteAllText(@"..\..\Database\workers.json", JsonConvert.SerializeObject(workers));
        }
        static public void SerializeWorkDays(List<WorkDay> workers)
        {
            System.IO.File.WriteAllText(@"..\..\Database\workdays.json", JsonConvert.SerializeObject(workers));
        }
    }
}
