using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpier.Core
{
    public partial class Printer
    {
        private Doc PrintBinaryExpressionSyntax(BinaryExpressionSyntax node)
        {
            var useLine = node.OperatorToken.Kind() is SyntaxKind.BarBarToken or SyntaxKind.BarToken or SyntaxKind.AmpersandAmpersandToken or SyntaxKind.AmpersandToken;
            
            return Concat(
                this.Print(node.Left),
                SpaceIfNoPreviousComment,
                this.PrintSyntaxToken(node.OperatorToken),
                useLine ? Line : SpaceIfNoPreviousComment,
                this.Print(node.Right));
        }
    }
}