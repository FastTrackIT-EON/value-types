namespace ValueTypes
{
    public enum DayOfWeek
    {
        None = 0,
        Luni = 1 << 0,
        Marti = 1 << 1,
        Miercuri = 1 << 2,
        Joi = 1 << 3,
        Vineri = 1 << 4,
        Sambata = 1 << 5,
        Duminica = 1 << 6,

        WorkingDays = DayOfWeek.Luni | DayOfWeek.Marti | DayOfWeek.Miercuri 
                      | DayOfWeek.Joi,
        Weekend = DayOfWeek.Vineri | DayOfWeek.Sambata | DayOfWeek.Duminica
    }

    public enum AccessLevel
    {
        None = 0,
        Read = 1 << 0,
        Write = 1 << 2,

        ReadAndWrite = AccessLevel.Read | AccessLevel.Write
    }

    public enum IdDocumentTypes
    {
        IdCard = 0,
        Passport,
        NewDocument,
        DrivingLicense,

    }
}
