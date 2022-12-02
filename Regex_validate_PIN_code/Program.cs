using System.Text.RegularExpressions;

// test
Console.WriteLine(ValidatePin("1"));
Console.WriteLine(ValidatePin("12"));
Console.WriteLine(ValidatePin("123"));
Console.WriteLine(ValidatePin("12345"));
Console.WriteLine(ValidatePin("1234567"));
Console.WriteLine(ValidatePin("-1234"));
Console.WriteLine(ValidatePin("-12345"));
Console.WriteLine(ValidatePin("1234"));
Console.WriteLine(ValidatePin("-1.234"));
Console.WriteLine(ValidatePin("00000000"));


// decision
bool ValidatePin(string pin) => !new Regex(@"[^0-9]").IsMatch(pin) && (pin.Length == 4 ^ pin.Length == 6) ? true : false;