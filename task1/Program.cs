

//Задача 1: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

string checkIfPolindrom(int x){
    int x1=x;
    if (x<10000 || x>99999) return "число " + x + " не явлется пятизначным";
    int [] array  = new int [5];
   for (int i = 0; i<5;i++){
    array[i] = x%10;
    x=x/10;
   }
   if (array[0]==array[4] && array[1]==array[3]) return "число " + x1 +" является палиндромом";
   return "число " + x1 +" не является палиндромом";
}
Console.WriteLine(checkIfPolindrom(14541));
Console.WriteLine(checkIfPolindrom(45621));
Console.WriteLine(checkIfPolindrom(456021));