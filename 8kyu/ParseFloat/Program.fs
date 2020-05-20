// Learn more about F# at http://fsharp.org

[<EntryPoint>]
let main argv =
    let parseFloat (s:string) =
         match System.Double.TryParse(s) with
         | (true, float) -> Some(float)
         | _ -> None
    0 // return an integer exit code
