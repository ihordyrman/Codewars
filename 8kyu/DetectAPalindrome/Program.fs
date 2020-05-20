// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let is_palindrome list =
        list = List.rev list
    0 // return an integer exit code
