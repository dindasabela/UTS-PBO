using System;

namespace EngCourse
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Complete the Personal Data Form");
            Console.Write("Nama Lengkap:");
            string Namalengkap=Console.ReadLine();
            Console.Write("Usia (tahun):");
            string Usia=Console.ReadLine();
            Console.Write("Alamat:");
            string Alamat=Console.ReadLine();
            Console.Write("Sekolah:");
            string Sekolah=Console.ReadLine();
            Console.Write("Gender (L/P):");
            string Gender=Console.ReadLine();
            Console.Write("Email:");
            string Email=Console.ReadLine();
            Console.WriteLine();

            string [] Siswa={Namalengkap,Usia, Alamat, Sekolah, Gender, Email};
            foreach (string Data in Siswa){
                Console.Write($"{Siswa.ToString()}");
            }
            

            Console.Write("Pilih nomor sesuai paket yang dipilih:");
            tampilkanPaket();
            string v = Console.ReadLine();
            Console.Write("Pilih hari dengan menuskan huruf pada pilihan yang tersedia:");
            tampilkanHari();
            string x= Console.ReadLine();
            Console.Write("Bill/Pembayaran Course:");
            tampilkanBill();
            Console.WriteLine("Pay in Cash? (Yes/Not):");
            string pay=Console.ReadLine();
            tampilkanMethod();
            Console.WriteLine("The registration is finished!\n THANK YOU");
        }


        private static void hasilExam(){
            Console.Write("Selamat telah menyelesaikan ujian!");
            Console.Write("Berapa skor yang kamu dapat? Tuliskan dalam angka:");
            string skor=Console.ReadLine();
        }

}
}
public class Score{
    private readonly bool skor;

    void tulisSkor(){
            string skor=Console.ReadLine();
    }
    void cariKelas(){
       int hasil=Convert.ToInt32(skor);
        if(hasil>10){
            Console.Write("Congratulations, You can join our Intermediate Class");
        }
        else{
            Console.Write("Congratulations, You can join our Beginner Class");
        }
}   
}
public class Tuition{
    int pilihan;
    string Y;

    public Tuition(int pilihan)
    {
        this.pilihan = pilihan;
        if(pilihan==1){
            Console.WriteLine("The bill payment for 'English for Kids' is Rp1.000.000,00/level",Y);
        }
        if(pilihan==2){
            Console.WriteLine("The bill payment for 'English for Students' is Rp2.500.000,00/level",Y);
        }
        if(pilihan==3){
            Console.WriteLine("The bill payment for 'English for Adults' is Rp3.000.000,00/level",Y);
        }
        if(pilihan==4){
            Console.WriteLine("The bill payment for 'Conversation for Teens' is Rp3.000.000,00/level",Y);
        }
        if(pilihan==5){
            Console.WriteLine("The bill payment for 'Bussiness English' is Rp6.000.000,00/level",Y);
        }
        if(pilihan==6){
            Console.WriteLine("The bill payment for 'TOEFL Test' is Rp1.000.000,00",Y);
        }
        if(pilihan==7){
            Console.WriteLine("The bill payment for 'IELTS Test' is Rp2.800.000,00",Y);
        }
        if(pilihan==8){
            Console.WriteLine("The bill payment for 'TOEIC Test' is Rp1.200.000,00",Y);
        }
    }
    void tampilkanBill() => Console.WriteLine(Y);

    public class PaymentMethod{
        string pay;
        void tampilkanMethod(){
        if(pay=="YES"){
            Console.WriteLine("Print and attach this when you make a cash payment at our office");
        }
        if(pay=="NO"){
            Console.Write("Here's the bank account:");
            Console.Write("BRI:00789864152");
            Console.Write("Dana:7979845");
        }
        else{
            Console.WriteLine("Do you forget to use capital?");
        }
        }
    }
}
