// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let reverseWords (str: string) =
        let words = str.Split(" ")
        Array.Reverse(words)
        let reversed = String.Join(" ", words)
        reversed

    let betterReverse (str: string) =
        str.Split ' ' |> Array.rev |> String.concat " "

    let word = reverseWords "hello friends"
    printf "%s" word
    0 // return an integer exit code
