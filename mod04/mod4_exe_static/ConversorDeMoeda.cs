

namespace mod4_exe_static
{
    class ConversorDeMoeda
    {
        public static double converte(double cotacao, double quantidade)
        {
            double valorTotal = (quantidade * 1.06) * cotacao;

            return valorTotal;
        }
    }
}
