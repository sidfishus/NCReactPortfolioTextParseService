
using NCReactPortfolioTextParseService.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace NCReactPortfolioTextParseService.Models {

    public sealed class TextParseExtractModel : TextParseResultBase {

        [JsonProperty("ExtractedText")]
        public List<string> ExtractedText
        {
            get;
            set;
        }
    }
}