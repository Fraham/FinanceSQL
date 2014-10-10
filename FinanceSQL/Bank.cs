using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceSQL
{
    class Bank
    {
        private int bankID;
        private string name;

        public Bank(int newBankID, string newName)
        {
            BankID = newBankID;
            Name = newName;
        }

        public int BankID
        {
            get
            {
                return this.bankID;
            }
            set
            {
                this.bankID = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
    }
}
