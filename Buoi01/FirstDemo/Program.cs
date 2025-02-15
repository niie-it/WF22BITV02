Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.InputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Hello, World!");
string HoTen;
int NamSinh;
Console.Write("Nhập họ tên: ");
HoTen = Console.ReadLine();
Console.Write("Nhập năm sinh: ");
NamSinh = int.Parse(Console.ReadLine());

Console.WriteLine($"Bạn {HoTen}, sinh {NamSinh}, {DateTime.Now.Year - NamSinh} tuổi");