// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let past h m s =
        let hours = if h > 0 then h * 3600000 else 0
        let minutes = if m > 0 then m * 60000 else 0
        let seconds = if s > 0 then s * 1000 else 0
        hours + minutes + seconds

    let betterPast h m s = 1000 * (h*3600 + m*60 + s)
    0 // return an integer exit code
