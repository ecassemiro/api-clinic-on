using API_Clinica.Model;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PEC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BotController : ControllerBase
    {
        [HttpGet]
        public object Get()
        {
            
            var response = new 
            {
                Type = "INFORMATION",
                Text = "teste aonde vc pode escrever o que quiser",

            };

            var teste = response.ToString();
            return new JsonResult(response);
        }

        public class Callback
        {
            public string endpoint { get; set; }
            public Data data { get; set; }
        }
        public class Data
        {
            public string example { get; set; }
        }
        public class Items
        {
            public int number { get; set; }
            public string text { get; set; }
            public Callback callback { get; set; }
        }

        // POST api/<BotController>
        [HttpPost]
        public object Post(Credentials_Request bot)
        {
            var Id = bot.Id;
            var Text = bot.Text;
            var Data = bot.Data;


            var Contact = bot.Contact;
            var uid = Contact.Uid;
            var type = Contact.Type;
            var Key = Contact.Key;
            var Name = Contact.Name;


            var Fields = Contact.Fields;
            var CPF = Fields.Cpf;
            var celular = Fields.Celular;

            // VOCES VAO COLOCAR OS TRATAMENTOS
            //SQL RECEBE ALGUMA VARIAVEL
            //FAZ UM WHERE COM A VARIAVEL
            //O QUE RETORNAR DESSE WHERE
            //VCS PODEM COLOCAR NA RESPONSE.

          

            var body = new
            {

                type = "MENU",
                text = "My first menu integration.",
                attachments = new[]
                {
                    new
                     {
                    position = "BEFORE",
                    type = "IMAGE",
                    name = "image.png",
                    url = "https://yourdomain.com/cdn/logo.png"
                }
                },

                items = new[]
                       {
                             new
                             {
                                number = 1,
                                 text = "CARDIO",
                                 callback = new Callback()
                                 {
                                     endpoint = "https://yourdomain.com/api/menu_1",
                                     data = new Data()
                                     {
                                         example = "Especialidade Cardio (text, text text..)",
                                     },
                                 },
                             },
                             new
                             {
                                 number = 2,
                                 text = " CLINICO GERAL",
                                 callback = new Callback()
                                 {
                                     endpoint = "https://yourdomain.com/api/menu_1",
                                     data = new Data()
                                     {
                                         example = "Especialidade CLINICO GERAL (text, text text..)",
                                     },
                                 },
                             },
                             new
                             {
                                 number = 3,
                                 text = " DERMATO",
                                 callback = new Callback()
                                 {
                                     endpoint = "https://yourdomain.com/api/menu_1",
                                     data = new Data()
                                     {
                                         example = "Especialidade DERMATO (text, text text..)",
                                     },
                                 },
                             },
                         }

            };

            return new JsonResult(body);
        }



        //retorno json assim oh
        //[HttpPost("{Json}")]
        //public object PostReturnJson()
        //{
        //    var payload = new Credentials_Request
        //    {
        //        Contact = new Contact
        //        {
        //            Name = "Agent Name",
        //        },
        //        Id = 23
        //    };

        //    var teste = payload;
        //    return new JsonResult(teste);

        //}


    }
}
