using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerTask.Task_Value
{
    public class Headers
    {
        public string acept { get; set; }
        public string aceptecoding { get; set; }
        public string aceptlanguage { get; set; }
        public string conection { get; set; }
        public string host { get; set; }
        public int upgradeins { get; set; }

        public override string ToString()
        {
            return $"acept: {acept}, aceptecoding: {aceptecoding}, aceptlanguage: {aceptlanguage}, conection: {conection}, host: {host}, upgradeins: {upgradeins}";
        }
    }
}
