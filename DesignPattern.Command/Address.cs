namespace DesignPattern.Command
{
    public class Address : IValidatable
    {
        public string Street { get; set; }
        public string Locality { get; set; }
        public string PostCode { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        #region IValidatable Members

        public bool IsValid()
        {
            if (string.IsNullOrEmpty(Street))
            {
                return false;
            }

            if (string.IsNullOrEmpty(Locality))
            {
                return false;
            }

            if (string.IsNullOrEmpty(PostCode))
            {
                return false;
            }

            if (string.IsNullOrEmpty(State))
            {
                return false;
            }

            if (string.IsNullOrEmpty(Country))
            {
                return false;
            }

            return true;
        }

        #endregion
    }
}
