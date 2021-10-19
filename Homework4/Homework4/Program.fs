module Homework4.Program

open System
open Homework4.Operation
open Homework4.Parser
open Homework4.Calculator


[<EntryPoint>]
let main argv =
    let mutable arg1 = 0
    let mutable arg2 = 0
    let mutable operation = Operation.None
    let arg1,operation,arg2 = Parser.Parse argv
    let result= Calculator.Calculate arg1 operation arg2
    0