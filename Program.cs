
using System;
using System.Threading;
 




namespace Practica2reloj
{
	class MainClass
	{
		
		static void Cronometro(){
					int minutos;
					int segundos;
					int horas;
					int milisegundos;
					
					
				for(horas=0;horas < 24; horas++){
					for (minutos=0;minutos<60;minutos++) {
						for (segundos=0; segundos<60; segundos++){
								for(milisegundos =0;milisegundos<100;milisegundos++){
									//Console.SetCursorPosition(5,50);
								Console.Clear();
								Console.WriteLine(""+horas+":"+minutos+":"+segundos+":"+milisegundos);
								Thread.Sleep(10);
								}
								
						}
					}
		
				}
		}
		static void reloj(){
		int horas;
			int minutos;
			int segundos;
			DateTime reloj = DateTime.Now;
			for (horas= reloj.Hour;horas<24;horas++) {
						for (minutos=reloj.Minute; minutos<60; minutos++){
								for(segundos= reloj.Second ;segundos<60;segundos++){
								reloj = DateTime.Now;
								Console.Clear();
								Console.WriteLine(""+horas+":"+minutos+":"+segundos);
								Thread.Sleep(1000);
								
								}
								
						}
					}
		}
		
		public static void Main (string[] args)
		{
			int menu;
			
			
			do {

				Console.WriteLine("\n1.-Cronometro\n2.-Reloj\n3.-Salir");

				menu=int.Parse(Console.ReadLine());
				switch (menu) {
			case 1 :
					Cronometro();
					break;

				case 2 :
					reloj();
					break;
				}

			}while (menu!=3);

		}
	}
}