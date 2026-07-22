public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        bool isNewYork = false;
        bool isFake = false;
        string lastNumbers = phoneNumber.Substring(8);

        if (phoneNumber.Substring(0, 3) == "212")
        {
            isNewYork = true;
        } 

        if (phoneNumber.Substring(4, 3) == "555")
        {
            isFake = true;
        }

        return (isNewYork, isFake, lastNumbers);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        if (phoneNumberInfo.IsFake == true)
        {
            return true;
        }

        return false;
    }
}
