module Homework4.Calculator

let Calculate (operation:string) (val1: int) (val2: int) =
    match operation with
    | "+" -> val1 + val2
    | "-" -> val1 - val2
    | "/" -> val1/val2
    | "*" -> val1*val2