module MathPipesTests

open Xunit
open MathPipes

[<Theory>]
[<InlineData(1.01, 1, 1.0)>]
[<InlineData(1.09, 1, 1.1)>]
let ``roundBy should round to the number of digits provided`` a b (expected: decimal) =
    let result = a
                 |> roundBy b
                 |> decimal
    Assert.Equal(expected, result)



[<Theory>]
[<InlineData(10, 2, 5)>]
[<InlineData(10, 5, 2)>]
[<InlineData(9, 3, 3)>]
[<InlineData(5, 2, 2.5)>]
let ``divideBy should calculate division`` a b (expected: decimal) =
    let result = a
                 |> divideBy b
                 |> decimal
    Assert.Equal(expected, result)