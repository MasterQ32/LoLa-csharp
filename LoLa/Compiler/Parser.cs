// This code was generated by the Gardens Point Parser Generator
// Copyright (c) Wayne Kelly, John Gough, QUT 2005-2014
// (see accompanying GPPGcopyright.rtf)

// GPPG version 1.5.2
// Machine:  denkplatte
// DateTime: 02/13/2018 19:36:51
// UserName: felix
// Input file <LoLa.y - 02/13/2018 07:44:53>

// options: lines

using System;
using System.Collections.Generic;
using System.CodeDom.Compiler;
using System.Globalization;
using System.Text;
using QUT.Gppg;
using LoLa.Compiler.AST;

namespace LoLa.Compiler
{
public enum LoLaTokenType {error=2,EOF=3,CURLY_O=4,CURLY_C=5,ROUND_O=6,
    ROUND_C=7,SQUARE_O=8,SQUARE_C=9,VAR=10,FOR=11,WHILE=12,
    IF=13,ELSE=14,FUNCTION=15,BREAK=16,CONTINUE=17,RETURN=18,
    IN=19,LEQUAL=20,GEQUAL=21,EQUALS=22,DIFFERS=23,LESS=24,
    MORE=25,IS=26,DOT=27,COMMA=28,TERMINATOR=29,PLUS=30,
    MINUS=31,MULT=32,DIV=33,MOD=34,AND=35,OR=36,
    INVERT=37,IDENT=38,NUMBER=39,STRING=40,Comment=41,LongComment=42,
    Whitespace=43};

[GeneratedCodeAttribute( "Gardens Point Parser Generator", "1.5.2")]
public class Parser: ShiftReduceParser<AstNode, LexLocation>
{
#pragma warning disable 649
  private static Dictionary<int, string> aliases;
#pragma warning restore 649
  private static Rule[] rules = new Rule[69];
  private static State[] states = new State[119];
  private static string[] nonTerms = new string[] {
      "program", "statement", "decl", "ass", "for", "while", "conditional", "expression", 
      "return", "function", "stmtlist", "body", "expr_0", "expr_1", "expr_2", 
      "expr_3", "expr_4", "plist", "rvalue", "call", "array", "lvalue", "expr_0_op", 
      "expr_1_op", "expr_2_op", "expr_3_op", "arglist", "$accept", };

