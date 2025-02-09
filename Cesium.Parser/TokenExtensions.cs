using Cesium.Core;
using Yoakke.SynKit.C.Syntax;
using Yoakke.SynKit.Lexer;

namespace Cesium.Parser;

public static class TokenExtensions
{
    public static string UnwrapStringLiteral(this IToken<CTokenType> token)
    {
        if (token.Kind != CTokenType.StringLiteral)
            throw new ParseException($"Non-string literal token: {token.Kind} {token.Text}");

        // TODO[#235]: More thorough unwrap for more literal types.
        return token.Text.Trim('"');
    }
}
