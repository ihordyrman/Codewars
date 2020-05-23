// Learn more about F# at http://fsharp.org

// https://www.codewars.com/kata/558fc85d8fd1938afb000014
// Create a function that returns the sum of the two lowest positive numbers given an array
// of minimum 4 positive integers. No floats or non-positive integers will be passed.
// For example, when an array is passed like [19, 5, 42, 2, 77], the output should be 7.
// [10, 343445353, 3453445, 3453545353453] should return 3453455.

open System

[<EntryPoint>]
let main argv =
    let sumTwoSmallestNumbers (numbers: Int64 []): int64 =
        numbers
        |> Array.sort
        |> Array.take 2
        |> Array.sum

    let anotherTwoSmallestNumbers numbers =
        let sorted = Array.sort numbers
        sorted.[0] + sorted.[1]
    0 // return an integer exit code
