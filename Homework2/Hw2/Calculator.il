// Type: Homework1.Calculator 
// Assembly: Homework1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F791C6FC-247A-4BB9-9675-9FA519E3A07B
// Location: D:\.Net_Homeworks\Homework1\Homework1\bin\Debug\net5.0\Homework1.dll
// Sequence point data from D:\.Net_Homeworks\Homework1\Homework1\bin\Debug\net5.0\Homework1.pdb

.class public abstract sealed auto ansi beforefieldinit
  Homework1.Calculator
    extends [System.Runtime]System.Object
{

  .method public hidebysig static int32
    Calculate(
      string operation,
      int32 val1,
      int32 val2
    ) cil managed
  {
    .maxstack 2
    .locals init (
      [0] int32 result,
      [1] int32 V_1,
      [2] int32 V_2
    )

    // [8 9 - 8 10]
    IL_0000: nop

    // [9 13 - 15 15]
    IL_0001: ldc.i4.1
    IL_0002: brtrue.s     IL_0005

    // [9 36 - 15 14]
    IL_0004: nop

    IL_0005: ldarg.0      // operation
    IL_0006: ldstr        "+"
    IL_000b: call         bool [System.Runtime]System.String::op_Equality(string, string)
    IL_0010: brtrue.s     IL_003b
    IL_0012: ldarg.0      // operation
    IL_0013: ldstr        "-"
    IL_0018: call         bool [System.Runtime]System.String::op_Equality(string, string)
    IL_001d: brtrue.s     IL_0041
    IL_001f: ldarg.0      // operation
    IL_0020: ldstr        "*"
    IL_0025: call         bool [System.Runtime]System.String::op_Equality(string, string)
    IL_002a: brtrue.s     IL_0047
    IL_002c: ldarg.0      // operation
    IL_002d: ldstr        "/"
    IL_0032: call         bool [System.Runtime]System.String::op_Equality(string, string)
    IL_0037: brtrue.s     IL_004d
    IL_0039: br.s         IL_0053

    // [11 24 - 11 35]
    IL_003b: ldarg.1      // val1
    IL_003c: ldarg.2      // val2
    IL_003d: add
    IL_003e: stloc.1      // V_1
    IL_003f: br.s         IL_005e

    // [12 24 - 12 35]
    IL_0041: ldarg.1      // val1
    IL_0042: ldarg.2      // val2
    IL_0043: sub
    IL_0044: stloc.1      // V_1
    IL_0045: br.s         IL_005e

    // [13 24 - 13 35]
    IL_0047: ldarg.1      // val1
    IL_0048: ldarg.2      // val2
    IL_0049: mul
    IL_004a: stloc.1      // V_1
    IL_004b: br.s         IL_005e

    // [14 24 - 14 35]
    IL_004d: ldarg.1      // val1
    IL_004e: ldarg.2      // val2
    IL_004f: div
    IL_0050: stloc.1      // V_1
    IL_0051: br.s         IL_005e
    IL_0053: ldc.i4.1
    IL_0054: brtrue.s     IL_0057

    // [9 36 - 15 14]
    IL_0056: nop

    IL_0057: ldarg.0      // operation
    IL_0058: newobj       instance void [System.Runtime]System.Runtime.CompilerServices.SwitchExpressionException::.ctor(object)
    IL_005d: throw

    IL_005e: ldc.i4.1
    IL_005f: brtrue.s     IL_0062

    // [9 13 - 15 15]
    IL_0061: nop

    IL_0062: ldloc.1      // V_1
    IL_0063: stloc.0      // result

    // [16 13 - 16 27]
    IL_0064: ldloc.0      // result
    IL_0065: stloc.2      // V_2
    IL_0066: br.s         IL_0068

    // [17 9 - 17 10]
    IL_0068: ldloc.2      // V_2
    IL_0069: ret

  } // end of method Calculator::Calculate
} // end of class Homework1.Calculator
