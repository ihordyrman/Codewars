// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let makeUpperCase (s: string) = s.ToUpper()

    printf "%s" (makeUpperCase "hello friends")
    0 // return an integer exit code

