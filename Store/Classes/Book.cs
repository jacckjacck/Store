﻿using System;

namespace Store.Classes
{
    public class Book
    {

		#region Fields
		
		private string editorial;
		private int stock;
		private int quantity;
		
		#endregion

		#region Properties
		public string Author { get; set; }
		public string Title { get; set; }

		public string Editorial
		{
			get { return editorial; }
			set
			{
				editorial = $"Editorial {value} setted on {DateTime.Now.Year}";
			}
		}

		public int Stock
		{
			get
			{
				if (stock < 0)
				{
					return 0;
				}

				return stock;
			}
			private set
			{
				stock = value;
			}
		}

		public int Quantity
		{
			get { return quantity; }
			set
			{
				if (value <= 0)
				{
					throw new Exception("You can only assign a value greater or equal to 1 in quantity for the book");
				}
				quantity = value;
			}
		}
		#endregion

		#region Constructors

		public Book(string title, string author, string editorial, int stock = 0)
		{
			Title = title;
			Author = author;
			Editorial = editorial;
			Stock = stock;
		}
		#endregion

		#region Public Methods

		public int GetRealStock()
		{
			return stock;
		}

		public void AddStock(int quantity)
		{
			Stock += quantity;

		}
		#endregion

		#region Private Methods		

		#endregion

	}
}
