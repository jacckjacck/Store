using System;

namespace Store.Classes
{
    public class Book : Product
    {

		#region Fields
		
		private string editorial;
		
		#endregion

		#region Properties
		public string Author { get; set; }

		public string Editorial
		{
			get { return editorial; }
			set
			{
				editorial = $"Editorial {value} setted on {DateTime.Now.Year}";
			}
		}

		
		#endregion

		#region Constructors

		public Book(string description, string author, string editorial, double unitPrice, int stock = 0)
			: base (description, stock, unitPrice)
		{
			Author = author;
			Editorial = editorial;
		}
		#endregion

		#region Public Methods
		
		#endregion

		#region Private Methods		

		#endregion

	}
}
