module Homework4.Calculator

open System
open Homework4.Operation

let Calculate (arg1:double) operation (arg2:double) =
    match operation with
    | Operation.Add -> arg1 + arg2
    | Operation.Subtract -> arg1 - arg2
    | Operation.Divide -> arg1 / arg2
    | Operation.Multiply -> arg1 * arg2