// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let findShort (str: string) =
        str.Split ' '
        |> Array.minBy String.length
        |> String.length

    let anotherFindShort (str: string) =
        str.Split ' '
        |> Array.map (fun x -> x.Length)
        |> Array.min

    let oneMoreFindShort (str: string) =
        str.Split ' '
        |> Array.toList
        |> List.minBy String.length
        |> String.length

    printfn "%i" (anotherFindShort "jehel asd hafdhasfhas afsdfas asdasdgax")
    0 // return an integer exit code
