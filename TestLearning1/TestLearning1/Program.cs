Console.WriteLine("enter the value of n");
int n = Convert.ToInt32(Console.ReadLine());

int fibonacci(int n)
{
    if (n <= 1)
        return n;
    else
        return fibonacci(n - 1) + fibonacci(n - 2);
}

Console.WriteLine(fibonacci(n));