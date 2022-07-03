
Console.WriteLine("Task 1 a.");

byte myByte;
myByte = 5;
short myShort = myByte;
Console.WriteLine("1.1. Converting a smaller type to a larger type size, short myShort = " + myShort + ". It's implicit conversion.\n");

short myShort1 = 32_767;
int myInt1 = myShort1;
Console.WriteLine("1.2. short c = myShort1, int myInt1. myInt1 = myShort1; myInt1 = " + myInt1 + ". It's implicit conversion.\n");

myInt1 = myShort;
Console.WriteLine("1.3. Convert short variable to int. myInt1 = " + myInt1 + ". It's implicit conversion.\n");

sbyte mySbyte = 127;
int myInt2 = mySbyte * 258 + 1;
Console.WriteLine("1.4. sbyte variable converted to int. myInt2 = " + myInt2 + ". It's implicit conversion.\n");

int myInt3 = 234_567;
double myDouble = myInt3 / 34.5;
Console.WriteLine("1.5. int variable converted to double. myDouble = " + myDouble + ". It's implicit conversion.\n");

float pi = 3.14F;
double myDouble1 = pi;
Console.WriteLine("1.6. float variable converted to double. myDouble1 = " + myDouble1 + ". It's implicit conversion.\n");

long myLong = myInt3;
Console.WriteLine("1.7. Converted int to long. myLong = " + myLong + ". It's implicit conversion.\n");

myLong = myByte + 19450;
Console.WriteLine("1.8. Converted byte to long. myLong = " + myLong + ". It's implicit conversion.\n");

uint myUint = 98_767;
ulong myUlong = myUint / 45;
Console.WriteLine("1.9. Converted uint to ulong. myLong = " + myUlong + ". It's implicit conversion.\n");

ushort myUshort = 67;
double myDouble2 = myUshort;
Console.WriteLine("1.10. ushort variable converted to double. myDouble2 = " + myDouble2 + ". It's implicit conversion.\n");

Console.WriteLine("Task 2 b.");

long myLong3 = 565673;
myShort = (short)myLong3;
Console.WriteLine("2.1. long variable converted to short. myShort = " + myShort + ". It's explicit conversion.\n");

byte myByte3 = 127;
sbyte mySbyte4 = Convert.ToSByte(myByte3);
Console.WriteLine("2.2. byte variable converted to sbyte. mySbyte4 = " + mySbyte4 + ". It's explicit conversion.\n");

double myDouble4 = 23.56;
int myInt4 = (int)myDouble4;
Console.WriteLine("2.3. double variable converted to int. mySbyte4 = " + myInt4 + ". It's explicit conversion.\n");

decimal myDecimal = Decimal.MinValue / 10000000000000;
long myLong1 = (long)myDecimal;
Console.WriteLine("2.4. decimal variable converted to long. myLong1 = " + myLong1 + ". It's explicit conversion.\n");

float myFloat = 4545.56f;
int myInt5 = (int)myFloat;
Console.WriteLine("2.5. float variable converted to int. myInt5 = " + myInt5 + ". It's explicit conversion.\n");

int myInt6 = 43;
string myString = Convert.ToString(myInt6);
Console.WriteLine("2.6. int variable converted to string. myString = \"" + myString + "\". It's explicit conversion.\n");

char myChar = 'f';
string myString2 = Convert.ToString(myChar);
Console.WriteLine("2.7. char variable converted to string. myString2 = \"" + myString2 + "\". It's explicit conversion.\n");

string myString3 = "5";
int myInt7 = Convert.ToInt32(myString3) + 1;
Console.WriteLine("2.8. string variable converted to int. myInt7 = " + myInt7 + ". It's explicit conversion.\n");

char myChar2 = '2';
int myInt8 = int.Parse(myChar2.ToString()) + 2;
Console.WriteLine("2.9. char variable parsed to int. myInt8 = " + myInt8 + ". It's explicit conversion.\n");

float myFloat1 = 454.66f;
string myString4 = Convert.ToString(myFloat1);
Console.WriteLine("2.10. float variable converted to string. myString4 = " + myString4 + ". It's explicit conversion.\n");

// "Task 1 c & d.Boxing / Unboxing"

int q = 545;
object obj = q;

obj = 897;
q = (int)obj;

string text = "hi";
obj = text;

obj = "bye";
text = (string)obj;

short sh = 33;
obj = sh;

obj = 32767;
sh = Convert.ToInt16(obj);

bool isTrue = false;
obj = isTrue;

obj = true;
isTrue = (Boolean)obj;

sbyte sb = 127;
obj = sb;

obj = -127;
sb = Convert.ToSByte(obj);

uint ui = 4294967295;
obj = ui;

obj = 0;
ui = Convert.ToUInt32(obj);

long lg = 9_223_372_036_854_775_807;
obj = lg;

obj = -9_223_372_036_854_775_808;
lg = (Int64)obj;

char ch = '$';
obj = ch;

obj = '€';
ch = (Char)obj;

double db = 34.4353;
obj = db;

obj = 3534.67567;
db = (Double)obj;

string num = "5";
obj = num;

obj = 6;
num = Convert.ToString(obj);