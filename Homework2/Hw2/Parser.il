// Type: Homework1.Parser 
// Assembly: Homework1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F791C6FC-247A-4BB9-9675-9FA519E3A07B
// Location: D:\.Net_Homeworks\Homework1\Homework1\bin\Debug\net5.0\Homework1.dll
// Sequence point data from D:\.Net_Homeworks\Homework1\Homework1\bin\Debug\net5.0\Homework1.pdb

.class public abstract sealed auto ansi beforefieldinit
  Homework1.Parser
    extends [System.Runtime]System.Object
{

  .class nested private sealed auto ansi serializable beforefieldinit
    '<>c'
      extends [System.Runtime]System.Object
  {
    .custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )

    .field public static initonly class Homework1.Parser/'<>c' '<>9'

    .field public static class [System.Runtime]System.Func`3<string, string, string> '<>9__1_0'

    .method private hidebysig static specialname rtspecialname void
      .cctor() cil managed
    {
      .maxstack 8

      IL_0000: newobj       instance void Homework1.Parser/'<>c'::.ctor()
      IL_0005: stsfld       class Homework1.Parser/'<>c' Homework1.Parser/'<>c'::'<>9'
      IL_000a: ret

    } // end of method '<>c'::.cctor

    .method public hidebysig specialname rtspecialname instance void
      .ctor() cil managed
    {
      .maxstack 8

      IL_0000: ldarg.0      // this
      IL_0001: call         instance void [System.Runtime]System.Object::.ctor()
      IL_0006: nop
      IL_0007: ret

    } // end of method '<>c'::.ctor

    .method assembly hidebysig instance string
      '<TryParseArguments>b__1_0'(
        string c,
        string n
      ) cil managed
    {
      .maxstack 8

      // [37 66 - 37 76]
      IL_0000: ldarg.1      // c
      IL_0001: ldstr        " "
      IL_0006: ldarg.2      // n
      IL_0007: call         string [System.Runtime]System.String::Concat(string, string, string)
      IL_000c: ret

    } // end of method '<>c'::'<TryParseArguments>b__1_0'
  } // end of class '<>c'

  .field public static initonly string[] SupportedOperations

  .method public hidebysig static int32
    TryParseArguments(
      string[] args,
      [out] int32& val1,
      [out] string& operation,
      [out] int32& val2
    ) cil managed
  {
    .maxstack 6
    .locals init (
      [0] bool isVal1Int,
      [1] bool isVal2Int,
      [2] bool V_2,
      [3] int32 V_3,
      [4] bool V_4,
      [5] bool V_5,
      [6] bool V_6
    )

    // [16 9 - 16 10]
    IL_0000: nop

    // [17 13 - 17 61]
    IL_0001: ldarg.0      // args
    IL_0002: ldc.i4.0
    IL_0003: ldelem.ref
    IL_0004: ldarg.1      // val1
    IL_0005: call         bool [System.Runtime]System.Int32::TryParse(string, int32&)
    IL_000a: stloc.0      // isVal1Int

    // [18 13 - 18 33]
    IL_000b: ldarg.2      // operation
    IL_000c: ldarg.0      // args
    IL_000d: ldc.i4.1
    IL_000e: ldelem.ref
    IL_000f: stind.ref

    // [19 13 - 19 61]
    IL_0010: ldarg.0      // args
    IL_0011: ldc.i4.2
    IL_0012: ldelem.ref
    IL_0013: ldarg.3      // val2
    IL_0014: call         bool [System.Runtime]System.Int32::TryParse(string, int32&)
    IL_0019: stloc.1      // isVal2Int

    // [21 13 - 21 34]
    IL_001a: ldarg.0      // args
    IL_001b: ldlen
    IL_001c: conv.i4
    IL_001d: ldc.i4.3
    IL_001e: ceq
    IL_0020: ldc.i4.0
    IL_0021: ceq
    IL_0023: stloc.2      // V_2

    IL_0024: ldloc.2      // V_2
    IL_0025: brfalse.s    IL_003a

    // [22 13 - 22 14]
    IL_0027: nop

    // [23 17 - 23 57]
    IL_0028: ldstr        "Wrong args length"
    IL_002d: call         void [System.Console]System.Console::WriteLine(string)
    IL_0032: nop

    // [24 17 - 24 26]
    IL_0033: ldc.i4.3
    IL_0034: stloc.3      // V_3
    IL_0035: br           IL_0114

    // [26 13 - 26 42]
    IL_003a: ldloc.0      // isVal1Int
    IL_003b: brfalse.s    IL_0043
    IL_003d: ldloc.1      // isVal2Int
    IL_003e: ldc.i4.0
    IL_003f: ceq
    IL_0041: br.s         IL_0044
    IL_0043: ldc.i4.1
    IL_0044: stloc.s      V_4

    IL_0046: ldloc.s      V_4
    IL_0048: brfalse.s    IL_006b

    // [27 13 - 27 14]
    IL_004a: nop

    // [28 17 - 28 101]
    IL_004b: ldarg.0      // args
    IL_004c: ldc.i4.0
    IL_004d: ldelem.ref
    IL_004e: ldarg.0      // args
    IL_004f: ldc.i4.1
    IL_0050: ldelem.ref
    IL_0051: ldarg.0      // args
    IL_0052: ldc.i4.2
    IL_0053: ldelem.ref
    IL_0054: ldstr        " is not a valid calculation syntax"
    IL_0059: call         string [System.Runtime]System.String::Concat(string, string, string, string)
    IL_005e: call         void [System.Console]System.Console::WriteLine(string)
    IL_0063: nop

    // [29 17 - 29 26]
    IL_0064: ldc.i4.1
    IL_0065: stloc.3      // V_3
    IL_0066: br           IL_0114

    // [32 13 - 32 58]
    IL_006b: ldsfld       string[] Homework1.Parser::SupportedOperations
    IL_0070: ldarg.2      // operation
    IL_0071: ldind.ref
    IL_0072: call         bool [System.Linq]System.Linq.Enumerable::Contains<string>(class [System.Runtime]System.Collections.Generic.IEnumerable`1<!!0/*string*/>, !!0/*string*/)
    IL_0077: ldc.i4.0
    IL_0078: ceq
    IL_007a: stloc.s      V_5

    IL_007c: ldloc.s      V_5
    IL_007e: brfalse.s    IL_00dc

    // [33 13 - 33 14]
    IL_0080: nop

    // [34 17 - 37 81]
    IL_0081: ldc.i4.5
    IL_0082: newarr       [System.Runtime]System.String
    IL_0087: dup
    IL_0088: ldc.i4.0
    IL_0089: ldarg.0      // args
    IL_008a: ldc.i4.0
    IL_008b: ldelem.ref
    IL_008c: stelem.ref
    IL_008d: dup
    IL_008e: ldc.i4.1
    IL_008f: ldarg.0      // args
    IL_0090: ldc.i4.1
    IL_0091: ldelem.ref
    IL_0092: stelem.ref
    IL_0093: dup
    IL_0094: ldc.i4.2
    IL_0095: ldarg.0      // args
    IL_0096: ldc.i4.2
    IL_0097: ldelem.ref
    IL_0098: stelem.ref
    IL_0099: dup
    IL_009a: ldc.i4.3
    IL_009b: ldstr        " is not a valid calculation syntax. Supported operations are "
    IL_00a0: stelem.ref
    IL_00a1: dup
    IL_00a2: ldc.i4.4
    IL_00a3: ldsfld       string[] Homework1.Parser::SupportedOperations
    IL_00a8: ldsfld       class [System.Runtime]System.Func`3<string, string, string> Homework1.Parser/'<>c'::'<>9__1_0'
    IL_00ad: dup
    IL_00ae: brtrue.s     IL_00c7
    IL_00b0: pop
    IL_00b1: ldsfld       class Homework1.Parser/'<>c' Homework1.Parser/'<>c'::'<>9'
    IL_00b6: ldftn        instance string Homework1.Parser/'<>c'::'<TryParseArguments>b__1_0'(string, string)
    IL_00bc: newobj       instance void class [System.Runtime]System.Func`3<string, string, string>::.ctor(object, native int)
    IL_00c1: dup
    IL_00c2: stsfld       class [System.Runtime]System.Func`3<string, string, string> Homework1.Parser/'<>c'::'<>9__1_0'
    IL_00c7: call         !!0/*string*/ [System.Linq]System.Linq.Enumerable::Aggregate<string>(class [System.Runtime]System.Collections.Generic.IEnumerable`1<!!0/*string*/>, class [System.Runtime]System.Func`3<!!0/*string*/, !!0/*string*/, !!0/*string*/>)
    IL_00cc: stelem.ref
    IL_00cd: call         string [System.Runtime]System.String::Concat(string[])
    IL_00d2: call         void [System.Console]System.Console::WriteLine(string)
    IL_00d7: nop

    // [38 17 - 38 26]
    IL_00d8: ldc.i4.2
    IL_00d9: stloc.3      // V_3
    IL_00da: br.s         IL_0114

    // [41 13 - 41 50]
    IL_00dc: ldarg.2      // operation
    IL_00dd: ldind.ref
    IL_00de: ldstr        "/"
    IL_00e3: call         bool [System.Runtime]System.String::op_Equality(string, string)
    IL_00e8: brfalse.s    IL_00f9
    IL_00ea: ldarg.0      // args
    IL_00eb: ldc.i4.2
    IL_00ec: ldelem.ref
    IL_00ed: ldstr        "0"
    IL_00f2: call         bool [System.Runtime]System.String::op_Equality(string, string)
    IL_00f7: br.s         IL_00fa
    IL_00f9: ldc.i4.0
    IL_00fa: stloc.s      V_6

    IL_00fc: ldloc.s      V_6
    IL_00fe: brfalse.s    IL_0110

    // [42 13 - 42 14]
    IL_0100: nop

    // [43 17 - 43 70]
    IL_0101: ldstr        "Calculator can't devide on 0"
    IL_0106: call         void [System.Console]System.Console::WriteLine(string)
    IL_010b: nop

    // [44 17 - 44 26]
    IL_010c: ldc.i4.4
    IL_010d: stloc.3      // V_3
    IL_010e: br.s         IL_0114

    // [47 13 - 47 22]
    IL_0110: ldc.i4.0
    IL_0111: stloc.3      // V_3
    IL_0112: br.s         IL_0114

    // [48 9 - 48 10]
    IL_0114: ldloc.3      // V_3
    IL_0115: ret

  } // end of method Parser::TryParseArguments

  .method private hidebysig static specialname rtspecialname void
    .cctor() cil managed
  {
    .maxstack 8

    // [8 9 - 13 11]
    IL_0000: ldc.i4.4
    IL_0001: newarr       [System.Runtime]System.String
    IL_0006: dup
    IL_0007: ldc.i4.0
    IL_0008: ldstr        "+"
    IL_000d: stelem.ref
    IL_000e: dup
    IL_000f: ldc.i4.1
    IL_0010: ldstr        "-"
    IL_0015: stelem.ref
    IL_0016: dup
    IL_0017: ldc.i4.2
    IL_0018: ldstr        "*"
    IL_001d: stelem.ref
    IL_001e: dup
    IL_001f: ldc.i4.3
    IL_0020: ldstr        "/"
    IL_0025: stelem.ref
    IL_0026: stsfld       string[] Homework1.Parser::SupportedOperations
    IL_002b: ret

  } // end of method Parser::.cctor
} // end of class Homework1.Parser
