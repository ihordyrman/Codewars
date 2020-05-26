// Learn more about F# at http://fsharp.org

// https://www.codewars.com/kata/566fc12495810954b1000030/train/fsharp

// Take an integer n (n >= 0) and a digit d (0 <= d <= 9) as an integer.
// Square all numbers k (0 <= k <= n) between 0 and n.
// Count the numbers of digits d used in the writing of all the k**2. Call nb_dig (or nbDig or ...)
// the function taking n and d as parameters and returning this count.
open System
open System.Collections.Generic
open System.Linq

[<EntryPoint>]
let main argv =
    let nbDig (n: int) (d: int) =
        [ for i in 0 .. n -> (i * i).ToString().Count(fun x -> x = char (48 + d)) ]
        |> List.sum

    let anotherNbDig (n: int) (d: int) =
        let dc =
            d
            |> string
            |> char
        [| for i in 0 .. n -> i * i |> string |]
        |> Array.map
            (Seq.sumBy (fun x ->
                if x = dc then 1 else 0))
        |> Array.sum

    let oneMoveNbDig (n: int) (d: int) =
        let sq n = n * n
        let dc =
            d
            |> string
            |> char
        [ 0 .. n ]
        |> Seq.map (sq >> string)
        |> String.concat ""
        |> Seq.filter ((=) dc)
        |> Seq.length

//    printfn "%A" (nbDig 10 1)
//    printfn "%A" (anotherNbDig 11011 2)
    printfn "%A" (oneMoveNbDig 12224 8)
    0 // return an integer exit code
