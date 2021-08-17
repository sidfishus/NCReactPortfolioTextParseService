
using Newtonsoft.Json;

namespace NCReactPortfolioTextParseService.Models {

    public sealed class TextParseMatchModel : TextParseResultBase {

        [JsonProperty("NumMatching")]
        public int NumMatching
        {
            get;
            set;
        }
    }
}