  static Parser() {
    states[0] = new State(-2,new int[]{-1,1});
    states[1] = new State(new int[]{3,2,15,5,10,16,38,53,11,85,12,93,13,99,18,110},new int[]{-10,3,-2,4,-3,15,-4,79,-22,80,-5,84,-6,92,-7,98,-8,106,-20,107,-9,109});
    states[2] = new State(-1);
    states[3] = new State(-3);
    states[4] = new State(-4);
    states[5] = new State(new int[]{38,6});
    states[6] = new State(new int[]{6,7});
    states[7] = new State(new int[]{7,116,38,118},new int[]{-18,8});
    states[8] = new State(new int[]{7,9,28,114});
    states[9] = new State(new int[]{4,11},new int[]{-12,10});
    states[10] = new State(-5);
    states[11] = new State(-10,new int[]{-11,12});
    states[12] = new State(new int[]{5,13,10,16,38,53,11,85,12,93,13,99,18,110},new int[]{-2,14,-3,15,-4,79,-22,80,-5,84,-6,92,-7,98,-8,106,-20,107,-9,109});
    states[13] = new State(-9);
    states[14] = new State(-11);
    states[15] = new State(-12);
    states[16] = new State(new int[]{38,17});
    states[17] = new State(new int[]{26,18,29,78});
    states[18] = new State(new int[]{31,45,37,46,6,48,38,53,8,63,40,68,39,69},new int[]{-13,19,-14,29,-15,34,-16,42,-26,43,-17,47,-19,51,-20,52,-21,62,-22,70});
    states[19] = new State(new int[]{29,20,22,23,23,24,20,25,21,26,25,27,24,28},new int[]{-23,21});
    states[20] = new State(-19);
    states[21] = new State(new int[]{31,45,37,46,6,48,38,53,8,63,40,68,39,69},new int[]{-13,22,-14,29,-15,34,-16,42,-26,43,-17,47,-19,51,-20,52,-21,62,-22,70});
    states[22] = new State(new int[]{22,23,23,24,20,25,21,26,25,27,24,28,29,-35,7,-35,28,-35,9,-35},new int[]{-23,21});
    states[23] = new State(-29);
    states[24] = new State(-30);
    states[25] = new State(-31);
    states[26] = new State(-32);
    states[27] = new State(-33);
    states[28] = new State(-34);
    states[29] = new State(new int[]{30,32,31,33,29,-36,22,-36,23,-36,20,-36,21,-36,25,-36,24,-36,7,-36,28,-36,9,-36},new int[]{-24,30});
    states[30] = new State(new int[]{31,45,37,46,6,48,38,53,8,63,40,68,39,69},new int[]{-14,31,-15,34,-16,42,-26,43,-17,47,-19,51,-20,52,-21,62,-22,70});
    states[31] = new State(new int[]{30,32,31,33,29,-39,22,-39,23,-39,20,-39,21,-39,25,-39,24,-39,7,-39,28,-39,9,-39},new int[]{-24,30});
    states[32] = new State(-37);
    states[33] = new State(-38);
    states[34] = new State(new int[]{32,37,33,38,34,39,35,40,36,41,30,-40,31,-40,29,-40,22,-40,23,-40,20,-40,21,-40,25,-40,24,-40,7,-40,28,-40,9,-40},new int[]{-25,35});
    states[35] = new State(new int[]{31,45,37,46,6,48,38,53,8,63,40,68,39,69},new int[]{-15,36,-16,42,-26,43,-17,47,-19,51,-20,52,-21,62,-22,70});
    states[36] = new State(new int[]{32,37,33,38,34,39,35,40,36,41,30,-46,31,-46,29,-46,22,-46,23,-46,20,-46,21,-46,25,-46,24,-46,7,-46,28,-46,9,-46},new int[]{-25,35});
    states[37] = new State(-41);
    states[38] = new State(-42);
    states[39] = new State(-43);
    states[40] = new State(-44);
    states[41] = new State(-45);
    states[42] = new State(-47);
    states[43] = new State(new int[]{31,45,37,46,6,48,38,53,8,63,40,68,39,69},new int[]{-16,44,-26,43,-17,47,-19,51,-20,52,-21,62,-22,70});
    states[44] = new State(-50);
    states[45] = new State(-48);
    states[46] = new State(-49);
    states[47] = new State(-51);
    states[48] = new State(new int[]{31,45,37,46,6,48,38,53,8,63,40,68,39,69},new int[]{-13,49,-14,29,-15,34,-16,42,-26,43,-17,47,-19,51,-20,52,-21,62,-22,70});
    states[49] = new State(new int[]{7,50,22,23,23,24,20,25,21,26,25,27,24,28},new int[]{-23,21});
    states[50] = new State(-52);
    states[51] = new State(-53);
    states[52] = new State(-55);
    states[53] = new State(new int[]{27,54,6,71,8,75,26,-68,32,-68,33,-68,34,-68,35,-68,36,-68,30,-68,31,-68,29,-68,22,-68,23,-68,20,-68,21,-68,25,-68,24,-68,7,-68,28,-68,9,-68});
    states[54] = new State(new int[]{38,55});
    states[55] = new State(new int[]{6,56});
    states[56] = new State(new int[]{7,57,31,45,37,46,6,48,38,53,8,63,40,68,39,69},new int[]{-27,58,-13,67,-14,29,-15,34,-16,42,-26,43,-17,47,-19,51,-20,52,-21,62,-22,70});
    states[57] = new State(-59);
    states[58] = new State(new int[]{7,59,28,60});
    states[59] = new State(-60);
    states[60] = new State(new int[]{31,45,37,46,6,48,38,53,8,63,40,68,39,69},new int[]{-13,61,-14,29,-15,34,-16,42,-26,43,-17,47,-19,51,-20,52,-21,62,-22,70});
    states[61] = new State(new int[]{22,23,23,24,20,25,21,26,25,27,24,28,7,-65,28,-65,9,-65},new int[]{-23,21});
    states[62] = new State(-56);
    states[63] = new State(new int[]{9,64,31,45,37,46,6,48,38,53,8,63,40,68,39,69},new int[]{-27,65,-13,67,-14,29,-15,34,-16,42,-26,43,-17,47,-19,51,-20,52,-21,62,-22,70});
    states[64] = new State(-63);
    states[65] = new State(new int[]{9,66,28,60});
    states[66] = new State(-64);
    states[67] = new State(new int[]{22,23,23,24,20,25,21,26,25,27,24,28,7,-66,28,-66,9,-66},new int[]{-23,21});
    states[68] = new State(-57);
    states[69] = new State(-58);
    states[70] = new State(-54);
    states[71] = new State(new int[]{7,72,31,45,37,46,6,48,38,53,8,63,40,68,39,69},new int[]{-27,73,-13,67,-14,29,-15,34,-16,42,-26,43,-17,47,-19,51,-20,52,-21,62,-22,70});
    states[72] = new State(-61);
    states[73] = new State(new int[]{7,74,28,60});
    states[74] = new State(-62);
    states[75] = new State(new int[]{31,45,37,46,6,48,38,53,8,63,40,68,39,69},new int[]{-13,76,-14,29,-15,34,-16,42,-26,43,-17,47,-19,51,-20,52,-21,62,-22,70});
    states[76] = new State(new int[]{9,77,22,23,23,24,20,25,21,26,25,27,24,28},new int[]{-23,21});
    states[77] = new State(-67);
    states[78] = new State(-20);
    states[79] = new State(-13);
    states[80] = new State(new int[]{26,81});
    states[81] = new State(new int[]{31,45,37,46,6,48,38,53,8,63,40,68,39,69},new int[]{-13,82,-14,29,-15,34,-16,42,-26,43,-17,47,-19,51,-20,52,-21,62,-22,70});
    states[82] = new State(new int[]{29,83,22,23,23,24,20,25,21,26,25,27,24,28},new int[]{-23,21});
    states[83] = new State(-21);
    states[84] = new State(-14);
    states[85] = new State(new int[]{6,86});
    states[86] = new State(new int[]{38,87});
    states[87] = new State(new int[]{19,88});
    states[88] = new State(new int[]{31,45,37,46,6,48,38,53,8,63,40,68,39,69},new int[]{-13,89,-14,29,-15,34,-16,42,-26,43,-17,47,-19,51,-20,52,-21,62,-22,70});
    states[89] = new State(new int[]{7,90,22,23,23,24,20,25,21,26,25,27,24,28},new int[]{-23,21});
    states[90] = new State(new int[]{4,11},new int[]{-12,91});
    states[91] = new State(-22);
    states[92] = new State(-15);
    states[93] = new State(new int[]{6,94});
    states[94] = new State(new int[]{31,45,37,46,6,48,38,53,8,63,40,68,39,69},new int[]{-13,95,-14,29,-15,34,-16,42,-26,43,-17,47,-19,51,-20,52,-21,62,-22,70});
    states[95] = new State(new int[]{7,96,22,23,23,24,20,25,21,26,25,27,24,28},new int[]{-23,21});
    states[96] = new State(new int[]{4,11},new int[]{-12,97});
    states[97] = new State(-23);
    states[98] = new State(-16);
    states[99] = new State(new int[]{6,100});
    states[100] = new State(new int[]{31,45,37,46,6,48,38,53,8,63,40,68,39,69},new int[]{-13,101,-14,29,-15,34,-16,42,-26,43,-17,47,-19,51,-20,52,-21,62,-22,70});
    states[101] = new State(new int[]{7,102,22,23,23,24,20,25,21,26,25,27,24,28},new int[]{-23,21});
    states[102] = new State(new int[]{4,11},new int[]{-12,103});
    states[103] = new State(new int[]{14,104,3,-27,15,-27,10,-27,38,-27,11,-27,12,-27,13,-27,18,-27,5,-27});
    states[104] = new State(new int[]{4,11},new int[]{-12,105});
    states[105] = new State(-26);
    states[106] = new State(-17);
    states[107] = new State(new int[]{29,108});
    states[108] = new State(-28);
    states[109] = new State(-18);
    states[110] = new State(new int[]{29,113,31,45,37,46,6,48,38,53,8,63,40,68,39,69},new int[]{-13,111,-14,29,-15,34,-16,42,-26,43,-17,47,-19,51,-20,52,-21,62,-22,70});
    states[111] = new State(new int[]{29,112,22,23,23,24,20,25,21,26,25,27,24,28},new int[]{-23,21});
    states[112] = new State(-24);
    states[113] = new State(-25);
    states[114] = new State(new int[]{38,115});
    states[115] = new State(-8);
    states[116] = new State(new int[]{4,11},new int[]{-12,117});
    states[117] = new State(-6);
    states[118] = new State(-7);

    for (int sNo = 0; sNo < states.Length; sNo++) states[sNo].number = sNo;

    rules[1] = new Rule(-28, new int[]{-1,3});
    rules[2] = new Rule(-1, new int[]{});
    rules[3] = new Rule(-1, new int[]{-1,-10});
    rules[4] = new Rule(-1, new int[]{-1,-2});
    rules[5] = new Rule(-10, new int[]{15,38,6,-18,7,-12});
    rules[6] = new Rule(-10, new int[]{15,38,6,7,-12});
    rules[7] = new Rule(-18, new int[]{38});
    rules[8] = new Rule(-18, new int[]{-18,28,38});
    rules[9] = new Rule(-12, new int[]{4,-11,5});
    rules[10] = new Rule(-11, new int[]{});
    rules[11] = new Rule(-11, new int[]{-11,-2});
    rules[12] = new Rule(-2, new int[]{-3});
    rules[13] = new Rule(-2, new int[]{-4});
    rules[14] = new Rule(-2, new int[]{-5});
    rules[15] = new Rule(-2, new int[]{-6});
    rules[16] = new Rule(-2, new int[]{-7});
    rules[17] = new Rule(-2, new int[]{-8});
    rules[18] = new Rule(-2, new int[]{-9});
    rules[19] = new Rule(-3, new int[]{10,38,26,-13,29});
    rules[20] = new Rule(-3, new int[]{10,38,29});
    rules[21] = new Rule(-4, new int[]{-22,26,-13,29});
    rules[22] = new Rule(-5, new int[]{11,6,38,19,-13,7,-12});
    rules[23] = new Rule(-6, new int[]{12,6,-13,7,-12});
    rules[24] = new Rule(-9, new int[]{18,-13,29});
    rules[25] = new Rule(-9, new int[]{18,29});
    rules[26] = new Rule(-7, new int[]{13,6,-13,7,-12,14,-12});
    rules[27] = new Rule(-7, new int[]{13,6,-13,7,-12});
    rules[28] = new Rule(-8, new int[]{-20,29});
    rules[29] = new Rule(-23, new int[]{22});
    rules[30] = new Rule(-23, new int[]{23});
    rules[31] = new Rule(-23, new int[]{20});
    rules[32] = new Rule(-23, new int[]{21});
    rules[33] = new Rule(-23, new int[]{25});
    rules[34] = new Rule(-23, new int[]{24});
    rules[35] = new Rule(-13, new int[]{-13,-23,-13});
    rules[36] = new Rule(-13, new int[]{-14});
    rules[37] = new Rule(-24, new int[]{30});
    rules[38] = new Rule(-24, new int[]{31});
    rules[39] = new Rule(-14, new int[]{-14,-24,-14});
    rules[40] = new Rule(-14, new int[]{-15});
    rules[41] = new Rule(-25, new int[]{32});
    rules[42] = new Rule(-25, new int[]{33});
    rules[43] = new Rule(-25, new int[]{34});
    rules[44] = new Rule(-25, new int[]{35});
    rules[45] = new Rule(-25, new int[]{36});
    rules[46] = new Rule(-15, new int[]{-15,-25,-15});
    rules[47] = new Rule(-15, new int[]{-16});
    rules[48] = new Rule(-26, new int[]{31});
    rules[49] = new Rule(-26, new int[]{37});
    rules[50] = new Rule(-16, new int[]{-26,-16});
    rules[51] = new Rule(-16, new int[]{-17});
    rules[52] = new Rule(-17, new int[]{6,-13,7});
    rules[53] = new Rule(-17, new int[]{-19});
    rules[54] = new Rule(-17, new int[]{-22});
    rules[55] = new Rule(-19, new int[]{-20});
    rules[56] = new Rule(-19, new int[]{-21});
    rules[57] = new Rule(-19, new int[]{40});
    rules[58] = new Rule(-19, new int[]{39});
    rules[59] = new Rule(-20, new int[]{38,27,38,6,7});
    rules[60] = new Rule(-20, new int[]{38,27,38,6,-27,7});
    rules[61] = new Rule(-20, new int[]{38,6,7});
    rules[62] = new Rule(-20, new int[]{38,6,-27,7});
    rules[63] = new Rule(-21, new int[]{8,9});
    rules[64] = new Rule(-21, new int[]{8,-27,9});
    rules[65] = new Rule(-27, new int[]{-27,28,-13});
    rules[66] = new Rule(-27, new int[]{-13});
    rules[67] = new Rule(-22, new int[]{38,8,-13,9});
    rules[68] = new Rule(-22, new int[]{38});
  }

