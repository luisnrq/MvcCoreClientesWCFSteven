using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReferenceNumberConversion;

namespace MvcCoreClientesWCF.Services
{
    public class ServiceNumberConversion
    {
        private NumberConversionSoapTypeClient client;
        public ServiceNumberConversion(NumberConversionSoapTypeClient client) 
        {
            this.client = client;
        }

        public async Task<string> GetNumberWords(int numero) 
        {
            NumberToWordsResponse response =
            await this.client.NumberToWordsAsync((ulong)numero);
            string result = response.Body.NumberToWordsResult;
            return result;
        }
    }
}
