namespace Find_Shortest_Path;

public class Program
{
    static void Main(string[] args)
    {
          
        // A --(4)-- B --(3)-- D
        //  \      /
        //  (2)  (1)
        //    \  /
        //     C
        var distances = new Dictionary<string, int> {
            ["A"] = 0,
            ["B"] = int.MaxValue,
            ["C"] = int.MaxValue,
            ["D"] = int.MaxValue,
        };

        var graph = new Dictionary<string, List<(string neighbor, int cost)>> {
            ["A"] = new() { ("B", 4), ("C", 2) },
            ["B"] = new() { ("D", 3) },
            ["C"] = new() { ("B", 1) },
            ["D"] = new()
        };

        var pq = new PriorityQueue<string, int>();
        pq.Enqueue("A", 0);

        while (pq.Count > 0) {
            var current = pq.Dequeue();
            var currentDist = distances[current];

            foreach (var (neighbor, cost) in graph[current]) {
                int newDist = currentDist + cost;
                if (newDist < distances[neighbor]) {
                    distances[neighbor] = newDist;
                    pq.Enqueue(neighbor, newDist);
                }
            }
        }

        Console.WriteLine($"Khoang cach ngan nhat tu A đen D la: {distances["D"]}");
        // Kết quả: 6 (A → C → B → D)
    }
}