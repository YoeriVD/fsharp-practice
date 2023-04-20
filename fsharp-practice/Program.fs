module Program


open Bmi
    
[<EntryPoint>]
let main argv =
            bmi 81 1.74 
            |> evaluateBmi
            |> printf "%s"
            0