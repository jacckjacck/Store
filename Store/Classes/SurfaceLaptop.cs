namespace Store.Classes
{
    public class SurfaceLaptop : Product
    {

        #region Constructors

        public SurfaceLaptop(string description, int stock, double unitPrice) : base(description, stock, unitPrice)
        {
        }

        #endregion

        #region Public Methods

        public override double GetTotal()
        {
            if (Quantity > 5)
            {
                return (Quantity * UnitPrice) - ((Quantity * UnitPrice) * 0.1);
            }

            return base.GetTotal();
        }

        #endregion

    }
}
