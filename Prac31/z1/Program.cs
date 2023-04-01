using Microsoft.Data.SqlClient;
using z1.Models;

//localhost\SQLEXPRESS01
string connectionString = @"Server=localhost\SQLEXPRESS01;Database=DBTur_firm;Trusted_Connection=True;TrustServerCertificate=True;";

using (SqlConnection connection = new SqlConnection(connectionString))
{
    await connection.OpenAsync();
    await WriteAllsTour(connection);
    Console.Write("Удаление тура: ");
    string nameTur = Console.ReadLine();
    SqlCommand command = new SqlCommand($"DELETE Тур WHERE Название='{nameTur}'", connection);
    await command.ExecuteNonQueryAsync();
    Console.WriteLine();
    Console.WriteLine($"Талица Тур после удаления тура: {nameTur}");
    await WriteAllsTour(connection);

    Console.WriteLine();
    Console.WriteLine("Таблица Турист");
    await WriteAllsTourist(connection);
    int nextId = await GetNextCodeTurist(connection);
    Tourist t1 = new Tourist(
    nextId,
    "Саливончик",
    "Антон",
    "Леонидович",
    new TouristInfo(
        "AB00000000",
        "Гродно",
        "Беларусь",
        "+375333333333",
        nextId));
    string sqlExpressionAddTurist = "INSERT INTO Турист ([Код туриста], Фамилия, Имя, Отчество) VALUES" +
    $" ({t1.Id},'{t1.Surname}','{t1.Name}','{t1.Midlename}')";
    string sqlExpressionAddTuristInfo = "INSERT INTO [Информация о туристах] ([Код туриста],[Серия паспорта], Город, Страна, Телефон, Индекс) " +
        $"VALUES ({t1.Id},'{t1.Info.PassportSeries}','{t1.Info.City}','{t1.Info.State}', '{t1.Info.NumPhone}', {t1.Info.Index})";
    command = new SqlCommand(sqlExpressionAddTurist, connection);
    int n1 = await command.ExecuteNonQueryAsync();
    command = new SqlCommand(sqlExpressionAddTuristInfo, connection);
    int n2 = await command.ExecuteNonQueryAsync();
    Console.WriteLine($"Добавлено объектов: {n1}");
    Console.WriteLine($"Добавлено объектов: {n2}");

    Console.WriteLine();
    Console.WriteLine("БД после всех изменений");
    await WriteAllsTourist(connection);
    await WriteAllsTour(connection);
}

async Task WriteAllsTour(SqlConnection connection)
{
    SqlCommand command = new SqlCommand("Select * FROM Тур", connection);
    SqlDataReader reader = await command.ExecuteReaderAsync();
    if (reader.HasRows)
    {
        string columnName1 = reader.GetName(0);
        string columnName2 = reader.GetName(1);
        string columnName3 = reader.GetName(2);
        string columnName4 = reader.GetName(3);
        Console.WriteLine($"{columnName1}\t{columnName2}\t{columnName3}\t{columnName4}");
        while (await reader.ReadAsync())
        {
            try
            {
                object id = reader.GetValue(0);
                object name = reader.GetValue(1);
                object price = reader.GetValue(2);
                object info = reader.GetValue(3);
                Console.WriteLine($"{id}\t{name}\t{price}\t{info}");
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("Ошибка чтения!\t");
            }
        }
    }
    await reader.CloseAsync();
}

async Task WriteAllsTourist(SqlConnection connection)
{
    SqlCommand command = new SqlCommand("SELECT * FROM Турист", connection);
    SqlDataReader reader = await command.ExecuteReaderAsync();
    if (reader.HasRows)
    {
        string columnName1 = reader.GetName(0);
        string columnName2 = reader.GetName(1);
        string columnName3 = reader.GetName(2);
        string columnName4 = reader.GetName(3);
        Console.WriteLine($"{columnName1}\t{columnName2}\t{columnName3}\t{columnName4}");
        while (await reader.ReadAsync())
        {
            try
            {
                object id = reader.GetValue(0);
                object surname = reader.GetValue(1);
                object name = reader.GetValue(2);
                object midlename = reader.GetValue(3);
                Console.WriteLine($"{id}\t{surname}\t{name}\t{midlename}");
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("Ошибка чтения!\t");
            }
        }
    }
    await reader.CloseAsync();
}

async Task<int> GetNextCodeTurist(SqlConnection connection)
{
    string sqlExpressionMaxCode = "SELECT MAX([Код туриста]) FROM Турист";
    SqlCommand command = new SqlCommand(sqlExpressionMaxCode, connection);
    SqlDataReader reader = await command.ExecuteReaderAsync();
    int nextId = 0;
    if (reader.HasRows)
    {
        while (await reader.ReadAsync()) // построчно считываем данные
        {
            try
            {
                nextId = (int)reader.GetValue(0);
                nextId++;
            }
            catch (InvalidCastException)
            {
                nextId = 0;
            }

        }
    }
    await reader.CloseAsync();
    return nextId;
}