// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let century year = year / 100 + if year % 100 = 0 then 0 else 1
    0 // return an integer exit code
