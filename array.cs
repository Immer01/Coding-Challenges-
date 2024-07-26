// Array Challenge

string[] orderIds = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

foreach (string id in orderIds)
{
    if (id.StartsWith("B"))
    {
        Console.WriteLine(id);
    }
}

 // Another Array Challenge

Random random = new Random();
string[] orderIDs = new string[5];

for (int i = 0; i < orderIDs.Length; i++)
{
    int prefixValue = random.Next(65, 70);
    string prefix = Convert.ToChar(prefixValue).ToString();
    string suffix = random.Next(1, 1000).ToString("000");

    orderIDs[i] = prefix + suffix;
}

foreach (var orderID in orderIDs)
{
    Console.WriteLine(orderID);
}

