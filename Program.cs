Console.WriteLine(sunNum(new List<int> { 1, 2, 3, 4, 5, 6 })); // Output: 12

static int sunNum(IEnumerable<int> n) => n.Where(x => x % 2 == 0).Sum();
