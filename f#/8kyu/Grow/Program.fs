// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let Grow (x : int[]) = x |> Array.reduce (*)

    printf "%i" (Grow [|4; 5; 6|])
    0 // return an integer exit code
