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
        static public int counterWorker=0;
        static public int counterWorkDays=0;
        static public int counterShiftDays=0;

        public int _counterWorker;
        public int _counterWorkDays;
        public int _counterShiftDays;

        LoadingDB(int a, int b, int c)
        {
            _counterWorker = a;
            _counterWorkDays = b;
            _counterShiftDays = c;
        }

        static private bool CheckAndCreate(string name)
        {
            if (System.IO.File.Exists(@"..\..\Database\"+name))
            {
                Console.WriteLine(name + " exists");
                return true;
            }
            System.IO.File.Create(@"..\..\Database\" + name);
            Console.WriteLine(name + " created");
            return false;
        }

        static public bool IsDBEmpty()
        {
            if (CheckAndCreate("people" + SettingModel.year + ".json"))
            {
                string text = System.IO.File.ReadAllText(@"..\..\Database\workers" + SettingModel.year + ".json");
                Console.WriteLine($"text={text}");
                if (text.Length < 5)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        static public void MakeDBReady()
        {
            if (CheckAndCreate("counter" + SettingModel.year + ".json"))
            {
                string text = System.IO.File.ReadAllText(@"..\..\Database\counter" + SettingModel.year + ".json");
                try
                {
                    Counter obj = JsonConvert.DeserializeObject<Counter>(text);
                    Console.WriteLine("Worker Counter: " + obj._counterWorker + '\n');
                    Counter.counterWorker = obj._counterWorker;
                    Counter.counterWorkDays = obj._counterWorkDays;
                    Counter.counterShiftDays = obj._counterShiftDays;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception Counter= " + ex + '\n');
                    Counter.counterWorker = 0;
                    Counter.counterWorkDays = 0;
                    Counter.counterShiftDays = 0;
                }
            }
        }
        static public void UpdateCounterDB()
        {
            Counter obj = new Counter(Counter.counterWorker, Counter.counterWorkDays, Counter.counterShiftDays);
            System.IO.File.WriteAllText(@"..\..\Database\counter" + SettingModel.year + ".json", JsonConvert.SerializeObject(obj));
        }

        static public List<Person> DeserializePeople()
        {
            if (CheckAndCreate("people" + SettingModel.year + ".json"))
            {
                string text = System.IO.File.ReadAllText(@"..\..\Database\people"+ SettingModel.year + ".json");
                try
                {
                    return JsonConvert.DeserializeObject<List<Person>>(text);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                return null;
            }
        }
        static public List<Worker> DeserializeWorkers()
        {
            if (CheckAndCreate("workers" + SettingModel.year + ".json"))
            {
                string text = System.IO.File.ReadAllText(@"..\..\Database\workers" + SettingModel.year + ".json");
                if (text.Length > 2)
                {
                    try
                    {
                        return JsonConvert.DeserializeObject<List<Worker>>(text);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Exception Worker= " + ex + '\n');
                        return null;
                    }
                }
            }
            return null;
        }
        static public List<WorkDay> DeserializeWorkDays()
        {
            if (CheckAndCreate("workdays" + SettingModel.year + ".json"))
            {
                string text = System.IO.File.ReadAllText(@"..\..\Database\workdays" + SettingModel.year + ".json");
                if (text.Length > 2)
                {
                    try
                    {
                        Console.WriteLine("Deserilze WorkDays \n");
                        return JsonConvert.DeserializeObject<List<WorkDay>>(text);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Exception WorkDay= " + ex + '\n');
                        return null;
                    }
                }
            }
            return null;

        }
        static public List<ShiftDay> DeserializeShiftDays()
        {
            if (CheckAndCreate("shiftdays" + SettingModel.year + ".json"))
            {
                string text = System.IO.File.ReadAllText(@"..\..\Database\shiftdays" + SettingModel.year + ".json");
                if (text.Length > 2)
                {
                    try
                    {
                        return JsonConvert.DeserializeObject<List<ShiftDay>>(text);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Exception ShiftDay= " + ex + '\n');
                        return null;
                    }
                }
            }
            return null;
        }
        static public void SerializePeople(List<Person> workers)
        {
            System.IO.File.WriteAllText(@"..\..\Database\people" + SettingModel.year + ".json", JsonConvert.SerializeObject(workers));
        }
        static public void SerializeWorkers(List<Worker> workers)
        {
            CheckAndCreate("workers" + SettingModel.year + ".json");
            System.IO.File.WriteAllText(@"..\..\Database\workers" + SettingModel.year + ".json", JsonConvert.SerializeObject(workers));
        }
        static public void SerializeWorkDays(List<WorkDay> workers)
        {
            System.IO.File.WriteAllText(@"..\..\Database\workdays" + SettingModel.year + ".json", JsonConvert.SerializeObject(workers));
        }
        static public void SerializeShiftDays(List<ShiftDay> workers)
        {
            System.IO.File.WriteAllText(@"..\..\Database\shiftdays" + SettingModel.year + ".json", JsonConvert.SerializeObject(workers));
        }
    }
}
