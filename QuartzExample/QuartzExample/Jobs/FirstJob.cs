using Quartz;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QuartzExample.Jobs
{
    public class FirstJob: IJob
    {
        public async Task Execute(IJobExecutionContext context)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
