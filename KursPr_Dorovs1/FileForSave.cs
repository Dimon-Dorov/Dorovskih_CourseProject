using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursPr_Dorovs
{
    class FileForSave
    {
        private static readonly string ConfigFilePath = "config.txt";

        public static (DateTime lastPaymentDate, decimal livingCost) LoadConfig()
        {
            if (!File.Exists(ConfigFilePath))
            {
                var defaultDate = DateTime.Now;
                var defaultCost = 500;
                SaveConfig(defaultDate, defaultCost);
                return (defaultDate, defaultCost);
            }

            var lines = File.ReadAllLines(ConfigFilePath);
            DateTime lastPaymentDate = DateTime.Parse(lines[0].Split('=')[1]);
            decimal livingCost = decimal.Parse(lines[1].Split('=')[1]);

            return (lastPaymentDate, livingCost);
        }

        public static void SaveConfig(DateTime lastPaymentDate, decimal livingCost)
        {
            var lines = new[]
            {
            $"LastPaymentDate={lastPaymentDate:yyyy-MM-dd}",
            $"LivingCost={livingCost}"
        };
            File.WriteAllLines(ConfigFilePath, lines);
        }
    }
}
