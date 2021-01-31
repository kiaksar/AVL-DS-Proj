using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVL
{
    class Node
    {
        public string value;
        public string meaning;
        public int height;
        public Node right;
        public Node left;
        public string idLine;
        public string idEnviroment;
        public Node(string value, string meaning, string idEnviroment)
        {
            this.value = value;
            this.meaning = meaning;
            this.idEnviroment = idEnviroment;
            height = 1;
        }
    }
}
