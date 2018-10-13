using System;
using Xunit;
using Lab02_UnitTesting;

namespace Lab02_Unit_Testing
{
    public class UnitTest1
    {   
        // test to view account balance in the beginning
        [Fact]
        public void CanReturnDefaultBalance()
        {
            // reset the balance to zero so other tests don't interfere
            Program.updateBalance(0);
            Assert.Equal(0, Program.ViewBalance());
        }

        // test to deposit money
        [Fact]
        public void CanDepositMoney()
        {
            // reset the balance to zero so other tests don't interfere
            Program.updateBalance(0);
            Program.deposit(5);
            Assert.Equal(5, Program.ViewBalance());
        }

        // test to ensure deposit does not accept negative amount
        [Fact]
        public void CannotDepositNegativeAmount()
        {
            // reset the balance to zero so other tests don't interfere
            Program.updateBalance(0);
            Program.deposit(-5);
            Assert.Equal(0, Program.ViewBalance());
        }

        // test to ensure money can be withdrawn
        [Fact]
        public void CanWithdrawMoney()
        {
            // reset the balance to zero so other tests don't interfere
            Program.updateBalance(0);
            Program.deposit(5);
            Program.withdraw(3);
            Assert.Equal(2, Program.ViewBalance());
        }

        // test to ensure money cannot be withdrawn if it results in balance less than zero
        [Fact]
        public void CannotWithdrawMoney()
        {
            // reset the balance to zero so other tests don't interfere
            Program.updateBalance(0);
            Program.deposit(5);
            Program.withdraw(6);
            Assert.Equal(5, Program.ViewBalance());
        }
    }
}
