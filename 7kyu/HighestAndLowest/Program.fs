// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let highAndLow (str : string) =
        str.Split()
        |> Array.sortBy int
        |> (fun a -> a |> Array.last, a |> Array.head)
        ||> sprintf "%s %s"

    0 // return an integer exit code
