// Learn more about F# at http://fsharp.org

[<EntryPoint>]
let main argv =
    let hexToDec (s:string) =
//        if s.Contains("-") then -Double.Parse(s.Replace("-", ""), System.Globalization.NumberStyles.HexNumber)
//            else Double.Parse(s, System.Globalization.NumberStyles.HexNumber);
        System.Convert.ToInt64(s, 16) |> float
    0 // return an integer exit code
