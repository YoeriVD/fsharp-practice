module Bmi

open MathPipes

let calculateBmi weight height =
    weight
    |> divideBy (height * height)
    |> roundByOne
    

let evaluateBmi bmi =
    match bmi with
    | bmiValue when bmiValue < 18.5 -> "Ondergewicht"
    | bmiValue when bmiValue >= 18.5 && bmiValue <= 24.9 -> "Normaal"
    | bmiValue when bmiValue >= 25.0 && bmiValue <= 29.9 -> "Overgewicht"
    | _ -> "Gezondheidsrisico"
    
// define a type for the bmi
type Bmi = {
    weight: float
    height: float
    bmi: float
    evaluation: string
}

// define a function to calculate the bmi, reuse existing functions
let bmi weight height =
    let bmi = calculateBmi weight height
    let evaluation = evaluateBmi bmi
    { weight = weight; height = height; bmi = bmi; evaluation = evaluation }

// define a function to pretty print the bmi
let printBmi bmi =
    printfn "Gewicht: %f" bmi.weight
    printfn "Lengte: %f" bmi.height
    printfn "BMI: %f" bmi.bmi
    printfn "Evaluatie: %s" bmi.evaluation