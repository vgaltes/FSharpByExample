module FizzBuzz.Tests

open NUnit.Framework

let fizzBuzz input = 
    if input = 3 then "Fizz"
    else input.ToString()

[<Test>]
let ``the number 1 is fizzBuzzed as is`` () =
    Assert.That ("1" = fizzBuzz 1)

[<Test>]
let ``the number 2 is fizzBuzzed as is`` () =
    Assert.That ("2" = fizzBuzz 2)

[<Test>]
let ``the number 3 is fizzBuzzed as Fizz`` () =
    Assert.That ("Fizz" = fizzBuzz 3)

[<Test>]
let ``the number 4 is returned as is`` () =
    Assert.That ("4" = fizzBuzz 4)
