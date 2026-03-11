//metod - a n dəyəri göndəriləcək.Metod həmin ədədin kvadratını qaytaracaq

//static int a(int n)
//{
//    return n * n;
//}

//int netice = a(5);
//Console.WriteLine(netice);

//Metod - a n dəyəri göndəriləcək.metod 1-dən n-dək olan cüt ədədlərin cəmini qaytaracaq

//static int a(int n)
//{
//    int cem = 0;
//    for (int i = 1; i <= n; i++)
//    {
//        if (i % 2 == 0)
//        {
//            cem += i;
//        }
//    }
//    return cem;
//}
//int netice = a(10);
//Console.WriteLine(netice);

//metod - a ədədlər massiv göndəriləcək.Həmin massivdəki, ən kiçik elementi tapıb geri qaytaracaq

//static int a(int[] ededler)
//{
//    int eded = ededler[0];
//    for (int i = 1; i < ededler.Length; i++)
//    {
//        if (eded > ededler[i])
//        {
//            eded = ededler[i];
//        }
//    }
//    return eded;
//}
//int[] ededler = { 5, 3, 8, 1, 4 };
//int netice = a(ededler);
//Console.WriteLine(netice);

//Metod - a söz və hərf göndəriləcək. Həmin sözdə verilən hərfdən neçə ədəd olduğunu qaytaracaq metod

//static int a(string soz, char herf)
//{
//    int eded = 0;
//    for (int i = 0; i < soz.Length; i++)
//    {
//        if (soz[i] == herf)
//        {
//            eded++;
//        }
//    }
//    return eded;
//}

//string soz = "aabdbdcbasjdlqwa";
//int netice = a(soz, 'a');
//Console.WriteLine(netice);

//Metod - a n və m ədədləri göndəriləcək. Həmin n və m ededleri arasindaki tek ededlerin sayini tapin.

//static int a(int n, int m)
//{
//    int say = 0;
//    for (int i = n; i < m; i++)
//    {
//        if (i % 2 == 1)
//        {
//            say++;
//        }
//    }
//    return say;
//}
//int netice = a(1, 10);
//Console.WriteLine(netice);

//metod - a bir string dəyər göndəriləcək. Həmin stringin polindrom olub olmamasini (true/false) qaytaracaq metod 

//static bool a(string soz)
//{
//    string ters = "";
//    for (int i = soz.Length - 1; i >= 0; i--)
//    {
//        ters += soz[i];
//    }
//    return soz == ters;
//}
//string soz = "ada";
//Console.WriteLine(a(soz));
//(polindrom: özü və tərs oxunuşu eyni olan sözlərdir (mühüm, kiçik))

//Metod-a 2 ədəd göndəriləcək və üzərində verilmiş simvola uyğun əməliyyat edən proqram. Simvol +,-,* və ya / olmalıdır, əks halda simvolu yenidən daxil edilməsi istənilməlidir.(Misaçün simvol * olarsa verilmiş 2 ədəd vurulacaq və nəticəsi göstəriləcək)


//static double a(double n, double m, char simvol)
//{
//    if (simvol == '+')
//    {
//        return n + m;
//    }
//    else if (simvol == '-')
//    {
//        return n - m;
//    }
//    else if (simvol == '/')
//    {
//        return n / m;
//    }
//    else if (simvol == '*')
//    {
//        return n * m;
//    }
//    else
//    {
//        Console.WriteLine("Simvolu düzgün daxil edin");
//        return 0;
//    }
//}
//double netice = a(10, 5, '*');
//Console.WriteLine(netice);


//Parametr olaraq 1 string dəyər qəbul edən və həmin string dəyəri icində bosluqlar qalmayacaq hala gətirən metod.Misal olaraq, name = " Hikmet  Abbasov " deyə bir variable-mız varsa onu yaratdigimiz metoda göndərdikdə variable-daki dəyər "HikmətAbbasov" olmalıdır.

//static string a(string soz)
//{
//    string netice = "";
//    for (int i = 0; i < soz.Length; i++)
//    {`
//        if (soz[i] != ' ')
//        {
//            netice += soz[i];
//        }
//    }
//    return netice;
//}
//string name = " Hikmet  Abbasov ";
//string netice = a(name);
//Console.WriteLine(netice);