using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.AccessControl;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace SkolSystem.Klasser
{
    public class Database
    {
        public static Data data = new Data();
        //public static List<Konto> allaKonton = new List<Konto>();
        public static string savePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\SkolSystem";
        public static void Save()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\SkolSystem";
            Directory.CreateDirectory(path);
            path += "\\Save.xml";
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                DataContractSerializer ser = new DataContractSerializer(typeof(Data));
                ser.WriteObject(fs, data);
            }
        }
        
        public static void Load()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\SkolSystem\\Save.xml";
            
            if (File.Exists(path))
            {
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    DataContractSerializer ser = new DataContractSerializer(typeof(Data));
                    Data tempData = (Data)ser.ReadObject(fs);
                    data = tempData;
                }
            }



            AddKursTyper();
        }

        public static void AddKursTyper()//Istället för sql
        {
            data.kursTyper = new List<KursTyp>();
            data.kursTyper.Add(new KursTyp("Matte", "Leker med siffror", 100));
            data.kursTyper.Add(new KursTyp("Fysik", "Kraft", 150));
            data.kursTyper.Add(new KursTyp("Programmering", "01010110001 Null exeption", 100));
            data.kursTyper.Add(new KursTyp("Svenska", "Tråkigt", 100));
            data.kursTyper.Add(new KursTyp("Engelska", "Very Nice", 100));
            data.kursTyper.Add(new KursTyp("Relgion", "Ame", 50));
        }

        public static void LoadKursTyper()
        {
            List<object[]> temp = SqlLoader.Fetch("SELECT * FROM KursTyper");

            data.kursTyper = new List<KursTyp>();

            foreach (object[] item in temp)
            {
                data.kursTyper.Add(new KursTyp(((string)item[1]).Trim(), ((string)item[2]).Trim(), (int)item[3])); //item(0) är id och den bryr jag mig inte om nu
            }
        }
    }
}
