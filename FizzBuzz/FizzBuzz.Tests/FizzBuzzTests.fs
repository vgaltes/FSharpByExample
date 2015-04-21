module FizzBuzz.Tests

open NUnit.Framework

let fizzBuzz input = if input = 1 then "1" else "2"

[<Test>]
let ``the number 1 is returned as is`` () =
    Assert.That ("1" = fizzBuzz 1)

[<Test>]
let ``the number 2 is returned as is`` () =
    Assert.That ("2" = fizzBuzz 2)