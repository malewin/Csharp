// ===== Работа с текстом
// Дан текст/ В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить большими "К",
// а бошьшие "С" заменить маленькими "с".

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

//string s = "qwerty"
//            0123
// s[3] //r

string Replace(string rext, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result + $"{newValue}";
        else result + $"{str[i]}";
    }

    return result;
}