// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let seven(m: int) =
        let mutable steps: int = 0
        let mutable value = m
        while value > 99 do
            value <- (value / 10 - 2 * (value % 10))
            steps <- steps + 1
        (value, steps)

    let sevenWithRecursion(m: int) =
        let rec helper(n, cnt) =
            match n with
            | x when x < 100 -> (n, cnt)
            | _ -> helper((n / 10) - 2 * (n % 10), cnt + 1)
        helper(m, 0)

    let anotherSeven n =
        let rec f = function
        | n, _ as result when n < 100 -> result
        | n, steps ->
            let x, y = n / 10, n % 10
            f (x - 2 * y, steps + 1)
        f (n, 0)

    printfn "%A" (seven 371)
    printfn "%A" (sevenWithRecursion 371)
    printfn "%A" (anotherSeven 371)
    0 // return an integer exit code