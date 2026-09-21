using System;
using System.Runtime.InteropServices;

class Program
{
    // bai1
    static int TinhTong(int a, int b)
    {
        return a + b;
    }

    static void bai1()
    {

        Console.Write("Nhập số thứ nhất (a): ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Nhập số thứ hai (b): ");
        int b = int.Parse(Console.ReadLine());

        int ketQua = TinhTong(a, b);
        Console.WriteLine($"ket qua :{ketQua}");
    }

    // bai2
    static bool KiemTraChan(int n)
    {
        return n % 2 == 0;
    }
    static void bai2()
    {
        Console.WriteLine("nhap so nguyen: ");
        int n = int.Parse(Console.ReadLine());
        bool lasochan = KiemTraChan(n);
        if (lasochan)
        {
            Console.WriteLine("n la so chan ");
        }
        else
        {
            Console.WriteLine("n la so le ");
        }
    }
    //bai3
    static int TimMax(int a, int b, int c)
    {
        return Math.Max(Math.Min(a, b), c);
    }
    static void bai3()
    {
        Console.WriteLine("nhap vao so thu nhat (a): ");
        int a = int.Parse((string)Console.ReadLine());
        Console.WriteLine("nhap vao so thu hai (b): ");
        int b = int.Parse((string)Console.ReadLine());
        Console.WriteLine("nhap vap so thu ba (c): ");
        int c = int.Parse((string)Console.ReadLine());
        int solonnhat = TimMax(a, b, c);
        Console.WriteLine($"so lon nhat la: {solonnhat}");
    }
    //bai4
    static long TinhGiaiThua(int n)
    {
        long giaithua = 1;
        for (int i = 1; i <= n; i++)
        {
            giaithua *= i;
        }
        return giaithua;
    }
        
