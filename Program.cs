int nilai;
string nama;

Console.WriteLine("Aplikasi nilai siswa\n");

Console.WriteLine("Nama siswa: ");
nama = Console.ReadLine();

Console.WriteLine("Nilai: ");
nilai = int.Parse(Console.ReadLine());

if (nilai == 75)
{
    Console.WriteLine("Selamat anda lulus");
}
else
{
    Console.WriteLine("Maaf, anda belum lulus");
}