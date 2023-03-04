using z1.Interface;
using z1.Model;


TestClass testClass = new TestClass("Тест строчка стол");
Console.WriteLine(testClass.IxF0("Вторая тест строчка стол"));
Console.WriteLine(testClass.IxF1());
Console.WriteLine(testClass.F0("Вторая тест строчка стол"));
Console.WriteLine(testClass.F1());
TestClass testClass2 = new TestClass("Тест строчка стол");
Console.WriteLine((testClass2 as Iz).F0("Вторая тест строчка стол"));
Console.WriteLine((testClass2 as Iz).F1());