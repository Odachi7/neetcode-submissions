public class Solution
{
    public Dictionary<int, int> ShortestPath(int n, List<List<int>> edges, int src)
    {
        Dictionary<int, List<int[]>> grafo = new Dictionary<int, List<int[]>>();

        for (int i = 0; i < n; i++)
        {
            grafo[i] = new List<int[]>();
        }

        foreach (List<int> edge in edges)
        {
            int u = edge[0];
            int v = edge[1];
            int w = edge[2];

            grafo[u].Add(new int[] { v, w });
        }

        int[] dist = new int[n];

        for (int i = 0; i < n; i++)
        {
            dist[i] = int.MaxValue;
        }

        dist[src] = 0;

        PriorityQueue<int, int> fila = new PriorityQueue<int, int>();
        fila.Enqueue(src, 0);

        while (fila.Count > 0)
        {
            int atual = fila.Dequeue();

            foreach (int[] vizinho in grafo[atual])
            {
                int proximo = vizinho[0];
                int peso = vizinho[1];

                if (dist[atual] + peso < dist[proximo])
                {
                    dist[proximo] = dist[atual] + peso;
                    fila.Enqueue(proximo, dist[proximo]);
                }
            }
        }

        Dictionary<int, int> resposta = new Dictionary<int, int>();

        for (int i = 0; i < n; i++)
        {
            resposta[i] = dist[i] == int.MaxValue ? -1 : dist[i];
        }

        return resposta;
    }
}