module Tests

open System
open Xunit
open Homework5


[<Fact>]
let ``AllIsGoodWithAdd`` () =
    let actual = Program.main [|"20.89";"+";"5"|]
    Assert.Equal(actual,0)
    
[<Fact>]
let ``AllIsGoodWithSubstract`` () =
    let actual = Program.main [|"20.3";"-";"5"|]
    Assert.Equal(actual,0)
    
[<Fact>]
let ``AllIsGoodWithMultiply`` () =
    let actual = Program.main [|"20";"*";"5"|]
    Assert.Equal(actual,0)
 
[<Fact>]
let ``AllIsGoodWithDivide`` () =
    let actual = Program.main [|"20";"/";"5.76"|]
    Assert.Equal(actual,0)
    
[<Fact>]
let ``WrongLength`` () =
    let actual = Program.main [|"20";"/";"5";"0"|]
    Assert.Equal(actual, 2)

[<Fact>]
let ``WrongArgFormat`` () =
    let actual = Program.main [|"+";"+";"2"|]
    Assert.Equal(actual, 1)


[<Fact>]
let ``DivideByZero`` () =
    let actual = Program.main [|"1";"/";"0"|]
    Assert.Equal(actual, 4)
    

[<Fact>]
let ``WrongOperationFormat`` () =
    let actual = Program.main [|"1";"$$";"0"|]
    Assert.Equal(actual, 3);