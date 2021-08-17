
using Newtonsoft.Json;

namespace NCReactPortfolioTextParseService
{

    public class ExecuteReplaceModel {
        [JsonProperty("Code")]

        public string Code {
            get;
            set;
        }

        [JsonProperty("ReturnVariableName")]
        public string ReturnVariableName {
            get;
            set;
        }

        [JsonProperty("UsingStatements")]
        public string[] UsingStatements {
            get;
            set;
        }
    };

};