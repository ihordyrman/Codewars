// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let hello name =
        match name with
        | Some name -> "Hello, " + name
        | None -> "Hello World"
    0 // return an integer exit code
