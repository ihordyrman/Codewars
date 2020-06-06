// Learn more about F# at http://fsharp.org

// https://www.codewars.com/kata/54da5a58ea159efa38000836/train/fsharp
// Given an array, find the integer that appears an odd number of times.
// There will always be only one integer that appears an odd number of times.

open System

[<EntryPoint>]
let main argv =
    let inline findOdd (numbers: List<int>) =
        numbers
        |> List.countBy id
        |> List.find (fun (_, count) -> count % 2 = 1)
        |> fst

    let cleverFindOdd numbers = List.reduce (^^^)

    let n = [20; 1; -1; 2; -2; 3; 3; 5; 5; 1; 2; 4; 20; 4; -1; -2; 5]
    printfn "%A" (findOdd n)
    printfn "%A" (cleverFindOdd n)
    0 // return an integer exit code
