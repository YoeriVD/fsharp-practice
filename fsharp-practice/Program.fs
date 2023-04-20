module Program


open Bmi
    
[<EntryPoint>]
let main args =
    bmi 81 1.74 
    |> evaluateBmi
    |> printf "%s"
    0