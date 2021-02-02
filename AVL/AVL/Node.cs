using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVL
{
    public class Node
    {
        public string value;
        public string meaning;
        public int height;
        public Node right;
        public Node left;
        public string idGaris;
        public string idLingkaran;
        public Node(string value, string meaning, string idLingkaran)
        {
            this.value = value;
            this.meaning = meaning;
            this.idLingkaran = idLingkaran;
            height = 1;
        }
    }
}
