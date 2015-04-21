module FizzBuzz.Tests

open NUnit.Framework

let fizzBuzz input = "1"

[<Test>]
let ``the number 1 is returned as is`` () =
    Assert.That ("1" = fizzBuzz 1)