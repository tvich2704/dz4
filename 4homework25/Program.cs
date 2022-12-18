int A = int.Parse(Console.ReadLine());
int B = int.Parse(Console.ReadLine());
Console.WriteLine($"{A},{B}->{multi(A, B)}");

int multi(int ferst, int second){
    int summ = 1;
    for (int i = 1; i <= second; i++)
    {
        summ *= ferst;
    }
    return summ;
}

