using Z2;
using MyLibrary;

Accauntant accauntant = new();

int hours = Convert.ToInt32(MyTool.Input("Введите кол-во чисов: "));

if (accauntant.AskForBonus(Post.director, hours))
{
    Console.WriteLine("Премия положена");
}
else
{
    Console.WriteLine("Премия не положена");
}

