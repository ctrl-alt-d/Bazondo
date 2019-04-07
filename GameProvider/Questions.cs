using System.Collections.Generic;
using Newtonsoft.Json; 

namespace Blazondo.Questions
{
    public class Questions 
    {

        public IEnumerable<Question> AllQuestions => JsonConvert.DeserializeObject<IEnumerable<Question>>(allQuestionsTxt);
        public string AllQuestionsTxt { get => allQuestionsTxt; }
        private string allQuestionsTxt = @"[
 { ""level"":""groc"", ""negre"":""si"", ""tecnica"":""are maki"", ""video"":""y3nUBMaMIgw"", ""alt"": """", ""picture"": ""are-makki"" },
 { ""level"":""groc"", ""negre"":""si"", ""tecnica"":""montong maki"", ""video"":""5dpFzb5eges"", ""alt"": """", ""picture"": ""are-makki"" },
 { ""level"":""groc"", ""negre"":""si"", ""tecnica"":""Montong an maki"", ""video"":""5fkuhw3ykeE"", ""alt"": """", ""picture"": ""are-makki"" },
 { ""level"":""groc"", ""negre"":""si"", ""tecnica"":""Olgul maki"", ""video"":""eLmvdSATImQ"", ""alt"": """", ""picture"": ""are-makki"" },
 { ""level"":""verd"", ""negre"":""si"", ""tecnica"":""Montong bakat maki"", ""video"":""FJHvYN50-K0"", ""alt"": """", ""picture"": ""are-makki"" },
 { ""level"":""verd"", ""negre"":""si"", ""tecnica"":""sonnal montong maki"", ""video"":""eb52M8MPbIM"", ""alt"": """", ""picture"": ""are-makki"" },
 { ""level"":""verd"", ""negre"":""si"", ""tecnica"":""jansonnal montong bakat maki"", ""video"":""vYhSC67r93o"", ""alt"": """", ""picture"": ""are-makki"" },
 { ""level"":""verd"", ""negre"":""si"", ""tecnica"":""nulo maki"", ""video"":""hWcDlF0r8DM"", ""alt"": """", ""picture"": ""are-makki"" },
 { ""level"":""blau"", ""negre"":""si"", ""tecnica"":""olgul bakat maki"", ""video"":""IuvzhF7rfKk"", ""alt"": """", ""picture"": ""are-makki"" },
 { ""level"":""blau"", ""negre"":""si"", ""tecnica"":""gechio are maki"", ""video"":""_pmtJV1w_Q0"", ""alt"": """", ""picture"": ""are-makki"" },
 { ""level"":""marró"", ""negre"":""si"", ""tecnica"":""batagson montong an maki"", ""video"":""dYO7moC38vI"", ""alt"": """", ""picture"": ""are-makki"" },
 { ""level"":""marró"", ""negre"":""si"", ""tecnica"":""sonnal are maki"", ""video"":""V6WI_u9WPJA"", ""alt"": """", ""picture"": ""are-makki"" },
 { ""level"":""marró"", ""negre"":""si"", ""tecnica"":""goduro batagson montong an maki"", ""video"":""uHZ6vmvikAc"", ""alt"": """", ""picture"": ""are-makki"" },
 { ""level"":""marró"", ""negre"":""si"", ""tecnica"":""gechio montong maki"", ""video"":""f0wssE3FkYQ"", ""alt"": """", ""picture"": ""are-makki"" },
 { ""level"":""marró"", ""negre"":""si"", ""tecnica"":""okgoro are maki"", ""video"":""mVd6rud9Wjc"", ""alt"": """", ""picture"": ""are-makki"" },
 { ""level"":""marró"", ""negre"":""si"", ""tecnica"":""jansonnal montong yop maki"", ""video"":""Lcs_rJEHvAw"", ""alt"": """", ""picture"": ""are-makki"" },
 { ""level"":""negre"", ""negre"":""si"", ""tecnica"":""goduro montong maki"", ""video"":""jDuPHXcKiXs"", ""alt"": """", ""picture"": ""are-makki"" },
 { ""level"":""negre"", ""negre"":""si"", ""tecnica"":""goduro are maki"", ""video"":""YjJmEHA62Ck"", ""alt"": """", ""picture"": ""are-makki"" },
 { ""level"":""groc"", ""negre"":""si"", ""tecnica"":""Montong bande jirugui"", ""video"":""ArcCBvkyLA4"", ""alt"": """", ""picture"": ""are-makki"" },
 { ""level"":""groc"", ""negre"":""si"", ""tecnica"":""Montong baro jirugui"", ""video"":""zwvB31_dC_k"", ""alt"": """", ""picture"": ""are-makki"" },
 { ""level"":""taronja"", ""negre"":""si"", ""tecnica"":""olgul bande jirugui"", ""video"":""Jpst_GappfM"", ""alt"": """", ""picture"": ""are-makki"" },
 { ""level"":""verd"", ""negre"":""si"", ""tecnica"":""Dubong montong jirugui"", ""video"":""FznywtUJlJ8"", ""alt"": """", ""picture"": ""are-makki"" },
 { ""level"":""verd"", ""negre"":""si"", ""tecnica"":""jansonnal mok chigui"", ""video"":""GARSXnyJV0U"", ""alt"": ""jansonnal an chigui"", ""picture"": ""are-makki"" },
 { ""level"":""verd"", ""negre"":""si"", ""tecnica"":""pionson kut seuo chirugui"", ""video"":""Mu6_Lui_ip4"", ""alt"": """", ""picture"": ""are-makki"" },
 { ""level"":""verd"", ""negre"":""si"", ""tecnica"":""dung chumok ape chigui"", ""video"":""l4KM6HRNB48"", ""alt"": """", ""picture"": ""are-makki"" },
 { ""level"":""blau"", ""negre"":""si"", ""tecnica"":""palkup dollyo chigui"", ""video"":""kenoYzX61zo"", ""alt"": """", ""picture"": ""are-makki"" },
 { ""level"":""marró"", ""negre"":""si"", ""tecnica"":""du chumok checho jirugui"", ""video"":""aI-HSZCWGyc"", ""alt"": """", ""picture"": ""are-makki"" },
 { ""level"":""marró"", ""negre"":""si"", ""tecnica"":""dung chumok bakat chigui"", ""video"":""MW-Pfo0CDMI"", ""alt"": """", ""picture"": ""are-makki"" },
 { ""level"":""marró"", ""negre"":""si"", ""tecnica"":""yop jirugui"", ""video"":""gbsfs9E3NI0"", ""alt"": """", ""picture"": ""are-makki"" },
 { ""level"":""verd"", ""negre"":""si"", ""tecnica"":""chebipum mok chigui"", ""video"":""_vaC0DUpohg"", ""alt"": """", ""picture"": ""are-makki"" },
 { ""level"":""blau"", ""negre"":""si"", ""tecnica"":""montong piochok palkup chigui"", ""video"":""WUPBPPUYWT0"", ""alt"": ""palkup montong piochok chigui"", ""picture"": ""are-makki"" },
 { ""level"":""blau"", ""negre"":""si"", ""tecnica"":""bituro jansonnal olgul bakat maki"", ""video"":""2ceqGSwbm8M"", ""alt"": """", ""picture"": ""are-makki"" },
 { ""level"":""marró"", ""negre"":""si"", ""tecnica"":""gawi maki"", ""video"":""zjiPglLsdOY"", ""alt"": """", ""picture"": ""are-makki"" },
 { ""level"":""marró"", ""negre"":""si"", ""tecnica"":""dangkiok ollyo murup chigui"", ""video"":""4igah7sddqQ"", ""alt"": """", ""picture"": ""are-makki"" },
 { ""level"":""negre"", ""negre"":""si"", ""tecnica"":""oe santul maki"", ""video"":""c0sDiHSDg0w"", ""alt"": """", ""picture"": ""are-makki"" },
 { ""level"":""negre"", ""negre"":""si"", ""tecnica"":""dangkiok tok jirugui"", ""video"":""ZbOd9D6RdYw"", ""alt"": """", ""picture"": ""are-makki"" },
 { ""level"":""groc"", ""negre"":""si"", ""tecnica"":""ap chagui"", ""video"":""G8KCx2g1nfs"", ""alt"": """", ""picture"": ""are-makki"" },
 { ""level"":""taronja"", ""negre"":""si"", ""tecnica"":""dollyo chagui"", ""video"":""mY-lCnt12Ck"", ""alt"": """", ""picture"": ""are-makki"" },
 { ""level"":""verd"", ""negre"":""si"", ""tecnica"":""yop chagui"", ""video"":""vHFKx2jRcCU"", ""alt"": """", ""picture"": ""are-makki"" },
 { ""level"":""taronja"", ""negre"":""si"", ""tecnica"":""tuit chagui"", ""video"":""Jdgnmr9enu8"", ""alt"": """", ""picture"": ""are-makki"" },
 { ""level"":""verd"", ""negre"":""si"", ""tecnica"":""nako chagui"", ""video"":""HaSC6PZzw0U"", ""alt"": """", ""picture"": ""are-makki"" },
 { ""level"":""verd"", ""negre"":""si"", ""tecnica"":""furio chagui"", ""video"":""3QRqe15zIKE"", ""alt"": """", ""picture"": ""are-makki"" },
 { ""level"":""verd"", ""negre"":""si"", ""tecnica"":""neryo chagui"", ""video"":""524tqlcNlJk"", ""alt"": """", ""picture"": ""are-makki"" },
 { ""level"":""blau"", ""negre"":""si"", ""tecnica"":""mom dollyo yop chagui"", ""video"":""zXnz75Wh308"", ""alt"": """", ""picture"": ""are-makki"" },
 { ""level"":""blau"", ""negre"":""si"", ""tecnica"":""mom dollyo tuit chagui"", ""video"":""XFsQVojlQ58"", ""alt"": """", ""picture"": ""are-makki"" },
 { ""level"":""marró"", ""negre"":""si"", ""tecnica"":""mom dollyo nako chagui"", ""video"":""z_9Cv3DXcJU"", ""alt"": """", ""picture"": ""are-makki"" },
 { ""level"":""marró"", ""negre"":""si"", ""tecnica"":""mom dollyo furio chagui"", ""video"":""m0eF69SfcPY"", ""alt"": """", ""picture"": ""are-makki"" },
 { ""level"":""groc"", ""negre"":""no"", ""tecnica"":""bandal chagui"", ""video"":""YExkwhssI9k"", ""alt"": """", ""picture"": ""are-makki"" },
 { ""level"":""groc"", ""negre"":""no"", ""tecnica"":""tuio bandal chagui"", ""video"":""DxDCg_6v9rE"", ""alt"": """", ""picture"": ""are-makki"" },
 { ""level"":""taronja"", ""negre"":""no"", ""tecnica"":""tuio ap chagui"", ""video"":""Z9rnJ15KKCU"", ""alt"": """", ""picture"": ""are-makki"" },
 { ""level"":""taronja"", ""negre"":""si"", ""tecnica"":""bakat chagui"", ""video"":""5hEZJ_Y22e0"", ""alt"": """", ""picture"": ""are-makki"" },
 { ""level"":""taronja"", ""negre"":""no"", ""tecnica"":""Tuio dollyo chagui"", ""video"":""DmnCfnC7qeM"", ""alt"": """", ""picture"": ""are-makki"" },
 { ""level"":""taronja"", ""negre"":""no"", ""tecnica"":""Tuio tuit chagui"", ""video"":""C5rBfYD15p4"", ""alt"": """", ""picture"": ""are-makki"" },
 { ""level"":""taronja"", ""negre"":""no"", ""tecnica"":""an chagui"", ""video"":""iO-Py_LDQYM"", ""alt"": """", ""picture"": ""are-makki"" },
 { ""level"":""taronja"", ""negre"":""si"", ""tecnica"":""olgul baro jirugui"", ""video"":""ea7GPUMsm6w"", ""alt"": """", ""picture"": ""are-makki"" },
 { ""level"":""taronja"", ""negre"":""no"", ""tecnica"":""miro chagui"", ""video"":""SpIJto5c7RM"", ""alt"": """", ""picture"": ""are-makki"" },
 { ""level"":""blau"", ""negre"":""si"", ""tecnica"":""Batangson montong maki "", ""video"":""BY6J0w04cXQ"", ""alt"": """", ""picture"": ""are-makki"" },
 { ""level"":""blau"", ""negre"":""si"", ""tecnica"":""Me chumok neryo yop chigui"", ""video"":""nEe4xzKwHQo"", ""alt"": """", ""picture"": ""are-makki"" },
 { ""level"":""blau"", ""negre"":""si"", ""tecnica"":""Tuio mom dollyo yop chagui"", ""video"":""IQS3q3AhbWE"", ""alt"": """", ""picture"": ""are-makki"" },
 { ""level"":""marró"", ""negre"":""si"", ""tecnica"":""Piochok chagui"", ""video"":""e6UR_s0NWzI"", ""alt"": """", ""picture"": ""are-makki"" },
 { ""level"":""negre"", ""negre"":""si"", ""tecnica"":""Tuio mom dollyo furio chagui "", ""video"":""7DtMO2tEMGs"", ""alt"": """", ""picture"": ""are-makki"" },
 { ""level"":""negre"", ""negre"":""si"", ""tecnica"":""Dubandanlsang ap chagui"", ""video"":""wK_1zLUnwQY"", ""alt"": """", ""picture"": ""are-makki"" },
 { ""level"":""negre"", ""negre"":""si"", ""tecnica"":""Tuio mom dollyo nako chagui"", ""video"":""a1C56KYeL2E"", ""alt"": """", ""picture"": ""are-makki"" }
]
";
    }
}