int line = int.Parse(Console.ReadLine());
Console.WriteLine($"{line}->{func(line)}");

int func(int numbers){
    int summ = 0;
    while (numbers > 0)
    {
        summ = summ + numbers % 10;
        numbers /= 10;
    }
    return summ;
}

