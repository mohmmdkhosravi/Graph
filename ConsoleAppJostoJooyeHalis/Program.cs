namespace ConsoleAppJostoJooyeHalis
{
    class Graph
    {
        private Dictionary<int, List<int>> adjacencyList;

        public Graph()
        {
            adjacencyList = new Dictionary<int, List<int>>();
        }

        public void AddEdge(int vertex, int edge)
        {
            if (!adjacencyList.ContainsKey(vertex))
            {
                adjacencyList[vertex] = new List<int>();
            }
            adjacencyList[vertex].Add(edge);
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph();

            int k = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                string[] nodesNumber = Console.ReadLine().Split(" ");
                int firstNode= Convert.ToInt32(nodesNumber[0]);
                int lastNode = Convert.ToInt32(nodesNumber[1]);

                graph.AddEdge(firstNode,lastNode);
                graph.AddEdge(firstNode,lastNode);

            }
        }
    }
}
