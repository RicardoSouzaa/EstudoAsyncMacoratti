using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteWfAsyncMacoratti
{
    class Teste
    {
        public async Task<bool> Task_Tresult_Async()
        {
            return await Task.FromResult<bool>(DateTime.IsLeapYear(DateTime.Now.Year));
        }

        public async Task Task_Void_Async()
        {
            await Task.Delay(10000);
            Console.WriteLine("10 segundos de atraso");
        }

        public async Task Task_LongaDuracao()
        {
            // espera verificar se é bissexto
            bool isAnoBissexto = await Task_Tresult_Async();

            Console.WriteLine($"{DateTime.Now.Year} {(isAnoBissexto ? "é" : "não é ")} um ano Bissexto -------- { DateTime.Now}");

            //por ultimo espera 10s e finaliza o longa.
            await Task_Void_Async();

            //Task taskTResultAsync = Task_Tresult_Async();
        }
    }
}