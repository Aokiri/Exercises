// Link to the exercise: https://exercism.org/tracks/csharp/exercises/robot-name

using System;
using System.Collections.Generic;

public class Robot
{
    private static List<string> _namesList = new();
    private static Random random = new Random();
    private string _letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    private string _name = string.Empty;

    public string Name
    {
        get
        {
            return _GetName();
        }
    }

    public void Reset()
    {
        _name = _GenerateRandomName();
    }

    private string _GetName()
    {
        if (_name == string.Empty)
        {
            _name = _GenerateRandomName();
        }
        return _name;
    }

    private string _GenerateRandomName()
    {
        bool nameIsUnique = true;
        string name = string.Empty;

        while (nameIsUnique)
        {
            name = string.Empty;

            string letter0 = _letters[random.Next(0, 26)];
            string letter1 = _letters[random.Next(0, 26)];
            string number0 = random.Next(0, 9).ToString();
            string number1 = random.Next(0, 9).ToString();
            string number2 = random.Next(0, 9).ToString();

            name = letter0 + letter1 + number0 + number1 + number2;

            nameIsUnique = !_namesList.Contains(name);
        }

        _namesList.Add(name);

        return name;
    }
}