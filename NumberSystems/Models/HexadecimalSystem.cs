
namespace NumberSystems.Models
{
	/// <summary>Class that represent the hexadecimal number system</summary>
	public class HexadecimalSystem : Base
	{
		/// <summary>
		/// Initializes a new instance of NumberSystems.Models.HexadecimalSystem class to the value indicated
		///     by a specified string parameter
		/// </summary> 
		/// <param name="value">
		/// string that hold the value of the Hexadecimal system Instance
		/// </param> 
		public HexadecimalSystem(string value)
		{
			value.Guard("0123456789ABCDEFabcdef", NumberBase.HEXADECIMAL);
			this.Value = value;
		}
	}




}
