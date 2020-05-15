using System;
namespace OOPInterface 
{
    public class IPrinterWindows
    {
        void Show()
        {
            
        }
        void Print()
        {
            
        }
    }
    
    public class Epson : IPrinterWindows
	{
		public void Show()
		{
			Console.WriteLine("Epson display dimension : 10*11");
		}
		public void Print()
		{
			Console.WriteLine("Epson printer printing....");
		}
	}
	
	public class Canon : IPrinterWindows
	{
		public void Show()
		{
			Console.WriteLine("Canon display dimension : 9.5*12");
		}
		public void Print()
		{
			Console.WriteLine("Canon printer printing....");
		}
	}
	
	public class LaserJet : IPrinterWindows
	{
		public void Show()
		{
			Console.WriteLine("LaserJet display dimension : 12*12");
		}
		public void Print()
		{
			Console.WriteLine("LaserJet printer printing....");
		}
	}
}
