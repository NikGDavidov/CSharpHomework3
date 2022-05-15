// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27. 
//5 -> 1, 8, 27, 64, 125

int[] CubArray(int n){
if (n<1) return new int[0];
int []array = new int[n];
for (int i=1; i<=n; i++){
array[i-1]= (int)Math.Pow(i,3);
}
return array;
}
Console.WriteLine("Введите целое число =>1");
int n=int.Parse(Console.ReadLine());
int [] array = CubArray(n);
 Console.Write($"{n} -> ");
for (int i=0; i<n; i++){
    Console.Write(array[i] +", ");
}