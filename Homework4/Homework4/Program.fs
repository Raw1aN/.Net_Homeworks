module Homework4.Program

open System

// Define a function to construct a message to print


let WrongOperationFormat = 3


[<EntryPoint>]
let main argv =
    let mutable val1 = 1
    let mutable val2 = 2
    let mutable operation = "+"
    
    if  Parser.TryParseOperation operation  = false then WrongOperationFormat
    else
    printf $"Result is: {Calculator.Calculate operation val1 val2}"
    0