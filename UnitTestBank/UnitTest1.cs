using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bank;
using System;

namespace UnitTestBank
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Debit_WithValidSmallAmount_UpdatesBalance()
        {
            //Arrange

            decimal beginningBalance = 100.00M;
            decimal debitAmount = 25.50M;
            decimal expected = 74.50M;

            //Act
            BankAccount testBankAccount = new BankAccount("Mr. Jamie Myland", beginningBalance);
            testBankAccount.Debit(debitAmount);

            //Asset
            Assert.AreEqual(expected, testBankAccount.Balance, "Account not debited correctly");
        }

        [TestMethod]
        public void Debit_WithInvalidLargeAmount_ThrowsException()
        {
            //Arrange

            decimal beginningBalance = 100.00M;
            decimal debitAmount = 999.50M;

            //Act
            BankAccount testBankAccount = new BankAccount("Mr. Jamie Myland", beginningBalance);
            

            //Asset
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => testBankAccount.Debit(debitAmount));
        }
    }
}
