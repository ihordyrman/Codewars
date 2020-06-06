// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let isDivisible n x y = if n % x + n % y > 0 then false else true
    let betterIsDivisible n x y = n%x + n%y = 0

    0 // return an integer exit code
