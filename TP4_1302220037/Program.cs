namespace TP4_1302220037
{
    internal class Program
    {
        public class KodePos
        {
            public int getKodePos(string kelurahan)
            {
                if (kelurahan == "Batununggal")
                {
                    return 40266;
                }
                else if (kelurahan == "Kujangsari" || kelurahan == "Cijaura")
                {
                    return 40287;
                }
                else if (kelurahan == "Mengger")
                {
                    return 40267;
                }
                else if (kelurahan == "Wates")
                {
                    return 40256;
                }
                else if (kelurahan == "Jatisari" || kelurahan == "Margasari" || kelurahan == "Sekejati")
                {
                    return 40286;
                }
                else if (kelurahan == "Kebonwaru")
                {
                    return 40272;
                }
                else if (kelurahan == "Maleer")
                {
                    return 40274;
                }
                else if (kelurahan == "Samoja")
                {
                    return 40273;
                }
                else
                {
                    return -1;
                }
            }

           
        }
        static void Main(string[] args)
        {

            KodePos kodePosObj = new KodePos();

            int kode1 = kodePosObj.getKodePos("Batununggal");
            int kode2 = kodePosObj.getKodePos("Kujangsari");
            int kode3 = kodePosObj.getKodePos("Mengger");
            int kode4 = kodePosObj.getKodePos("Wates");
            int kode5 = kodePosObj.getKodePos("Cijaura");
            int kode6 = kodePosObj.getKodePos("Jatisari");
            int kode7 = kodePosObj.getKodePos("Margasari");
            int kode8 = kodePosObj.getKodePos("Sekejati");
            int kode9 = kodePosObj.getKodePos("Kebonwaru");
            int kode10 = kodePosObj.getKodePos("Maleer");
            int kode11 = kodePosObj.getKodePos("Samoja");

            Console.WriteLine("Kode pos Batununggal: " + kode1);
            Console.WriteLine("Kode pos Kujangsari: " + kode2);
            Console.WriteLine("Kode pos Mengger: " + kode3);
            Console.WriteLine("Kode pos Wates: " + kode4);
            Console.WriteLine("Kode pos Cijaura: " + kode5);
            Console.WriteLine("Kode pos Jatisari: " + kode6);
            Console.WriteLine("Kode pos Margasari: " + kode7);
            Console.WriteLine("Kode pos Sekejati: " + kode8);
            Console.WriteLine("Kode pos Kebonwaru: " + kode9);
            Console.WriteLine("Kode pos Maleer: " + kode10);
            Console.WriteLine("Kode pos Samoja: " + kode11);
        }
    }
}
