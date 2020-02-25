using System;

namespace Store.Classes
{
    public class Product
    {
        #region Fields

        private int stock;
		private int quantity;
		private double unitPrice;


		#endregion

		#region Properties

		public string Description { get; set; }

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

		public double UnitPrice
		{
			get { return unitPrice; }
		}

		#endregion

		#region Constructors

		public Product(string description, int stock, double unitPrice)
		{
			Description = description;
			this.unitPrice = unitPrice;
			AddStock(stock);
		}

		#endregion

		#region Public Methods

		public void AddStock(int quantity)
		{
			stock += quantity;

		}

		public int GetRealStock()
		{
			return stock;
		}

		public virtual double GetTotal()
		{
			if (Quantity <= 0)
			{
				throw new Exception("There aren't products added");
			}
			return Quantity * UnitPrice;
		}
		#endregion

	}
}
