﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    public class EsnafKredisiManager : IKrediManager
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Esnaf Kredisi hesaplandı.");
        }
    }
}
