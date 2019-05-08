using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;

namespace Broker
{
    class Client
    {
        Type type;
        Dictionary<string, int> criterias = new Dictionary<string,int>();
        Dictionary<string, bool> features = new Dictionary<string, bool>();
        public void setType(Type type)
        {
            this.type = type;
        }

        public Type getType()
        {
            return this.type;
        }

        public void setCriterias(Dictionary<string, int> map)
        {
            this.criterias = map;
        }

        public Dictionary<string, int> getCriterias()
        {
            return criterias; 
        }

        public void setFeatures(Dictionary<string, bool> map)
        {
            this.features = map;
        }

        public Dictionary<string, bool> getFeatures()
        {
            return features;
        }
    }
}
