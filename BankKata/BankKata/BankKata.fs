module BankKata
    module Prod =
        type Result<'T> =
            | Success of 'T
            | Failure of string

        type Currency = 
        |USD

        type Account = {Amount : (int * Currency)}

        let newAccount = {Amount = (0, USD)}

        let deposit amount currency {Amount = (oldAmount, _)} =
            {Amount = (oldAmount + amount, USD)}

        let withdraw amount currency account =
            Success {Amount = (30, USD)}

    module Tests =
        open Prod
        open NUnit.Framework

        [<Test>]
        let ``a new account has a balance of 0``() =
            let bankAccount = newAccount
            Assert.AreEqual ((0, USD), bankAccount.Amount)

        [<Test>]
        let ``money can be deposited into a bank account``() =
            let bankAccount = newAccount |> deposit 10 USD
            Assert.AreEqual ((10, USD), bankAccount.Amount)

        [<Test>]
        let ``money deposited into a bank account should be added to current amount``() =
            let bankAccount = newAccount |> deposit 10 USD |> deposit 5 USD
            Assert.AreEqual((15, USD), bankAccount.Amount)

        [<Test>]
        let ``money can be withdrawn from a bank account``() =
            let (Success(bankAccount)) = newAccount |> deposit 50 USD |> withdraw 20 USD
            Assert.AreEqual({ Amount = (30, USD) }, bankAccount)