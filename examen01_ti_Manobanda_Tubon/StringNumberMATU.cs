namespace examen01_ti_Manobanda_Tubon;

public class StringNumberMATU
{
    public string OriginalMATU { get; }
    public string NormalizedMATU { get; }

    public StringNumberMATU(string input_MATU)
    {
        if (string.IsNullOrWhiteSpace(input_MATU))
            throw new ArgumentException("El valor no puede estar vacío.");

        string s_MATU = input_MATU.Trim();

        if (s_MATU.StartsWith("+")) s_MATU = s_MATU.Substring(1);
        if (s_MATU.StartsWith("-"))
            throw new ArgumentException("Solo se aceptan enteros positivos.");

        foreach (char c in s_MATU)
        {
            if (c < '0' || c > '9') throw new ArgumentException("El valor debe contener solo dígitos.");
        }

        int idx_MATU = 0;
        while (idx_MATU < s_MATU.Length - 1 && s_MATU[idx_MATU] == '0') idx_MATU++;
        NormalizedMATU = s_MATU.Substring(idx_MATU);
        OriginalMATU = input_MATU;
    }
}
