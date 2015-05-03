module BankKata
    module Prod =
        type Currency = 
        |USD

        type Account = {Amount : (int * Currency)}

        let newAccount = {Amount = (20, USD)}

    module Tests =
        open Prod
        open NUnit.Framework

        [<Test>]
        let ``a new account has a balance of 0``() =
            let bankAccount = newAccount
            Assert.AreEqual ((0, USD), bankAccount.Amount)
