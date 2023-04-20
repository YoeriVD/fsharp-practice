module BmiTests

open Xunit
open Bmi

[<Theory>]
[<InlineData(82, 1.74, 27.1)>]
[<InlineData(65, 1.65, 23.9)>]
let ``bmi should calculate bmi value for`` weight heigth (expectedBmi: decimal) =
    let result = bmi weight heigth
    Assert.Equal(expectedBmi, result |> decimal)
    
    
[<Theory>]
[<InlineData(27.1, "Overgewicht")>]
[<InlineData(17.1, "Ondergewicht")>]
[<InlineData(31.1, "Gezondheidsrisico")>]
let ``evaluateBmi should print textual feedback`` bmi evaluation =
    let result = evaluateBmi bmi
    Assert.Equal(evaluation, result)