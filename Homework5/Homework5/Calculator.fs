module Homework5.Calculator

open System
open Homework5.Operation

let Calculate (arg1:decimal,operation:Operation,arg2:decimal) =
    match operation with
    | Operation.Add -> arg1 + arg2
    | Operation.Subtract -> arg1 - arg2
    | Operation.Divide -> arg1 / arg2
    | Operation.Multiply -> arg1 * arg2