// Learn more about F# at http://fsharp.org

open System
open System.Text

[<EntryPoint>]
let main argv =
    let removeExclamationMarks (s:string) = s.Replace("!", "")

    printfn "%s" (removeExclamationMarks "Hello world!")
    0 // return an integer exit code
