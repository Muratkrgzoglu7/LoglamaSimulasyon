using System;
using System.Collections.Generic;

namespace OOP3
{
	class Program
	{
		static void Main(string[] args)
		{
			IKrediManager tasitKrediManager = new TasitKrediManager();
			IKrediManager konutKrediManager = new KonutKrediManager();		
			IKrediManager ihtiyacKrediManager = new İhtiyacKrediManager();
			IKrediManager esnafKrediManager = new EsnafKrediManager();

			ILoggerService dataBaseLoggerService = new DataBaseLoggerService();
			ILoggerService fileBaseLoggerService = new FileBaseLoggerService();
			ILoggerService smsLoggerService = new SmsLoggerService();


			BasvuruManager basvuruManager = new BasvuruManager();
			basvuruManager.BasvuruYap(new TasitKrediManager(),new List<ILoggerService>() {new FileBaseLoggerService()
				,new SmsLoggerService() }) ;
			List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,konutKrediManager,tasitKrediManager };
			//basvuruManager.KrediOnBilgilendirmesiYap(krediler);
			
		}
	}
}
