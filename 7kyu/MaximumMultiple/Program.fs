// Learn more about F# at http://fsharp.org

// https://www.codewars.com/kata/5aba780a6a176b029800041c/train/fsharp

// Given a Divisor and a Bound , Find the largest integer N , Such That ,

// Conditions :
// N is divisible by divisor
// N is less than or equal to bound
// N is greater than 0.

// Notes
// The parameters (divisor, bound) passed to the function are only positve values .
// It's guaranteed that a divisor is Found .

open System

[<EntryPoint>]
let main argv =
    let maxMultiple d b = 
        let mutable value = b
        while value % d <> 0 do
            value <- value - 1
        value

    let maxMultiple2 d b = b - b % d

    let maxMultiple3 d b = 
        [1 .. b]
        |> List.filter (fun x -> x % d = 0)
        |> List.max

    printfn "%i" (maxMultiple 2 7)
    printfn "%i" (maxMultiple2 2 7)
    0 // return an integer exit code
