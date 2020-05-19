// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let binToDec s = Convert.ToInt32(s, 2)

    let anotherBinToDec (s: string) =
        s
        |> Seq.map (fun x -> int x - int '0')
        |> Seq.mapi (fun i x -> (float x) * (2.00 ** (float (String.length s - i-1))))
        |> Seq.reduce (+)
        |> int
    0 // return an integer exit code
