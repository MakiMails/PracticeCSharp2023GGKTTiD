//Паттерн Состояние
Document doc = new Document("У себя", "Дождались меня белые ночи\r\nНад простором густых островов…\r\nСнова смотрят знакомые очи,\r\nИ мелькает былое без слов.");
Console.WriteLine(doc);
Console.WriteLine();
doc.ToPublish();
Console.WriteLine();
Console.WriteLine(doc);
Console.WriteLine();
doc.ToPublish();
Console.WriteLine();
Console.WriteLine(doc);
Console.WriteLine();
doc.ToPublish();
Console.WriteLine();
Console.WriteLine(doc);
Console.WriteLine();
doc.LowerState();
Console.WriteLine();
Console.WriteLine(doc);
Console.WriteLine();
doc.LowerState();
Console.WriteLine();
Console.WriteLine(doc);
Console.WriteLine();
doc.LowerState();
Console.WriteLine();
class Document
{
    private StateDocument _state;
    private string _name;
    private string _text;

    public StateDocument State { get => _state; set => _state = value; }

    public Document(string name,string text)
    {
        _state = new DraftState();
        _text = text;
    }

    public void ToPublish()
    {
        _state.NextState(this);
    }

    public void LowerState() 
    {
        _state.BackState(this);
    }

    public override string ToString()
    {
        return $"Название: {_name}\n" +
            $"Статус: {_state}\n" +
            $"{_text}\n";
    }
}

abstract class StateDocument
{
    public abstract void NextState(Document doc);
    public abstract void BackState(Document doc);
    public abstract override string ToString();
}

class DraftState : StateDocument
{
    public override void NextState(Document doc)
    {
        doc.State = new ModerationState();
        Console.WriteLine("Документ сменил состаяние с черновика на модрерацию");
    }

    public override void BackState(Document doc)
    {
        Console.WriteLine("Документ является черновиком. Это минимальное состояние для документа");
    }

    public override string ToString()
    {
        return "Черновик";
    }
}

class ModerationState : StateDocument
{
    public override void NextState(Document doc)
    {
        doc.State = new PublishedState();
        Console.WriteLine("Документ сменил состаяние с модрерации на публиковаеый ");
    }

    public override void BackState(Document doc)
    {
        doc.State = new DraftState();
        Console.WriteLine("Документ сменил состаяние с модрерации на черновик");
    }

    public override string ToString()
    {
        return "На модерации";
    }
}

class PublishedState : StateDocument
{
    public override void NextState(Document doc)
    {
        Console.WriteLine("Документ является публикованным, следующего состояния нет");
    }

    public override void BackState(Document doc)
    {
        doc.State = new ModerationState();
        Console.WriteLine("Документ сменил состаяние с публиковоный на модрерацию");
    }

    public override string ToString()
    {
        return "Опубликован";
    }
}