int a,i;
Console.Write("Введите число:");
a= int.Parse(Console.ReadLine());
i=1;
while(i <= a ){
    if( i % 2 == 0)
    {
    Console.WriteLine($"{i},");
}
i++;
}


