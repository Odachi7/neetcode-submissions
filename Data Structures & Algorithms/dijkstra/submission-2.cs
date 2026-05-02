public class Solution
{
    public Dictionary<int, int> ShortestPath(int n, List<List<int>> edges, int src)
    {
        // Lista de adjacência mais leve
        List<(int v, int w)>[] grafo = new List<(int, int)>[n];

        for (int i = 0; i < n; i++)
        {
            grafo[i] = new List<(int, int)>();
        }

        foreach (var edge in edges)
        {
            int u = edge[0];
            int v = edge[1];
            int w = edge[2];

            grafo[u].Add((v, w));
        }

        int[] dist = new int[n];
        Array.Fill(dist, int.MaxValue);
        dist[src] = 0;

        PriorityQueue<(int node, int dist), int> fila = new PriorityQueue<(int, int), int>();
        fila.Enqueue((src, 0), 0);

        while (fila.Count > 0)
        {
            var atual = fila.Dequeue();
            int node = atual.node;
            int distAtual = atual.dist;

            // evita processamento inútil
            if (distAtual > dist[node])
                continue;

            foreach (var (proximo, peso) in grafo[node])
            {
                int novaDist = dist[node] + peso;

                if (novaDist < dist[proximo])
                {
                    dist[proximo] = novaDist;
                    fila.Enqueue((proximo, novaDist), novaDist);
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
