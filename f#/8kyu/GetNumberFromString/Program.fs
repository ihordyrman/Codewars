// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let getNumberFromString (s: string) =
        s |> String.filter System.Char.IsDigit |> System.Int32.Parse
    0 // return an integer exit code
