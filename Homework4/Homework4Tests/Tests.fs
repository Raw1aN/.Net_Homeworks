module Tests

open System
open Homework4.Parser
open Xunit
open Homework4

[<Fact>]
let ``AllIsGoodWithAdd`` () =
    let actual = Program.main [|"20";"+";"5"|]
    Assert.Equal(actual,0)
    
[<Fact>]
let ``AllIsGoodWithSubstract`` () =
    let actual = Program.main [|"20";"-";"5"|]
    Assert.Equal(actual,0)
    
[<Fact>]
let ``AllIsGoodWithMultiply`` () =
    let actual = Program.main [|"20";"*";"5"|]
    Assert.Equal(actual,0)
 
[<Fact>]
let ``AllIsGoodWithDivide`` () =
    let actual = Program.main [|"20";"/";"5"|]
    Assert.Equal(actual,0)
       
[<Fact>]
let ``WrongOperation1`` () =
    let actual() =
        let res = Program.main [|"20";"=";"a"|]
        printfn ""
    Assert.Throws<ArgumentException>(Action actual)
    
[<Fact>]
let ``WrongArgs2`` () =
    let actual() =
        let res = Program.main [|"20";"/";"a"|]
        printfn ""
    Assert.Throws<ArgumentException>(Action actual)
    
[<Fact>]
let ``WrongArgs`` () =
    let actual() =
        let res = Program.main [|"-";"/";"5"|]
        printfn ""
    Assert.Throws<ArgumentException>(Action actual )
    
[<Fact>]
let ``DevideByZero`` () =
    let actual() =
        let res = Program.main [|"20";"/";"0"|]
        printfn ""
    Assert.Throws<DivideByZeroException>(Action actual )
    
[<Fact>]
let ``WrongOperation`` () =
    let actual() =
        let res = Program.main [|"20";"?";"0"|]
        printfn ""
    Assert.Throws<ArgumentException>(Action actual )

[<Fact>]
let ``WrongLength`` () =
    let actual() =
        let res = Program.main [|"20";"/";"0";"0"|]
        printfn ""
    Assert.Throws<MissingMemberException>(Action actual )