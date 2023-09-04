// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

byte b = 5;
sbyte c = 5;

short s = 4;
ushort us = 7;

Int16 i16 = 97;
Int32 i32 = 24;
int i = 116;
Int64 i64 = 211;
uint iu = 785;

long l = 69;
ulong ul = 71;

//Reel Sayılar
float f = 21;
double d = 21.5;
decimal de = 81;

char ch = '1';
string str = "Selam";

bool b1 = true;
bool b2 = false;

DateTime dt = DateTime.Now;
Console.WriteLine(dt);

object o1 = "4";
object o2 = '3';
object o3 = 4;
object o4 = 4.3;

//String İfadeler
string str1 = string.Empty;
str1 = "Baran Tarhan";
string ad = "Baran";
string soyad = "Tarhan";
string tamisim = ad + " " + soyad;

//İnteger tanımlama
int s1 = 21;
int s2 = 4;
int toplam = s1 * s2;

//boolean
bool z = 10>4;

//Değişken dönüşümleri
string str20 = "20";
int int20 = 20;
string sondeger = str20 + int20.ToString();
Console.WriteLine(sondeger); // Çıktı 2020

int Int21 = int20 + Convert.ToInt32(str20);
Console.WriteLine(Int21); // Çıktı 40

int int22 = int20 + int.Parse(str20);
Console.WriteLine(int22); // Çıktı 40

//DateTime
string dt1 = DateTime.Now.ToString("dd.MM.yyyy");
Console.WriteLine(dt1);

string dt2 = DateTime.Now.ToString("dd/MM/yyyy");
Console.WriteLine(dt2);

//Saat
string hour = DateTime.Now.ToString("HH.mm");
Console.WriteLine(hour);