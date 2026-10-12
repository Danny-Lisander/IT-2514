Console.WriteLine(sumNum(new List<int> { 1, 2, 3, 4, 5, 6 })); // Output: 12

static int sumNum(IEnumerable<int> n) => n.Where(x => x % 2 == 0).Sum();
