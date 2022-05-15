//Задача 2: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
double Distance(int x1,int y1,int z1, int x2, int y2,int z2 ){
    return Math.Round(Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2) + Math.Pow(z2-z1,2)),4);
}

 Console.WriteLine($"Расстояние между точками {Distance(4,3,4,6,8,9)}");
