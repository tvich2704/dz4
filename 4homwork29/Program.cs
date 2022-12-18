rea(mass());

 int[] mass(){
    int[] array = new int[8];
    for (int i = 0; i <= 7; i++)
    {
        array[i] = new Random().Next(101);
    }
    return array;
 }

void rea(int[] sub){
    for(int i = 0; i <= sub.Length - 1; i++)
    {
        Console.Write($"{sub[i]} ");
    }
    Console.Write("->[");
    for(int i = 0; i <= sub.Length - 1; i++)
    {
        Console.Write($"{sub[i]} ");
    }
    Console.Write("]");
}

