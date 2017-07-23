namespace ComplejidadTF
{
    class DisjointSet
    {
        private int[] parent;
        private int[] rank;
        private int n;

        public DisjointSet(int n)
        {
            this.n = n;
            parent = new int[n];
            rank = new int[n];

            for (int i = 0; i < n; i++)
            {
                parent[i] = i;
                rank[i] = 0;
            }
        }

        public int FindSet(int n)
        {
            if (n != parent[n])
                parent[n] = FindSet(parent[n]);
            return parent[n];
        }

        public void UnionSet(int n1, int n2)
        {
            n1 = FindSet(n1);
            n2 = FindSet(n2);

            if (rank[n1] > rank[n2])
                parent[n2] = n1;
            else
            {
                parent[n1] = n2;
                if (rank[n1] == rank[n2])
                    rank[n2]++;
            }
        }
    }
}