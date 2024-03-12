using System;

public class Class1
{
    public class DoorMachine()
    {
        public enum StateDoor
        {
            TERBUKA, TERKUNCI
        }

    }
    static void Main(string[] args)
    {
        DoorMachine.StateDoor machine = new DoorMachine.StateDoor();
        DoorMachine.StateDoor machine = DoorMachine.StateDoor.TERKUNCI;
        Console.Write("Masukkan Perintah: BukaPintu/KunciPintu/Exit");
        string input = Console.ReadLine();
        while (input != "Exit")
        {
            switch (machine)
            {
                case DoorMachine.StateDoor.TERBUKA:
                    if (input == "KunciPintu")
                    {
                        machine = DoorMachine.StateDoor.TERKUNCI
                        Console.WriteLine("Pintu Terkunci");

                    }
            } break;
                case DoorMachine.StateDoor.TERKUNCI:
                if (input == "BukaPintu")
                {
                    machine = DoorMachine.StateDoor.TERBUKA;
                    Console.WriteLine("Pintu Tidak Terkunci");

                }
                break;
                {

                }
                Console.Write("Input Perintah:  ");
                input = Console.ReadLine();

                }
        }
    } 
}
