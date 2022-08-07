namespace passcode.Models;
#pragma warning disable CS8618 


public class PassCode
{
    public string Code { get; set; }

    Random rand = new Random();

    public string Alphabet =
    "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

    public string GenerateString()
    {
        char[] chars = new char[14];
        for (int i = 0; i < chars.Length; i++)
        {
            chars[i] = Alphabet[rand.Next(Alphabet.Length)];
        }
        Code = new string(chars);
        return Code;
    }


}

