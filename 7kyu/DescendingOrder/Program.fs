// Learn more about F# at http://fsharp.org

// Your task is to make a function that can take any non-negative integer as a argument
// and return it with its digits in descending order. Essentially,
// rearrange the digits to create the highest possible number.

// Examples:
// Input: 21445 Output: 54421
// Input: 145263 Output: 654321
// Input: 123456789 Output: 987654321

[<EntryPoint>]
let main argv =
    let descendingOrder n =
        string n
        |> Seq.sort
        |> Seq.rev
        |> Seq.map string
        |> Seq.reduce (+)
        |> int

    let anotherDescending n =
        let ret = n.ToString() |> Seq.sort |> Seq.rev |> System.String.Concat
        int ret

    printfn "%i" (anotherDescending 51234168)
    printfn "%i" (descendingOrder 615134)
    0 // return an integer exit code