    static void bai4()
    {
        Console.WriteLine("nhap so nguyen duong n: ");
            int n=int.Parse(Console.ReadLine());
            long kq = TinhGiaiThua(n);
            Console.WriteLine($"giai thua cua so {n} la: {kq} ");
    }
    static string DaoNguocChuoi(string input)
    {
        char [] chararray = input.ToCharArray();
        Array.Reverse(chararray);
        return new string(chararray); 
    }
    static void bai5()
    {
        Console.WriteLine("nhap vao mot chuoi ki tu: ");
        string input = Console.ReadLine();
        string kq = DaoNguocChuoi(input);
        Console.WriteLine($"chuoi dao nguoc:{kq}");
    }
    static bool KiemTraNguyenTo(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0) return false;
        }
        return true;
    }
    static void bai6()
    {
        Console.WriteLine("nhap vao so nguyen : ");
        int n = int.Parse(Console.ReadLine());
        bool kq = KiemTraNguyenTo(n);
        Console.WriteLine($"input {n}-> output {kq}");

    }
    static void InFibonacci(int n)
    {
        if (n <= 0) return;

        long a = 0, b = 1;
        for (int i = 1; i <= n; i++)
        {
            Console.Write(a + " ");
            long temp = a + b;
            a = b;
            b = temp;
        }
        Console.WriteLine();
    }
    static void bai7()
    {
        Console.Write("nhap vao so nguyen n: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write($"Input: {n} -> Output: ");
        InFibonacci(n);
    }
    static int DemNguyenAm(string s)
    {
        int count = 0;
        // Chuyển chuỗi về chữ thường để dễ dàng so sánh
        string lowerStr = s.ToLower();

        foreach (char c in lowerStr)
        {
            // Các ký tự nguyên âm: a, e, i, o, u
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
            {
                count++;
            }
        }
        return count;
    }
    static void bai8()
    {
        Console.Write("nhap vao mot chuoi: ");
        string input = Console.ReadLine();

        int ketQua = DemNguyenAm(input);
        Console.WriteLine($"Input: \"{input}\" -> Output: {ketQua}");
    }
    static double TinhLuyThua(double x, int y)
    {
        double result = 1;

        // Trường hợp số mũ y dương
        int n = Math.Abs(y);
        for (int i = 0; i < n; i++)
        {
            result *= x;
        }

        // Nếu số mũ y âm, kết quả là 1 / (x^|y|)
        if (y < 0)
        {
            return 1 / result;
        }

        return result;
    }
    static void bai9()
    {
        Console.Write("nhap co so x: ");
        double x = double.Parse(Console.ReadLine());

        Console.Write("nhap so mu y (nguyen): ");
        int y = int.Parse(Console.ReadLine());

        double ketQua = TinhLuyThua(x, y);
        Console.WriteLine($"Input: x = {x}, y = {y} -> Output: {ketQua}");
    }
    static double TinhTrungBinh(int[] arr)
    {
        if (arr == null || arr.Length == 0) return 0;

        double tong = 0;
        foreach (int num in arr)
        {
            tong += num;
        }
        return tong / arr.Length;
    }
    static void bai10()
    {
        // Khởi tạo mảng mẫu theo đề bài: [4, 5, 6, 7]
        int[] arr = { 4, 5, 6, 7 };

        double ketQua = TinhTrungBinh(arr);

        // In ra định dạng kết quả
        Console.Write("Input: [");
        Console.Write(string.Join(", ", arr));
        Console.WriteLine($"] -> Output: {ketQua}");
    }
    static bool KiemTraDoiXung(string s)
    {
        if (string.IsNullOrEmpty(s)) return true;

        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
            if (s[left] != s[right]) return false;
            left++;
            right--;
        }
        return true;
    }
    static void bai11()
    {
        Console.Write("nhap vao mot chuoi: ");
        string s = Console.ReadLine();

        bool ketQua = KiemTraDoiXung(s);
        Console.WriteLine($"Input: \"{s}\" -> Output: {ketQua}");
    }
    static double CelsiusToFahrenheit(double c)
    {
        return (c * 9 / 5) + 32; 
    }
    static void bai12()
    {
        Console.Write("nhap nhiet do (do C): ");
        double c = double.Parse(Console.ReadLine());

        double ketQua = CelsiusToFahrenheit(c);
        Console.WriteLine($"Input: {c} -> Output: {ketQua}");
    }
    static int TimMin(int[] arr)
    {
        int min = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < min)
            {
                min = arr[i];
            }
        }
        return min;
    }

    static void bai13()
    {
        int[] arr = { 10, 5, 8, 2, 9 };
        int ketQua = TimMin(arr);

        Console.Write("Input: [");
        Console.Write(string.Join(", ", arr));
        Console.WriteLine($"] -> Output: {ketQua}");
    }
    static int TongCacChuSo(int n)
    {
        int tong = 0;
        n = Math.Abs(n); // Xử lý trường hợp số âm
        while (n > 0)
        {
            tong += n % 10;
            n /= 10;
        }
        return tong;
    }

    static void bai14()
    {
        Console.Write("nhap vao mot so nguyen n: ");
        int n = int.Parse(Console.ReadLine());

        int ketQua = TongCacChuSo(n);
        Console.WriteLine($"Input: {n} -> Output: {ketQua}");
    }
    static void SapXepMang(int[] arr)
    {
        Array.Sort(arr);
        
    }
    static void bai15()
    {
        Console.WriteLine("Nhap so luong phan tu cua mang: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        Console.WriteLine("Nhap cac phan tu cua mang:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Phan tu thu {i + 1}: ");
            arr[i] = int.Parse(Console.ReadLine());
        }
        SapXepMang(arr);
        Console.WriteLine("Output (mang sau khi sap xep tang dan):");
        Console.WriteLine(string.Join(" ", arr));
    }
    static string XoaTrungLap(string s)
    {
        if (string.IsNullOrEmpty(s)) return s;

        string ketQua = "";
        foreach (char c in s)
        {
            if (!ketQua.Contains(c))
            {
                ketQua += c;
            }
        }
        return ketQua;
    }
    static void bai16()
    {
        Console.Write("nhap vao mot chuoi: ");
        string input = Console.ReadLine();

        string ketQua = XoaTrungLap(input);
        Console.WriteLine($"Input: \"{input}\" -> Output: \"{ketQua}\"");
    }
    static int UCLN(int a ,int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return Math.Abs(a);
    }
    static void bai17()
    {
        Console.Write("nhap so nguyen a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("nhap so nguyen b: ");
        int b = int.Parse(Console.ReadLine());

        int ketQua = UCLN(a, b);
        Console.WriteLine($"Input: a = {a}, b = {b} -> Output: {ketQua}");
    }
    static string DecimalToBinary(int n)
    {
        if (n == 0) return "0";

        string binary = "";
        int temp = Math.Abs(n); // Xử lý nếu số nhập vào là số dương

        while (temp > 0)
        {
            int remainder = temp % 2; // Lấy phần dư khi chia cho 2
            binary = remainder + binary; // Ghép phần dư vào trước chuỗi kết quả
            temp /= 2; // Chia đôi số thập phân
        }

        return binary;
    }

    static void bai18()
    {
        Console.Write("nhap vao mot so thap phan: ");
        int n = int.Parse(Console.ReadLine());

        string ketQua = DecimalToBinary(n);
        Console.WriteLine($"Input: {n} -> Output: \"{ketQua}\"");
    }
    static bool KiemTraNamNhuan(int year)
    {
        // Năm nhuận là năm chia hết cho 4 nhưng không chia hết cho 100, 
        // hoặc chia hết cho 400
        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        {
            return true;
        }
        return false;
    }

    static void bai19()
    {
        Console.Write("nhap vao nam can kiem tra: ");
        int year = int.Parse(Console.ReadLine());

        bool ketQua = KiemTraNamNhuan(year);
        Console.WriteLine($"Input: {year} -> Output: {ketQua}");
    }
    {
    
    static int DemSoTu(string sentence)
    {
        
        if (string.IsNullOrWhiteSpace(sentence)) return 0;

        // Dùng Split kết hợp Trim để tách câu thành mảng các từ dựa vào khoảng trắng,
        // đồng thời loại bỏ các khoảng trắng thừa nếu người dùng nhập dôi dư
        string[] words = sentence.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        // Trả về số lượng phần tử trong mảng (chính là số từ)
        return words.Length;
    }

    static void bai20()
    {
        Console.Write("nhap vao mot cau: ");
        string input = Console.ReadLine();

        int ketQua = DemSoTu(input);
        Console.WriteLine($"Input: \"{input}\" -> Output: {ketQua}");
    }


    // main
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // go bai muon chay 
        bai1(); 
        bai2();
        bai3();
        bai4();
        bai5();
        bai6();
        bai7();
        bai8();
        bai9();
        bai10();
        bai11();
        bai12();
        bai13();
        bai14();
        bai15();
        bai16();
        bai17();
        bai18();
        bai19();
        bai20();
    }
}