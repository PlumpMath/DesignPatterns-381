using System.Collections.Generic;

namespace DesignPattern.Command
{
    public class Person : IValidatable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        #region IValidatable Members

        public bool IsValid()
        {
            if(string.IsNullOrEmpty(FirstName))
            {
                return false;
            }

            if(string.IsNullOrEmpty(LastName))
            {
                return false;
            }

            return true;
        }

        #endregion
    }
}
