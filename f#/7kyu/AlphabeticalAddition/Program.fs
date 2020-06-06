// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let rec getCharacter (x: int): char =
        match x with
        | x when x > 0 && x < 27 -> char (x + 96)
        | x when x = 0 -> 'z'
        | _ -> getCharacter (x - 26)

    let addLetters (arr: List<char>): char =
        arr
        |> List.map (fun x -> int x - 96)
        |> List.sum
        |> fun x -> getCharacter (x)


    printfn "%c" (addLetters [])
    printfn "%c" (addLetters [ 'a'; 'b'; 'c' ])
    printfn "%c" (addLetters [ 'z'; 'a' ])
    0 // return an integer exit code
