using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace UWPhabitHero
{
    public class TodoItem // Todo object for users to write to, also stored on azure with node.js
    {
        public string Id { get; set; } // id of the item

        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; } // the text of the item

        [JsonProperty(PropertyName = "complete")]
        public bool Complete { get; set; } // boolean to check if the textbox is checked
    }
}
