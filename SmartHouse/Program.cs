using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<string, Device> ComponentList = new Dictionary<string, Device>();
            ComponentList.Add("Samsung", new Conditioner("Samsung"));
            ComponentList.Add("Sony", new TV("Sony"));
            ComponentList.Add("LG", new Fridge("LG"));
            ComponentList.Add("CentralLamp", new Lamp("CentralLamp"));
            ComponentList.Add("CentralJalousie", new Jalousie("CentralJalousie"));

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Меня зовут Джарвис,я управляю системой умного дома\nВ вашем доме находится:\n ");
                foreach (var i in ComponentList)
                {
                    Console.WriteLine(i.Value.ToString());
                }
                Console.WriteLine();
                Console.Write("Введите команду: ");
                string[] commands = Console.ReadLine().Split(' ');
                if (commands[0].ToLower() == "exit" & commands.Length == 1)
                {
                    return;
                }
                else if (commands.Length < 2)
                {
                    Help();

                }
                if (commands[0] == "add")
                {
                    if (commands[0].ToLower() == "add" && !ComponentList.ContainsKey(commands[2]))
                    {
                        switch (commands[1].ToLower())
                        {
                            case "lamp":
                                ComponentList.Add(commands[2], new Lamp(commands[2]));
                                break;
                            case "conditioner":
                                ComponentList.Add(commands[2], new Conditioner(commands[2]));
                                break;
                            case "fridge":
                                ComponentList.Add(commands[2], new Fridge(commands[2]));
                                break;
                            case "jalousie":
                                ComponentList.Add(commands[2], new Jalousie(commands[2]));
                                break;
                            case "tv":
                                ComponentList.Add(commands[2], new TV(commands[2]));
                                break;
                            default:
                                Console.WriteLine("Такого типа устройства не существует");
                                Help();
                                break;
                        }
                        continue;
                    }
                    else if (commands[0].ToLower() == "add" && ComponentList.ContainsKey(commands[2]))
                    {
                        Console.WriteLine("Устройство с таким именем существует.");
                        Console.WriteLine("Нажмите любую клавишу для продолжения");
                        Console.ReadLine();
                        continue;
                    }
                }
                if (commands.Length == 2 && ComponentList.ContainsKey(commands[0]))
                {
                    switch (commands[1].ToLower())
                    {
                        case "on":
                            if (ComponentList[commands[0]] is IStatusOnOff)
                            {
                                ((IStatusOnOff)ComponentList[commands[0]]).StatusOn();
                            }
                            else
                            {
                                Console.WriteLine("ошибка " + commands[1]);
                                Help();
                            }
                            break;
                        case "off":
                            if (ComponentList[commands[0]] is IStatusOnOff)
                            {
                                ((IStatusOnOff)ComponentList[commands[0]]).StatusOff();
                            }
                            else
                            {
                                Console.WriteLine("ошибка " + commands[0]);
                                Help();
                            }
                            break;
                        case "open":
                            if (ComponentList[commands[0]] is IStatusOpenClose)
                            {
                                ((IStatusOpenClose)ComponentList[commands[0]]).StatusOpen();
                            }
                            else
                            {
                                Console.WriteLine("ошибка " + commands[0]);
                                Help();
                            }
                            break;
                        case "close":
                            if (ComponentList[commands[0]] is IStatusOpenClose)
                            {
                                ((IStatusOpenClose)ComponentList[commands[0]]).StatusClose();
                            }
                            else
                            {
                                Console.WriteLine("ошибка " + commands[0]);
                                Help();
                            }
                            break;
                        case "frost":
                            if (ComponentList[commands[0]] is ITemperature)
                            {
                                ((ITemperature)ComponentList[commands[0]]).SetSuperFrost();
                            }
                            else
                            {
                                Console.WriteLine("ошибка " + commands[0]);
                                Help();
                            }
                            break;
                        case "coold":
                            if (ComponentList[commands[0]] is ITemperature)
                            {
                                ((ITemperature)ComponentList[commands[0]]).SetSuperСoold();
                            }
                            else
                            {
                                Console.WriteLine("ошибка " + commands[0]);
                                Help();
                            }
                            break;
                        case "safe":
                            if (ComponentList[commands[0]] is ITemperature)
                            {
                                ((ITemperature)ComponentList[commands[0]]).SetFrostSafe();
                            }
                            else
                            {
                                Console.WriteLine("ошибка " + commands[0]);
                                Help();
                            }
                            break;
                        case "low":
                            if (ComponentList[commands[0]] is IBrightness)
                            {
                                ((IBrightness)ComponentList[commands[0]]).SetLow();
                            }
                            else
                            {
                                Console.WriteLine("ошибка " + commands[0]);
                                Help();
                            }
                            break;
                        case "medium":
                            if (ComponentList[commands[0]] is IBrightness)
                            {
                                ((IBrightness)ComponentList[commands[0]]).SetMedium();
                            }
                            else
                            {
                                Console.WriteLine("ошибка " + commands[0]);
                                Help();
                            }
                            break;
                        case "high":
                            if (ComponentList[commands[0]] is IBrightness)
                            {
                                ((IBrightness)ComponentList[commands[0]]).SetHigh();
                            }
                            else
                            {
                                Console.WriteLine("ошибка " + commands[0]);
                                Help();
                            }
                            break;
                        case "nextchannel":
                            if (ComponentList[commands[0]] is IChangeChanel)
                            {
                                ((IChangeChanel)ComponentList[commands[0]]).NextChannel();
                            }
                            else
                            {
                                Console.WriteLine("ошибка " + commands[0]);
                                Help();
                            }
                            break;
                        case "prevchannel":
                            if (ComponentList[commands[0]] is IChangeChanel)
                            {
                                ((IChangeChanel)ComponentList[commands[0]]).PrevChannel();
                            }
                            else
                            {
                                Console.WriteLine("ошибка " + commands[0]);
                                Help();
                            }
                            break;
                        case "volume-":
                            if (ComponentList[commands[0]] is IVolume)
                            {
                                ((IVolume)ComponentList[commands[0]]).VolumeMinus();
                            }
                            else
                            {
                                Console.WriteLine("ошибка " + commands[0]);
                                Help();
                            }
                            break;

                        case "volume+":
                            if (ComponentList[commands[0]] is IVolume)
                            {
                                ((IVolume)ComponentList[commands[0]]).VolumePlus();
                            }
                            else
                            {
                                Console.WriteLine("ошибка " + commands[0]);
                                Help();
                            }
                            break;
                        case "del":
                            ComponentList.Remove(commands[0]);
                            break;
                        case "temperature-":
                            if (ComponentList[commands[0]] is ITemperature)
                            {
                                ((ITemperature)ComponentList[commands[0]]).TemperatureMinus();
                            }
                            else
                            {
                                Console.WriteLine("ошибка " + commands[0]);
                                Help();
                            }
                            break;
                        case "temperature+":
                            if (ComponentList[commands[0]] is ITemperature)
                            {
                                ((ITemperature)ComponentList[commands[0]]).TemperaturePlus();
                            }
                            else
                            {
                                Console.WriteLine("ошибка " + commands[0]);
                                Help();
                            }
                            break;
                    }
                }
            }
        }
        private static void Help()
        {
            Console.WriteLine("Допустимые типы устройств");
            Console.WriteLine("\tlamp");
            Console.WriteLine("\tconditioner");
            Console.WriteLine("\tfridge");
            Console.WriteLine("\tjalousie");
            Console.WriteLine("\ttv");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  
            Console.WriteLine("Доступные команды для них:");
            Console.WriteLine("\tadd тип устройства имя устройства");
            Console.WriteLine("\tимя устройства del ");

            Console.WriteLine("\tимя устройства on");
            Console.WriteLine("\tимя устройства off");
            Console.WriteLine("\tимя устройства open");
            Console.WriteLine("\tимя устройства close");

            Console.WriteLine("    Допустимо для устройств таких как tv ");
            Console.WriteLine("\tимя устройства nextchannel");
            Console.WriteLine("\tимя устройства prevchannel");
            Console.WriteLine("\tимя устройства volume-");
            Console.WriteLine("\tимя устройства volume+");

            Console.WriteLine("    Допустимо для устройств таких как conditioner и fridge ");
            Console.WriteLine("\tимя устройства frost");
            Console.WriteLine("\tимя устройства coold");
            Console.WriteLine("\tимя устройства safe");
            Console.WriteLine("\tимя устройства temperature-");
            Console.WriteLine("\tимя устройства temperature+");

            Console.WriteLine("    Допустимо для устройств таких как jalousie и lamp ");
            Console.WriteLine("\tимя устройства low");
            Console.WriteLine("\tимя устройства medium");
            Console.WriteLine("\tимя устройства high");

            Console.WriteLine("\texit");
            Console.WriteLine("Нажмите любую клавишу для продолжения");
            Console.ReadLine();
        }
    }
}
