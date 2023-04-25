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
[<InlineData(1.01, 1.0)>]
[<InlineData(1.09, 1.1)>]
[<InlineData(1.0999999, 1.1)>]
[<InlineData(1.0999, 1.1)>]
[<InlineData(1.09999, 1.1)>]
let ``roundByOne should round to one digit after comma`` a (expected: decimal) =
    let result = a
                 |> roundByOne
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
    
    
[<Theory>]
[<InlineData(1, 1, 1)>]
[<InlineData(2, 2, 4)>]
[<InlineData(2, 3, 8)>]
[<InlineData(3, 2, 9)>]
[<InlineData(3, 3, 27)>]
let ``powerBy should multiply a with itself for amount b`` a b (expected: decimal) =
    let result = a
                 |> powerBy b
                 |> decimal
    Assert.Equal(expected, result)
    
    
[<Theory>]
[<InlineData(2, 4)>]
[<InlineData(3, 9)>]
let ``square should multiply a with itself twice`` a (expected: decimal) =
    let result = a
                 |> square
                 |> decimal
    Assert.Equal(expected, result)