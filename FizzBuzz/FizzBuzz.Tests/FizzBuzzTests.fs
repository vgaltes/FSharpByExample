module FizzBuzz
    module Prod =
        let fizzBuzz input = 
            match (input % 3, input % 5) with
            | (0, 0) -> "FizzBuzz"
            | (0, _) -> "Fizz"
            | (_, 0) -> "Buzz"
            | (_, _) -> input.ToString()


    module Tests =
        open Prod
        open NUnit.Framework 

        [<TestCase(1, "1")>]
        [<TestCase(2, "2")>]
        [<TestCase(3, "Fizz")>]
        [<TestCase(4, "4")>]
        [<TestCase(5, "Buzz")>]
        [<TestCase(6, "Fizz")>]
        [<TestCase(9, "Fizz")>]
        [<TestCase(10, "Buzz")>]
        [<TestCase(15, "FizzBuzz")>]
        [<TestCase(30, "FizzBuzz")>]
        let ``the number is fizzBuzzed``(number:int, expectedOutput:string) =
            Assert.That (fizzBuzz number = expectedOutput)
