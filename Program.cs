Console.WriteLine($"Sum of even numbers greater than 3: from 1 to 6: {sumNum(new List<int> { 1, 2, 3, 4, 5, 6 })}"); // Output: 12

static int sumNum(IEnumerable<int> n) => n
    .Where(x => x % 2 == 0)
    .Where( x => x > 3)
    .Sum();