// See https://aka.ms/new-console-template for more information
using mod4_103022330036;

internal class Program
{
    private static void Main(string[] args)
    {
        kodeProduk produk = new kodeProduk();
        Console.WriteLine("Laptop " + produk.getKodeProduk("Laptop"));
        Console.WriteLine("Smartphone " + produk.getKodeProduk("Smartphone"));
        Console.WriteLine("Tablet " + produk.getKodeProduk("Tablet"));
        Console.WriteLine("Headset " + produk.getKodeProduk("Headset"));
        Console.WriteLine("Keyboard " + produk.getKodeProduk("Keyboard"));
        Console.WriteLine("Mouse  " + produk.getKodeProduk("Mouse"));
        Console.WriteLine("Printer " + produk.getKodeProduk("Printer"));
        Console.WriteLine("Monitor " + produk.getKodeProduk("Monitor"));
        Console.WriteLine("Smartwatch " + produk.getKodeProduk("Smartwatch"));
        Console.WriteLine("Kamera " + produk.getKodeProduk("Kamera"));

        Console.WriteLine("\n");

        FanLaptop fan = new FanLaptop();
        Console.WriteLine("== Fan Laptop Status ==");
        Console.WriteLine("== Status Awal==");
        string choice = Console.ReadLine();
        string command = Console.ReadLine();
        switch (command)
        {
            case "Turbo":
                fan.Turbo();
                break;
            case "Quite":
                fan.Quite();
                break;
            case "Performance":
                fan.Performance();
                break;
            case "Balanced":
                fan.Balanced();
                break;
            default:
                Console.WriteLine("Perintah tidak valid Silahkan coba lagi");
                break;
        }
        fan.showState();
    }
    }