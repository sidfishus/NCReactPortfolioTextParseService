
using Newtonsoft.Json;

namespace NCReactPortfolioTextParseService
{
    public class TextParseBuiltInExampleModel {
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