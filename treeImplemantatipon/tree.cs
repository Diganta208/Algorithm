using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treeImplemantatipon
{
    class tree
    {
        private int data;
        private tree leftChild;
        private tree rightChild;

        public tree createNode(int data)
        {
            tree aTree = new tree();
            this.data = data;
            this.leftChild = null;
            this.rightChild = null;

            return aTree;

        }

        public void addLeftChild(tree parent, tree child)
        {
            parent.leftChild = child;
        }

        public void addRightChild(tree parent, tree child)
        {
            parent.rightChild = child;
        }

        public void preOder(tree node)
        {
            Console.WriteLine(node.data);
            if(node.leftChild!= null)
            {
                preOder(node.leftChild);
            }
            if(node.rightChild!=null)
            {
                preOder(node.rightChild);
            }
        }

        public void postOder(tree node)
        {
            if (node.leftChild != null)
            {
                preOder(node.leftChild);
            }
            if (node.rightChild != null)
            {
                preOder(node.rightChild);
            }
            Console.WriteLine(node.data);
        }

        public void inOder(tree node)
        {
            if (node.leftChild != null)
            {
                preOder(node.leftChild);
            }

            Console.WriteLine(node.data);

            if (node.rightChild != null)
            {
                preOder(node.rightChild);
            }
        }

    }
}
