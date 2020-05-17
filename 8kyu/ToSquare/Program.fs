// Learn more about F# at http://fsharp.org

open System
open System.Linq

[<EntryPoint>]
let main argv =
    let squareOrSquareRoot =
        Array.map (fun x ->
            let root =
                x
                |> float
                |> sqrt
                |> int
            if root * root = x then root else x * x)
    0 // return an integer exit code
