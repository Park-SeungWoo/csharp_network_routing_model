using System;

namespace networknode
{
    class Program
    {
        static void Main(string[] args)
        {
            // This program shows the most primitive routing work.
            Nodes tnode = new Nodes();  // Nodes class create 7 nodes as default. 
                                        // If you want to add more nodes, you have to redefine topology and modify routingtbl.cs.
                                        // refer to ./topology_img/topology.png

            Console.WriteLine("7nodes created!");
            Console.Write("Start node : ");
            int sn = int.Parse(Console.ReadLine());
            Console.Write("Destination node : ");
            int dn = int.Parse(Console.ReadLine());
            Console.Write("Send message : ");
            string mes = Console.ReadLine();

            tnode.send(sn, dn, mes);
        }
    }
}
