using NumberSystems.Models;

namespace NumberSystems.Test
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("---- From BINARY ----");
			Base b = new BinarySystem("1010");
			var binary = b.To(NumberBase.BINARY);
			var octal = b.To(NumberBase.OCTAL);
			var dec = b.To(NumberBase.DECIMAL);
			var hexadecimal = b.To(NumberBase.HEXADECIMAL);


			Console.WriteLine($"({b.Value})({(int)NumberBase.BINARY}) = ({binary}){(int)NumberBase.BINARY}");
			Console.WriteLine($"({b.Value})({(int)NumberBase.BINARY}) = ({octal}){(int)NumberBase.OCTAL}");
			Console.WriteLine($"({b.Value})({(int)NumberBase.BINARY}) = ({dec}){(int)NumberBase.DECIMAL}");
			Console.WriteLine($"({b.Value})({(int)NumberBase.BINARY}) = ({hexadecimal}){(int)NumberBase.HEXADECIMAL}");

			BinarySystem bn = new BinarySystem("1110");
			Console.WriteLine($"({bn.Value}) ToDecimal: {bn.ToDecimal()}");
			Console.WriteLine($"({bn.Value}) ToOctal: {bn.ToOctal()}");
			Console.WriteLine($"({bn.Value}) ToHexadecimal: {bn.ToHexadecimal()}");

			Console.WriteLine("---- From OCTAL ----");

			b = new OctalSystem("12");
			binary = b.To(NumberBase.BINARY);
			octal = b.To(NumberBase.OCTAL);
			dec = b.To(NumberBase.DECIMAL);
			hexadecimal = b.To(NumberBase.HEXADECIMAL);

			Console.WriteLine($"({b.Value})({(int)NumberBase.OCTAL}) = ({binary}){(int)NumberBase.BINARY}");
			Console.WriteLine($"({b.Value})({(int)NumberBase.OCTAL}) = ({octal}){(int)NumberBase.OCTAL}");
			Console.WriteLine($"({b.Value})({(int)NumberBase.OCTAL}) = ({dec}){(int)NumberBase.DECIMAL}");
			Console.WriteLine($"({b.Value})({(int)NumberBase.OCTAL}) = ({hexadecimal}){(int)NumberBase.HEXADECIMAL}");

			OctalSystem oct = new OctalSystem("1324316");
			Console.WriteLine($"({oct.Value}) ToDecimal: {oct.ToDecimal()}");
			Console.WriteLine($"({oct.Value}) ToBinary: {oct.ToBinary()}");
			Console.WriteLine($"({oct.Value}) ToHexadecimal: {oct.ToHexadecimal()}");

			Console.WriteLine("---- From DECIMAL ----");

			b = new DecimalSystem("10");
			binary = b.To(NumberBase.BINARY);
			octal = b.To(NumberBase.OCTAL);
			dec = b.To(NumberBase.DECIMAL);
			hexadecimal = b.To(NumberBase.HEXADECIMAL);


			Console.WriteLine($"({b.Value})({(int)NumberBase.DECIMAL}) = ({binary}){(int)NumberBase.BINARY}");
			Console.WriteLine($"({b.Value})({(int)NumberBase.DECIMAL}) = ({octal}){(int)NumberBase.OCTAL}");
			Console.WriteLine($"({b.Value})({(int)NumberBase.DECIMAL}) = ({dec}){(int)NumberBase.DECIMAL}");
			Console.WriteLine($"({b.Value})({(int)NumberBase.DECIMAL}) = ({hexadecimal}){(int)NumberBase.HEXADECIMAL}");

			DecimalSystem dcl = new DecimalSystem("2024");
			Console.WriteLine($"({dcl.Value}) ToOctal: {dcl.ToOctal()}");
			Console.WriteLine($"({dcl.Value}) ToBinary: {dcl.ToBinary()}");
			Console.WriteLine($"({dcl.Value}) ToHexadecimal: {dcl.ToHexadecimal()}");

			Console.WriteLine("---- From HEXADECIMAL ----");


			b = new HexadecimalSystem("A");
			binary = b.To(NumberBase.BINARY);
			octal = b.To(NumberBase.OCTAL);
			dec = b.To(NumberBase.DECIMAL);
			hexadecimal = b.To(NumberBase.HEXADECIMAL);

			Console.WriteLine($"({b.Value})({(int)NumberBase.HEXADECIMAL}) = ({binary}){(int)NumberBase.BINARY}");
			Console.WriteLine($"({b.Value})({(int)NumberBase.HEXADECIMAL}) = ({octal}){(int)NumberBase.OCTAL}");
			Console.WriteLine($"({b.Value})({(int)NumberBase.HEXADECIMAL}) = ({dec}){(int)NumberBase.DECIMAL}");
			Console.WriteLine($"({b.Value})({(int)NumberBase.HEXADECIMAL}) = ({hexadecimal}){(int)NumberBase.HEXADECIMAL}");

			HexadecimalSystem hexa = new HexadecimalSystem("2024ef");
			Console.WriteLine($"({hexa.Value}) ToOctal: {hexa.ToOctal()}");
			Console.WriteLine($"({hexa.Value}) ToBinary: {hexa.ToBinary()}");
			Console.WriteLine($"({hexa.Value}) ToDecimal: {hexa.ToDecimal()}");
		}
	}
}
