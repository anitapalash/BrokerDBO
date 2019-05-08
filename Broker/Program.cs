using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Broker
{
    enum Type { INDIVIDUAL, LEGENT, CORPORATE }

    static class Program
    {
        static Client client = new Client();

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Entrance());
        }

        public static void setClientType(Type type)
        {
            client.setType(type);
        }

        public static void setCriterias(Dictionary<string, int> map)
        {
            Dictionary<string, int> currentMap = client.getCriterias();
            foreach (var rate in map)
                currentMap.Add(rate.Key, rate.Value);
            client.setCriterias(currentMap);
        }

        public static void setFeatures(Dictionary<string, bool> map)
        {
            Dictionary<string, bool> currentMap = client.getFeatures();
            foreach (var feature in map)
                currentMap.Add(feature.Key, feature.Value);
            client.setFeatures(currentMap);
        }
    }
}
