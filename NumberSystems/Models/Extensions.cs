namespace NumberSystems.Models
{


	/// <summary>Class that contains extension methods to convert number from one base to another</summary>
	public static class Extensions
	{
		public static void Guard(this string source, string allowedCharacter, NumberBase numberBase)
		{
			foreach (var character in source)
			{
				if (!allowedCharacter.Contains(character))
				{
					throw new InvalidOperationException($"'{source}' is invalid {numberBase}");
				}
			}
		}

		public static string To<T>(this T source, NumberBase toBase) where T : Base
		{
			NumberBase fromBase;
			switch (source)
			{
				case BinarySystem: fromBase = NumberBase.BINARY; break;
				case OctalSystem: fromBase = NumberBase.OCTAL; break;
				case DecimalSystem: fromBase = NumberBase.DECIMAL; break;
				case HexadecimalSystem: fromBase = NumberBase.HEXADECIMAL; break;
				default: fromBase = NumberBase.DECIMAL; break;

			}
			//The Convert.ToInt32 method converts the input string from the original base (fromBase) to a base 10 integer.(support base 2,8,10,16)
			//The Convert.ToString method converts the base 10 integer to the string representation in the target base (toBase).					
			return Convert.ToString(Convert.ToInt32(source.Value, (int)fromBase), (int)toBase);
		}

		// 1) Decimal System

		/// <summary>
		/// Extension Method to convert the decimal value of <paramref name="source"/> to <paramref name="toBase"/> 
		/// </summary> 
		/// <param name="source">
		/// Number system Instance to convert
		/// </param> 
		/// <returns>A string value as a result of conversion from decimal system to binary</returns>
		public static string ToBinary(this DecimalSystem source) =>
		   source.To(NumberBase.BINARY);

		/// <summary>
		/// Extension Method to convert the decimal value of <paramref name="source"/> to <paramref name="toBase"/> 
		/// </summary> 
		/// <param name="source">
		/// Number system Instance to convert
		/// </param> 
		/// <returns>A string value as a result of conversion from decimal system to octal</returns>
		public static string ToOctal(this DecimalSystem source) =>
			source.To(NumberBase.OCTAL);

		/// <summary>
		/// Extension Method to convert the decimal value of <paramref name="source"/> to <paramref name="toBase"/> 
		/// </summary> 
		/// <param name="source">
		/// Number system Instance to convert
		/// </param> 
		/// <returns>A string value as a result of conversion from decimal system to hexadecimal</returns>
		public static string ToHexadecimal(this DecimalSystem source) =>
		 source.To(NumberBase.HEXADECIMAL);

		// 2) Hexadecimal System


		/// <summary>
		/// Extension Method to convert the hexadecimal value of <paramref name="source"/> to <paramref name="toBase"/> 
		/// </summary> 
		/// <param name="source">
		/// Number system Instance to convert
		/// </param> 
		/// <returns>A string value as a result of conversion from hexadecimal system to binary</returns>
		public static string ToBinary(this HexadecimalSystem source) =>
			 source.To(NumberBase.BINARY);

		/// <summary>
		/// Extension Method to convert the hexadecimal value of <paramref name="source"/> to <paramref name="toBase"/> 
		/// </summary> 
		/// <param name="source">
		/// Number system Instance to convert
		/// </param> 
		/// <returns>A string value as a result of conversion from hexadecimal system to octal</returns>
		public static string ToOctal(this HexadecimalSystem source) =>
			  source.To(NumberBase.OCTAL);

		/// <summary>
		/// Extension Method to convert the hexadecimal value of <paramref name="source"/> to <paramref name="toBase"/> 
		/// </summary> 
		/// <param name="source">
		/// Number system Instance to convert
		/// </param> 
		/// <returns>A string value as a result of conversion from hexadecimal system to decimal</returns>
		public static string ToDecimal(this HexadecimalSystem source) =>
			  source.To(NumberBase.DECIMAL);

		// 3) Octal System

		/// <summary>
		/// Extension Method to convert the Octal value of <paramref name="source"/> to <paramref name="toBase"/> 
		/// </summary> 
		/// <param name="source">
		/// Number system Instance to convert
		/// </param> 
		/// <returns>A string value as a result of conversion from octal system to binary</returns>
		public static string ToBinary(this OctalSystem source) =>
		   source.To(NumberBase.BINARY);

		/// <summary>
		/// Extension Method to convert the Octal value of <paramref name="source"/> to <paramref name="toBase"/> 
		/// </summary> 
		/// <param name="source">
		/// Number system Instance to convert
		/// </param> 
		/// <returns>A string value as a result of conversion from octal system to decimal</returns>
		public static string ToDecimal(this OctalSystem source) =>
		   source.To(NumberBase.DECIMAL);

		/// <summary>
		/// Extension Method to convert the Octal value of <paramref name="source"/> to <paramref name="toBase"/> 
		/// </summary> 
		/// <param name="source">
		/// Number system Instance to convert
		/// </param> 
		/// <returns>A string value as a result of conversion from octal system to hexadecimal</returns>
		public static string ToHexadecimal(this OctalSystem source) =>
		   source.To(NumberBase.HEXADECIMAL);

		// 4) Binary System

		/// <summary>
		/// Extension Method to convert the Binary value of <paramref name="source"/> to <paramref name="toBase"/> 
		/// </summary> 
		/// <param name="source">
		/// Number system Instance to convert
		/// </param> 
		/// <returns>A string value as a result of conversion from Binary system to octal</returns>
		public static string ToOctal(this BinarySystem source) =>
		  source.To(NumberBase.OCTAL);

		/// <summary>
		/// Extension Method to convert the Binary value of <paramref name="source"/> to <paramref name="toBase"/> 
		/// </summary> 
		/// <param name="source">
		/// Number system Instance to convert
		/// </param> 
		/// <returns>A string value as a result of conversion from Binary system to decimal</returns>
		public static string ToDecimal(this BinarySystem source) =>
		   source.To(NumberBase.DECIMAL);

		/// <summary>
		/// Extension Method to convert the Binary value of <paramref name="source"/> to <paramref name="toBase"/> 
		/// </summary> 
		/// <param name="source">
		/// Number system Instance to convert
		/// </param> 
		/// <returns>A string value as a result of conversion from Binary system to hexadecimal</returns>
		public static string ToHexadecimal(this BinarySystem source) =>
			source.To(NumberBase.HEXADECIMAL);
	}
}
