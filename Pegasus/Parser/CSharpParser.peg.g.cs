// -----------------------------------------------------------------------
// <auto-generated>
//   This code was generated by Pegasus 4.0.0.0
//
//   Changes to this file may cause incorrect behavior and will be lost if
//   the code is regenerated.
// </auto-generated>
// -----------------------------------------------------------------------

namespace
#line 1 "CSharpParser.peg"
           Pegasus.Parser
#line default
{
    using System;
    using System.Collections.Generic;
    using Pegasus.Common;
    using
        #line 4 "CSharpParser.peg"
       Microsoft.CodeAnalysis.CSharp
        #line default
        ;
    using
        #line 5 "CSharpParser.peg"
       Microsoft.CodeAnalysis.CSharp.Syntax
        #line default
        ;

    /// <summary>
    ///  Parses a string according to the rules of the <see cref="CSharpParser" /> grammar.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Pegasus", "4.0.0.0")]
    internal
    partial class
    #line 2 "CSharpParser.peg"
           CSharpParser
    #line default
    {
        #line 7 "CSharpParser.peg"
 
    private static ParseResult<T> ParseHelper<T>(ref Cursor cursor, T syntax)
        where T : CSharpSyntaxNode
    {
        if (syntax.Span.IsEmpty)
        {
            return null;
        }

        var start = cursor;
        cursor = start.Advance(syntax.FullSpan.End);
        return new ParseResult<T>(start, cursor, syntax);
    }
        #line default

        private ExportedRules exported;

        /// <summary>
        /// Gets the set of rules exported by this parser.
        /// </summary>
        public ExportedRules Exported
        {
            get
            {
                return this.exported ?? (this.exported = new ExportedRules(this));
            }
        }

        private IParseResult<
            #line 22 "CSharpParser.peg"
              ArgumentListSyntax
            #line default
            > ArgumentList(ref Cursor cursor)
        {
            IParseResult<ArgumentListSyntax> r0 = null;
            r0 = this.ParseHelper<ArgumentListSyntax>(ref cursor, (ref Cursor state) =>
                #line 23 "CSharpParser.peg"
    ParseHelper(ref state, SyntaxFactory.ParseArgumentList(state.Subject, state.Location, consumeFullText: false))
                #line default
                );
            return r0;
        }

        private IParseResult<
            #line 26 "CSharpParser.peg"
                       AttributeArgumentListSyntax
            #line default
            > AttributeArgumentList(ref Cursor cursor)
        {
            IParseResult<AttributeArgumentListSyntax> r0 = null;
            r0 = this.ParseHelper<AttributeArgumentListSyntax>(ref cursor, (ref Cursor state) =>
                #line 27 "CSharpParser.peg"
    ParseHelper(ref state, SyntaxFactory.ParseAttributeArgumentList(state.Subject, state.Location, consumeFullText: false))
                #line default
                );
            return r0;
        }

        private IParseResult<
            #line 30 "CSharpParser.peg"
                       BracketedArgumentListSyntax
            #line default
            > BracketedArgumentList(ref Cursor cursor)
        {
            IParseResult<BracketedArgumentListSyntax> r0 = null;
            r0 = this.ParseHelper<BracketedArgumentListSyntax>(ref cursor, (ref Cursor state) =>
                #line 31 "CSharpParser.peg"
    ParseHelper(ref state, SyntaxFactory.ParseBracketedArgumentList(state.Subject, state.Location, consumeFullText: false))
                #line default
                );
            return r0;
        }

        private IParseResult<
            #line 34 "CSharpParser.peg"
                        BracketedParameterListSyntax
            #line default
            > BracketedParameterList(ref Cursor cursor)
        {
            IParseResult<BracketedParameterListSyntax> r0 = null;
            r0 = this.ParseHelper<BracketedParameterListSyntax>(ref cursor, (ref Cursor state) =>
                #line 35 "CSharpParser.peg"
    ParseHelper(ref state, SyntaxFactory.ParseBracketedParameterList(state.Subject, state.Location, consumeFullText: false))
                #line default
                );
            return r0;
        }

        private IParseResult<
            #line 38 "CSharpParser.peg"
            ExpressionSyntax
            #line default
            > Expression(ref Cursor cursor)
        {
            IParseResult<ExpressionSyntax> r0 = null;
            r0 = this.ParseHelper<ExpressionSyntax>(ref cursor, (ref Cursor state) =>
                #line 39 "CSharpParser.peg"
    ParseHelper(ref state, SyntaxFactory.ParseExpression(state.Subject, state.Location, consumeFullText: false))
                #line default
                );
            return r0;
        }

        private IParseResult<
            #line 42 "CSharpParser.peg"
      NameSyntax
            #line default
            > Name(ref Cursor cursor)
        {
            IParseResult<NameSyntax> r0 = null;
            r0 = this.ParseHelper<NameSyntax>(ref cursor, (ref Cursor state) =>
                #line 43 "CSharpParser.peg"
    ParseHelper(ref state, SyntaxFactory.ParseName(state.Subject, state.Location, consumeFullText: false))
                #line default
                );
            return r0;
        }

        private IParseResult<
            #line 46 "CSharpParser.peg"
               ParameterListSyntax
            #line default
            > ParameterList(ref Cursor cursor)
        {
            IParseResult<ParameterListSyntax> r0 = null;
            r0 = this.ParseHelper<ParameterListSyntax>(ref cursor, (ref Cursor state) =>
                #line 47 "CSharpParser.peg"
    ParseHelper(ref state, SyntaxFactory.ParseParameterList(state.Subject, state.Location, consumeFullText: false))
                #line default
                );
            return r0;
        }

        private IParseResult<
            #line 50 "CSharpParser.peg"
           StatementSyntax
            #line default
            > Statement(ref Cursor cursor)
        {
            IParseResult<StatementSyntax> r0 = null;
            r0 = this.ParseHelper<StatementSyntax>(ref cursor, (ref Cursor state) =>
                #line 51 "CSharpParser.peg"
    ParseHelper(ref state, SyntaxFactory.ParseStatement(state.Subject, state.Location, consumeFullText: false))
                #line default
                );
            return r0;
        }

        private IParseResult<
            #line 54 "CSharpParser.peg"
      TypeSyntax
            #line default
            > Type(ref Cursor cursor)
        {
            IParseResult<TypeSyntax> r0 = null;
            r0 = this.ParseHelper<TypeSyntax>(ref cursor, (ref Cursor state) =>
                #line 55 "CSharpParser.peg"
    ParseHelper(ref state, SyntaxFactory.ParseTypeName(state.Subject, state.Location, consumeFullText: false))
                #line default
                );
            return r0;
        }

        private IParseResult<T> StartRuleHelper<T>(Cursor cursor, ParseDelegate<T> startRule, string ruleName)
        {
            var result = startRule(ref cursor);
            if (result == null)
            {
                throw ExceptionHelper(cursor, state => "Failed to parse '" + ruleName + "'.");
            }
            return result;
        }

        private IParseResult<string> ParseLiteral(ref Cursor cursor, string literal, bool ignoreCase = false)
        {
            if (cursor.Location + literal.Length <= cursor.Subject.Length)
            {
                var substr = cursor.Subject.Substring(cursor.Location, literal.Length);
                if (ignoreCase ? substr.Equals(literal, StringComparison.OrdinalIgnoreCase) : substr == literal)
                {
                    var endCursor = cursor.Advance(substr.Length);
                    var result = this.ReturnHelper<string>(cursor, ref endCursor, state => substr);
                    cursor = endCursor;
                    return result;
                }
            }
            return null;
        }

        private IParseResult<string> ParseClass(ref Cursor cursor, string characterRanges, bool negated = false, bool ignoreCase = false)
        {
            if (cursor.Location + 1 <= cursor.Subject.Length)
            {
                var c = cursor.Subject[cursor.Location];
                bool match = false;
                for (int i = 0; !match && i < characterRanges.Length; i += 2)
                {
                    match = c >= characterRanges[i] && c <= characterRanges[i + 1];
                }
                if (!match && ignoreCase && (char.IsUpper(c) || char.IsLower(c)))
                {
                    var cs = c.ToString();
                    for (int i = 0; !match && i < characterRanges.Length; i += 2)
                    {
                        var min = characterRanges[i];
                        var max = characterRanges[i + 1];
                        for (char o = min; !match && o <= max; o++)
                        {
                            match = (char.IsUpper(o) || char.IsLower(o)) && cs.Equals(o.ToString(), StringComparison.CurrentCultureIgnoreCase);
                        }
                    }
                }
                if (match ^ negated)
                {
                    var endCursor = cursor.Advance(1);
                    var substr = cursor.Subject.Substring(cursor.Location, 1);
                    var result = this.ReturnHelper<string>(cursor, ref endCursor, state => substr);
                    cursor = endCursor;
                    return result;
                }
            }
            return null;
        }

        private IParseResult<string> ParseAny(ref Cursor cursor)
        {
            if (cursor.Location + 1 <= cursor.Subject.Length)
            {
                var substr = cursor.Subject.Substring(cursor.Location, 1);
                var endCursor = cursor.Advance(1);
                var result = this.ReturnHelper<string>(cursor, ref endCursor, state => substr);
                cursor = endCursor;
                return result;
            }
            return null;
        }

        private IParseResult<T> ReturnHelper<T>(Cursor startCursor, ref Cursor endCursor, Func<Cursor, T> wrappedCode)
        {
            var result = wrappedCode(endCursor);
            var lexical = result as ILexical;
            if (lexical != null && lexical.StartCursor == null && lexical.EndCursor == null)
            {
                lexical.StartCursor = startCursor;
                lexical.EndCursor = endCursor;
            }
            return new ParseResult<T>(startCursor, endCursor, result);
        }

        private IParseResult<T> ParseHelper<T>(ref Cursor cursor, ParseDelegate<T> wrappedCode)
        {
            var startCursor = cursor;
            var result = wrappedCode(ref cursor);
            if (result == null)
            {
                cursor = startCursor;
                return null;
            }
            else
            {
                cursor = cursor.WithMutability(false);
                return result;
            }
        }

        private Exception ExceptionHelper(Cursor cursor, Func<Cursor, string> wrappedCode)
        {
            var ex = new FormatException(wrappedCode(cursor));
            ex.Data["cursor"] = cursor;
            return ex;
        }

        private T ValueOrDefault<T>(IParseResult<T> result)
        {
            return result == null
                ? default(T)
                : result.Value;
        }

        /// <summary>
        /// Defines the set of rules exported by this parser.
        /// </summary>
        public sealed class ExportedRules
        {
            private CSharpParser parser;

            internal ExportedRules(CSharpParser parser)
            {
                this.parser = parser;
            }

            /// <summary>
            ///  Executes the <c>ArgumentList</c> rule and advances the cursor.
            /// </summary>
            /// <returns>
            ///  A parse result containing the parsed <see cref="ArgumentListSyntax"/> if the parse was successful, <c>null</c> otherwise.
            /// </returns>
            public IParseResult<ArgumentListSyntax> ArgumentList(ref Cursor cursor)
            {
                return this.parser.ArgumentList(ref cursor);
            }

            /// <summary>
            ///  Executes the <c>AttributeArgumentList</c> rule and advances the cursor.
            /// </summary>
            /// <returns>
            ///  A parse result containing the parsed <see cref="AttributeArgumentListSyntax"/> if the parse was successful, <c>null</c> otherwise.
            /// </returns>
            public IParseResult<AttributeArgumentListSyntax> AttributeArgumentList(ref Cursor cursor)
            {
                return this.parser.AttributeArgumentList(ref cursor);
            }

            /// <summary>
            ///  Executes the <c>BracketedArgumentList</c> rule and advances the cursor.
            /// </summary>
            /// <returns>
            ///  A parse result containing the parsed <see cref="BracketedArgumentListSyntax"/> if the parse was successful, <c>null</c> otherwise.
            /// </returns>
            public IParseResult<BracketedArgumentListSyntax> BracketedArgumentList(ref Cursor cursor)
            {
                return this.parser.BracketedArgumentList(ref cursor);
            }

            /// <summary>
            ///  Executes the <c>BracketedParameterList</c> rule and advances the cursor.
            /// </summary>
            /// <returns>
            ///  A parse result containing the parsed <see cref="BracketedParameterListSyntax"/> if the parse was successful, <c>null</c> otherwise.
            /// </returns>
            public IParseResult<BracketedParameterListSyntax> BracketedParameterList(ref Cursor cursor)
            {
                return this.parser.BracketedParameterList(ref cursor);
            }

            /// <summary>
            ///  Executes the <c>Expression</c> rule and advances the cursor.
            /// </summary>
            /// <returns>
            ///  A parse result containing the parsed <see cref="ExpressionSyntax"/> if the parse was successful, <c>null</c> otherwise.
            /// </returns>
            public IParseResult<ExpressionSyntax> Expression(ref Cursor cursor)
            {
                return this.parser.Expression(ref cursor);
            }

            /// <summary>
            ///  Executes the <c>Name</c> rule and advances the cursor.
            /// </summary>
            /// <returns>
            ///  A parse result containing the parsed <see cref="NameSyntax"/> if the parse was successful, <c>null</c> otherwise.
            /// </returns>
            public IParseResult<NameSyntax> Name(ref Cursor cursor)
            {
                return this.parser.Name(ref cursor);
            }

            /// <summary>
            ///  Executes the <c>ParameterList</c> rule and advances the cursor.
            /// </summary>
            /// <returns>
            ///  A parse result containing the parsed <see cref="ParameterListSyntax"/> if the parse was successful, <c>null</c> otherwise.
            /// </returns>
            public IParseResult<ParameterListSyntax> ParameterList(ref Cursor cursor)
            {
                return this.parser.ParameterList(ref cursor);
            }

            /// <summary>
            ///  Executes the <c>Statement</c> rule and advances the cursor.
            /// </summary>
            /// <returns>
            ///  A parse result containing the parsed <see cref="StatementSyntax"/> if the parse was successful, <c>null</c> otherwise.
            /// </returns>
            public IParseResult<StatementSyntax> Statement(ref Cursor cursor)
            {
                return this.parser.Statement(ref cursor);
            }

            /// <summary>
            ///  Executes the <c>Type</c> rule and advances the cursor.
            /// </summary>
            /// <returns>
            ///  A parse result containing the parsed <see cref="TypeSyntax"/> if the parse was successful, <c>null</c> otherwise.
            /// </returns>
            public IParseResult<TypeSyntax> Type(ref Cursor cursor)
            {
                return this.parser.Type(ref cursor);
            }
        }
    }
}
