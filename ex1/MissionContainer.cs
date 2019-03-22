using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1 { 
public delegate double Operation(double var);   //delegate type for the lambda expressions input
    public class FunctionsContainer
    {
        private Dictionary<string, Operation> dic = new Dictionary<string, Operation>();
        public Operation this [string key] //Indexer mapping string- name of operation and the function
        {
            get {
                if (!dic.ContainsKey(key)) {
                    dic.Add(key, value => value);
                }
                return dic[key];
            }
            set
            {
                dic[key] = value;
            }
        }
        //returning the the mission names (all the keys in the dictionary)
        public List<string> getAllMissions()
        {
            List<string> names = dic.Keys.ToList();
            return names;
        }
    }
}