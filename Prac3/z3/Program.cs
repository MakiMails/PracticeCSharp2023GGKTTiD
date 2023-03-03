using z3.Models;

Vector3 vector1 = new Vector3(1, 2, 3);
Console.WriteLine($"Длина вектора: {vector1.Length:.###}");
Vector3 vector2 = new Vector3(4, 5, 6);
Console.WriteLine($"Скалярное проеизведение двух векторов: {vector1.GetScalarProductOfVector3(vector2)}");
Console.WriteLine($"Косинус угла между двумя веторами: {vector1.GetCosCornerBetweenVector3(vector2):.###}");
