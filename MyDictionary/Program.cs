using MyDictionary;


    MyDictionary<int, string> persons = new MyDictionary<int, string>();
    persons.Add(1, "Nur");
    persons.Add(2, "Yakup");
    persons.Add(3, "Yasir");

    foreach (var person in persons.value)
    {
        Console.WriteLine(person);
    }
    foreach (var person in persons.key)
    {
        Console.WriteLine(person);
    }

    Console.WriteLine("Dizinin Uzunluğu: " + persons.Length);