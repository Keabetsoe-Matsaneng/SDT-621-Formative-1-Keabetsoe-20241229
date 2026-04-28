using System;

public class CitizenProfile
{
    public string FullName { get; set; }
    public string IDNumber { get; set; }
    public int Age { get; set; }
    public string CitizenshipStatus { get; set; }

    public CitizenProfile(string name, string id, string citizen)
    {
        FullName = name;
        IDNumber = id;
        CitizenshipStatus = citizen;
        Age = CalculateAge();
    }

    private int CalculateAge()
    {
        try
        {
            string yy = IDNumber.Substring(0, 2);
            string mm = IDNumber.Substring(2, 2);
            string dd = IDNumber.Substring(4, 2);

            int year = int.Parse(yy);
            int month = int.Parse(mm);
            int day = int.Parse(dd);

            int currentYearShort = DateTime.Now.Year % 100;
            int fullYear = (year <= currentYearShort) ? 2000 + year : 1900 + year;

            DateTime birthDate = new DateTime(fullYear, month, day);

            int age = DateTime.Now.Year - birthDate.Year;
            if (DateTime.Now < birthDate.AddYears(age))
                age--;

            return age;
        }
        catch
        {
            return 0;
        }
    }

    public string ValidateID()
    {
        if (IDNumber.Length != 13)
            return "Invalid ID: Must be 13 digits.";

        if (!long.TryParse(IDNumber, out _))
            return "Invalid ID: Must contain only numbers.";

        if (Age <= 0)
            return "Invalid ID: Birth date is not valid.";

        return $"Valid ID. Citizen is {Age} years old.";
    }
}