using Nethereum.ENS;
using Nethereum.Hex.HexTypes;

var ensUtil = new EnsUtil();

Console.Write("Enter your domain name: ");
var domain = Console.ReadLine()?.ToLower();

if(string.IsNullOrEmpty(domain))
{
    throw new ArgumentException("domain cannot be null or empty", nameof(domain));
}

if(!domain.EndsWith(".eth"))
{
    domain = domain + ".eth";
}

var nameHash = ensUtil.GetNameHash(domain);

var ggg = domain[..4];

var labelHash = ensUtil.GetLabelHash(domain[..4]);

var nameHashHex = new HexBigInteger(nameHash);

var labelHashHex = new HexBigInteger(labelHash);

Console.WriteLine($"Domain ID: {nameHashHex.Value}");
Console.WriteLine($"Domain Hex: {nameHashHex.HexValue}");
Console.WriteLine();
Console.WriteLine("---------------------------------------------");
Console.WriteLine();
Console.WriteLine($"Label ID: {labelHashHex.Value}");
Console.WriteLine($"Label Hex: {labelHashHex.HexValue}");