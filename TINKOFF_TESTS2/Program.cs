﻿using System;
//В некоторой компании есть n﻿ джунов-разработчиков и ﻿m﻿ сеньор-разработчиков. Чтобы код, который написал джун, мог попасть в прод, его должны проверить хотя бы k﻿ сеньоров. На проверку одной программы сеньор-разработчик тратит 1﻿ минуту.

//Каждый из ﻿n﻿ джунов написал программу, которую хочет отправить в прод. К сожалению, система проверки пока не распределенная, поэтому два разработчика не могут проверять одну работу одновременно. Также сеньор-разработчик хочет провести действительно хорошее код-ревью, поэтому две программы одновременно он не проверяет и не отвлекается на другие дела во время проверки.

//Определите, сколько времени в минутах потребуется всем сеньор-разработчикам для просмотра всех написанных джунами программ.
class Program
{

    static void Main(string[] args)
    {
        // ФОРМАТ "N""M""T"
        try
        {
            string str = Console.ReadLine();
            string[] subs = str.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            uint dg = Convert.ToUInt32(subs[0]);
            uint sn = Convert.ToUInt32(subs[1]);
            uint count = Convert.ToUInt32(subs[2]);
            if ((dg >= 0 && dg <= 10000) && (sn >= 0 && sn <= 10000) && (count >= 0 && count <= 10000))
            {
                uint itog;
                uint pl = dg * count;
                if (pl % sn != 0)
                {
                    itog = pl / sn + 1;
                }
                else
                {
                    itog = dg * count / sn;
                }
                Console.WriteLine(itog);
            }
            else
            {
                Console.WriteLine("Превышен лимит");
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Неверный формат");
        }
    }
}

