using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CatFactNetwise.Models
{
    public   class ParameterConnect
    { 
        protected   string _baseAdress;
        public  string BaseAdress
        {
            get 
            {
                if (String.IsNullOrWhiteSpace(_baseAdress))
                {
                    _baseAdress = "https://catfact.ninja/fact";
                }

                return _baseAdress;
            }
           
        }
        protected   HttpClient _httpClient;
        public  HttpClient HttpClient
        {
            get 
            {
                if (_httpClient == null)
                {
                    _httpClient = new HttpClient();
                }

                return _httpClient;
            }
            
        }

        


        
    }
}
