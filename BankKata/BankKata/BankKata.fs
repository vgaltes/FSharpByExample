module BankKata
    module Prod =
        let bank = ()

    module Tests =
        
        open NUnit.Framework

        [<Test>]
        let ``test framework``() = 
            Assert.IsTrue(true)
