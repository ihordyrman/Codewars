// Learn more about F# at http://fsharp.org

open System
open System.Collections.Generic

[<EntryPoint>]
let main argv =
    let expressionMatter (a: int) (b: int) (c: int): int =
        Math.Max(Math.Max(Math.Max(a * (b + c), a * b * c), Math.Max(a + b * c, (a + b) * c)), a + b + c)

    let anotherExpression (a: int) (b: int) (c: int): int =
        (max (a + b + c) (a * b * c), max ((a + b) * c) (a * (b + c))) ||> max

    let reduceExpression (a: int) (b: int) (c: int): int =
        [a+b+c; a*(b+c); a*b*c; a+(b*c); (a+b)*c] |> List.reduce max

    let arrayMaxExpression (a: int) (b: int) (c: int): int =
        Array.max [|a+b+c; a*(b+c); a*b*c; a+(b*c); (a+b)*c|]
    0 // return an integer exit code
