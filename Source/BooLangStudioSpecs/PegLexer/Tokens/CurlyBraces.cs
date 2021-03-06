﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.Package;
using System.IO;
using Xunit;
using Spec = Xunit.FactAttribute;
using Rhino.Mocks;
using Rhino.Testing.AutoMocking;

using Boo.BooLangService;

namespace Boo.BooLangStudioSpecs
{

    public class TokenLeftCurlyBraces : AutoTokenTestFixture
    {
        public TokenLeftCurlyBraces()
            : base()
        {
            //      0
            //      0
            line = "{";
            offset = 0;

            expectedTokenType = TokenType.Delimiter;
            expectedTokenColor = TokenColor.Text;
            expectedStartIndex = 0;
            expectedEndIndex = 0;

            BuildTokens(line, offset);
        }

    }

    public class TokenRightCurlyBraces : AutoTokenTestFixture
    {
        public TokenRightCurlyBraces()
            : base()
        {
            //      0
            //      0
            line = "}";
            offset = 0;

            expectedTokenType = TokenType.Delimiter;
            expectedTokenColor = TokenColor.Text;
            expectedStartIndex = 0;
            expectedEndIndex = 0;

            BuildTokens(line, offset);
        }

    }

}