using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
namespace Animals
{
   
    public class Program
    {
        static string path = @"C:\\prog\\test.txt";
        static string pathxml = @"C:\\prog\\test.xml";
        public class Animal
        {
            public string owner;
            public string type;
            public string name;
            public int age;
          public  Animal() { }
            public Animal(string owner, string type, string name, int age)
            {
                this.owner = owner;
                this.type = type;
                this.name = name;
                this.age = age;
            }
            public void show()
            {
                Console.WriteLine($"{owner,-10}{type,-10}{name,-10}{age,4}");
            }
        }
        static void initText(List <Animal> Olegi)
        {
            StreamReader sr = new StreamReader(path, System.Text.Encoding.Default);
            string line;
            string[] temp = new string[4];
            int counter = 0;
            while(!sr.EndOfStream)
            {
                counter++;
                line = sr.ReadLine();
                temp = line.Split(',');
                Olegi.Add(new Animal(temp[0], temp[1], temp[2], Convert.ToInt32(temp[3])));
            }
        }
        static int typesofanimalAtOwner(List<Animal> Olegi)
        {
            Console.WriteLine("insert name of owner ");
            string ownerName = Console.ReadLine();
            List<Animal> countByOwner = new List<Animal>();
            for (int i = 0; i < Olegi.Count(); i++)
            {
                if (Olegi.ElementAt(i).owner == ownerName)
                {
                    countByOwner.Add(Olegi.ElementAt(i));
                }
            }
            for (int i = 0; i < countByOwner.Count(); i++)
            {
                for (int j = i + 1; j < countByOwner.Count(); j++)
                {
                    if (countByOwner.ElementAt(i).type == countByOwner.ElementAt(j).type)
                    {
                        countByOwner.RemoveAt(j);
                    }
                }
            }
            if(countByOwner.Count() == 0)
            {
                Console.WriteLine("Incorrect owner name");
            }
            return countByOwner.Count();
        }
        static void ShowAnimalTypeMaster(List<Animal> Olegi)
        {
            Console.WriteLine("insert type of animal");
            string animalType = Console.ReadLine();
            List<Animal> TypeMaster = new List<Animal>();
            for (int i = 0; i < Olegi.Count(); i++)
            {
                if (Olegi.ElementAt(i).type == animalType)
                {
                    TypeMaster.Add(new Animal(Olegi.ElementAt(i).owner, Olegi.ElementAt(i).type, Olegi.ElementAt(i).name, Olegi.ElementAt(i).age));
                }
            }
            if (TypeMaster.Count() == 0)
            {
                Console.WriteLine("Incorrect Type");
                return;
            }
            for(int i = 0; i < TypeMaster.Count(); i++)
            {
                for (int j = i + 1; j < TypeMaster.Count(); j++)
                {
                    if (TypeMaster.ElementAt(i).owner == TypeMaster.ElementAt(j).owner && TypeMaster.ElementAt(i).name == TypeMaster.ElementAt(j).name)
                    {
                        TypeMaster.RemoveAt(j);
                    }
                } 
            }
            for(int i = 0; i < TypeMaster.Count(); i++)
            {
                TypeMaster.ElementAt(i).show();
            }
        }
        static void TypesOfAnimalsMaster(List<Animal> Olegi)
        {
            Console.Write("Insert name of animal: ");
            string animalName = Console.ReadLine();
            List<Animal> NameByType = new List<Animal>();
            int counter = 0;
            for (int i = 0; i < Olegi.Count(); i ++)
            {
                if(Olegi.ElementAt(i).name == animalName)
                {
                    NameByType.Add(Olegi.ElementAt(i));
                }
            }
            for (int i = 0; i < NameByType.Count(); i++)
            {
                 for (int j = i + 1; j < NameByType.Count(); j++)
                {
                    if (NameByType.ElementAt(i).type == NameByType.ElementAt(j).type)
                    {
                        NameByType.RemoveAt(j);
                    }
                }
            }
            Console.WriteLine("Type of animals with that name: ");
            for (int i = 0; i < NameByType.Count(); i++)
            {
                NameByType.ElementAt(i).show();
            }
            Console.WriteLine("Count of that types: " + NameByType.Count());
        }
        static Animal youngerAnimal(List<Animal> Olegi)
        {
            int age = Olegi.ElementAt(0).age;
            for(int i = 0; i < Olegi.Count(); i++)
            {
                if (age >= Olegi.ElementAt(i).age)
                {
                    age = Olegi.ElementAt(i).age;
                }
            }
            for (int i = 0; i < Olegi.Count(); i++)
            {
                if (age == Olegi.ElementAt(i).age)
                {
                    return Olegi.ElementAt(i);
                }
            }
            return Olegi.ElementAt(0);
        }
        static Animal olderAnimal(List<Animal> Olegi)
        {
            int age = Olegi.ElementAt(0).age;
            for (int i = 0; i < Olegi.Count(); i++)
            {
                if (age <= Olegi.ElementAt(i).age)
                {
                    age = Olegi.ElementAt(i).age;
                }
            }
            for (int i = 0; i < Olegi.Count(); i++)
            {
                if (age == Olegi.ElementAt(i).age)
                {
                    return Olegi.ElementAt(i);
                }
            }
            return Olegi.ElementAt(0);
        }

        static void Serialization(List<Animal> Olegi)
        {
            XmlSerializer formator = new XmlSerializer(typeof(List<Animal>));
            using (FileStream fs = new FileStream(pathxml, FileMode.OpenOrCreate))
            {
                formator.Serialize(fs, Olegi);
            }
        }


        static List<Animal> Init_xml()
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Animal>));
            using (StreamReader sr = new StreamReader(pathxml))
            {
                return (List<Animal>)xs.Deserialize(sr);
            }

        }


        static void Main(string[] args)
        {
            List <Animal> Olegi = new List<Animal>();
            initText(Olegi);
            Serialization(Olegi);
            bool isClose = false;
            int choose;
            while (isClose == false)
            {
                for (int i = 0; i < Olegi.Count(); i++)
                {
                    Olegi.ElementAt(i).show();
                }
                Console.WriteLine("1 -  Show count of animal at owner, 2 - Show owners and names of animals by type, 3 - count of types animals with name, 4- show younger and older animal, 5 - close app");
                choose = Convert.ToInt32(Console.ReadLine());
                switch(choose)
                {
                    case 1:
                        Console.WriteLine(typesofanimalAtOwner(Olegi));
                        break;
                    case 2:
                        ShowAnimalTypeMaster(Olegi);
                        break;
                    case 3:
                        TypesOfAnimalsMaster(Olegi);
                        break;
                    case 4:
                        Console.WriteLine("Younger animal is: ");
                        youngerAnimal(Olegi).show();
                        Console.WriteLine("Older animal is: ");
                        olderAnimal(Olegi).show();
                        break;
                    case 5:
                        isClose = true;
                        break;
                    default:
                        Console.WriteLine("Incorrect digit");
                        break;
                }
                Console.WriteLine("Press any key");
                Console.ReadKey();
                Console.Clear();
            }
         /*   Console.WriteLine(animalAtOwner(Olegi));
            ShowAnimalTypeMaster(Olegi);
            TypesOfAnimalsMaster(Olegi);
            Console.WriteLine("Younger animal is: ");
            youngerAnimal(Olegi).show();
            Console.WriteLine("Older animal is: ");
            olderAnimal(Olegi).show();
            Console.ReadKey();*/
        }
    }
}