using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DAL
{
    public static class XMLManager
    {
        static XmlTextWriter xmlWriter;
        public static string file;

        public static void createFile()
        {
            
                xmlWriter = new XmlTextWriter(file, Encoding.UTF8);
                xmlWriter.Formatting = Formatting.Indented;
                xmlWriter.WriteStartElement("Employees");
                xmlWriter.WriteEndElement();
                xmlWriter.Close();
           
        }

        public static void addEmployee(string id,
            string name,string salary, string age, string type)
        {
           
            // Checking file 
            if (!File.Exists(file))
            {
                createFile();
            }
            // Open file 
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(file);

            // Writing data to file 
            XmlNode employee = xDoc.CreateElement("Employee");
            
            XmlNode _id = xDoc.CreateElement("ID");
            _id.InnerText = id;

            XmlNode _name = xDoc.CreateElement("Name");
            _name.InnerText = name;

            XmlNode _salary = xDoc.CreateElement("Salary");
            _salary.InnerText = salary;

            XmlNode _age = xDoc.CreateElement("Age");
            _age.InnerText = age;

            XmlNode _type = xDoc.CreateElement("Type");
            _type.InnerText = type;

            employee.AppendChild(_id);
            employee.AppendChild(_name);
            employee.AppendChild(_salary);
            employee.AppendChild(_age);
            employee.AppendChild(_type);

            xDoc.DocumentElement.AppendChild(employee);

            // Close doc and save 
            xDoc.Save(file);


        }
    }

}
