using examen01_ti_manobanda_tubon;

namespace examen01_ti_Manobanda_Tubon
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== SUMA DE GRANDES ENTEROS ===");

            Console.Write("Ingrese número A: ");
            string a_MATU = Console.ReadLine()?.Trim() ?? "";

            Console.Write("Ingrese número B: ");
            string b_MATU = Console.ReadLine()?.Trim() ?? "";

            try
            {
                var normA_MATU = new StringNumberMATU(a_MATU).NormalizedMATU;
                var normB_MATU = new StringNumberMATU(b_MATU).NormalizedMATU;

                IAdderMATU adder_MATU = new BigNumberAdderMATU();
                string suma_MATU = adder_MATU.AddMATU(normA_MATU, normB_MATU);

                Console.WriteLine($"\nResultado de la suma: {suma_MATU}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
