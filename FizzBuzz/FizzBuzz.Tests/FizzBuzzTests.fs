module FizzBuzz.Tests

open NUnit.Framework

let fizzBuzz input = 
    if input % 15 = 0 then "FizzBuzz"
    elif input % 3 = 0 then "Fizz"
    elif input % 5 = 0 then "Buzz"
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
let ``the number 4 is fizzBuzzed as is`` () =
    Assert.That ("4" = fizzBuzz 4)

[<Test>]
let ``the number 5 is fizzBuzzed as Buzz`` () =
    Assert.That ("Buzz" = fizzBuzz 5)

[<Test>]
let ``the number 6 is fizzBuzzed as Fizz`` () =
    Assert.That ("Fizz" = fizzBuzz 6)

[<Test>]
let ``the number 9 is fizzBuzzed as Fizz`` () =
    Assert.That ("Fizz" = fizzBuzz 9)

[<Test>]
let ``the number 10 is fizzBuzzed as Buzz`` () =
    Assert.That ("Buzz" = fizzBuzz 10)

[<Test>]
let ``the number 15 is fizzBuzzed as FizzBuzz`` () =
    Assert.That ("FizzBuzz" = fizzBuzz 15)

[<Test>]
let ``the number 30 is fizzBuzzed as FizzBuzz`` () =
    Assert.That ("FizzBuzz" = fizzBuzz 30)