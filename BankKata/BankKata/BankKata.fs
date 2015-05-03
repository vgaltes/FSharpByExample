module BankKata
    module Prod =
        

    module Tests =
        
        open NUnit.Framework

        [<Test>]
        let ``a new account has a balance of 0``() =
            let bankAccount = newAccount
            Assert.AreEqual ((0, USD), bankAccount.Amount)