  protected override void Initialize() {
    this.InitSpecialTokens((int)LoLaTokenType.error, (int)LoLaTokenType.EOF);
    this.InitStates(states);
    this.InitRules(rules);
    this.InitNonTerminals(nonTerms);
  }

  protected override void DoAction(int action)
  {
#pragma warning disable 162, 1522
    switch (action)
    {
      case 2: // program -> /* empty */
#line 47 "LoLa.y"
                              { CurrentSemanticValue.Program = new Program(); }
#line default
        break;
      case 3: // program -> program, function
#line 48 "LoLa.y"
                             { CurrentSemanticValue.Program = ValueStack[ValueStack.Depth-2].Program; CurrentSemanticValue.Program.Functions.Add(ValueStack[ValueStack.Depth-1].Function); }
#line default
        break;
      case 4: // program -> program, statement
#line 49 "LoLa.y"
                             { CurrentSemanticValue.Program = ValueStack[ValueStack.Depth-2].Program; CurrentSemanticValue.Program.Statements.Add(ValueStack[ValueStack.Depth-1].Statement); }
#line default
        break;
      case 5: // function -> FUNCTION, IDENT, ROUND_O, plist, ROUND_C, body
#line 53 "LoLa.y"
   {
				CurrentSemanticValue.Function = new AST.Function();
				CurrentSemanticValue.Function.Name = ValueStack[ValueStack.Depth-5].String;
				CurrentSemanticValue.Function.Parameters = ValueStack[ValueStack.Depth-3].NameList;
				CurrentSemanticValue.Function.Statements = ValueStack[ValueStack.Depth-1].Statements;
			}
#line default
        break;
      case 6: // function -> FUNCTION, IDENT, ROUND_O, ROUND_C, body
#line 60 "LoLa.y"
   {
				CurrentSemanticValue.Function = new AST.Function();
				CurrentSemanticValue.Function.Name = ValueStack[ValueStack.Depth-4].String;
				CurrentSemanticValue.Function.Parameters = new List<string>();
				CurrentSemanticValue.Function.Statements = ValueStack[ValueStack.Depth-1].Statements;
			}
#line default
        break;
      case 7: // plist -> IDENT
#line 69 "LoLa.y"
   { 
				CurrentSemanticValue.NameList = new List<string>(); 
				CurrentSemanticValue.NameList.Add(ValueStack[ValueStack.Depth-1].String);
			}
#line default
        break;
      case 8: // plist -> plist, COMMA, IDENT
#line 74 "LoLa.y"
   {
				CurrentSemanticValue.NameList = ValueStack[ValueStack.Depth-3].NameList;
				CurrentSemanticValue.NameList.Add(ValueStack[ValueStack.Depth-1].String);
			}
#line default
        break;
      case 9: // body -> CURLY_O, stmtlist, CURLY_C
#line 80 "LoLa.y"
                                     { CurrentSemanticValue.Statements = ValueStack[ValueStack.Depth-2].Statements; }
#line default
        break;
      case 10: // stmtlist -> /* empty */
#line 83 "LoLa.y"
                          { CurrentSemanticValue.Statements = new List<AST.Statement>();  }
#line default
        break;
      case 11: // stmtlist -> stmtlist, statement
#line 84 "LoLa.y"
                             { CurrentSemanticValue.Statements = ValueStack[ValueStack.Depth-2].Statements; CurrentSemanticValue.Statements.Add(ValueStack[ValueStack.Depth-1].Statement); }
#line default
        break;
      case 19: // decl -> VAR, IDENT, IS, expr_0, TERMINATOR
#line 89 "LoLa.y"
                                         { CurrentSemanticValue.Statement = new Declaration(ValueStack[ValueStack.Depth-4].String, ValueStack[ValueStack.Depth-2].Expression); }
#line default
        break;
      case 20: // decl -> VAR, IDENT, TERMINATOR
#line 90 "LoLa.y"
                               { CurrentSemanticValue.Statement = new Declaration(ValueStack[ValueStack.Depth-2].String); }
#line default
        break;
      case 21: // ass -> lvalue, IS, expr_0, TERMINATOR
#line 93 "LoLa.y"
                                       { CurrentSemanticValue.Statement = new Assignment(ValueStack[ValueStack.Depth-4].LValue, ValueStack[ValueStack.Depth-2].Expression); }
#line default
        break;
      case 22: // for -> FOR, ROUND_O, IDENT, IN, expr_0, ROUND_C, body
#line 96 "LoLa.y"
                                                 { CurrentSemanticValue.Statement = new ForLoop(ValueStack[ValueStack.Depth-5].String,ValueStack[ValueStack.Depth-3].Expression,ValueStack[ValueStack.Depth-1].Statements); }
#line default
        break;
      case 23: // while -> WHILE, ROUND_O, expr_0, ROUND_C, body
#line 99 "LoLa.y"
                                             { CurrentSemanticValue.Statement = new WhileLoop(ValueStack[ValueStack.Depth-3].Expression, ValueStack[ValueStack.Depth-1].Statements); }
#line default
        break;
      case 24: // return -> RETURN, expr_0, TERMINATOR
#line 102 "LoLa.y"
                                       { CurrentSemanticValue.Statement = new Return(ValueStack[ValueStack.Depth-2].Expression); }
#line default
        break;
      case 25: // return -> RETURN, TERMINATOR
#line 103 "LoLa.y"
                             { CurrentSemanticValue.Statement = new Return(); }
#line default
        break;
      case 26: // conditional -> IF, ROUND_O, expr_0, ROUND_C, body, ELSE, body
#line 106 "LoLa.y"
                                                       { CurrentSemanticValue.Statement = new IfElse(ValueStack[ValueStack.Depth-5].Expression, ValueStack[ValueStack.Depth-3].Statements, ValueStack[ValueStack.Depth-1].Statements); }
#line default
        break;
      case 27: // conditional -> IF, ROUND_O, expr_0, ROUND_C, body
#line 107 "LoLa.y"
                                      { CurrentSemanticValue.Statement = new IfElse(ValueStack[ValueStack.Depth-3].Expression, ValueStack[ValueStack.Depth-1].Statements); }
#line default
        break;
      case 28: // expression -> call, TERMINATOR
#line 110 "LoLa.y"
                                   { CurrentSemanticValue.Statement = new DiscardResult(ValueStack[ValueStack.Depth-2].RValue); }
#line default
        break;
      case 35: // expr_0 -> expr_0, expr_0_op, expr_0
#line 114 "LoLa.y"
                                      { CurrentSemanticValue.Expression = new BinaryOperator(ValueStack[ValueStack.Depth-2].String, ValueStack[ValueStack.Depth-3].Expression, ValueStack[ValueStack.Depth-1].Expression); }
#line default
        break;
      case 36: // expr_0 -> expr_1
#line 115 "LoLa.y"
                    { CurrentSemanticValue.Expression = ValueStack[ValueStack.Depth-1].Expression; }
#line default
        break;
      case 39: // expr_1 -> expr_1, expr_1_op, expr_1
#line 120 "LoLa.y"
                                      { CurrentSemanticValue.Expression = new BinaryOperator(ValueStack[ValueStack.Depth-2].String, ValueStack[ValueStack.Depth-3].Expression, ValueStack[ValueStack.Depth-1].Expression); }
#line default
        break;
      case 40: // expr_1 -> expr_2
#line 121 "LoLa.y"
                    { CurrentSemanticValue.Expression = ValueStack[ValueStack.Depth-1].Expression; }
#line default
        break;
      case 46: // expr_2 -> expr_2, expr_2_op, expr_2
#line 126 "LoLa.y"
                                      { CurrentSemanticValue.Expression = new BinaryOperator(ValueStack[ValueStack.Depth-2].String, ValueStack[ValueStack.Depth-3].Expression, ValueStack[ValueStack.Depth-1].Expression); }
#line default
        break;
      case 47: // expr_2 -> expr_3
#line 127 "LoLa.y"
                    { CurrentSemanticValue.Expression = ValueStack[ValueStack.Depth-1].Expression; }
#line default
        break;
      case 50: // expr_3 -> expr_3_op, expr_3
#line 132 "LoLa.y"
                                 { CurrentSemanticValue.Expression = new UnaryOperator(ValueStack[ValueStack.Depth-2].String, ValueStack[ValueStack.Depth-1].Expression); }
#line default
        break;
      case 51: // expr_3 -> expr_4
#line 133 "LoLa.y"
                    { CurrentSemanticValue.Expression = ValueStack[ValueStack.Depth-1].Expression; }
#line default
        break;
      case 52: // expr_4 -> ROUND_O, expr_0, ROUND_C
#line 137 "LoLa.y"
                                     { CurrentSemanticValue.Expression = ValueStack[ValueStack.Depth-2].Expression; }
#line default
        break;
      case 53: // expr_4 -> rvalue
#line 138 "LoLa.y"
                    { CurrentSemanticValue.Expression = ValueStack[ValueStack.Depth-1].RValue; }
#line default
        break;
      case 54: // expr_4 -> lvalue
#line 139 "LoLa.y"
                    { CurrentSemanticValue.Expression = ValueStack[ValueStack.Depth-1].LValue; }
#line default
        break;
      case 55: // rvalue -> call
#line 142 "LoLa.y"
                        { CurrentSemanticValue.RValue = ValueStack[ValueStack.Depth-1].RValue; }
#line default
        break;
      case 56: // rvalue -> array
#line 143 "LoLa.y"
                    { CurrentSemanticValue.RValue = ValueStack[ValueStack.Depth-1].RValue; }
#line default
        break;
      case 57: // rvalue -> STRING
#line 144 "LoLa.y"
                    { CurrentSemanticValue.RValue = new AST.Literal(ValueStack[ValueStack.Depth-1].String); }
#line default
        break;
      case 58: // rvalue -> NUMBER
#line 145 "LoLa.y"
                    { CurrentSemanticValue.RValue = new AST.Literal(Convert.ToDouble(ValueStack[ValueStack.Depth-1].String, CultureInfo.InvariantCulture)); }
#line default
        break;
      case 59: // call -> IDENT, DOT, IDENT, ROUND_O, ROUND_C
#line 148 "LoLa.y"
                                          { CurrentSemanticValue.RValue = new FunctionCall(ValueStack[ValueStack.Depth-5].String, ValueStack[ValueStack.Depth-3].String); }
#line default
        break;
      case 60: // call -> IDENT, DOT, IDENT, ROUND_O, arglist, ROUND_C
#line 149 "LoLa.y"
                                             { CurrentSemanticValue.RValue = new FunctionCall(ValueStack[ValueStack.Depth-6].String, ValueStack[ValueStack.Depth-4].String, ValueStack[ValueStack.Depth-2].Expressions); }
#line default
        break;
      case 61: // call -> IDENT, ROUND_O, ROUND_C
#line 150 "LoLa.y"
                                { CurrentSemanticValue.RValue = new FunctionCall(ValueStack[ValueStack.Depth-3].String); }
#line default
        break;
      case 62: // call -> IDENT, ROUND_O, arglist, ROUND_C
#line 151 "LoLa.y"
                                      { CurrentSemanticValue.RValue = new FunctionCall(ValueStack[ValueStack.Depth-4].String, ValueStack[ValueStack.Depth-2].Expressions); }
#line default
        break;
      case 63: // array -> SQUARE_O, SQUARE_C
#line 154 "LoLa.y"
                                 { CurrentSemanticValue.RValue = new ArrayLiteral(); }
#line default
        break;
      case 64: // array -> SQUARE_O, arglist, SQUARE_C
#line 155 "LoLa.y"
                                   { CurrentSemanticValue.RValue = new ArrayLiteral(ValueStack[ValueStack.Depth-2].Expressions); }
#line default
        break;
      case 65: // arglist -> arglist, COMMA, expr_0
#line 158 "LoLa.y"
                                     { CurrentSemanticValue.Expressions = ValueStack[ValueStack.Depth-3].Expressions; CurrentSemanticValue.Expressions.Add(ValueStack[ValueStack.Depth-1].Expression); }
#line default
        break;
      case 66: // arglist -> expr_0
#line 159 "LoLa.y"
                    { CurrentSemanticValue.Expressions = new List<AST.Expression>(); CurrentSemanticValue.Expressions.Add(ValueStack[ValueStack.Depth-1].Expression); }
#line default
        break;
      case 67: // lvalue -> IDENT, SQUARE_O, expr_0, SQUARE_C
#line 162 "LoLa.y"
                                           { CurrentSemanticValue.LValue = new ArrayIndexer(ValueStack[ValueStack.Depth-4].String, ValueStack[ValueStack.Depth-2].Expression); }
#line default
        break;
      case 68: // lvalue -> IDENT
#line 163 "LoLa.y"
                    { CurrentSemanticValue.LValue = new AST.VariableRef(ValueStack[ValueStack.Depth-1].String); }
#line default
        break;
    }
#pragma warning restore 162, 1522
  }

  protected override string TerminalToString(int terminal)
  {
    if (aliases != null && aliases.ContainsKey(terminal))
        return aliases[terminal];
    else if (((LoLaTokenType)terminal).ToString() != terminal.ToString(CultureInfo.InvariantCulture))
        return ((LoLaTokenType)terminal).ToString();
    else
        return CharToString((char)terminal);
  }

#line 168 "LoLa.y"
public Parser(Lexer lexer) : base(lexer) 
{ 
	
}

public Program Result => this.CurrentSemanticValue.Program;
#line default
}
}
