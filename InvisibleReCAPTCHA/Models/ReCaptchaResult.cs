using System.Collections.Generic;
using Newtonsoft.Json;

namespace InvisibleReCAPTCHA.Models
{
    public class ReCaptchaResult
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("error-codes")]
        public List<string> ErrorCodes { get; set; }
    }
}