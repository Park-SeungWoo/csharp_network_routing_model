using System;
using System.Collections.Generic;

namespace networknode
{
    class Node
    {
        private Dictionary<int, char> routingTBL;
        private void SetroutingTBL(int n)
        {
            routingTBL = rtable.getrtable(n + 1);
        }
        public char useroutingTBL(int node)
        {
            try
            { return routingTBL[node]; }
            catch (Exception)
            {
                throw new Exception($"There isn't exsits node{node}");
            }
        }

        public Node(int i)
        {
            SetroutingTBL(i);
        }
    }
    class Nodes
    {
        public List<Node> nodesarr = new List<Node>();

        public void send(int snode, int dnode, string msg)
        {
            Console.WriteLine("Routing...");
            routing(snode, dnode, msg);
        }
        private void receive(int desnode, string msg, string visited)
        {
            Console.WriteLine(visited);
            Console.WriteLine($"node{desnode} received : {msg}");
        }
        private void routing(int snode, int dnode, string msg)
        {
            int nextnode = snode;
            string visitednode = $"node{snode}->";
            char status = '0';
            while (true)
            {
                try
                {
                    status = nodesarr[nextnode - 1].useroutingTBL(dnode);
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.Message);
                    status = 'n';
                }
                switch (status)
                {
                    case '0':
                        visitednode += "receive";
                        receive(nextnode, msg, visitednode);
                        break;
                    case '1':
                        nextnode = 1;
                        visitednode += "node1->";
                        continue;
                    case '2':
                        nextnode = 2;
                        visitednode += "node2->";
                        continue;
                    case '3':
                        nextnode = 3;
                        visitednode += "node3->";
                        continue;
                    case '4':
                        nextnode = 4;
                        visitednode += "node4->";
                        continue;
                    case '5':
                        nextnode = 5;
                        visitednode += "node5->";
                        continue;
                    case '6':
                        nextnode = 6;
                        visitednode += "node6->";
                        continue;
                    case '7':
                        nextnode = 7;
                        visitednode += "node7->";
                        continue;
                    case 'n':
                        Console.WriteLine("NOPE");
                        break;
                }
                break;
            }
        }
        public Nodes(int n = 7)
        {
            for (int i = 0; i < n; i++)
            {
                nodesarr.Add(new Node(i));
            }
        }
    }
}