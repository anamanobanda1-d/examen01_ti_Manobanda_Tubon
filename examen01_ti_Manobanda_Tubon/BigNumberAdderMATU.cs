
namespace examen01_ti_manobanda_tubon;

public class BigNumberAdderMATU : IAdderMATU
{
    public string AddMATU(string numberA_MATU, string numberB_MATU)
    {
        var a_MATU = ReverseMATU(numberA_MATU);
        var b_MATU = ReverseMATU(numberB_MATU);

        int maxLen_MATU = Math.Max(a_MATU.Length, b_MATU.Length);
        int carry_MATU = 0;
        StringBuilder sb_MATU = new StringBuilder();

        for (int i = 0; i < maxLen_MATU; i++)
        {
            int da_MATU = (i < a_MATU.Length) ? (a_MATU[i] - '0') : 0;
            int db_MATU = (i < b_MATU.Length) ? (b_MATU[i] - '0') : 0;

            int sum_MATU = da_MATU + db_MATU + carry_MATU;
            carry_MATU = sum_MATU / 10;
            int digit_MATU = sum_MATU % 10;
            sb_MATU.Append((char)('0' + digit_MATU));
        }

        if (carry_MATU > 0) sb_MATU.Append((char)('0' + carry_MATU));

        return TrimLeadingZerosMATU(ReverseMATU(sb_MATU.ToString()));
    }

    private string ReverseMATU(string s_MATU)
    {
        char[] arr = s_MATU.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }

    private string TrimLeadingZerosMATU(string s_MATU)
    {
        int i = 0;
        while (i < s_MATU.Length - 1 && s_MATU[i] == '0') i++;
        return s_MATU.Substring(i);
    }
}

