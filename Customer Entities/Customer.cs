using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poppel_Ordering_System.Customer_Entities
{
    class Customer
    {
        #region Fields
        private int customerID;
        private string firstName;
        private string lastName;
        private string creditStatus;
        #endregion

        #region Construtors
        public Customer()
        {
            customerID = 0;
            firstName = null;
            lastName = null;
            creditStatus = null;
        }

        public Customer(int cID, string fName, string lName, string cStatus)
        {
            customerID = cID;
            firstName = fName;
            lastName = lName;
            creditStatus = cStatus;
        }
        #endregion

        #region Properties
        public int CustomerID
        {
            get
            {
                return customerID;
            }

            set
            {
                customerID = value;
            }
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }

        public string CreditStatus
        {
            get
            {
                return creditStatus;
            }

            set
            {
                creditStatus = value;
            }
        }
        #endregion
    }
}
