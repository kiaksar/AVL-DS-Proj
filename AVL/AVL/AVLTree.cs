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
        public Dictionary<string, Lingkaran> lingkaran = new Dictionary<string, Lingkaran>();
        public Dictionary<string, Garis> garis= new Dictionary<string, Garis>();

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
        public void delay()
        {
            form.pictureBox1.Invalidate();
            Application.DoEvents();
            Thread.Sleep(300);

        }
        // Get Balance factor of node N 
        int getBalance(Node N)
        {
            if (N == null)
                return 0;
            return height(N.left) - height(N.right);
        }
        public Node InsertHelper(Node node, int key)
        {
            return insert(node, key, 1, 1, 34);
        }
        public Node insert(Node node, int key, int kali, int bagi, int tinggi)
        {
            if (node == null)
            {
                form.Status.Text = "Current is null";
                delay();
                form.Status.Text = "Inserting node";
                delay();

                lingkaran.Add("lingkaran" + ctrLingkaran, new Lingkaran(484 / bagi * kali + 1, tinggi, key.ToString()));
                ctrLingkaran++;
                form.pictureBox1.Invalidate();
                return (new Node(key, "lingkaran" + (ctrLingkaran - 1)));

            }

            if (key < node.key)
            {
                form.Status.Text = key + " is lesser than " + node.key;
                lingkaran[node.idLingkaran].brush = new SolidBrush(Color.Yellow);
                delay();
                form.Status.Text = " Current go to left";
                lingkaran[node.idLingkaran].brush = new SolidBrush(Color.Black);
                delay();

                node.left = insert(node.left, key, (kali * 2) - 1, bagi * 2, tinggi + 100);
            }
            else if (key > node.key)
            {
                form.Status.Text = key + " is greater than " + node.key;
                lingkaran[node.idLingkaran].brush = new SolidBrush(Color.Yellow);
                delay();
                form.Status.Text = " Current go to right";
                lingkaran[node.idLingkaran].brush = new SolidBrush(Color.Black);
                delay();
                node.right = insert(node.right, key, (kali * 2) + 1, bagi * 2, tinggi + 100);
            }
            else
                return node;

            /* 2. Update height of this ancestor node */
            node.height = 1 + max(height(node.left),
                                height(node.right));

            /* 3. Get the balance factor of this ancestor  
            node to check whether this node became  
            Wunbalanced */
            int balance = getBalance(node);

            // If this node becomes unbalanced, then  
            // there are 4 cases Left Left Case  
            if (balance > 1 && key < node.left.key)
            {
                form.Status.Text = "Right Rotate on " + node.key;
                delay();
                return rightRotate(node);
            }

            // Right Right Case  
            if (balance < -1 && key > node.right.key)
            {
                form.Status.Text = "Right Rotate on " + node.key;
                delay();
                return leftRotate(node);
            }

            // Left Right Case  
            if (balance > 1 && key > node.left.key)
            {
                form.Status.Text = "Double right Rotate on " + node.key;
                delay();
                node.left = leftRotate(node.left);
                return rightRotate(node);
            }

            // Right Left Case  
            if (balance < -1 && key < node.right.key)
            {
                form.Status.Text = "Double left Rotate on " + node.key;
                delay();
                node.right = rightRotate(node.right);
                return leftRotate(node);
            }

            /* return the (unchanged) node pointer */
            return node;
        }

    }
}
