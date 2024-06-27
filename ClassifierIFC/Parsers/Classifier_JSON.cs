using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static ClassifierIFC.Parsers.Classifier_JSON;

namespace ClassifierIFC.Parsers
{
    public class Classifier_JSON
    {
        public List<Classifier> objects { get; set; }

        [Newtonsoft.Json.JsonObject(Title = "Object")]
        public class Classifier
        {
            public List<string> Type { get; set; }
            public string Category { get; set; }
            public string KSI { get; set; }
        }

        public string SearchKSI(string type, string category)
        {
            var obj = this.objects.FirstOrDefault(x => 
            x.Type.Select(t => t?.ToLower()).Contains(type?.ToLower()) &&
            x.Category?.ToLower() == category?.ToLower()
            );
            return obj?.KSI;
        }

        public static Classifier_JSON ReadFromFile(string filePath)
        {
            //using (StreamReader reader = File.OpenText(filePath))
            //{
            //    Classifier obj = JsonConvert.DeserializeObject<Classifier>(reader.ReadToEnd());
            //    return obj;
            //}
            
                Classifier_JSON obj = JsonConvert.DeserializeObject<Classifier_JSON>(File.ReadAllText(filePath));
                return obj;
            
        }
               

    }


    public class OutClassifer// : Classifier_JSON.Classifier
    {
        public string Name { get; set; }
        public string IFC_class { get; set; }
        public string Category { get; set; }
        public string KSI { get; set; }

        public OutClassifer(string name, string ifc_class, string category, string ksi)
        {
            this.Name = name;
            this.IFC_class = ifc_class;
            this.Category = category;
            this.KSI = ksi;
        }

        public OutClassifer(Xbim.Common.IPersistEntity element, Classifier_JSON classifier)
        {
            var ifcObject = (element as Xbim.Ifc2x3.Kernel.IfcObject);
            this.Name = ifcObject?.Name;
            this.IFC_class = element.ExpressType?.Name;
            this.Category = ifcObject?.GetPropertySingleNominalValue("Другая", "Категория")?.Value.ToString();
            this.KSI = classifier?.SearchKSI(this.IFC_class, this.Category);
        }

        public override string ToString()
        {
            return String.Concat(this.Name, "\t",
                this.IFC_class, "\t",
                this.Category, "\t",
                this.KSI
                );
        }

        public bool IsValid()
        {
            if (string.IsNullOrWhiteSpace(this.Name))
                return false;
            if (string.IsNullOrWhiteSpace(this.IFC_class))
                return false;
            if (string.IsNullOrWhiteSpace(this.Category))
                return false;
            return true;
        }
    }
}
