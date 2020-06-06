// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let hello s =
        match s with
        | "" -> "Hello, World!"
        | _  -> "Hello, " + System.Char.ToUpper(s.[0]).ToString() + s.Substring(1).ToLower() + "!"
    0 // return an integer exit code
