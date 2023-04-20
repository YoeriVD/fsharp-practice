module MathTests

open Xunit
open Math

[<Theory>]
[<InlineData(1, 1)>]
[<InlineData(2, 4)>]
[<InlineData(3, 9)>]
[<InlineData(2.5, 6.25)>]
let ``Square should power a number by 2`` input expected =
    let result = square input
    Assert.Equal(expected, result)


[<Theory>]
[<InlineData(1, 1, 1)>]
[<InlineData(2, 2, 4)>]
[<InlineData(2, 4, 8)>]
let ``multiplyWith should multiply a number by another`` a b expected =
    let result = multiplyWith a b
    Assert.Equal(expected, result)
    
[<Theory>]
[<InlineData(1, 1, 1)>]
[<InlineData(1, 2, 0.5)>]
[<InlineData(4, 2, 2)>]
let ``devideBy should devide a number by another`` a b expected =
    let result = devideBy a b
    Assert.Equal(expected, result)