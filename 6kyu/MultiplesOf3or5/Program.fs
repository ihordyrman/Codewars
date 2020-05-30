// Learn more about F# at http://fsharp.org

// https://www.codewars.com/kata/514b92a657cdc65150000006/train/fsharp

// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. 
// The sum of these multiples is 23.
// Finish the solution so that it returns the sum of all the multiples of 3 or 5 below the number passed in.
// Note: If the number is a multiple of both 3 and 5, only count it once.

open System

[<EntryPoint>]
let main argv =
    let solve n = 
        seq { 1 .. n - 1} 
        |> Seq.filter (fun x -> x % 3 = 0 || x % 5 = 0) 
        |> Seq.sum

    let anotherSolve n = 
        seq { for x in 3..(n - 1) do if x % 3 = 0 || x % 5 = 0 then yield x } 
        |> Seq.sum

    printfn "%A" (solve 12)
    printfn "%A" (anotherSolve 12)
    0 // return an integer exit code
