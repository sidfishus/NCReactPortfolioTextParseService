
using NCReactPortfolioTextParseService.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace NCReactPortfolioTextParseService.Models {

    public sealed class TextParseReplaceModel : TextParseResultBase {

        [JsonProperty("ReplacedText")]
        public string ReplacedText
        {
            get;
            set;
        }

        [JsonProperty("NumMatching")]
        public int NumMatching
        {
            get;
            set;
        }
    }
}