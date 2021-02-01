using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace AVL
{
    class AVLTree
    {
        public Node root;
        public string inOrderResult;

        // A utility function to get height of the tree  
        public Dictionary<string, Environment> environment = new Dictionary<string, Environment>();
        public Dictionary<string, Line> line = new Dictionary<string, Line>();

        Form1 form;
        int ctrGaris = 1;
        int ctrLingkaran = 1;

        public AVLTree(Form1 form)
        {
            this.form = form;
            root = null;
        }


        int height(Node N)
        {
            if (N == null)
                return 0;
            return N.height;
        }

        // A utility function to get maximum of two integers  
        int max(int a, int b)
        {
            return (a > b) ? a : b;
        }

        // A utility function to right rotate subtree rooted with y  
        // See the diagram given above.  
        Node rightRotate(Node y)
        {
            Node x = y.left;
            Node T2 = x.right;

            // Perform rotation  
            x.right = y;
            y.left = T2;

            // Update heights  
            y.height = max(height(y.left), height(y.right)) + 1;
            x.height = max(height(x.left), height(x.right)) + 1;

            // Return new root  
            return x;
        }

        // A utility function to left rotate subtree rooted with x  
        // See the diagram given above.  
        Node leftRotate(Node x)
        {
            //y= new root 
            //T2= anak kiri root baru
            Node y = x.right;
            //50
            Node T2 = y.left;
            //48
            // Perform rotation  

            //kiri 50 44 sama 17
            y.left = x;
            //kanan 44 48
            x.right = T2;

            // Update heights  
            x.height = max(height(x.left), height(x.right)) + 1;
            y.height = max(height(y.left), height(y.right)) + 1;

            // Return new root  
            return y;
        }

    }
}
