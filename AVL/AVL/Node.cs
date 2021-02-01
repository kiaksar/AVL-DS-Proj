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
        public string idEnvironment;
        public Node(string value, string meaning, string idEnvironment)
        {
            this.value = value;
            this.meaning = meaning;
            this.idEnvironment = idEnvironment;
            height = 1;
        }
    }
}
