using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ListaCursos.Interfaces;
using ListaCursos.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;


namespace ListaCursos.Pages
{
    public class ChatModel : PageModel
    {

        private readonly IMessageProvider messageProvider;

         // Marked as BindProperty for use link bidirectional and support of get/post 
        [BindProperty(SupportsGet = true)]
        public string TypeMessage { get; set; }

        public List<Message> Messages = new List<Message>();

        private string UID;

        public ChatModel(IMessageProvider messageProvider)
        {
            this.messageProvider = messageProvider;
            this.UID = Guid.NewGuid().ToString();


        }

        public void OnGet()
        {
            // Validate than TypeMessage isn't null or empty
            if (!string.IsNullOrWhiteSpace(TypeMessage))
            {
                // Create Object 
                Message ms = new Message()
                {
                    Id = UID,
                    Name = "",
                    MessageText = TypeMessage
                };

                // Add message to message List
                Messages.Add(ms);

                //  Serialize Message Object
                string msJson = JsonConvert.SerializeObject(ms);
                
                messageProvider.SendMessage(msJson);
                
               
            }
            else
            {

                var result = messageProvider.GetMessage();
                if (result != null)
                {
                    Messages.Add(result);                    
                }

            }
         
        }

      
    }
}
