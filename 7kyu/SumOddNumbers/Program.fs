// Learn more about F# at http://fsharp.org

// https://www.codewars.com/kata/55fd2d567d94ac3bc9000064

// Given the triangle of consecutive odd numbers:
//              1
//           3     5
//        7     9    11
//    13    15    17    19
// 21    23    25    27    29
// ...

// Calculate the row sums of this triangle from the row index (starting at index 1) e.g.:
// rowSumOddNumbers 1 // 1
// rowSumOddNumbers 2 // 3 + 5 = 8
open System

[<EntryPoint>]
let main argv =
    let rowSumOddNumbers n =
        let start = n * (n - 1) / 2 + 1
        let first = 2 * start - 1
        let last = 2 * (start + n) - 3
        let column = seq { first .. 2 .. last }
        column |> Seq.sum

    let CleverRowSumOddNumbers n = n * n * n

    printfn "%i" (rowSumOddNumbers 3)
    0 // return an integer exit code
