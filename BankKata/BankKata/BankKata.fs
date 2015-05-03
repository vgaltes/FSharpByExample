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

        let withdraw amount currency {Amount = (oldAmount, _)} =
            match oldAmount - amount with
            | newAmount when newAmount < 0 -> Failure("This bank account cannot be overdrawn.")
            | newAmount -> Success {Amount = (oldAmount - amount, USD)}

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
            let (Success(bankAccount)) = newAccount |> deposit 50 USD |> withdraw 25 USD
            Assert.AreEqual({ Amount = (25, USD) }, bankAccount)

        [<Test>]
        let ``a bank account cannot be overdrawn``() =
            let (Failure(error)) = newAccount |> deposit 50 USD |> withdraw 100 USD
            Assert.AreEqual("This bank account cannot be overdrawn.", error)

        [<Test>]
        let ``multiple withdrawals can be chained``() =
            let (Success(bankAccount)) = newAccount |> deposit 1000 USD |> withdraw 500 USD |>> withdraw 200 USD
            Assert.AreEqual((300, USD), bankAccount.Amount)