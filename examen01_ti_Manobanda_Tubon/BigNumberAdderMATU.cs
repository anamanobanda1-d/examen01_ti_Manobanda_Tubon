using System.Text;

namespace examen01_ti_Manobanda_Tubon;

public class BigNumberAdderMATU : IAdderMATU
{
    public string AddMATU(string numberA_MATU, string numberB_MATU)
    {
        if (numberA_MATU == null || numberB_MATU == null)
            throw new ArgumentNullException("Los números no pueden ser nulos.");

        if (!IsDigitsMATU(numberA_MATU) || !IsDigitsMATU(numberB_MATU))
            throw new ArgumentException("Los valores deben contener solo dígitos (0-9).");

        var a_MATU = ReverseMATU(numberA_MATU);
        var b_MATU = ReverseMATU(numberB_MATU);

        var maxLen_MATU = Math.Max(a_MATU.Length, b_MATU.Length);
        var carry_MATU = 0;
        var sb_MATU = new StringBuilder();

        for (int i = 0; i < maxLen_MATU; i++)
        {
            int da_MATU = (i < a_MATU.Length) ? (a_MATU[i] - '0') : 0;
            int db_MATU = (i < b_MATU.Length) ? (b_MATU[i] - '0') : 0;

            int s_MATU = da_MATU + db_MATU + carry_MATU;
            carry_MATU = s_MATU / 10;
            int digit_MATU = s_MATU % 10;
            sb_MATU.Append((char)('0' + digit_MATU));
        }

        if (carry_MATU > 0) sb_MATU.Append((char)('0' + carry_MATU));

        var res_MATU = ReverseMATU(sb_MATU.ToString());
        res_MATU = TrimLeadingZerosMATU(res_MATU);
        return res_MATU;
    }

    private static bool IsDigitsMATU(string s_MATU)
    {
        if (string.IsNullOrEmpty(s_MATU)) return false;
        foreach (var c in s_MATU)
        {
            if (c < '0' || c > '9') return false;
        }
        return true;
    }

    private static string ReverseMATU(string s_MATU)
    {
        var arr_MATU = s_MATU.ToCharArray();
        Array.Reverse(arr_MATU);
        return new string(arr_MATU);
    }

    private static string TrimLeadingZerosMATU(string s_MATU)
    {
        int i = 0;
        while (i < s_MATU.Length - 1 && s_MATU[i] == '0') i++;
        return s_MATU.Substring(i);
    }
}
